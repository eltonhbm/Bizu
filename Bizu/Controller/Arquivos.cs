using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Controller
{
    public class Arquivos
    {
        private void Selecionar(object sender, EventArgs e)
        {
            //var fbd = new FolderBrowserDialog();
            //fbd.Description = "Selecione a pasta onde está os arquivos para serem renomeados:";
            //fbd.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            //fbd.ShowNewFolderButton = false;

            //if (fbd.ShowDialog() == DialogResult.OK)
            //    txtLocalArquivos.Text = fbd.SelectedPath;
        }

        private void Renomear()
        {
            //if (!string.IsNullOrWhiteSpace(txtLocalArquivos.Text) && Directory.Exists(txtLocalArquivos.Text))
            //{
            //    DirectoryInfo dir = new DirectoryInfo(txtLocalArquivos.Text);
            //    FileInfo[] arqs = dir.GetFiles();

            //    pgRenomear.Step = 0;
            //    pgRenomear.Maximum = arqs.Length;

            //    foreach (FileInfo arq in arqs)
            //    {
            //        File.Copy(arq.FullName, arq.FullName.Replace(txtNomeRemover.Text, "").TrimStart().TrimEnd());
            //        File.Delete(arq.FullName);
            //        pgRenomear.Value = pgRenomear.Step++;
            //        pgRenomear.Refresh();
            //    }

            //    pgRenomear.Step = 0;
            //}
            //else
            //    txtLocalArquivos.Focus();
        }
    }
}