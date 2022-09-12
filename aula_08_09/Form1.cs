using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_08_09
{
    public partial class Form1 : Form
    {
        Produto prod = new Produto();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             //Instancia do objeto

        }
        private void button1_Click(object sender, EventArgs e)
        {
            prod.id = int.Parse(textBox1.Text);
            prod.nome = textBox2.Text;
            prod.qtd_estoque = int.Parse(textBox3.Text);
            prod.preco = float.Parse(textBox4.Text);

            MessageBox.Show("Dados salvos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Limpar dados
            textBox1.Text = ""; //Objeto.Propriedade = valor;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Dados do produto:\n" +
                            "\nID: " + prod.id +
                            "\nNome: " + prod.nome +
                            "\nQuantidade" + prod.qtd_estoque +
                            "\nPreço: " + prod.preco,
                            "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var vResp = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
