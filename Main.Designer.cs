namespace PI_IDO
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            butCreate = new System.Windows.Forms.Button();
            output = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            butSave = new System.Windows.Forms.Button();
            butLoad = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // butCreate
            // 
            butCreate.Location = new System.Drawing.Point(12, 351);
            butCreate.Name = "butCreate";
            butCreate.Size = new System.Drawing.Size(188, 69);
            butCreate.TabIndex = 3;
            butCreate.Text = "Добавить сотрудника";
            butCreate.UseVisualStyleBackColor = true;
            butCreate.Click += Create;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            output.Location = new System.Drawing.Point(12, 51);
            output.Name = "output";
            output.Size = new System.Drawing.Size(208, 209);
            output.TabIndex = 4;
            output.Text = "ФИО:\r\nДата рождения:\r\nПол:\r\nСерия и номер:\r\nКем выдан:\r\nДата выдачи:\r\nУровень образования:\r\nОбразовательная организация:\r\nМестоположение организации:\r\nСпециальность:\r\nКвалификация:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { справкаToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(570, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += Help;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += Exit;
            // 
            // butSave
            // 
            butSave.Location = new System.Drawing.Point(206, 351);
            butSave.Name = "butSave";
            butSave.Size = new System.Drawing.Size(159, 32);
            butSave.TabIndex = 6;
            butSave.Text = "Сохранить";
            butSave.UseVisualStyleBackColor = true;
            butSave.Click += Save;
            // 
            // butLoad
            // 
            butLoad.Location = new System.Drawing.Point(206, 388);
            butLoad.Name = "butLoad";
            butLoad.Size = new System.Drawing.Size(159, 32);
            butLoad.TabIndex = 7;
            butLoad.Text = "Загрузить список сотрудников";
            butLoad.UseVisualStyleBackColor = true;
            butLoad.Click += LoadList;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(570, 432);
            Controls.Add(butLoad);
            Controls.Add(butSave);
            Controls.Add(output);
            Controls.Add(butCreate);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            this.Load += this.Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        public System.Windows.Forms.Label output;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butLoad;
    }
}
