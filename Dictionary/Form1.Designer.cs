namespace Dictionary
{
    partial class frmMain
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
            this.cmbLanguage1 = new System.Windows.Forms.ComboBox();
            this.cmbLanguage2 = new System.Windows.Forms.ComboBox();
            this.txtLanguage1 = new System.Windows.Forms.TextBox();
            this.txtLanguage2 = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLanguage1
            // 
            this.cmbLanguage1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbLanguage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLanguage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguage1.FormattingEnabled = true;
            this.cmbLanguage1.Location = new System.Drawing.Point(39, 117);
            this.cmbLanguage1.Name = "cmbLanguage1";
            this.cmbLanguage1.Size = new System.Drawing.Size(181, 33);
            this.cmbLanguage1.TabIndex = 0;
            this.cmbLanguage1.Text = "Select language";
            this.cmbLanguage1.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage1_SelectedIndexChanged);
            // 
            // cmbLanguage2
            // 
            this.cmbLanguage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLanguage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguage2.FormattingEnabled = true;
            this.cmbLanguage2.Location = new System.Drawing.Point(291, 117);
            this.cmbLanguage2.Name = "cmbLanguage2";
            this.cmbLanguage2.Size = new System.Drawing.Size(189, 33);
            this.cmbLanguage2.TabIndex = 1;
            this.cmbLanguage2.Text = "Select language";
            this.cmbLanguage2.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage2_SelectedIndexChanged);
            // 
            // txtLanguage1
            // 
            this.txtLanguage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage1.Location = new System.Drawing.Point(39, 174);
            this.txtLanguage1.Name = "txtLanguage1";
            this.txtLanguage1.Size = new System.Drawing.Size(181, 30);
            this.txtLanguage1.TabIndex = 2;
            this.txtLanguage1.TextChanged += new System.EventHandler(this.txtLanguage1_TextChanged);
            // 
            // txtLanguage2
            // 
            this.txtLanguage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage2.Location = new System.Drawing.Point(291, 174);
            this.txtLanguage2.Name = "txtLanguage2";
            this.txtLanguage2.Size = new System.Drawing.Size(189, 30);
            this.txtLanguage2.TabIndex = 3;
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTranslate.Enabled = false;
            this.btnTranslate.FlatAppearance.BorderSize = 0;
            this.btnTranslate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.ForeColor = System.Drawing.Color.White;
            this.btnTranslate.Location = new System.Drawing.Point(291, 238);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(189, 31);
            this.btnTranslate.TabIndex = 4;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(39, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 449);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtLanguage2);
            this.Controls.Add(this.txtLanguage1);
            this.Controls.Add(this.cmbLanguage2);
            this.Controls.Add(this.cmbLanguage1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLanguage1;
        private System.Windows.Forms.ComboBox cmbLanguage2;
        private System.Windows.Forms.TextBox txtLanguage1;
        private System.Windows.Forms.TextBox txtLanguage2;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnAdd;
    }
}

