using DisStation.Model.Entities;
using DisStation.Model.Repositories;
using DisStation.Validator;
using Word = Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisStation
{
    public partial class MainForm : Form
    {
        private Word.Application _wordApp;
        private decimal _allMoneyEarned;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IRepository reposiory = new FuelRepository();
            cmbFuels.DisplayMember = "Type";
            cmbFuels.DataSource = reposiory.Get();
            sumCafe.Text = "0,00";
        }


        private void cmbFuels_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuelInfo select = cmbFuels.SelectedItem as FuelInfo;
            if (select != null)
            {
                tbFuelPrice.Text = select.Price.ToString("N2");
                tbSumOfLitres_TextChanged(tbSumOfLitres, EventArgs.Empty);
            }
        }


        private void tbCafe_Click(object sender, EventArgs e)
        {
            CheckBox tb = sender as CheckBox;
            if (tb != null)
            {
                var control = this.Controls.Find(tb.Tag.ToString(), true).First() as TextBox;
                control.ReadOnly = !tb.Checked;
                CalcSumCafe();
            }
        }


        private void rad_Click(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            var control = this.Controls.Find(rad.Tag.ToString(), true).First() as TextBox;
            control.Text = String.Empty;
            sumOil_TextChanged(sumOil, EventArgs.Empty);
        }


        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            tbLitres.ReadOnly = !rbtnCount.Checked;
            tbSumOfLitres.ReadOnly = rbtnCount.Checked;

            tbLitres.Text = String.Empty;
            tbSumOfLitres.Text = String.Empty;
        }


        private void tbSumOfLitres_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            bool check = false;
            if (!String.IsNullOrEmpty(tb.Text) && tb.ValidatorNumbers() && tb.Text.Equals(tbSumOfLitres.Text))
            {
                decimal money = Decimal.Parse(tbSumOfLitres.Text);
                decimal fuelPrice = Decimal.Parse(tbFuelPrice.Text);
                tbLitres.Text = (money / fuelPrice).ToString("N2");
                check = true;
            }
            else if (String.IsNullOrEmpty(tbSumOfLitres.Text) && rbtnSum.Checked)
                tbLitres.Text = "0";
            else if (!tbSumOfLitres.ValidatorNumbers())
                return;

            if (!String.IsNullOrEmpty(tbLitres.Text) && tbLitres.ValidatorNumbers())
            {
                if (rbtnSum.Checked)
                    tbLitres.BackColor = Color.White;
                check = true;
            }
            if (check)
                sumOil_TextChanged(sumOil, EventArgs.Empty);
        }


        private void sumOil_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSumOfLitres.Text) && tbSumOfLitres.ValidatorNumbers())
                sumOil.Text = tbSumOfLitres.Text;
            else if (!String.IsNullOrEmpty(tbLitres.Text))
                sumOil.Text = (Decimal.Parse(tbFuelPrice.Text) * Decimal.Parse(tbLitres.Text, CultureInfo.InvariantCulture)).ToString("N2");
            else
                sumOil.Text = "0.00";
        }


        private void sumCafe_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            sumCafe.Text = tb.Text;
        }


        private void tbCountCafe_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = sender as TextBox;
            if (!String.IsNullOrEmpty(tBox.Text) && tBox.ValidatorNumbers())
            {
                CalcSumCafe();
            }
        }


        private void CalcSumCafe()
        {
            var constrols = gbStationCafe.Controls.OfType<CheckBox>();
            var markertSumma = 0m;
            foreach (var item in constrols)
            {
                if (!item.Checked)
                    continue;

                var controlAmount = (TextBox)Controls.Find(item.Tag.ToString(), true).First();
                var controlPrice = (TextBox)Controls.Find(controlAmount.Tag.ToString(), true).First();
                markertSumma += Decimal.Parse(controlAmount.Text, CultureInfo.InvariantCulture) * Decimal.Parse(controlPrice.Text, CultureInfo.InvariantCulture);
            }
            sumCafe.Text = markertSumma.ToString("N2");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string fuelPrice = sumOil.Text.ToString().Replace(',', '.');
            string cafePrice = sumCafe.Text.ToString().Replace(',', '.');

            _allMoneyEarned += Decimal.Parse(fuelPrice, CultureInfo.InvariantCulture) + Decimal.Parse(cafePrice, CultureInfo.InvariantCulture);
            tbGeneralSum.Text = _allMoneyEarned.ToString();
            CreateWordDoc();
        }

        private void CreateWordDoc()
        {
            var controls = gbStationCafe.Controls.OfType<CheckBox>();
            List<string> bought = new List<string>();
            List<string> boughtCount = new List<string>();
            List<string> boughtPrice = new List<string>();
            foreach (var item in controls)
            {
                if (!item.Checked)
                {
                    continue;
                }

                bought.Add(item.Name);
                var cntControl = item.Controls.Find(item.Tag.ToString(), true).First() as TextBox;
                boughtCount.Add(cntControl.Text.ToString());
                var prcControl = cntControl.Controls.Find(cntControl.Tag.ToString(), true).First() as TextBox;
                boughtPrice.Add(prcControl.Text.ToString());
            }


            _wordApp = new Word.Application();

            _wordApp.Visible = true;
            Word.Paragraph wordparagraph;
            Word.Document wordDoc;
            object MyTemplate = Type.Missing;
            object NewTemplate = false;
            object DocumentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object Visible = true;

            wordDoc = _wordApp.Documents.Add(ref MyTemplate,
                             ref NewTemplate,
                             ref DocumentType,
                             ref Visible);

            object pargf = Type.Missing;
            wordparagraph = wordDoc.Content.Paragraphs.Add(ref pargf);
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph.Range.Font.Size = 14;
            // добавление текста
            wordparagraph.Range.Text = "Чек об оплате";
            // выравнивание текста по центру 
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            // вставка параграфа
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = "Тема:";
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 20;

            int i = 0;
            foreach (var boughtI in bought)
            {
                wordparagraph.Range.Text = $"{boughtI[i]} {boughtCount[i]} {boughtPrice[i]}";
                i++;
            }
            wordparagraph.Range.Text = $"{cmbFuels.Text.ToString()} {tbLitres.Text.ToString()} {sumOil.Text.ToString()}";
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
        }
    }
}
