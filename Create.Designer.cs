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
            button1.Location = new System.Drawing.Point(337, 611);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(166, 57);
            button1.TabIndex = 0;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save;
            // 
            // FIO
            // 
            FIO.Location = new System.Drawing.Point(169, 28);
            FIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FIO.Name = "FIO";
            FIO.PlaceholderText = "Фамилия Имя Отчество";
            FIO.Size = new System.Drawing.Size(311, 27);
            FIO.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "ФИО";
            // 
            // DTP1
            // 
            DTP1.Location = new System.Drawing.Point(252, 63);
            DTP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DTP1.Name = "DTP1";
            DTP1.Size = new System.Drawing.Size(228, 27);
            DTP1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 20);
            label2.TabIndex = 5;
            label2.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 20);
            label3.TabIndex = 7;
            label3.Text = "Пол";
            // 
            // passSeries
            // 
            passSeries.Location = new System.Drawing.Point(6, 37);
            passSeries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            passSeries.Name = "passSeries";
            passSeries.PlaceholderText = "Серия";
            passSeries.Size = new System.Drawing.Size(53, 27);
            passSeries.TabIndex = 9;
            passSeries.KeyPress += Onlydigits;
            // 
            // passNum
            // 
            passNum.Location = new System.Drawing.Point(65, 37);
            passNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            passNum.Name = "passNum";
            passNum.PlaceholderText = "Номер";
            passNum.Size = new System.Drawing.Size(53, 27);
            passNum.TabIndex = 10;
            passNum.KeyPress += Onlydigits;
            // 
            // passwhom
            // 
            passwhom.Location = new System.Drawing.Point(141, 37);
            passwhom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            passwhom.Multiline = true;
            passwhom.Name = "passwhom";
            passwhom.PlaceholderText = "Кем выдан";
            passwhom.Size = new System.Drawing.Size(314, 53);
            passwhom.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(141, 101);
            dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(228, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 106);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(97, 20);
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
            groupBox1.Location = new System.Drawing.Point(14, 16);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(488, 145);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Личные данные";
            // 
            // der
            // 
            der.AutoSize = true;
            der.Location = new System.Drawing.Point(305, 102);
            der.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            der.Name = "der";
            der.Size = new System.Drawing.Size(92, 24);
            der.TabIndex = 9;
            der.TabStop = true;
            der.Text = "Женский";
            der.UseVisualStyleBackColor = true;
            // 
            // gen
            // 
            gen.AutoSize = true;
            gen.Location = new System.Drawing.Point(122, 102);
            gen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gen.Name = "gen";
            gen.Size = new System.Drawing.Size(93, 24);
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
            groupBox2.Location = new System.Drawing.Point(14, 169);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(488, 149);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Паспортные данные";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(docType);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(qual);
            groupBox3.Controls.Add(special);
            groupBox3.Controls.Add(orgLoc);
            groupBox3.Controls.Add(eduOrg);
            groupBox3.Controls.Add(edulvl);
            groupBox3.Location = new System.Drawing.Point(14, 326);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(488, 277);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Сведения об образовании";
            // 
            // docType
            // 
            docType.Enabled = false;
            docType.FormattingEnabled = true;
            docType.Items.AddRange(new object[] { "Аттестат", "Диплом", "Удостоверение", "Свидетельство" });
            docType.Location = new System.Drawing.Point(6, 232);
            docType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            docType.Name = "docType";
            docType.Size = new System.Drawing.Size(175, 28);
            docType.TabIndex = 12;
            docType.Text = "unused";
            docType.KeyPress += Ehandled;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 47);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(166, 20);
            label4.TabIndex = 7;
            label4.Text = "Уровень образования";
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new System.Drawing.Point(210, 233);
            textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(114, 27);
            textBox9.TabIndex = 6;
            textBox9.Text = "unused";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new System.Drawing.Point(366, 232);
            textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(114, 27);
            textBox8.TabIndex = 5;
            textBox8.Text = "unused";
            // 
            // qual
            // 
            qual.Location = new System.Drawing.Point(7, 197);
            qual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            qual.Name = "qual";
            qual.PlaceholderText = "Квалификация";
            qual.Size = new System.Drawing.Size(473, 27);
            qual.TabIndex = 4;
            // 
            // special
            // 
            special.Location = new System.Drawing.Point(7, 159);
            special.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            special.Name = "special";
            special.PlaceholderText = "Специальность";
            special.Size = new System.Drawing.Size(473, 27);
            special.TabIndex = 3;
            // 
            // orgLoc
            // 
            orgLoc.Location = new System.Drawing.Point(7, 120);
            orgLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            orgLoc.Name = "orgLoc";
            orgLoc.PlaceholderText = "Местоположение организации";
            orgLoc.Size = new System.Drawing.Size(474, 27);
            orgLoc.TabIndex = 2;
            // 
            // eduOrg
            // 
            eduOrg.Location = new System.Drawing.Point(7, 81);
            eduOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            eduOrg.Name = "eduOrg";
            eduOrg.PlaceholderText = "Образовательная организация";
            eduOrg.Size = new System.Drawing.Size(474, 27);
            eduOrg.TabIndex = 1;
            // 
            // edulvl
            // 
            edulvl.FormattingEnabled = true;
            edulvl.Items.AddRange(new object[] { "Основное общее образование", "Среднее общее образование", "Среднее професиональное образование", "Высшее образование" });
            edulvl.Location = new System.Drawing.Point(179, 43);
            edulvl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            edulvl.Name = "edulvl";
            edulvl.Size = new System.Drawing.Size(302, 28);
            edulvl.TabIndex = 0;
            edulvl.KeyPress += Ehandled;
            // 
            // Create
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(515, 681);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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