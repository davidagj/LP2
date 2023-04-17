namespace PMenu
{
    partial class l
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btncomparar = new System.Windows.Forms.Button();
            this.btnempurra = new System.Windows.Forms.Button();
            this.txtpalavra1 = new System.Windows.Forms.TextBox();
            this.txtpalavra2 = new System.Windows.Forms.TextBox();
            this.btnempurra2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(37, 102);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(37, 210);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btncomparar
            // 
            this.btncomparar.Location = new System.Drawing.Point(28, 327);
            this.btncomparar.Name = "btncomparar";
            this.btncomparar.Size = new System.Drawing.Size(75, 58);
            this.btncomparar.TabIndex = 2;
            this.btncomparar.Text = "Compara Iguais";
            this.btncomparar.UseVisualStyleBackColor = true;
            this.btncomparar.Click += new System.EventHandler(this.Btncomparar_Click);
            // 
            // btnempurra
            // 
            this.btnempurra.Location = new System.Drawing.Point(178, 327);
            this.btnempurra.Name = "btnempurra";
            this.btnempurra.Size = new System.Drawing.Size(75, 58);
            this.btnempurra.TabIndex = 3;
            this.btnempurra.Text = "Inserir Meio";
            this.btnempurra.UseVisualStyleBackColor = true;
            this.btnempurra.Click += new System.EventHandler(this.Btnempurra_Click);
            // 
            // txtpalavra1
            // 
            this.txtpalavra1.Location = new System.Drawing.Point(108, 102);
            this.txtpalavra1.Name = "txtpalavra1";
            this.txtpalavra1.Size = new System.Drawing.Size(294, 20);
            this.txtpalavra1.TabIndex = 4;
            // 
            // txtpalavra2
            // 
            this.txtpalavra2.Location = new System.Drawing.Point(118, 207);
            this.txtpalavra2.Name = "txtpalavra2";
            this.txtpalavra2.Size = new System.Drawing.Size(284, 20);
            this.txtpalavra2.TabIndex = 5;
            // 
            // btnempurra2
            // 
            this.btnempurra2.Location = new System.Drawing.Point(308, 327);
            this.btnempurra2.Name = "btnempurra2";
            this.btnempurra2.Size = new System.Drawing.Size(75, 58);
            this.btnempurra2.TabIndex = 6;
            this.btnempurra2.Text = "Inserir asterisco";
            this.btnempurra2.UseVisualStyleBackColor = true;
            this.btnempurra2.Click += new System.EventHandler(this.Btnempurra2_Click);
            // 
            // l
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 468);
            this.Controls.Add(this.btnempurra2);
            this.Controls.Add(this.txtpalavra2);
            this.Controls.Add(this.txtpalavra1);
            this.Controls.Add(this.btnempurra);
            this.Controls.Add(this.btncomparar);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "l";
            this.Text = "frmexercicio2";
            this.Load += new System.EventHandler(this.Frmexercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btncomparar;
        private System.Windows.Forms.Button btnempurra;
        private System.Windows.Forms.TextBox txtpalavra1;
        private System.Windows.Forms.TextBox txtpalavra2;
        private System.Windows.Forms.Button btnempurra2;
    }
}