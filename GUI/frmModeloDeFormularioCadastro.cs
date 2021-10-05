using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmModeloDeFormularioCadastro : Form
    {
        public string operacao;

        public frmModeloDeFormularioCadastro()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            // op - operações que serão feitas com os botões
            // 1 - prerar os botões para inserir ou localizar
            // 2 - prerar os botões para inserir/alterar um registro
            // 3 - prerar os botões para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if(op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            } 
            else if(op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            } 
            else if(op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        private void frmModeloDeFormularioCadastro_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void frmModeloDeFormularioCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
