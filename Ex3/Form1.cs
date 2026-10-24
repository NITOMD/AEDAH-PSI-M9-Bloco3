using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarProduto_Click(object sender, EventArgs e)
        {
            Produto p = new Produto("Portátil Lenovo", "Informática", 850.00, 5, chkDisponivel.Checked);

            lblOutput.Text = p.ExibirProduto();

            // Mostrar imagem consoante disponibilidade
            if (p.Disponivel)
            {
                picProduto.Image = Properties.Resources.produtoDisponivel; // imagem colorida
            }
            else
            {
                picProduto.Image = Properties.Resources.produtoIndisponivel; // imagem a preto e branco
            }
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
