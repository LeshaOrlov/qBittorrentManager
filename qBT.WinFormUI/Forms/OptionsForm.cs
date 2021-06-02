using qBT.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class OptionsForm : Form
    {
        private Options options;
        private string fileOptionsPath = "options.json";
        public OptionsForm()
        {
            InitializeComponent();
            options = OptionsManager.GetOptions(fileOptionsPath);
            IPAddressTxt.Text = options.IPAddress;
            PortTxt.Text = options.Port.ToString();
            SleepTimeTxt.Text = options.SleepTime.ToString();
            UserNameTxt.Text = options.UserName;
            PasswordTxt.Text = options.Password;
            //OptionsFileTxt.Text = options.PathOptionsFile;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            options.IPAddress = IPAddressTxt.Text;
            options.Port = Int32.Parse(PortTxt.Text);
            options.SleepTime = Int32.Parse(SleepTimeTxt.Text);
            options.UserName = UserNameTxt.Text;
            options.Password = PasswordTxt.Text;
            //options.PathOptionsFile = OptionsFileTxt.Text;
            OptionsManager.SaveOptions(options, fileOptionsPath);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
