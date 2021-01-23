using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var pontoDoDia = DateTime.Now.ToLongDateString();
            var hora = DateTime.Now.ToLongTimeString();
            List<Ponto> list = new List<Ponto>();
            string pontos = pontoDoDia;

            list.Add(new Ponto(pontos, hora));

            string path = @"D:\Ponto\Registro.txt";
            try
            {
                using (StreamWriter escreve = File.AppendText(path))
                {
                    foreach (var data in list)
                    {
                        escreve.WriteLine(data.DataPonto + " " + data.Hora);
                    }

                }
            }
            catch (IOException e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
           // label3.Enabled = true;
            
        }
    }
}
