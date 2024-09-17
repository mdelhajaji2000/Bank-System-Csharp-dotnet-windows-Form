using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.DivContact
{
    public partial class AboutProgrammerForm : Form
    {
        public AboutProgrammerForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/mdelhajaji2000/Bank-System-Csharp-dotnet-windows-Form") { UseShellExecute = true });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/mdelhajaji2000/Bank-System-Csharp-dotnet-windows-Form") { UseShellExecute = true });
        }
    }
}
