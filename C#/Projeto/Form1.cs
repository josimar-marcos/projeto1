using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://minhanet.net.com.br/fatura-facil/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NovaGuia();
            linkLabel1.Text = "Acessando o site google";
            linkLabel1.Links.Add(0, 99, "http://www.google.com");
            //14 é a posição inicial da área clicável (link) e 9 é o comprimento
            txtUrl.Text = "https://www.google.com";
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {
            NovaGuia();
        }

        /*
         * Código do Método NovaGuia

           Aqui criamos uma nova guia e definimos uma instância da classe WebBrowser usando o método Navigate
           que carrega o documento no local especificado, no caso a url para página do Google.
       
         */
        private void NovaGuia()
        {
            TabPage tab = new TabPage();
            tab.Text = "Nova Guia";

            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);

            WebBrowser browser = new WebBrowser() { ScriptErrorsSuppressed = true };

            browser.Parent = tab;
            browser.Dock = DockStyle.Fill;
            browser.Navigate("https://www.google.com");

            txtUrl.Text = "https://www.google.com";

            browser.DocumentCompleted += Browser_DocumentCompleted;
        }

        /*  Código do evento DocumentCompleted

            O evento DocumentCompleted ocorre quando o controle termina de carregar um documento.
            O evento é disparado quando a página foi completamente carregada.
         
         */

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                tabControl1.SelectedTab.Text = browser.DocumentTitle;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            WebBrowser browser = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoForward)
                    browser.GoForward();
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void controlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            finalizador("conhost");
            MessageBox.Show("realizado e finalizado.\n conhost");

        }

        public static void finalizador(string processos)
        {
            string a = processos;
            Process[] processes = Process.GetProcessesByName(a);

            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private void linearServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finalizador("LinearServiceManager");
            MessageBox.Show("realizado e finalizado.\n LinearSerciceManager");
        }

        private void googleChromesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finalizador("google");
            MessageBox.Show("realizado e finalizado.\n google");
        }
    }
}
