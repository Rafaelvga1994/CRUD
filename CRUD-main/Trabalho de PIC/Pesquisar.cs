using BLL;
using DAL;
using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_PIC
{
    public partial class Pesquisar : Form
    {
        public int guardar = 0;

        public Pesquisar()
        {
            InitializeComponent();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                dados dc = new dados();
                conex cx = new conex(dc.ConectarX);
                buscar f = new buscar();

                BLLAnimal animal = new BLLAnimal(cx);
                MODELAnimal a = new MODELAnimal();
                a.Id = guardar;
                a.Proprietario = textBox1.Text;
                a.Animal = textBox2.Text;
                a.Telefone = maskedTextBox1.Text;
                a.DataConsulta = Convert.ToDateTime(maskedTextBox2.Text);
                a.Anaminese = textBox3.Text;
                a.Medicacao = textBox4.Text;

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    animal.Atualizar(a);
                    MessageBox.Show("Registro alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
            catch (MySqlException a)
            {
                MessageBox.Show("Falha ao conectar ao servidor: " + a.Message);
            }
            catch (Exception a)
            {
                MessageBox.Show("Falha ao alterar : " + a.Message);
            }
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    buscar f = new buscar();

                    dados dc = new dados();
                    conex cx = new conex(dc.ConectarX);

                    BLLAnimal animal = new BLLAnimal(cx);
                    animal.Deletar(guardar);
                    MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.Refresh();
                    this.Close();
                }
            }
            catch(MySqlException a)
            {
                MessageBox.Show("Não foi possivel se conectar ao servidor " + a.Message);
            }
            catch(Exception a)
            {
                MessageBox.Show("Erro: " + a.Message);
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {

        }
    }
}
