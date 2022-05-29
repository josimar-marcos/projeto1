using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace conectar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = @"C:\NOVO\A";
            string output = @"C:\NOVO\B";

            copiaDiretorio(input, output);
        }
        

        public void copiaDiretorio(string input, string output)
        {


            if (!Directory.Exists(output))
            {
                Directory.CreateDirectory(output);
            }

            if (!string.IsNullOrEmpty(input))
            {
                string[] arquivos = Directory.GetFiles(input);
                foreach (string arquivo in arquivos)
                {
                    if (input == output)
                    {
                        MessageBox.Show("ok");
                    }
                    else
                    {
                        File.Copy(input + @"\" + Path.GetFileName(arquivo), output + @"\" + Path.GetFileName(arquivo));
                    }
                }
                string[] diretorios = Directory.GetDirectories(input);
                foreach (string diretorio in diretorios)
                {
                    copiaDiretorio(diretorio, output + @"\" + diretorio.Split(Convert.ToChar(@"\"))[diretorio.Split(Convert.ToChar(@"\")).Length - 1]);
                }
            } 

        }

    }
}
