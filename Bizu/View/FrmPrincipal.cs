using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bizu.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
                
        private void menuListarProgramasInstalados_Click(object sender, EventArgs e)
        {
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            var sb = new StringBuilder();

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        if (subkey.GetValue("DisplayName") != null)
                            sb.Append("Nome: " + subkey.GetValue("DisplayName") + "\nVersão: " + subkey.GetValue("DisplayVersion") + "\n\n");
                    }
                }
            }

            MessageBox.Show(sb.ToString());
        }

        private void menuVerificarProcessoExecussao_Click(object sender, EventArgs e)
        {
            var processos = Process.GetProcessesByName("notepad");

            if (processos.Length > 0)
                MessageBox.Show("O notepad tem " + processos.Length + " instância(s) em execução", "Atenção");
            else
                MessageBox.Show("O notepad não está em execução", "Atenção");
        }

        private void menuVerificaHorarioVerao_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.IsDaylightSavingTime())
                MessageBox.Show("Estamos no hoário de verão.");
            else
                MessageBox.Show("Não estamos no hoário de verão.");
        }

        private void exemplo1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i);
            }
        }

        public static IEnumerable<int> Power(int number, int exponent)
        {
            int counter = 0;
            int result = 1;
            while (counter++ < exponent)
            {
                result = result * number;
                yield return result;
            }
        }

        private void exemplo2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var pessoa = new Model.Pessoa();
            var mensagens = pessoa.Validar();

            foreach (var msg in mensagens)
            {
                Console.WriteLine(msg);
            }

            var numeros = pessoa.ObterNumeros();

            foreach (var num in numeros)
            {
                Console.Write(num);
            }
        }

        private void menuDownloadArquivo_Click(object sender, EventArgs e)
        {
            new Controller.Download().iniciarDownload();
        }

        private void menuSaqueBancario_Click(object sender, EventArgs e)
        {
            //if (txtValorSaque.Text.Trim().Length > 0)
            //{
            //    int valor;

            //    if (int.TryParse(txtValorSaque.Text, out valor))
            //        MessageBox.Show(new SaqueCedulas().Sacar(txtValorSaque.Text), "Saque");
            //    else
            //    {
            //        txtValorSaque.Text = "";
            //        txtValorSaque.Focus();
            //    }
            //}
            //else
            //    txtValorSaque.Focus();
        }

        private void menuRenomearArquivos_Click(object sender, EventArgs e)
        {
            new Controller.Arquivos();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}