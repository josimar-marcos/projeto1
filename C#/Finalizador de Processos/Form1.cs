using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Finalizador_de_Processos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        // Função que recebe o paramentro do processo e finaliza *todos os processos com aquele nome
        public void finalizador(string processos)
        {
            string a = processos;
            Process[] processes = Process.GetProcessesByName(a);

            foreach (Process process in processes)
            {
                process.Kill();
            }

            return;
        }

        // processo de encerramento do google chrome 
        // chamando a função finalizador e repassando o nome do processo por parametro
        private void btnGoogle_Click(object sender, EventArgs e)
        {
            finalizador("chrome");
            MessageBox.Show("realizado e finalizado.\n google", @"/\*/\ Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        // processo de encerramento do conhost 
        // chamando a função finalizador e repassando o nome do processo por parametro
        private void btnConhost_Click(object sender, EventArgs e)
        {
            finalizador("conhost");
            MessageBox.Show("realizado e finalizado.\n conhost",".... Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // processo de encerramento do Linerar Service Manager 
        // chamando a função finalizador e repassando o nome do processo por parametro
        private void btnLSM_Click(object sender, EventArgs e)
        {
            finalizador("LinearServiceManager");
            MessageBox.Show("realizado e finalizado.\n LinearSerciceManager",".... Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnLinear_Click(object sender, EventArgs e)
        {
            finalizador("SGLinear");
            MessageBox.Show("realizado e finalizado.\n Linear", " Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finalizador("SIMPlus");
            MessageBox.Show("realizado e finalizado.\n Cameras de Seguraça - Intelbras", " Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOutlook_Click(object sender, EventArgs e)
        {
            finalizador("OUTLOOK");
            MessageBox.Show("realizado e finalizado.\n Outlook - Email", " Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            finalizador("EXCEL");
            MessageBox.Show("realizado e finalizado.\n Excel - Pacote Office", " Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
           // finalizador("WINWORD");
            finalizador("winword");
            MessageBox.Show("realizado e finalizado.\n Word -  Pacote Office", " Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            finalizador("msedge");
            MessageBox.Show("realizado e finalizado.\n Edge - NOVO Internet Explorer Microsoft", "Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnColetorVB_Click(object sender, EventArgs e)
        {
            finalizador("coletorVB");
            MessageBox.Show("realizado e finalizado.\n ColetorVB - Monitor", " Processo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEmidia_Click(object sender, EventArgs e)
        {
            finalizador("NLfrutas");
            MessageBox.Show("realizado e finalizado.\n Emidia- NLfrutas"," Processo Finalizado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
