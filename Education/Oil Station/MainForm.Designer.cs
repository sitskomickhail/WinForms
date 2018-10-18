namespace DisStation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbStationOil = new System.Windows.Forms.GroupBox();
            this.lb_rubles_oil = new System.Windows.Forms.Label();
            this.tbFuelPrice = new System.Windows.Forms.TextBox();
            this.lb_sale = new System.Windows.Forms.Label();
            this.lb_oil = new System.Windows.Forms.Label();
            this.cmbFuels = new System.Windows.Forms.ComboBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSumOfLitres = new System.Windows.Forms.TextBox();
            this.tbLitres = new System.Windows.Forms.TextBox();
            this.rbtnSum = new System.Windows.Forms.RadioButton();
            this.rbtnCount = new System.Windows.Forms.RadioButton();
            this.gbPaymentOil = new System.Windows.Forms.GroupBox();
            this.sumOil = new System.Windows.Forms.TextBox();
            this.gbStationCafe = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSaleCocaCola_4 = new System.Windows.Forms.TextBox();
            this.gbPaymentCafe = new System.Windows.Forms.GroupBox();
            this.sumCafe = new System.Windows.Forms.TextBox();
            this.tbCountCafe_4 = new System.Windows.Forms.TextBox();
            this.tbCocaCola_4 = new System.Windows.Forms.CheckBox();
            this.tbSaleHotDog_1 = new System.Windows.Forms.TextBox();
            this.tbCheeseB_3 = new System.Windows.Forms.CheckBox();
            this.tbSaleCheeseB_3 = new System.Windows.Forms.TextBox();
            this.tbHamb_2 = new System.Windows.Forms.CheckBox();
            this.tbSaleHamb_2 = new System.Windows.Forms.TextBox();
            this.tbHotDog_1 = new System.Windows.Forms.CheckBox();
            this.tbCountCafe_1 = new System.Windows.Forms.TextBox();
            this.tbCountCafe_3 = new System.Windows.Forms.TextBox();
            this.tbCountCafe_2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbGeneralSum = new System.Windows.Forms.TextBox();
            this.lbItogo = new System.Windows.Forms.Label();
            this.gbStationOil.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.gbPaymentOil.SuspendLayout();
            this.gbStationCafe.SuspendLayout();
            this.gbPaymentCafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStationOil
            // 
            this.gbStationOil.Controls.Add(this.lb_rubles_oil);
            this.gbStationOil.Controls.Add(this.tbFuelPrice);
            this.gbStationOil.Controls.Add(this.lb_sale);
            this.gbStationOil.Controls.Add(this.lb_oil);
            this.gbStationOil.Controls.Add(this.cmbFuels);
            this.gbStationOil.Controls.Add(this.gbClient);
            this.gbStationOil.Controls.Add(this.gbPaymentOil);
            this.gbStationOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbStationOil.Location = new System.Drawing.Point(12, 12);
            this.gbStationOil.Name = "gbStationOil";
            this.gbStationOil.Size = new System.Drawing.Size(306, 314);
            this.gbStationOil.TabIndex = 0;
            this.gbStationOil.TabStop = false;
            this.gbStationOil.Text = "Топливо";
            // 
            // lb_rubles_oil
            // 
            this.lb_rubles_oil.AutoSize = true;
            this.lb_rubles_oil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_rubles_oil.ForeColor = System.Drawing.Color.Red;
            this.lb_rubles_oil.Location = new System.Drawing.Point(268, 56);
            this.lb_rubles_oil.Name = "lb_rubles_oil";
            this.lb_rubles_oil.Size = new System.Drawing.Size(33, 15);
            this.lb_rubles_oil.TabIndex = 14;
            this.lb_rubles_oil.Text = "руб.";
            // 
            // tbFuelPrice
            // 
            this.tbFuelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFuelPrice.Location = new System.Drawing.Point(112, 50);
            this.tbFuelPrice.Name = "tbFuelPrice";
            this.tbFuelPrice.ReadOnly = true;
            this.tbFuelPrice.Size = new System.Drawing.Size(150, 21);
            this.tbFuelPrice.TabIndex = 7;
            // 
            // lb_sale
            // 
            this.lb_sale.AutoSize = true;
            this.lb_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_sale.ForeColor = System.Drawing.Color.Blue;
            this.lb_sale.Location = new System.Drawing.Point(36, 58);
            this.lb_sale.Name = "lb_sale";
            this.lb_sale.Size = new System.Drawing.Size(41, 15);
            this.lb_sale.TabIndex = 6;
            this.lb_sale.Text = "Цена";
            // 
            // lb_oil
            // 
            this.lb_oil.AutoSize = true;
            this.lb_oil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_oil.ForeColor = System.Drawing.Color.Blue;
            this.lb_oil.Location = new System.Drawing.Point(36, 28);
            this.lb_oil.Name = "lb_oil";
            this.lb_oil.Size = new System.Drawing.Size(55, 15);
            this.lb_oil.TabIndex = 5;
            this.lb_oil.Text = "Бензин";
            // 
            // cmbFuels
            // 
            this.cmbFuels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFuels.FormattingEnabled = true;
            this.cmbFuels.Location = new System.Drawing.Point(112, 20);
            this.cmbFuels.Name = "cmbFuels";
            this.cmbFuels.Size = new System.Drawing.Size(150, 23);
            this.cmbFuels.TabIndex = 4;
            this.cmbFuels.SelectedIndexChanged += new System.EventHandler(this.cmbFuels_SelectedIndexChanged);
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.label5);
            this.gbClient.Controls.Add(this.label4);
            this.gbClient.Controls.Add(this.tbSumOfLitres);
            this.gbClient.Controls.Add(this.tbLitres);
            this.gbClient.Controls.Add(this.rbtnSum);
            this.gbClient.Controls.Add(this.rbtnCount);
            this.gbClient.Location = new System.Drawing.Point(12, 95);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(288, 80);
            this.gbClient.TabIndex = 3;
            this.gbClient.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(253, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "руб.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(253, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "л.";
            // 
            // tbSumOfLitres
            // 
            this.tbSumOfLitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSumOfLitres.Location = new System.Drawing.Point(150, 44);
            this.tbSumOfLitres.Name = "tbSumOfLitres";
            this.tbSumOfLitres.ReadOnly = true;
            this.tbSumOfLitres.Size = new System.Drawing.Size(100, 21);
            this.tbSumOfLitres.TabIndex = 4;
            this.tbSumOfLitres.TextChanged += new System.EventHandler(this.tbSumOfLitres_TextChanged);
            // 
            // tbLitres
            // 
            this.tbLitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLitres.Location = new System.Drawing.Point(150, 14);
            this.tbLitres.Name = "tbLitres";
            this.tbLitres.Size = new System.Drawing.Size(100, 21);
            this.tbLitres.TabIndex = 3;
            this.tbLitres.Text = "0";
            this.tbLitres.TextChanged += new System.EventHandler(this.tbSumOfLitres_TextChanged);
            // 
            // rbtnSum
            // 
            this.rbtnSum.AutoSize = true;
            this.rbtnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnSum.Location = new System.Drawing.Point(6, 47);
            this.rbtnSum.Name = "rbtnSum";
            this.rbtnSum.Size = new System.Drawing.Size(68, 19);
            this.rbtnSum.TabIndex = 2;
            this.rbtnSum.Tag = "tbSumOfLitres";
            this.rbtnSum.Text = "Сумма";
            this.rbtnSum.UseVisualStyleBackColor = true;
            this.rbtnSum.Click += new System.EventHandler(this.rad_Click);
            // 
            // rbtnCount
            // 
            this.rbtnCount.AutoSize = true;
            this.rbtnCount.Checked = true;
            this.rbtnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCount.Location = new System.Drawing.Point(6, 17);
            this.rbtnCount.Name = "rbtnCount";
            this.rbtnCount.Size = new System.Drawing.Size(104, 19);
            this.rbtnCount.TabIndex = 1;
            this.rbtnCount.TabStop = true;
            this.rbtnCount.Tag = "tbLitres";
            this.rbtnCount.Text = "Количество";
            this.rbtnCount.UseVisualStyleBackColor = true;
            this.rbtnCount.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            this.rbtnCount.Click += new System.EventHandler(this.rad_Click);
            // 
            // gbPaymentOil
            // 
            this.gbPaymentOil.Controls.Add(this.sumOil);
            this.gbPaymentOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPaymentOil.Location = new System.Drawing.Point(6, 198);
            this.gbPaymentOil.Name = "gbPaymentOil";
            this.gbPaymentOil.Size = new System.Drawing.Size(278, 100);
            this.gbPaymentOil.TabIndex = 0;
            this.gbPaymentOil.TabStop = false;
            this.gbPaymentOil.Text = "К оплате";
            // 
            // sumOil
            // 
            this.sumOil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sumOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumOil.Location = new System.Drawing.Point(6, 19);
            this.sumOil.Multiline = true;
            this.sumOil.Name = "sumOil";
            this.sumOil.ReadOnly = true;
            this.sumOil.Size = new System.Drawing.Size(266, 75);
            this.sumOil.TabIndex = 0;
            this.sumOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sumOil.TextChanged += new System.EventHandler(this.sumOil_TextChanged);
            // 
            // gbStationCafe
            // 
            this.gbStationCafe.Controls.Add(this.label6);
            this.gbStationCafe.Controls.Add(this.label7);
            this.gbStationCafe.Controls.Add(this.label8);
            this.gbStationCafe.Controls.Add(this.label9);
            this.gbStationCafe.Controls.Add(this.label3);
            this.gbStationCafe.Controls.Add(this.label2);
            this.gbStationCafe.Controls.Add(this.tbSaleCocaCola_4);
            this.gbStationCafe.Controls.Add(this.gbPaymentCafe);
            this.gbStationCafe.Controls.Add(this.tbCountCafe_4);
            this.gbStationCafe.Controls.Add(this.tbCocaCola_4);
            this.gbStationCafe.Controls.Add(this.tbSaleHotDog_1);
            this.gbStationCafe.Controls.Add(this.tbCheeseB_3);
            this.gbStationCafe.Controls.Add(this.tbSaleCheeseB_3);
            this.gbStationCafe.Controls.Add(this.tbHamb_2);
            this.gbStationCafe.Controls.Add(this.tbSaleHamb_2);
            this.gbStationCafe.Controls.Add(this.tbHotDog_1);
            this.gbStationCafe.Controls.Add(this.tbCountCafe_1);
            this.gbStationCafe.Controls.Add(this.tbCountCafe_3);
            this.gbStationCafe.Controls.Add(this.tbCountCafe_2);
            this.gbStationCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbStationCafe.Location = new System.Drawing.Point(324, 12);
            this.gbStationCafe.Name = "gbStationCafe";
            this.gbStationCafe.Size = new System.Drawing.Size(306, 314);
            this.gbStationCafe.TabIndex = 1;
            this.gbStationCafe.TabStop = false;
            this.gbStationCafe.Text = "Мини-кафе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(183, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "руб.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(183, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "руб.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(183, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "руб.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(183, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "руб.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(214, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 13;
            this.label3.Tag = "";
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(111, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Цена";
            // 
            // tbSaleCocaCola_4
            // 
            this.tbSaleCocaCola_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSaleCocaCola_4.Location = new System.Drawing.Point(111, 143);
            this.tbSaleCocaCola_4.Name = "tbSaleCocaCola_4";
            this.tbSaleCocaCola_4.ReadOnly = true;
            this.tbSaleCocaCola_4.Size = new System.Drawing.Size(66, 21);
            this.tbSaleCocaCola_4.TabIndex = 11;
            this.tbSaleCocaCola_4.Text = "4.5";
            this.tbSaleCocaCola_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbPaymentCafe
            // 
            this.gbPaymentCafe.Controls.Add(this.sumCafe);
            this.gbPaymentCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPaymentCafe.Location = new System.Drawing.Point(6, 198);
            this.gbPaymentCafe.Name = "gbPaymentCafe";
            this.gbPaymentCafe.Size = new System.Drawing.Size(294, 100);
            this.gbPaymentCafe.TabIndex = 2;
            this.gbPaymentCafe.TabStop = false;
            this.gbPaymentCafe.Text = "К оплате";
            // 
            // sumCafe
            // 
            this.sumCafe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sumCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumCafe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sumCafe.Location = new System.Drawing.Point(6, 19);
            this.sumCafe.Multiline = true;
            this.sumCafe.Name = "sumCafe";
            this.sumCafe.ReadOnly = true;
            this.sumCafe.Size = new System.Drawing.Size(282, 75);
            this.sumCafe.TabIndex = 1;
            this.sumCafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sumCafe.TextChanged += new System.EventHandler(this.sumCafe_TextChanged);
            // 
            // tbCountCafe_4
            // 
            this.tbCountCafe_4.Location = new System.Drawing.Point(217, 143);
            this.tbCountCafe_4.Name = "tbCountCafe_4";
            this.tbCountCafe_4.ReadOnly = true;
            this.tbCountCafe_4.Size = new System.Drawing.Size(83, 20);
            this.tbCountCafe_4.TabIndex = 7;
            this.tbCountCafe_4.Tag = "tbSaleCocaCola_4";
            this.tbCountCafe_4.Text = "1";
            this.tbCountCafe_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCountCafe_4.Click += new System.EventHandler(this.tbCafe_Click);
            this.tbCountCafe_4.TextChanged += new System.EventHandler(this.tbCountCafe_TextChanged);
            // 
            // tbCocaCola_4
            // 
            this.tbCocaCola_4.AutoSize = true;
            this.tbCocaCola_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCocaCola_4.ForeColor = System.Drawing.Color.Blue;
            this.tbCocaCola_4.Location = new System.Drawing.Point(6, 143);
            this.tbCocaCola_4.Name = "tbCocaCola_4";
            this.tbCocaCola_4.Size = new System.Drawing.Size(94, 19);
            this.tbCocaCola_4.TabIndex = 3;
            this.tbCocaCola_4.Tag = "tbCountCafe_4";
            this.tbCocaCola_4.Text = "Кока-кола";
            this.tbCocaCola_4.UseVisualStyleBackColor = true;
            this.tbCocaCola_4.Click += new System.EventHandler(this.tbCafe_Click);
            // 
            // tbSaleHotDog_1
            // 
            this.tbSaleHotDog_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSaleHotDog_1.Location = new System.Drawing.Point(111, 43);
            this.tbSaleHotDog_1.Name = "tbSaleHotDog_1";
            this.tbSaleHotDog_1.ReadOnly = true;
            this.tbSaleHotDog_1.Size = new System.Drawing.Size(66, 21);
            this.tbSaleHotDog_1.TabIndex = 8;
            this.tbSaleHotDog_1.Tag = "";
            this.tbSaleHotDog_1.Text = "5";
            this.tbSaleHotDog_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCheeseB_3
            // 
            this.tbCheeseB_3.AutoSize = true;
            this.tbCheeseB_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheeseB_3.ForeColor = System.Drawing.Color.Blue;
            this.tbCheeseB_3.Location = new System.Drawing.Point(6, 108);
            this.tbCheeseB_3.Name = "tbCheeseB_3";
            this.tbCheeseB_3.Size = new System.Drawing.Size(94, 19);
            this.tbCheeseB_3.TabIndex = 2;
            this.tbCheeseB_3.Tag = "tbCountCafe_3";
            this.tbCheeseB_3.Text = "Чизбургер";
            this.tbCheeseB_3.UseVisualStyleBackColor = true;
            this.tbCheeseB_3.Click += new System.EventHandler(this.tbCafe_Click);
            // 
            // tbSaleCheeseB_3
            // 
            this.tbSaleCheeseB_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSaleCheeseB_3.Location = new System.Drawing.Point(111, 108);
            this.tbSaleCheeseB_3.Name = "tbSaleCheeseB_3";
            this.tbSaleCheeseB_3.ReadOnly = true;
            this.tbSaleCheeseB_3.Size = new System.Drawing.Size(66, 21);
            this.tbSaleCheeseB_3.TabIndex = 10;
            this.tbSaleCheeseB_3.Text = "6";
            this.tbSaleCheeseB_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHamb_2
            // 
            this.tbHamb_2.AutoSize = true;
            this.tbHamb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHamb_2.ForeColor = System.Drawing.Color.Blue;
            this.tbHamb_2.Location = new System.Drawing.Point(6, 75);
            this.tbHamb_2.Name = "tbHamb_2";
            this.tbHamb_2.Size = new System.Drawing.Size(96, 19);
            this.tbHamb_2.TabIndex = 1;
            this.tbHamb_2.Tag = "tbCountCafe_2";
            this.tbHamb_2.Text = "Гамбургер";
            this.tbHamb_2.UseVisualStyleBackColor = true;
            this.tbHamb_2.Click += new System.EventHandler(this.tbCafe_Click);
            // 
            // tbSaleHamb_2
            // 
            this.tbSaleHamb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSaleHamb_2.Location = new System.Drawing.Point(111, 75);
            this.tbSaleHamb_2.Name = "tbSaleHamb_2";
            this.tbSaleHamb_2.ReadOnly = true;
            this.tbSaleHamb_2.Size = new System.Drawing.Size(66, 21);
            this.tbSaleHamb_2.TabIndex = 9;
            this.tbSaleHamb_2.Text = "4";
            this.tbSaleHamb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHotDog_1
            // 
            this.tbHotDog_1.AutoSize = true;
            this.tbHotDog_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHotDog_1.ForeColor = System.Drawing.Color.Blue;
            this.tbHotDog_1.Location = new System.Drawing.Point(6, 43);
            this.tbHotDog_1.Name = "tbHotDog_1";
            this.tbHotDog_1.Size = new System.Drawing.Size(78, 19);
            this.tbHotDog_1.TabIndex = 0;
            this.tbHotDog_1.Tag = "tbCountCafe_1";
            this.tbHotDog_1.Text = "Хот-дог";
            this.tbHotDog_1.UseVisualStyleBackColor = true;
            this.tbHotDog_1.Click += new System.EventHandler(this.tbCafe_Click);
            // 
            // tbCountCafe_1
            // 
            this.tbCountCafe_1.Location = new System.Drawing.Point(217, 43);
            this.tbCountCafe_1.Name = "tbCountCafe_1";
            this.tbCountCafe_1.ReadOnly = true;
            this.tbCountCafe_1.Size = new System.Drawing.Size(83, 20);
            this.tbCountCafe_1.TabIndex = 4;
            this.tbCountCafe_1.Tag = "tbSaleHotDog_1";
            this.tbCountCafe_1.Text = "1";
            this.tbCountCafe_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCountCafe_1.Click += new System.EventHandler(this.tbCafe_Click);
            this.tbCountCafe_1.TextChanged += new System.EventHandler(this.tbCountCafe_TextChanged);
            // 
            // tbCountCafe_3
            // 
            this.tbCountCafe_3.Location = new System.Drawing.Point(217, 108);
            this.tbCountCafe_3.Name = "tbCountCafe_3";
            this.tbCountCafe_3.ReadOnly = true;
            this.tbCountCafe_3.Size = new System.Drawing.Size(83, 20);
            this.tbCountCafe_3.TabIndex = 6;
            this.tbCountCafe_3.Tag = "tbSaleCheeseB_3";
            this.tbCountCafe_3.Text = "1";
            this.tbCountCafe_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCountCafe_3.TextChanged += new System.EventHandler(this.tbCountCafe_TextChanged);
            // 
            // tbCountCafe_2
            // 
            this.tbCountCafe_2.Location = new System.Drawing.Point(217, 75);
            this.tbCountCafe_2.Name = "tbCountCafe_2";
            this.tbCountCafe_2.ReadOnly = true;
            this.tbCountCafe_2.Size = new System.Drawing.Size(83, 20);
            this.tbCountCafe_2.TabIndex = 5;
            this.tbCountCafe_2.Tag = "tbSaleHamb_2";
            this.tbCountCafe_2.Text = "1";
            this.tbCountCafe_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCountCafe_2.TextChanged += new System.EventHandler(this.tbCountCafe_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Red;
            this.btnCalculate.Location = new System.Drawing.Point(51, 369);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(205, 70);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbGeneralSum
            // 
            this.tbGeneralSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGeneralSum.Location = new System.Drawing.Point(405, 369);
            this.tbGeneralSum.Multiline = true;
            this.tbGeneralSum.Name = "tbGeneralSum";
            this.tbGeneralSum.Size = new System.Drawing.Size(216, 70);
            this.tbGeneralSum.TabIndex = 3;
            this.tbGeneralSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbItogo
            // 
            this.lbItogo.AutoSize = true;
            this.lbItogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbItogo.ForeColor = System.Drawing.Color.Blue;
            this.lbItogo.Location = new System.Drawing.Point(262, 384);
            this.lbItogo.Name = "lbItogo";
            this.lbItogo.Size = new System.Drawing.Size(142, 37);
            this.lbItogo.TabIndex = 5;
            this.lbItogo.Text = "ИТОГО:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 479);
            this.Controls.Add(this.lbItogo);
            this.Controls.Add(this.tbGeneralSum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbStationCafe);
            this.Controls.Add(this.gbStationOil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Автозаправка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.gbStationOil.ResumeLayout(false);
            this.gbStationOil.PerformLayout();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbPaymentOil.ResumeLayout(false);
            this.gbPaymentOil.PerformLayout();
            this.gbStationCafe.ResumeLayout(false);
            this.gbStationCafe.PerformLayout();
            this.gbPaymentCafe.ResumeLayout(false);
            this.gbPaymentCafe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStationOil;
        private System.Windows.Forms.GroupBox gbStationCafe;
        private System.Windows.Forms.GroupBox gbPaymentOil;
        private System.Windows.Forms.TextBox sumOil;
        private System.Windows.Forms.GroupBox gbPaymentCafe;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbGeneralSum;
        private System.Windows.Forms.Label lbItogo;
        private System.Windows.Forms.RadioButton rbtnSum;
        private System.Windows.Forms.RadioButton rbtnCount;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label lb_rubles_oil;
        private System.Windows.Forms.TextBox tbFuelPrice;
        private System.Windows.Forms.Label lb_sale;
        private System.Windows.Forms.Label lb_oil;
        private System.Windows.Forms.ComboBox cmbFuels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSumOfLitres;
        private System.Windows.Forms.TextBox tbLitres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSaleCocaCola_4;
        private System.Windows.Forms.TextBox tbCountCafe_4;
        private System.Windows.Forms.CheckBox tbCocaCola_4;
        private System.Windows.Forms.TextBox tbSaleHotDog_1;
        private System.Windows.Forms.CheckBox tbCheeseB_3;
        private System.Windows.Forms.TextBox tbSaleCheeseB_3;
        private System.Windows.Forms.CheckBox tbHamb_2;
        private System.Windows.Forms.TextBox tbSaleHamb_2;
        private System.Windows.Forms.CheckBox tbHotDog_1;
        private System.Windows.Forms.TextBox tbCountCafe_1;
        private System.Windows.Forms.TextBox tbCountCafe_3;
        private System.Windows.Forms.TextBox tbCountCafe_2;
        private System.Windows.Forms.TextBox sumCafe;
    }
}
