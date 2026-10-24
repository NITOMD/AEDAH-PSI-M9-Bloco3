namespace Ex3
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.btnCriarProduto = new System.Windows.Forms.Button();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(41, 36);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(79, 29);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "label1";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(463, 52);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(187, 163);
            this.picProduto.TabIndex = 1;
            this.picProduto.TabStop = false;
            // 
            // btnCriarProduto
            // 
            this.btnCriarProduto.Location = new System.Drawing.Point(64, 276);
            this.btnCriarProduto.Name = "btnCriarProduto";
            this.btnCriarProduto.Size = new System.Drawing.Size(284, 37);
            this.btnCriarProduto.TabIndex = 2;
            this.btnCriarProduto.Text = "Criar Produto";
            this.btnCriarProduto.UseVisualStyleBackColor = true;
            this.btnCriarProduto.Click += new System.EventHandler(this.btnCriarProduto_Click);
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(485, 276);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(95, 20);
            this.chkDisponivel.TabIndex = 3;
            this.chkDisponivel.Text = "checkBox1";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.btnCriarProduto);
            this.Controls.Add(this.picProduto);
            this.Controls.Add(this.lblOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Button btnCriarProduto;
        private System.Windows.Forms.CheckBox chkDisponivel;
    }
}

