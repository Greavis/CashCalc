
namespace CashCalc
{
    partial class CalcForm
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
            this.CloseBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emplCount1 = new System.Windows.Forms.RadioButton();
            this.emplCount2 = new System.Windows.Forms.RadioButton();
            this.expBox = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.magazineCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sumAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.principalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aksesAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneOrderCount = new System.Windows.Forms.TextBox();
            this.radio13proc = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.radio68proc = new System.Windows.Forms.RadioButton();
            this.checkBoxCardPay = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.settingsCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.repairs30 = new System.Windows.Forms.TextBox();
            this.repairs50 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bonusesCount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.daySalary = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.CalcButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.monthSalary = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hoursCount = new System.Windows.Forms.NumericUpDown();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.Location = new System.Drawing.Point(695, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 25);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "X";
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CashCalc.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стаж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Магазин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кол-во человек";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Раб. часы";
            // 
            // emplCount1
            // 
            this.emplCount1.AutoSize = true;
            this.emplCount1.Checked = true;
            this.emplCount1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emplCount1.ForeColor = System.Drawing.Color.White;
            this.emplCount1.Location = new System.Drawing.Point(138, 179);
            this.emplCount1.Name = "emplCount1";
            this.emplCount1.Size = new System.Drawing.Size(31, 19);
            this.emplCount1.TabIndex = 10;
            this.emplCount1.TabStop = true;
            this.emplCount1.Text = "1";
            this.emplCount1.UseVisualStyleBackColor = true;
            // 
            // emplCount2
            // 
            this.emplCount2.AutoSize = true;
            this.emplCount2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emplCount2.ForeColor = System.Drawing.Color.White;
            this.emplCount2.Location = new System.Drawing.Point(175, 179);
            this.emplCount2.Name = "emplCount2";
            this.emplCount2.Size = new System.Drawing.Size(31, 19);
            this.emplCount2.TabIndex = 11;
            this.emplCount2.Text = "2";
            this.emplCount2.UseVisualStyleBackColor = true;
            // 
            // expBox
            // 
            this.expBox.Location = new System.Drawing.Point(86, 97);
            this.expBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(37, 23);
            this.expBox.TabIndex = 12;
            this.expBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(22, 256);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 13;
            // 
            // magazineCombo
            // 
            this.magazineCombo.FormattingEnabled = true;
            this.magazineCombo.Items.AddRange(new object[] {
            "Артбухта",
            "Меньшикова",
            "Остряки",
            "Пожарова",
            "Посейдон",
            "Центр",
            "Юмашева"});
            this.magazineCombo.Location = new System.Drawing.Point(86, 136);
            this.magazineCombo.Name = "magazineCombo";
            this.magazineCombo.Size = new System.Drawing.Size(121, 23);
            this.magazineCombo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(270, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Общ. оборот";
            // 
            // sumAmount
            // 
            this.sumAmount.Location = new System.Drawing.Point(270, 346);
            this.sumAmount.Name = "sumAmount";
            this.sumAmount.PlaceholderText = "0";
            this.sumAmount.ReadOnly = true;
            this.sumAmount.Size = new System.Drawing.Size(100, 23);
            this.sumAmount.TabIndex = 16;
            this.sumAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(270, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Осн. товар";
            // 
            // principalAmount
            // 
            this.principalAmount.Location = new System.Drawing.Point(270, 67);
            this.principalAmount.Name = "principalAmount";
            this.principalAmount.Size = new System.Drawing.Size(100, 23);
            this.principalAmount.TabIndex = 18;
            this.principalAmount.Text = "0";
            this.principalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.principalAmount.Click += new System.EventHandler(this.principalAmount_Click);
            this.principalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.principalAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(270, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Аксесуары";
            // 
            // aksesAmount
            // 
            this.aksesAmount.Location = new System.Drawing.Point(270, 122);
            this.aksesAmount.Name = "aksesAmount";
            this.aksesAmount.Size = new System.Drawing.Size(100, 23);
            this.aksesAmount.TabIndex = 20;
            this.aksesAmount.Text = "0";
            this.aksesAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aksesAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aksesAmount_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(270, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Сумм телеф заказ";
            // 
            // phoneOrderCount
            // 
            this.phoneOrderCount.Location = new System.Drawing.Point(270, 185);
            this.phoneOrderCount.Name = "phoneOrderCount";
            this.phoneOrderCount.Size = new System.Drawing.Size(100, 23);
            this.phoneOrderCount.TabIndex = 22;
            this.phoneOrderCount.Text = "0";
            this.phoneOrderCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneOrderCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneOrderCount_KeyPress);
            // 
            // radio13proc
            // 
            this.radio13proc.AutoSize = true;
            this.radio13proc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.radio13proc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio13proc.ForeColor = System.Drawing.Color.White;
            this.radio13proc.Location = new System.Drawing.Point(276, 229);
            this.radio13proc.Name = "radio13proc";
            this.radio13proc.Size = new System.Drawing.Size(81, 19);
            this.radio13proc.TabIndex = 23;
            this.radio13proc.TabStop = true;
            this.radio13proc.Text = "от 1 до 3%";
            this.radio13proc.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(270, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "наценка";
            // 
            // radio68proc
            // 
            this.radio68proc.AutoSize = true;
            this.radio68proc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.radio68proc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio68proc.ForeColor = System.Drawing.Color.White;
            this.radio68proc.Location = new System.Drawing.Point(276, 255);
            this.radio68proc.Name = "radio68proc";
            this.radio68proc.Size = new System.Drawing.Size(81, 19);
            this.radio68proc.TabIndex = 25;
            this.radio68proc.TabStop = true;
            this.radio68proc.Text = "от 6 до 8%";
            this.radio68proc.UseVisualStyleBackColor = false;
            // 
            // checkBoxCardPay
            // 
            this.checkBoxCardPay.AutoSize = true;
            this.checkBoxCardPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkBoxCardPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCardPay.ForeColor = System.Drawing.Color.White;
            this.checkBoxCardPay.Location = new System.Drawing.Point(276, 281);
            this.checkBoxCardPay.Name = "checkBoxCardPay";
            this.checkBoxCardPay.Size = new System.Drawing.Size(107, 19);
            this.checkBoxCardPay.TabIndex = 26;
            this.checkBoxCardPay.Text = "Оплата картой";
            this.checkBoxCardPay.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(517, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Настройки";
            // 
            // settingsCount
            // 
            this.settingsCount.Location = new System.Drawing.Point(517, 66);
            this.settingsCount.Name = "settingsCount";
            this.settingsCount.Size = new System.Drawing.Size(100, 23);
            this.settingsCount.TabIndex = 28;
            this.settingsCount.Text = "0";
            this.settingsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.settingsCount_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(517, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ремонты 30%";
            // 
            // repairs30
            // 
            this.repairs30.Location = new System.Drawing.Point(517, 123);
            this.repairs30.Name = "repairs30";
            this.repairs30.Size = new System.Drawing.Size(100, 23);
            this.repairs30.TabIndex = 30;
            this.repairs30.Text = "0";
            this.repairs30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repairs30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repairs30_KeyPress);
            // 
            // repairs50
            // 
            this.repairs50.Location = new System.Drawing.Point(517, 181);
            this.repairs50.Name = "repairs50";
            this.repairs50.Size = new System.Drawing.Size(100, 23);
            this.repairs50.TabIndex = 32;
            this.repairs50.Text = "0";
            this.repairs50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repairs50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repairs50_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(517, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ремонты 50%";
            // 
            // bonusesCount
            // 
            this.bonusesCount.Location = new System.Drawing.Point(517, 240);
            this.bonusesCount.Name = "bonusesCount";
            this.bonusesCount.Size = new System.Drawing.Size(100, 23);
            this.bonusesCount.TabIndex = 34;
            this.bonusesCount.Text = "0";
            this.bonusesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bonusesCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bonusesCount_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(517, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Бонусы";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.daySalary);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.CalcButton);
            this.panel2.Location = new System.Drawing.Point(443, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 152);
            this.panel2.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(146, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "ЗП за день";
            // 
            // daySalary
            // 
            this.daySalary.Location = new System.Drawing.Point(129, 61);
            this.daySalary.Name = "daySalary";
            this.daySalary.PlaceholderText = "0";
            this.daySalary.ReadOnly = true;
            this.daySalary.Size = new System.Drawing.Size(100, 23);
            this.daySalary.TabIndex = 2;
            this.daySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(24, 89);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 32);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // CalcButton
            // 
            this.CalcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.CalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcButton.ForeColor = System.Drawing.Color.White;
            this.CalcButton.Location = new System.Drawing.Point(24, 25);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(85, 32);
            this.CalcButton.TabIndex = 0;
            this.CalcButton.Text = "Расчитать";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(273, 386);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 21);
            this.label16.TabIndex = 36;
            this.label16.Text = "ЗП за месяц";
            // 
            // monthSalary
            // 
            this.monthSalary.Location = new System.Drawing.Point(270, 414);
            this.monthSalary.Name = "monthSalary";
            this.monthSalary.ReadOnly = true;
            this.monthSalary.Size = new System.Drawing.Size(100, 23);
            this.monthSalary.TabIndex = 37;
            this.monthSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(248, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 149);
            this.panel3.TabIndex = 10;
            // 
            // hoursCount
            // 
            this.hoursCount.Location = new System.Drawing.Point(98, 221);
            this.hoursCount.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hoursCount.Name = "hoursCount";
            this.hoursCount.Size = new System.Drawing.Size(51, 23);
            this.hoursCount.TabIndex = 38;
            this.hoursCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(70, 48);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 21);
            this.usernameLabel.TabIndex = 39;
            this.usernameLabel.Text = "username";
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(720, 462);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.hoursCount);
            this.Controls.Add(this.monthSalary);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bonusesCount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.repairs50);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.repairs30);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.settingsCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBoxCardPay);
            this.Controls.Add(this.radio68proc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radio13proc);
            this.Controls.Add(this.phoneOrderCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aksesAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.principalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sumAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.magazineCombo);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.expBox);
            this.Controls.Add(this.emplCount2);
            this.Controls.Add(this.emplCount1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalcForm";
            this.Text = "CalcForm";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton emplCount1;
        private System.Windows.Forms.RadioButton emplCount2;
        private System.Windows.Forms.NumericUpDown expBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox magazineCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sumAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox principalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aksesAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneOrderCount;
        private System.Windows.Forms.RadioButton radio13proc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radio68proc;
        private System.Windows.Forms.CheckBox checkBoxCardPay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox settingsCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox repairs30;
        private System.Windows.Forms.TextBox repairs50;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bonusesCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox daySalary;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox monthSalary;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown hoursCount;
        private System.Windows.Forms.Label usernameLabel;
    }
}