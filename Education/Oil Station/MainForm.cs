using DisStation.Model.Entities;
using DisStation.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisStation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IRepository reposiory = new FuelRepository();
            cmbFuels.DisplayMember = "Type";
            cmbFuels.DataSource = reposiory.Get();
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
            }
        }

        private void rad_Click(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            var control = this.Controls.Find(rad.Tag.ToString(), true).First() as TextBox;
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
            if (!String.IsNullOrEmpty(tbSumOfLitres.Text))
            {
                decimal money = Decimal.Parse(tbSumOfLitres.Text);
                decimal fuelPrice = Decimal.Parse(tbFuelPrice.Text);
                tbLitres.Text = (money / fuelPrice).ToString("N1");
            }
            if (String.IsNullOrEmpty(tbLitres.Text))
            {
                return;
            }
            sumOil_TextChanged(sumOil, EventArgs.Empty);
        }

        private void sumOil_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSumOfLitres.Text))
                sumOil.Text = tbSumOfLitres.Text + " руб.";
            else
                sumOil.Text = (Decimal.Parse(tbFuelPrice.Text) * Decimal.Parse(tbLitres.Text)).ToString("N2") + " руб.";
        }

        private void sumCafe_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            sumCafe.Text = tb.Text;
        }

        private void tbCountCafe_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = sender as TextBox;
            if (!String.IsNullOrEmpty(tBox.Text))
            {
                var control = this.Controls.Find(tBox.Tag.ToString(), true).First() as TextBox;

                CalcSumCafe(control, tBox);
            }
        }

        private void CalcSumCafe(TextBox tbTag, TextBox tbMain)
        {
            decimal price = Decimal.Parse(tbTag.Text.ToString());
            int count =  Int32.Parse(tbMain.Text.ToString());
            sumCafe.Text = $"{price * count}";
        }
    }
}