namespace PI_IDO
{
    partial class Create
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
            button1 = new System.Windows.Forms.Button();
            FIO = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            DTP1 = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            passSeries = new System.Windows.Forms.TextBox();
            passNum = new System.Windows.Forms.TextBox();
            passwhom = new System.Windows.Forms.TextBox();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            der = new System.Windows.Forms.RadioButton();
            gen = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            docType = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox9 = new System.Windows.Forms.TextBox();
            textBox8 = new System.Windows.Forms.TextBox();
            qual = new System.Windows.Forms.TextBox();
            special = new System.Windows.Forms.TextBox();
            orgLoc = new System.Windows.Forms.TextBox();
            eduOrg = new System.Windows.Forms.TextBox();
            edulvl = new System.Windows.Forms.ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(324, 578);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(109, 40);
            button1.TabIndex = 0;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save;
            // 
            // FIO
            // 
            FIO.Location = new System.Drawing.Point(148, 34);
            FIO.Name = "FIO";
            FIO.PlaceholderText = "Фамилия Имя Отчество";
            FIO.Size = new System.Drawing.Size(273, 23);
            FIO.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "ФИО";
            // 
            // DTP1
            // 
            DTP1.Location = new System.Drawing.Point(221, 64);
            DTP1.Name = "DTP1";
            DTP1.Size = new System.Drawing.Size(200, 23);
            DTP1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Пол";
            // 
            // passSeries
            // 
            passSeries.Location = new System.Drawing.Point(123, 28);
            passSeries.Name = "passSeries";
            passSeries.PlaceholderText = "Серия";
            passSeries.Size = new System.Drawing.Size(47, 23);
            passSeries.TabIndex = 9;
            passSeries.KeyPress += Onlydigits;
            // 
            // passNum
            // 
            passNum.Location = new System.Drawing.Point(176, 28);
            passNum.Name = "passNum";
            passNum.PlaceholderText = "Номер";
            passNum.Size = new System.Drawing.Size(47, 23);
            passNum.TabIndex = 10;
            passNum.KeyPress += Onlydigits;
            // 
            // passwhom
            // 
            passwhom.Location = new System.Drawing.Point(29, 57);
            passwhom.Multiline = true;
            passwhom.Name = "passwhom";
            passwhom.PlaceholderText = "Кем выдан";
            passwhom.Size = new System.Drawing.Size(342, 30);
            passwhom.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(123, 93);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(29, 99);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 15);
            label5.TabIndex = 15;
            label5.Text = "Дата выдачи";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(der);
            groupBox1.Controls.Add(gen);
            groupBox1.Controls.Add(FIO);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DTP1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(427, 127);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Личные данные";
            // 
            // der
            // 
            der.AutoSize = true;
            der.Location = new System.Drawing.Point(266, 96);
            der.Name = "der";
            der.Size = new System.Drawing.Size(75, 19);
            der.TabIndex = 9;
            der.TabStop = true;
            der.Text = "Женский";
            der.UseVisualStyleBackColor = true;
            // 
            // gen
            // 
            gen.AutoSize = true;
            gen.Location = new System.Drawing.Point(105, 96);
            gen.Name = "gen";
            gen.Size = new System.Drawing.Size(77, 19);
            gen.TabIndex = 8;
            gen.TabStop = true;
            gen.Text = "Мужской";
            gen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passSeries);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(passNum);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(passwhom);
            groupBox2.Location = new System.Drawing.Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(427, 127);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Паспортные данные";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(docType);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(qual);
            groupBox3.Controls.Add(special);
            groupBox3.Controls.Add(orgLoc);
            groupBox3.Controls.Add(eduOrg);
            groupBox3.Controls.Add(edulvl);
            groupBox3.Location = new System.Drawing.Point(12, 278);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(427, 263);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Сведения об образовании";
            // 
            // docType
            // 
            docType.FormattingEnabled = true;
            docType.Items.AddRange(new object[] { "Аттестат", "Диплом", "Удостоверение", "Свидетельство" });
            docType.Location = new System.Drawing.Point(6, 206);
            docType.Name = "docType";
            docType.Size = new System.Drawing.Size(154, 23);
            docType.TabIndex = 12;
            docType.KeyPress += Ehandled;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 151);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(88, 15);
            label9.TabIndex = 11;
            label9.Text = "Квалификация";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 122);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(92, 15);
            label8.TabIndex = 10;
            label8.Text = "Специальность";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 93);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(179, 15);
            label7.TabIndex = 9;
            label7.Text = "Местоположение организации";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 64);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(176, 15);
            label6.TabIndex = 8;
            label6.Text = "Образовательная организация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(127, 15);
            label4.TabIndex = 7;
            label4.Text = "Уровень образования";
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(196, 206);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(100, 23);
            textBox9.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(321, 206);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(100, 23);
            textBox8.TabIndex = 5;
            // 
            // qual
            // 
            qual.Location = new System.Drawing.Point(176, 148);
            qual.Name = "qual";
            qual.Size = new System.Drawing.Size(245, 23);
            qual.TabIndex = 4;
            // 
            // special
            // 
            special.Location = new System.Drawing.Point(176, 119);
            special.Name = "special";
            special.Size = new System.Drawing.Size(245, 23);
            special.TabIndex = 3;
            // 
            // orgLoc
            // 
            orgLoc.Location = new System.Drawing.Point(196, 90);
            orgLoc.Name = "orgLoc";
            orgLoc.Size = new System.Drawing.Size(225, 23);
            orgLoc.TabIndex = 2;
            // 
            // eduOrg
            // 
            eduOrg.Location = new System.Drawing.Point(196, 61);
            eduOrg.Name = "eduOrg";
            eduOrg.Size = new System.Drawing.Size(225, 23);
            eduOrg.TabIndex = 1;
            // 
            // edulvl
            // 
            edulvl.FormattingEnabled = true;
            edulvl.Items.AddRange(new object[] { "Основное общее образование", "Среднее общее образование", "Среднее професиональное образование", "Высшее образование" });
            edulvl.Location = new System.Drawing.Point(196, 32);
            edulvl.Name = "edulvl";
            edulvl.Size = new System.Drawing.Size(225, 23);
            edulvl.TabIndex = 0;
            edulvl.KeyPress += Ehandled;
            // 
            // Create
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(451, 643);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "Create";
            Text = "Добавление сотрудника";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passSeries;
        private System.Windows.Forms.TextBox passNum;
        private System.Windows.Forms.TextBox whom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton der;
        private System.Windows.Forms.RadioButton gen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox edulvl;
        private System.Windows.Forms.ComboBox docType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox qual;
        private System.Windows.Forms.TextBox special;
        private System.Windows.Forms.TextBox orgLoc;
        private System.Windows.Forms.TextBox eduOrg;
        private System.Windows.Forms.TextBox passwhom;
    }
}