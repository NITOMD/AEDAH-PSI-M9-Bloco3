using Ex3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarProduto_Click(object sender, EventArgs e)
        {
            // Converter os valores inseridos nas TextBox
            string nome = txtNome.Text;
            string categoria = txtCategoria.Text;
            double preco = 0;
            int quantidade = 0;

            // Validação simples dos campos numéricos
            if (!double.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Por favor, introduza um valor numérico válido para o preço.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out quantidade))
            {
                MessageBox.Show("Por favor, introduza um número inteiro válido para a quantidade.");
                return;
            }

            // Criar o objeto Produto
            Produto p = new Produto(nome, categoria, preco, quantidade, chkDisponivel.Checked);

            // Exibir os dados na Label
            lblOutput.Text = p.ExibirProduto();

            // Mostrar imagem conforme o estado e stock
            if (!p.Disponivel)
            {
                // Produto indisponível -> imagem a preto e branco
                picProduto.Image = Properties.Resources.produtoIndisponivel;
            }
            else if (p.Quantidade < 3)
            {
                // Stock baixo -> imagem de aviso
                picProduto.Image = Properties.Resources.stockBaixo;
            }
            else
            {
                // Produto normal disponível
                picProduto.Image = Properties.Resources.produtoDisponivel;
            }
            Console.Beep();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
 }

