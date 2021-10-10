using BLL;
using DAL;
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
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;

        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void DestacarLinhaDataGridView()
        {
            foreach(DataGridViewRow row in dgvDados.Rows)
            {
                if ((int.Parse(row.Cells[0].Value.ToString()) % 2) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.PaleTurquoise;
                }
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
            this.DestacarLinhaDataGridView();
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Cód.";
            dgvDados.Columns[0].Width = 35;
            dgvDados.Columns[1].HeaderText = "Produto";
            dgvDados.Columns[1].Width = 100;
            dgvDados.Columns[2].HeaderText = "Descrição";
            dgvDados.Columns[2].Width = 150;
            //dgvDados.Columns[3].HeaderText = "Foto";
            dgvDados.Columns[3].Visible = false;
            dgvDados.Columns[4].HeaderText = "Valor Pago";
            dgvDados.Columns[4].Width = 60;
            dgvDados.Columns[4].DefaultCellStyle.Format = "c";
            dgvDados.Columns[5].HeaderText = "Valor de Venda";
            dgvDados.Columns[5].Width = 60;
            dgvDados.Columns[5].DefaultCellStyle.Format = "c";
            dgvDados.Columns[6].HeaderText = "Qtda.";
            dgvDados.Columns[6].Width = 45;
            dgvDados.Columns[6].DefaultCellStyle.Format = "N2";
            //dgvDados.Columns[7].HeaderText = "Und. Med.";
            dgvDados.Columns[7].Visible = false;
            //dgvDados.Columns[8].HeaderText = "Categoria";
            dgvDados.Columns[8].Visible = false;
            //dgvDados.Columns[9].HeaderText = "SubCategoria";
            dgvDados.Columns[9].Visible = false;
            dgvDados.Columns[10].HeaderText = "Und. Med.";
            dgvDados.Columns[10].Width = 60;
            dgvDados.Columns[11].HeaderText = "Categoria";
            dgvDados.Columns[11].Width = 100;
            dgvDados.Columns[12].HeaderText = "SubCategoria";
            dgvDados.Columns[12].Width = 100;

            //também pode ser usado assim para não mostrar
            //dgvDados.Columns["cat_cod"].Visible = false;

            this.DestacarLinhaDataGridView();
        }

        private void dgvDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
