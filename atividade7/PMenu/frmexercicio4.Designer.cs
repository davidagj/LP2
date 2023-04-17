namespace PMenu
{
    partial class frmexercicio4
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
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnEspaço = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTexto
            // 
            this.rchTexto.Location = new System.Drawing.Point(121, 55);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(455, 166);
            this.rchTexto.TabIndex = 0;
            this.rchTexto.Text = "";
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(121, 287);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(101, 23);
            this.btnNumeros.TabIndex = 1;
            this.btnNumeros.Text = "Total de numeros";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(294, 287);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(103, 23);
            this.btnLetras.TabIndex = 2;
            this.btnLetras.Text = "total de letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnEspaço
            // 
            this.btnEspaço.Location = new System.Drawing.Point(466, 287);
            this.btnEspaço.Name = "btnEspaço";
            this.btnEspaço.Size = new System.Drawing.Size(110, 23);
            this.btnEspaço.TabIndex = 3;
            this.btnEspaço.Text = "Primeiro espaço";
            this.btnEspaço.UseVisualStyleBackColor = true;
            this.btnEspaço.Click += new System.EventHandler(this.btnEspaço_Click);
            // 
            // frmexercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEspaço);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.rchTexto);
            this.Name = "frmexercicio4";
            this.Text = "frmexercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTexto;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnEspaço;
    }
}