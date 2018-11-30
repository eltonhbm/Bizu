namespace Bizu.View
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuTestes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegedit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListarProgramasInstalados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerificarProcessoExecussao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataHora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerificaHorarioVerao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.yieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDownloadArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaqueBancario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRenomearArquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTestes});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(584, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu de opções";
            // 
            // menuTestes
            // 
            this.menuTestes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegedit,
            this.menuWindows,
            this.menuDataHora,
            this.menuCSharp,
            this.menuDownload,
            this.menuLogica,
            this.menuArquivos,
            this.toolStripSeparator1,
            this.menuSair});
            this.menuTestes.Name = "menuTestes";
            this.menuTestes.Size = new System.Drawing.Size(52, 20);
            this.menuTestes.Text = "Testes";
            // 
            // menuRegedit
            // 
            this.menuRegedit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuListarProgramasInstalados});
            this.menuRegedit.Name = "menuRegedit";
            this.menuRegedit.Size = new System.Drawing.Size(152, 22);
            this.menuRegedit.Text = "Regedit";
            // 
            // menuListarProgramasInstalados
            // 
            this.menuListarProgramasInstalados.Name = "menuListarProgramasInstalados";
            this.menuListarProgramasInstalados.Size = new System.Drawing.Size(218, 22);
            this.menuListarProgramasInstalados.Text = "Listar programas instalados";
            this.menuListarProgramasInstalados.Click += new System.EventHandler(this.menuListarProgramasInstalados_Click);
            // 
            // menuWindows
            // 
            this.menuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVerificarProcessoExecussao});
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(152, 22);
            this.menuWindows.Text = "Processos";
            // 
            // menuVerificarProcessoExecussao
            // 
            this.menuVerificarProcessoExecussao.Name = "menuVerificarProcessoExecussao";
            this.menuVerificarProcessoExecussao.Size = new System.Drawing.Size(243, 22);
            this.menuVerificarProcessoExecussao.Text = "Verificar processo em execussão";
            this.menuVerificarProcessoExecussao.Click += new System.EventHandler(this.menuVerificarProcessoExecussao_Click);
            // 
            // menuDataHora
            // 
            this.menuDataHora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVerificaHorarioVerao});
            this.menuDataHora.Name = "menuDataHora";
            this.menuDataHora.Size = new System.Drawing.Size(152, 22);
            this.menuDataHora.Text = "Data e hora";
            // 
            // menuVerificaHorarioVerao
            // 
            this.menuVerificaHorarioVerao.Name = "menuVerificaHorarioVerao";
            this.menuVerificaHorarioVerao.Size = new System.Drawing.Size(202, 22);
            this.menuVerificaHorarioVerao.Text = "Verifica horário de verão";
            this.menuVerificaHorarioVerao.Click += new System.EventHandler(this.menuVerificaHorarioVerao_Click);
            // 
            // menuCSharp
            // 
            this.menuCSharp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yieldToolStripMenuItem});
            this.menuCSharp.Name = "menuCSharp";
            this.menuCSharp.Size = new System.Drawing.Size(152, 22);
            this.menuCSharp.Text = "C#";
            // 
            // yieldToolStripMenuItem
            // 
            this.yieldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exemplo1ToolStripMenuItem,
            this.exemplo2ToolStripMenuItem});
            this.yieldToolStripMenuItem.Name = "yieldToolStripMenuItem";
            this.yieldToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yieldToolStripMenuItem.Text = "Yield";
            // 
            // exemplo1ToolStripMenuItem
            // 
            this.exemplo1ToolStripMenuItem.Name = "exemplo1ToolStripMenuItem";
            this.exemplo1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exemplo1ToolStripMenuItem.Text = "Exemplo 1";
            this.exemplo1ToolStripMenuItem.Click += new System.EventHandler(this.exemplo1ToolStripMenuItem_Click_1);
            // 
            // exemplo2ToolStripMenuItem
            // 
            this.exemplo2ToolStripMenuItem.Name = "exemplo2ToolStripMenuItem";
            this.exemplo2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exemplo2ToolStripMenuItem.Text = "Exemplo 2";
            this.exemplo2ToolStripMenuItem.Click += new System.EventHandler(this.exemplo2ToolStripMenuItem_Click_1);
            // 
            // menuDownload
            // 
            this.menuDownload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDownloadArquivo});
            this.menuDownload.Name = "menuDownload";
            this.menuDownload.Size = new System.Drawing.Size(152, 22);
            this.menuDownload.Text = "Download";
            // 
            // menuDownloadArquivo
            // 
            this.menuDownloadArquivo.Name = "menuDownloadArquivo";
            this.menuDownloadArquivo.Size = new System.Drawing.Size(187, 22);
            this.menuDownloadArquivo.Text = "Download de arquivo";
            this.menuDownloadArquivo.Click += new System.EventHandler(this.menuDownloadArquivo_Click);
            // 
            // menuLogica
            // 
            this.menuLogica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaqueBancario});
            this.menuLogica.Name = "menuLogica";
            this.menuLogica.Size = new System.Drawing.Size(152, 22);
            this.menuLogica.Text = "Lógica";
            // 
            // menuSaqueBancario
            // 
            this.menuSaqueBancario.Name = "menuSaqueBancario";
            this.menuSaqueBancario.Size = new System.Drawing.Size(155, 22);
            this.menuSaqueBancario.Text = "Saque bancário";
            this.menuSaqueBancario.Click += new System.EventHandler(this.menuSaqueBancario_Click);
            // 
            // menuArquivos
            // 
            this.menuArquivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRenomearArquivos});
            this.menuArquivos.Name = "menuArquivos";
            this.menuArquivos.Size = new System.Drawing.Size(152, 22);
            this.menuArquivos.Text = "Arquivos";
            // 
            // menuRenomearArquivos
            // 
            this.menuRenomearArquivos.Name = "menuRenomearArquivos";
            this.menuRenomearArquivos.Size = new System.Drawing.Size(176, 22);
            this.menuRenomearArquivos.Text = "Renomear arquivos";
            this.menuRenomearArquivos.Click += new System.EventHandler(this.menuRenomearArquivos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(152, 22);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bizu";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuTestes;
        private System.Windows.Forms.ToolStripMenuItem menuRegedit;
        private System.Windows.Forms.ToolStripMenuItem menuListarProgramasInstalados;
        private System.Windows.Forms.ToolStripMenuItem menuWindows;
        private System.Windows.Forms.ToolStripMenuItem menuVerificarProcessoExecussao;
        private System.Windows.Forms.ToolStripMenuItem menuDataHora;
        private System.Windows.Forms.ToolStripMenuItem menuVerificaHorarioVerao;
        private System.Windows.Forms.ToolStripMenuItem menuCSharp;
        private System.Windows.Forms.ToolStripMenuItem yieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDownload;
        private System.Windows.Forms.ToolStripMenuItem menuDownloadArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuLogica;
        private System.Windows.Forms.ToolStripMenuItem menuSaqueBancario;
        private System.Windows.Forms.ToolStripMenuItem menuArquivos;
        private System.Windows.Forms.ToolStripMenuItem menuRenomearArquivos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
    }
}