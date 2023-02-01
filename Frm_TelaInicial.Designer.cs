namespace WellPokedex
{
    partial class Frm_TelaInicial
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDigitar = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.LblInformações = new System.Windows.Forms.Label();
            this.lblHabilidade1 = new System.Windows.Forms.Label();
            this.lblHabilidade2 = new System.Windows.Forms.Label();
            this.lblHabilidade3 = new System.Windows.Forms.Label();
            this.btnForma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(225, 50);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(340, 125);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 23);
            this.lblNome.TabIndex = 1;
            // 
            // txtDigitar
            // 
            this.txtDigitar.Location = new System.Drawing.Point(30, 50);
            this.txtDigitar.Name = "txtDigitar";
            this.txtDigitar.Size = new System.Drawing.Size(188, 27);
            this.txtDigitar.TabIndex = 2;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.Location = new System.Drawing.Point(30, 15);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(275, 28);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.Text = "Digite o nome do Pokémon:";
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(227)))), ((int)(((byte)(177)))));
            this.picImagem.Location = new System.Drawing.Point(30, 100);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(283, 323);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 4;
            this.picImagem.TabStop = false;
            this.picImagem.Click += new System.EventHandler(this.picImagem_Click);
            // 
            // LblInformações
            // 
            this.LblInformações.AutoSize = true;
            this.LblInformações.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblInformações.Location = new System.Drawing.Point(361, 90);
            this.LblInformações.Name = "LblInformações";
            this.LblInformações.Size = new System.Drawing.Size(129, 28);
            this.LblInformações.TabIndex = 5;
            this.LblInformações.Text = "Informações";
            // 
            // lblHabilidade1
            // 
            this.lblHabilidade1.AutoSize = true;
            this.lblHabilidade1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHabilidade1.Location = new System.Drawing.Point(340, 250);
            this.lblHabilidade1.Name = "lblHabilidade1";
            this.lblHabilidade1.Size = new System.Drawing.Size(0, 23);
            this.lblHabilidade1.TabIndex = 6;
            // 
            // lblHabilidade2
            // 
            this.lblHabilidade2.AutoSize = true;
            this.lblHabilidade2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHabilidade2.Location = new System.Drawing.Point(340, 285);
            this.lblHabilidade2.Name = "lblHabilidade2";
            this.lblHabilidade2.Size = new System.Drawing.Size(0, 23);
            this.lblHabilidade2.TabIndex = 7;
            // 
            // lblHabilidade3
            // 
            this.lblHabilidade3.AutoSize = true;
            this.lblHabilidade3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHabilidade3.Location = new System.Drawing.Point(340, 320);
            this.lblHabilidade3.Name = "lblHabilidade3";
            this.lblHabilidade3.Size = new System.Drawing.Size(0, 23);
            this.lblHabilidade3.TabIndex = 8;
            // 
            // btnForma
            // 
            this.btnForma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnForma.Enabled = false;
            this.btnForma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForma.ForeColor = System.Drawing.Color.White;
            this.btnForma.Location = new System.Drawing.Point(124, 436);
            this.btnForma.Name = "btnForma";
            this.btnForma.Size = new System.Drawing.Size(94, 29);
            this.btnForma.TabIndex = 9;
            this.btnForma.Text = "Forma";
            this.btnForma.UseVisualStyleBackColor = false;
            this.btnForma.Click += new System.EventHandler(this.btnForma_Click);
            // 
            // Frm_TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(642, 477);
            this.Controls.Add(this.btnForma);
            this.Controls.Add(this.lblHabilidade3);
            this.Controls.Add(this.lblHabilidade2);
            this.Controls.Add(this.lblHabilidade1);
            this.Controls.Add(this.LblInformações);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtDigitar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_TelaInicial";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Well Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOk;
        private Label lblNome;
        private TextBox txtDigitar;
        private Label lblTexto;
        private PictureBox picImagem;
        private Label LblInformações;
        private Label lblHabilidade1;
        private Label lblHabilidade2;
        private Label lblHabilidade3;
        private Button btnForma;
    }
}