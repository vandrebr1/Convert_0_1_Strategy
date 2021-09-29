
namespace Convert_0_1_Strategy
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbSaida = new System.Windows.Forms.RichTextBox();
            this.btnInicia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSaida
            // 
            this.rtbSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSaida.Location = new System.Drawing.Point(12, 25);
            this.rtbSaida.Name = "rtbSaida";
            this.rtbSaida.Size = new System.Drawing.Size(1182, 384);
            this.rtbSaida.TabIndex = 0;
            this.rtbSaida.Text = "";
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(1119, 415);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(75, 23);
            this.btnInicia.TabIndex = 1;
            this.btnInicia.Text = "Iniciar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 450);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.rtbSaida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSaida;
        private System.Windows.Forms.Button btnInicia;
    }
}

