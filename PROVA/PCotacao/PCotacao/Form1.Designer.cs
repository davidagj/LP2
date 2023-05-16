namespace PCotacao
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
            this.lstbS = new System.Windows.Forms.ListBox();
            this.btnex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbS
            // 
            this.lstbS.FormattingEnabled = true;
            this.lstbS.Location = new System.Drawing.Point(229, 91);
            this.lstbS.Name = "lstbS";
            this.lstbS.Size = new System.Drawing.Size(546, 290);
            this.lstbS.TabIndex = 0;
            this.lstbS.SelectedIndexChanged += new System.EventHandler(this.LstbS_SelectedIndexChanged);
            // 
            // btnex
            // 
            this.btnex.Location = new System.Drawing.Point(41, 143);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(117, 118);
            this.btnex.TabIndex = 1;
            this.btnex.Text = "Executar";
            this.btnex.UseVisualStyleBackColor = true;
            this.btnex.Click += new System.EventHandler(this.Btnex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.lstbS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbS;
        private System.Windows.Forms.Button btnex;
    }
}

