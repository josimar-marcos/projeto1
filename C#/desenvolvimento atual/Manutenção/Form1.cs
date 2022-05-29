using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manutenção.Sistema;

namespace Manutenção
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)

            {
                this.Hide();
                notifyIcon1.Visible = true;

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show(); // abre o formulario
            this.WindowState = FormWindowState.Normal; // start o formulario como normal
            this.notifyIcon1.Visible = false; // deixa o icone invisivel "oculto"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PequenosReparos form2 = new PequenosReparos();
            form2.Show();
        }
    }
}
