
namespace GUI
{
    partial class frmCadastroProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbUndMedia = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btCarregarFoto = new System.Windows.Forms.Button();
            this.btRemoverFoto = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btRemoverFoto);
            this.pnDados.Controls.Add(this.btCarregarFoto);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.cbSubCategoria);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.cbUndMedia);
            this.pnDados.Controls.Add(this.txtQuantidade);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor da Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quant.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unid. de Medida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(199, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "SubCategoria";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(18, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(18, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(346, 22);
            this.txtNome.TabIndex = 11;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(18, 141);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(346, 106);
            this.txtDescricao.TabIndex = 12;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(18, 276);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(162, 22);
            this.txtValorPago.TabIndex = 13;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(202, 276);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(162, 22);
            this.txtValorVenda.TabIndex = 14;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(18, 335);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(162, 22);
            this.txtQuantidade.TabIndex = 15;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // cbUndMedia
            // 
            this.cbUndMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUndMedia.FormattingEnabled = true;
            this.cbUndMedia.Location = new System.Drawing.Point(202, 336);
            this.cbUndMedia.Name = "cbUndMedia";
            this.cbUndMedia.Size = new System.Drawing.Size(162, 24);
            this.cbUndMedia.TabIndex = 16;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(18, 385);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(162, 24);
            this.cbCategoria.TabIndex = 17;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(202, 385);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(162, 24);
            this.cbSubCategoria.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Foto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(396, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 299);
            this.panel1.TabIndex = 19;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(344, 297);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btCarregarFoto
            // 
            this.btCarregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregarFoto.Location = new System.Drawing.Point(396, 355);
            this.btCarregarFoto.Name = "btCarregarFoto";
            this.btCarregarFoto.Size = new System.Drawing.Size(161, 54);
            this.btCarregarFoto.TabIndex = 20;
            this.btCarregarFoto.Text = "Carregar Foto";
            this.btCarregarFoto.UseVisualStyleBackColor = true;
            this.btCarregarFoto.Click += new System.EventHandler(this.btCarregarFoto_Click);
            // 
            // btRemoverFoto
            // 
            this.btRemoverFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverFoto.Location = new System.Drawing.Point(581, 355);
            this.btRemoverFoto.Name = "btRemoverFoto";
            this.btRemoverFoto.Size = new System.Drawing.Size(161, 54);
            this.btRemoverFoto.TabIndex = 21;
            this.btRemoverFoto.Text = "Remover Foto";
            this.btRemoverFoto.UseVisualStyleBackColor = true;
            this.btRemoverFoto.Click += new System.EventHandler(this.btRemoverFoto_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRemoverFoto;
        private System.Windows.Forms.Button btCarregarFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbUndMedia;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}
