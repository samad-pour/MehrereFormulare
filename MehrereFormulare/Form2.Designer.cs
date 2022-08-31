namespace MehrereFormulare
{
    partial class Form2
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
            this.txtUnter = new System.Windows.Forms.TextBox();
            this.chkUnter = new System.Windows.Forms.CheckBox();
            this.btnEndeUnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnter
            // 
            this.txtUnter.Location = new System.Drawing.Point(12, 74);
            this.txtUnter.Name = "txtUnter";
            this.txtUnter.Size = new System.Drawing.Size(250, 47);
            this.txtUnter.TabIndex = 0;
            // 
            // chkUnter
            // 
            this.chkUnter.AutoSize = true;
            this.chkUnter.Location = new System.Drawing.Point(12, 146);
            this.chkUnter.Name = "chkUnter";
            this.chkUnter.Size = new System.Drawing.Size(380, 45);
            this.chkUnter.TabIndex = 1;
            this.chkUnter.Text = "CheckBox Unterformular";
            this.chkUnter.UseVisualStyleBackColor = true;
            // 
            // btnEndeUnter
            // 
            this.btnEndeUnter.Location = new System.Drawing.Point(12, 211);
            this.btnEndeUnter.Name = "btnEndeUnter";
            this.btnEndeUnter.Size = new System.Drawing.Size(337, 58);
            this.btnEndeUnter.TabIndex = 2;
            this.btnEndeUnter.Text = "Ende Unterformular";
            this.btnEndeUnter.UseVisualStyleBackColor = true;
            this.btnEndeUnter.Click += new System.EventHandler(this.btnEndeUnter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEndeUnter);
            this.Controls.Add(this.chkUnter);
            this.Controls.Add(this.txtUnter);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUnter;
        private CheckBox chkUnter;
        private Button btnEndeUnter;
    }
}