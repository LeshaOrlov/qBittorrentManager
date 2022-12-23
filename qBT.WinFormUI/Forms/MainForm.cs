using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using qBT.Core;

namespace FormsApp
{
    public partial class FormApp : Form
    {
        TorrentServerManager loop;
        
        //Task task;
        public FormApp()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;

            notifyIcon1.Icon = new Icon("Resourses/qBittorent.ico");
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            Options options = OptionsManager.GetOptions();
            loop = new TorrentServerManager(new qBitttorrentApi(options));
            loop.SetProcessList(new FileLoader("fileProcess.txt", new EmptyMessager()).Get());
            loop.Start();

            stopToolStripMenuItem.Enabled = true;
            runToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loop.Stop();
            Application.Exit();
        }

        private void FormApp_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopToolStripMenuItem.Enabled = true;
            runToolStripMenuItem.Enabled = false;
            loop.Stop();
            MessageBox.Show("Сервер запущен!");
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopToolStripMenuItem.Enabled = false;
            runToolStripMenuItem.Enabled = true;
            loop.Stop();
            MessageBox.Show("Сервер остановлен!");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form opForm = new OptionsForm();
            opForm.Show();
        }
    }
}
