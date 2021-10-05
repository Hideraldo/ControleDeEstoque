using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUnidadeDeMedida : GUI.frmModeloDeFormularioCadastro
    {
        public frmCadastroUnidadeDeMedida()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCodigo.BackColor = Control.DefaultBackColor;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtCodigo.BackColor = Color.White;
            txtNome.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                modelo.UmedNome = txtNome.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso! Código: " + modelo.UmedCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.UmedCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeMedida(f.codigo);
                txtCodigo.Text = modelo.UmedCod.ToString();
                txtNome.Text = modelo.UmedNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if(this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                r = bll.VerificarUnidadeDeMedida(txtNome.Text);
                if(r > 0)
                {
                    DialogResult d = MessageBox.Show("Unidade de medida já existe. Deseja alter o registro", "Aviso", MessageBoxButtons.YesNo);
                    if(d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeMedida(r);
                        txtCodigo.Text = modelo.UmedCod.ToString();
                        txtNome.Text = modelo.UmedNome;
                    }
                    else
                    {
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                }
            }
        }
    }
}
