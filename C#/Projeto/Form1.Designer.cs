namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnGuia = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleChromesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coletorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.linearServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Claro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(621, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "abrir google";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnGuia
            // 
            this.btnGuia.Location = new System.Drawing.Point(448, 46);
            this.btnGuia.Name = "btnGuia";
            this.btnGuia.Size = new System.Drawing.Size(75, 23);
            this.btnGuia.TabIndex = 2;
            this.btnGuia.Text = "novaguia";
            this.btnGuia.UseVisualStyleBackColor = true;
            this.btnGuia.Click += new System.EventHandler(this.btnGuia_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 49);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(338, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(367, 49);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 5;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(11, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 396);
            this.tabControl1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.processosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aToolStripMenuItem.Text = "Inicio";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizadoresToolStripMenuItem});
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.processosToolStripMenuItem.Text = "Processos";
            // 
            // finalizadoresToolStripMenuItem
            // 
            this.finalizadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleChromesToolStripMenuItem,
            this.controlerToolStripMenuItem,
            this.coletorToolStripMenuItem,
            this.linearServiceToolStripMenuItem});
            this.finalizadoresToolStripMenuItem.Name = "finalizadoresToolStripMenuItem";
            this.finalizadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finalizadoresToolStripMenuItem.Text = "Finalizadores";
            // 
            // googleChromesToolStripMenuItem
            // 
            this.googleChromesToolStripMenuItem.Name = "googleChromesToolStripMenuItem";
            this.googleChromesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.googleChromesToolStripMenuItem.Text = "Google Chromes";
            this.googleChromesToolStripMenuItem.Click += new System.EventHandler(this.googleChromesToolStripMenuItem_Click);
            // 
            // controlerToolStripMenuItem
            // 
            this.controlerToolStripMenuItem.Name = "controlerToolStripMenuItem";
            this.controlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.controlerToolStripMenuItem.Text = "Controler";
            this.controlerToolStripMenuItem.Click += new System.EventHandler(this.controlerToolStripMenuItem_Click);
            // 
            // coletorToolStripMenuItem
            // 
            this.coletorToolStripMenuItem.Name = "coletorToolStripMenuItem";
            this.coletorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coletorToolStripMenuItem.Text = "Coletor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // linearServiceToolStripMenuItem
            // 
            this.linearServiceToolStripMenuItem.Name = "linearServiceToolStripMenuItem";
            this.linearServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linearServiceToolStripMenuItem.Text = "Linear Service";
            this.linearServiceToolStripMenuItem.Click += new System.EventHandler(this.linearServiceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnGuia);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnGuia;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleChromesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coletorToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem linearServiceToolStripMenuItem;
    }
}

