namespace Activity_4_Breakfast_Menu
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnToday = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnPancakes = new System.Windows.Forms.RadioButton();
            this.btnHouse = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkGreen = new System.Windows.Forms.CheckBox();
            this.checkMilk = new System.Windows.Forms.CheckBox();
            this.checkMuffin = new System.Windows.Forms.CheckBox();
            this.checkCake = new System.Windows.Forms.CheckBox();
            this.checkHash = new System.Windows.Forms.CheckBox();
            this.checkEspresso = new System.Windows.Forms.CheckBox();
            this.checkPuccino = new System.Windows.Forms.CheckBox();
            this.checkLatte = new System.Windows.Forms.CheckBox();
            this.checkMatcha = new System.Windows.Forms.CheckBox();
            this.checkLychee = new System.Windows.Forms.CheckBox();
            this.checkPepper = new System.Windows.Forms.CheckBox();
            this.checkMello = new System.Windows.Forms.CheckBox();
            this.checkAw = new System.Windows.Forms.CheckBox();
            this.checkFanta = new System.Windows.Forms.CheckBox();
            this.checkCoca = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbresultDiscount = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMilitary = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.btnNone = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(45, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 232);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToday);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.btnPancakes);
            this.groupBox1.Controls.Add(this.btnHouse);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Items";
            // 
            // btnToday
            // 
            this.btnToday.AutoSize = true;
            this.btnToday.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnToday.Location = new System.Drawing.Point(19, 185);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(127, 20);
            this.btnToday.TabIndex = 3;
            this.btnToday.TabStop = true;
            this.btnToday.Text = "Today\'s Special";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.CheckedChanged += new System.EventHandler(this.btnToday_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton3.Location = new System.Drawing.Point(19, 125);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(178, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "House Authentic Omelets";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnPancakes
            // 
            this.btnPancakes.AutoSize = true;
            this.btnPancakes.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPancakes.Location = new System.Drawing.Point(19, 75);
            this.btnPancakes.Name = "btnPancakes";
            this.btnPancakes.Size = new System.Drawing.Size(181, 20);
            this.btnPancakes.TabIndex = 1;
            this.btnPancakes.TabStop = true;
            this.btnPancakes.Text = "World-Famous Pancakes";
            this.btnPancakes.UseVisualStyleBackColor = true;
            this.btnPancakes.CheckedChanged += new System.EventHandler(this.btnPancakes_CheckedChanged);
            // 
            // btnHouse
            // 
            this.btnHouse.AutoSize = true;
            this.btnHouse.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHouse.Location = new System.Drawing.Point(19, 26);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(155, 20);
            this.btnHouse.TabIndex = 0;
            this.btnHouse.TabStop = true;
            this.btnHouse.Text = "House-Made Waffles";
            this.btnHouse.UseVisualStyleBackColor = true;
            this.btnHouse.CheckedChanged += new System.EventHandler(this.btnHouse_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(492, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 232);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkGreen);
            this.groupBox2.Controls.Add(this.checkMilk);
            this.groupBox2.Controls.Add(this.checkMuffin);
            this.groupBox2.Controls.Add(this.checkCake);
            this.groupBox2.Controls.Add(this.checkHash);
            this.groupBox2.Controls.Add(this.checkEspresso);
            this.groupBox2.Controls.Add(this.checkPuccino);
            this.groupBox2.Controls.Add(this.checkLatte);
            this.groupBox2.Controls.Add(this.checkMatcha);
            this.groupBox2.Controls.Add(this.checkLychee);
            this.groupBox2.Controls.Add(this.checkPepper);
            this.groupBox2.Controls.Add(this.checkMello);
            this.groupBox2.Controls.Add(this.checkAw);
            this.groupBox2.Controls.Add(this.checkFanta);
            this.groupBox2.Controls.Add(this.checkCoca);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 229);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beverages and Cakes";
            // 
            // checkGreen
            // 
            this.checkGreen.AutoSize = true;
            this.checkGreen.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkGreen.Location = new System.Drawing.Point(573, 26);
            this.checkGreen.Name = "checkGreen";
            this.checkGreen.Size = new System.Drawing.Size(155, 20);
            this.checkGreen.TabIndex = 14;
            this.checkGreen.Text = "Green Tea          $4.99";
            this.checkGreen.UseVisualStyleBackColor = true;
            // 
            // checkMilk
            // 
            this.checkMilk.AutoSize = true;
            this.checkMilk.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkMilk.Location = new System.Drawing.Point(573, 58);
            this.checkMilk.Name = "checkMilk";
            this.checkMilk.Size = new System.Drawing.Size(158, 20);
            this.checkMilk.TabIndex = 13;
            this.checkMilk.Text = "Milkshakes          $4.99";
            this.checkMilk.UseVisualStyleBackColor = true;
            // 
            // checkMuffin
            // 
            this.checkMuffin.AutoSize = true;
            this.checkMuffin.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkMuffin.Location = new System.Drawing.Point(573, 103);
            this.checkMuffin.Name = "checkMuffin";
            this.checkMuffin.Size = new System.Drawing.Size(151, 20);
            this.checkMuffin.TabIndex = 12;
            this.checkMuffin.Text = "Muffin                   $2.99";
            this.checkMuffin.UseVisualStyleBackColor = true;
            // 
            // checkCake
            // 
            this.checkCake.AutoSize = true;
            this.checkCake.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkCake.Location = new System.Drawing.Point(573, 147);
            this.checkCake.Name = "checkCake";
            this.checkCake.Size = new System.Drawing.Size(161, 20);
            this.checkCake.TabIndex = 11;
            this.checkCake.Text = "Marble Cake        $2.99";
            this.checkCake.UseVisualStyleBackColor = true;
            // 
            // checkHash
            // 
            this.checkHash.AutoSize = true;
            this.checkHash.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkHash.Location = new System.Drawing.Point(573, 203);
            this.checkHash.Name = "checkHash";
            this.checkHash.Size = new System.Drawing.Size(159, 20);
            this.checkHash.TabIndex = 10;
            this.checkHash.Text = "Hash Brown         $2.99";
            this.checkHash.UseVisualStyleBackColor = true;
            // 
            // checkEspresso
            // 
            this.checkEspresso.AutoSize = true;
            this.checkEspresso.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkEspresso.Location = new System.Drawing.Point(276, 21);
            this.checkEspresso.Name = "checkEspresso";
            this.checkEspresso.Size = new System.Drawing.Size(166, 20);
            this.checkEspresso.TabIndex = 9;
            this.checkEspresso.Text = "Espresso                $5.99";
            this.checkEspresso.UseVisualStyleBackColor = true;
            // 
            // checkPuccino
            // 
            this.checkPuccino.AutoSize = true;
            this.checkPuccino.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkPuccino.Location = new System.Drawing.Point(276, 58);
            this.checkPuccino.Name = "checkPuccino";
            this.checkPuccino.Size = new System.Drawing.Size(168, 20);
            this.checkPuccino.TabIndex = 8;
            this.checkPuccino.Text = "Frappuccino           $5.99";
            this.checkPuccino.UseVisualStyleBackColor = true;
            // 
            // checkLatte
            // 
            this.checkLatte.AutoSize = true;
            this.checkLatte.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkLatte.Location = new System.Drawing.Point(276, 103);
            this.checkLatte.Name = "checkLatte";
            this.checkLatte.Size = new System.Drawing.Size(169, 20);
            this.checkLatte.TabIndex = 7;
            this.checkLatte.Text = "Latte Macchaito     $5.99";
            this.checkLatte.UseVisualStyleBackColor = true;
            // 
            // checkMatcha
            // 
            this.checkMatcha.AutoSize = true;
            this.checkMatcha.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkMatcha.Location = new System.Drawing.Point(276, 148);
            this.checkMatcha.Name = "checkMatcha";
            this.checkMatcha.Size = new System.Drawing.Size(167, 20);
            this.checkMatcha.TabIndex = 6;
            this.checkMatcha.Text = "Matcha                     $4.99";
            this.checkMatcha.UseVisualStyleBackColor = true;
            // 
            // checkLychee
            // 
            this.checkLychee.AutoSize = true;
            this.checkLychee.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkLychee.Location = new System.Drawing.Point(276, 203);
            this.checkLychee.Name = "checkLychee";
            this.checkLychee.Size = new System.Drawing.Size(204, 20);
            this.checkLychee.TabIndex = 5;
            this.checkLychee.Text = "Lychee  Tea            $4.99           ";
            this.checkLychee.UseVisualStyleBackColor = true;
            // 
            // checkPepper
            // 
            this.checkPepper.AutoSize = true;
            this.checkPepper.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkPepper.Location = new System.Drawing.Point(46, 203);
            this.checkPepper.Name = "checkPepper";
            this.checkPepper.Size = new System.Drawing.Size(170, 20);
            this.checkPepper.TabIndex = 4;
            this.checkPepper.Text = "Dr. Pepper               $1.99";
            this.checkPepper.UseVisualStyleBackColor = true;
            // 
            // checkMello
            // 
            this.checkMello.AutoSize = true;
            this.checkMello.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkMello.Location = new System.Drawing.Point(46, 147);
            this.checkMello.Name = "checkMello";
            this.checkMello.Size = new System.Drawing.Size(169, 20);
            this.checkMello.TabIndex = 3;
            this.checkMello.Text = "Mello Yello              $1.99";
            this.checkMello.UseVisualStyleBackColor = true;
            // 
            // checkAw
            // 
            this.checkAw.AutoSize = true;
            this.checkAw.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkAw.Location = new System.Drawing.Point(46, 103);
            this.checkAw.Name = "checkAw";
            this.checkAw.Size = new System.Drawing.Size(166, 20);
            this.checkAw.TabIndex = 2;
            this.checkAw.Text = "A&&W                         $1.99";
            this.checkAw.UseVisualStyleBackColor = true;
            // 
            // checkFanta
            // 
            this.checkFanta.AutoSize = true;
            this.checkFanta.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkFanta.Location = new System.Drawing.Point(46, 58);
            this.checkFanta.Name = "checkFanta";
            this.checkFanta.Size = new System.Drawing.Size(169, 20);
            this.checkFanta.TabIndex = 1;
            this.checkFanta.Text = "Fanta                         $1.99";
            this.checkFanta.UseVisualStyleBackColor = true;
            // 
            // checkCoca
            // 
            this.checkCoca.AutoSize = true;
            this.checkCoca.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkCoca.Location = new System.Drawing.Point(46, 21);
            this.checkCoca.Name = "checkCoca";
            this.checkCoca.Size = new System.Drawing.Size(167, 20);
            this.checkCoca.TabIndex = 0;
            this.checkCoca.Text = "Coca                         $1.99";
            this.checkCoca.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(797, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 263);
            this.panel3.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTotal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbTax);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbresultDiscount);
            this.groupBox3.Controls.Add(this.lbDiscount);
            this.groupBox3.Controls.Add(this.lbSubtotal);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(3, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 260);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTotal.Location = new System.Drawing.Point(294, 201);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(100, 23);
            this.lbTotal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(69, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Order Total:";
            // 
            // lbTax
            // 
            this.lbTax.BackColor = System.Drawing.SystemColors.Window;
            this.lbTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTax.Location = new System.Drawing.Point(294, 151);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(100, 23);
            this.lbTax.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(69, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tax(7.75%)";
            // 
            // lbresultDiscount
            // 
            this.lbresultDiscount.BackColor = System.Drawing.SystemColors.Window;
            this.lbresultDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbresultDiscount.ForeColor = System.Drawing.Color.Red;
            this.lbresultDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbresultDiscount.Location = new System.Drawing.Point(294, 105);
            this.lbresultDiscount.Name = "lbresultDiscount";
            this.lbresultDiscount.Size = new System.Drawing.Size(100, 23);
            this.lbresultDiscount.TabIndex = 3;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbDiscount.Location = new System.Drawing.Point(69, 105);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(62, 16);
            this.lbDiscount.TabIndex = 2;
            this.lbDiscount.Text = "Discount:";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.lbSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSubtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSubtotal.Location = new System.Drawing.Point(294, 56);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(100, 23);
            this.lbSubtotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(69, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(492, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 263);
            this.panel4.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(66, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Location = new System.Drawing.Point(66, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(66, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.groupBox5);
            this.panel5.Location = new System.Drawing.Point(45, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(438, 136);
            this.panel5.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(0, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(438, 121);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(429, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Info;
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Location = new System.Drawing.Point(45, 407);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(438, 118);
            this.panel6.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMilitary);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.btnNone);
            this.groupBox4.Location = new System.Drawing.Point(0, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 115);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Discount";
            // 
            // btnMilitary
            // 
            this.btnMilitary.AutoSize = true;
            this.btnMilitary.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMilitary.Location = new System.Drawing.Point(313, 53);
            this.btnMilitary.Name = "btnMilitary";
            this.btnMilitary.Size = new System.Drawing.Size(70, 20);
            this.btnMilitary.TabIndex = 2;
            this.btnMilitary.TabStop = true;
            this.btnMilitary.Text = "Military";
            this.btnMilitary.UseVisualStyleBackColor = true;
            this.btnMilitary.CheckedChanged += new System.EventHandler(this.btnMilitary_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton6.Location = new System.Drawing.Point(162, 53);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(90, 20);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Employee";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // btnNone
            // 
            this.btnNone.AutoSize = true;
            this.btnNone.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNone.Location = new System.Drawing.Point(42, 53);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(61, 20);
            this.btnNone.TabIndex = 0;
            this.btnNone.TabStop = true;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.CheckedChanged += new System.EventHandler(this.btnNone_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1304, 626);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Breakfast Menu";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnToday;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton btnPancakes;
        private System.Windows.Forms.RadioButton btnHouse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkGreen;
        private System.Windows.Forms.CheckBox checkMilk;
        private System.Windows.Forms.CheckBox checkMuffin;
        private System.Windows.Forms.CheckBox checkCake;
        private System.Windows.Forms.CheckBox checkHash;
        private System.Windows.Forms.CheckBox checkEspresso;
        private System.Windows.Forms.CheckBox checkPuccino;
        private System.Windows.Forms.CheckBox checkLatte;
        private System.Windows.Forms.CheckBox checkMatcha;
        private System.Windows.Forms.CheckBox checkLychee;
        private System.Windows.Forms.CheckBox checkPepper;
        private System.Windows.Forms.CheckBox checkMello;
        private System.Windows.Forms.CheckBox checkAw;
        private System.Windows.Forms.CheckBox checkFanta;
        private System.Windows.Forms.CheckBox checkCoca;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbresultDiscount;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton btnMilitary;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton btnNone;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

