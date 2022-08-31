namespace MehrereFormulare
{
    partial class Form1
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
            this.btnStartUnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHaupt = new System.Windows.Forms.TextBox();
            this.chkHaupt = new System.Windows.Forms.CheckBox();
            this.btnEndeHaupt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartUnter
            // 
            this.btnStartUnter.Location = new System.Drawing.Point(12, 12);
            this.btnStartUnter.Name = "btnStartUnter";
            this.btnStartUnter.Size = new System.Drawing.Size(367, 58);
            this.btnStartUnter.TabIndex = 0;
            this.btnStartUnter.Text = "Start Unterformular";
            this.btnStartUnter.UseVisualStyleBackColor = true;
            this.btnStartUnter.Click += new System.EventHandler(this.btnStartUnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 41);
            this.label1.TabIndex = 1;
            // 
            // txtHaupt
            // 
            this.txtHaupt.Location = new System.Drawing.Point(12, 91);
            this.txtHaupt.Name = "txtHaupt";
            this.txtHaupt.Size = new System.Drawing.Size(250, 47);
            this.txtHaupt.TabIndex = 2;
            this.txtHaupt.Text = "Hallo";
            // 
            // chkHaupt
            // 
            this.chkHaupt.AutoSize = true;
            this.chkHaupt.Checked = true;
            this.chkHaupt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHaupt.Location = new System.Drawing.Point(12, 157);
            this.chkHaupt.Name = "chkHaupt";
            this.chkHaupt.Size = new System.Drawing.Size(387, 45);
            this.chkHaupt.TabIndex = 3;
            this.chkHaupt.Text = "CheckBox Hauptformular";
            this.chkHaupt.UseVisualStyleBackColor = true;
            // 
            // btnEndeHaupt
            // 
            this.btnEndeHaupt.Location = new System.Drawing.Point(12, 220);
            this.btnEndeHaupt.Name = "btnEndeHaupt";
            this.btnEndeHaupt.Size = new System.Drawing.Size(367, 58);
            this.btnEndeHaupt.TabIndex = 4;
            this.btnEndeHaupt.Text = "Ende Hauptformular";
            this.btnEndeHaupt.UseVisualStyleBackColor = true;
            this.btnEndeHaupt.Click += new System.EventHandler(this.btnEndeHaupt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.btnEndeHaupt);
            this.Controls.Add(this.chkHaupt);
            this.Controls.Add(this.txtHaupt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartUnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartUnter;
        private Label label1;
        private TextBox txtHaupt;
        private CheckBox chkHaupt;
        private Button btnEndeHaupt;
    }
}