using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TBDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_write_Click(object sender, EventArgs e)
        {
            TextWriter Writing = new StreamWriter("Test.txt");
            Writing.WriteLine("Hola mundo, soy Leo el Hacker y estoy aprendiendo duro");
            Writing.Close();

            StreamWriter add = File.AppendText("Test.txt");
            add.WriteLine("Nueva Linea, estudiar programación puede ser divertido");
            add.Close();

            MessageBox.Show("Test listo");
        }

        private void Btn_read_Click(object sender, EventArgs e)
        {
            TextReader Reading = new StreamReader("Test.txt");
            //MessageBox.Show(Reading.ReadLine());
            MessageBox.Show(Reading.ReadToEnd());
            Reading.Close();

        }        

        private void Btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Busca tu archivo";
                openFileDialog1.ShowDialog();
                string text = openFileDialog1.FileName;

                if (File.Exists(openFileDialog1.FileName))
                {

                    TextReader Reading = new StreamReader(text);
                    rxt_content.Text = Reading.ReadToEnd();
                    Reading.Close();
                }

                txt_direction.Text = text;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al abrir");
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textsave = File.CreateText(txt);
                        textsave.Write(rxt_content.Text);
                        textsave.Flush();
                        textsave.Close();

                        txt_direction.Text = txt;
                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textsave = File.CreateText(txt);
                        textsave.Write(rxt_content.Text);
                        textsave.Flush();
                        textsave.Close();

                        txt_direction.Text = txt;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar");
            }
        }
    }
}
