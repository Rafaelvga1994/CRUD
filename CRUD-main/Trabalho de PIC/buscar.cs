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
    public partial class buscar : Form
    {
        public MODELAnimal modelo = new MODELAnimal();
        public buscar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void DGVDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                modelo.Id = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value);
                modelo.Proprietario = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                modelo.Animal = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
                modelo.Telefone = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
                DateTime data = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[4].Value.ToString());
                modelo.Anaminese = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();
                modelo.Medicacao = DGVDados.Rows[e.RowIndex].Cells[6].Value.ToString();
               
                modelo.DataConsulta = data;
                
                
                     Pesquisar x = new Pesquisar();


            x.textBox1.Text = modelo.Proprietario;
            x.textBox2.Text = modelo.Animal;
            x.maskedTextBox1.Text = modelo.Telefone;
            x.maskedTextBox2.Text = Convert.ToString(modelo.DataConsulta);
            x.textBox3.Text = modelo.Anaminese;
            x.textBox4.Text = modelo.Medicacao;
            x.guardar = modelo.Id;

            x.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string opc = procuraBox.Text;
                dados dc = new dados();
                conex cx = new conex(dc.ConectarX);

                BLLAnimal animal = new BLLAnimal(cx);

                DataTable ta = animal.Procurar(textBox1.Text, opc);

                DGVDados.DataSource = ta;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao conectar ao servidor!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Selecione um campo para buscar!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void panelchildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panelchildForm_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
