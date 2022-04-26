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
    public partial class Ficha : Form
    {
        public Ficha()
        {
            InitializeComponent(); 
          
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                dados dc = new dados();
                conex cx = new conex(dc.ConectarX);

                BLLAnimal animal = new BLLAnimal(cx);

                MODELAnimal modeloanimal = new MODELAnimal();
                modeloanimal.Proprietario = textBox1.Text;
                modeloanimal.Animal = textBox2.Text;
                modeloanimal.Telefone = maskedTextBox1.Text;
                modeloanimal.DataConsulta = Convert.ToDateTime(maskedTextBox2.Text);
                modeloanimal.Anaminese = textBox3.Text;
                modeloanimal.Medicacao = textBox4.Text;

                animal.Incluir(modeloanimal);

                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
            catch (MySqlException a)
            {
                MessageBox.Show("Falha ao conectar ao servidor: " + a.Message);
            }
            catch (Exception a)
            {
                MessageBox.Show("Falha ao cadastrar : " + a.Message);
            }
        }

        public void limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
                    }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
