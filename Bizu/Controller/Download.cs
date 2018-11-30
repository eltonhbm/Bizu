using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bizu.Controller
{
    public class Download
    {
        WebClient client = new WebClient();

        public void iniciarDownload()
        {
            if (System.IO.File.Exists(@"C:\Elton\SIGECOM_1.0.17.5.zip"))
                System.IO.File.Delete(@"C:\Elton\SIGECOM_1.0.17.5.zip");

            Thread thread = new Thread(() =>
            {
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://s3-sa-east-1.amazonaws.com/sigecom/2017/SIGECOM_1.0.17.5.zip"), @"C:\Elton\SIGECOM_1.0.17.5.zip");
            });
            thread.Start();
            //lblDownload.Text = "Preparando para baixar...";
            //btnDownload.Enabled = false;
            //this.Cursor = Cursors.AppStarting;
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //this.BeginInvoke((MethodInvoker)delegate
            //{
            //    double bytesIn = double.Parse(e.BytesReceived.ToString());
            //    double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            //    double percentage = bytesIn / totalBytes * 100;
            //    lblDownload.Text = "Baixado " + e.BytesReceived / 1024 + " KB de " + e.TotalBytesToReceive / 1024 + " KB";
            //    lblDownload.Refresh();
            //    lblPorcentagem.Text = e.ProgressPercentage + "%";
            //    lblPorcentagem.Refresh();
            //    pbDownload.Value = int.Parse(Math.Truncate(percentage).ToString());
            //    pbDownload.Refresh();
            //});
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                //this.BeginInvoke((MethodInvoker)delegate
                //{
                //    this.Cursor = Cursors.Default;
                //});
            }
        }
    }
}