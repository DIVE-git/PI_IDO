namespace PI_IDO
{
    partial class Load
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
            ComboLoad = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ComboLoad
            // 
            ComboLoad.FormattingEnabled = true;
            ComboLoad.Location = new System.Drawing.Point(12, 12);
            ComboLoad.Name = "ComboLoad";
            ComboLoad.Size = new System.Drawing.Size(267, 23);
            ComboLoad.TabIndex = 0;
            ComboLoad.KeyPress += EHandled;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(41, 69);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(197, 35);
            button1.TabIndex = 2;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Load
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(291, 116);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ComboLoad);
            Name = "Load";
            Text = "Load";
            Load += Load_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox ComboLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}