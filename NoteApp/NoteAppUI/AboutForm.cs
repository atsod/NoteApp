using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mailto = "mailto:" + EmailLinkLabel.Text;
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = mailto,
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(psi);
        }

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/atsod/NoteApp",
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(psi);
        }
    }
}
