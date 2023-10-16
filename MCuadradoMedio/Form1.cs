using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCuadradoMedio.Algoritmos;


namespace MCuadradoMedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Semillas", "N");
            dataGridView1.Columns.Add("Semillas", "R(n)");
            dataGridView1.Columns.Add("Cuadrados", "R(n)^2");
            dataGridView1.Columns.Add("Valor1", "Valor 1");
            dataGridView1.Columns.Add("Valor2", "Valor 2");
        }


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int semilla) && semilla >= 100 && semilla <= 999)
            {
                AlgoritmoGenerador generador = new AlgoritmoGenerador();
                List<Tuple<int, int, int, double, double>> resultados = generador.MetodoCuadradosMedios(semilla);

                dataGridView1.Rows.Clear();
                foreach (Tuple<int, int, int, double, double> resultado in resultados)
                {
                    dataGridView1.Rows.Add(resultado.Item1.ToString(), resultado.Item2.ToString(), resultado.Item3.ToString(), resultado.Item4.ToString(), resultado.Item5.ToString());
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una semilla de 3 dígitos.");
            }
        }
    }
}