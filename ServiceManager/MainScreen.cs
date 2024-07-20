using ServiceManager.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServiceManager
{
    public partial class MainScreen : Form
    {
        // Instantiations
        ServiceMethods serviceMethods = new ServiceMethods();
        ServiceInfo serviceInfo = new ServiceInfo();

        //  Adjust the above to de-couple and make static if possible.

        public MainScreen()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            InputBox(sender, e);
            serviceMethods.AddService(ServiceName.Text, folderBrowserDialog.SelectedPath);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            InputBox(sender, e);
            serviceMethods.DeleteService(ServiceName.Text, folderBrowserDialog.SelectedPath);
        }

        private void InputBox(object sender, EventArgs e)
        {
            serviceInfo.ServiceName = ServiceName.Text;
        }

        private void ServiceNameClear_Click(object sender, EventArgs e)
        {
            if (this.ServiceName.Text == "Service Name Here...")
            {
                this.ServiceName.Clear();
                this.ServiceName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void Select_Folder_Location_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_HelpRequest(sender, e);
        }

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderBrowserTextBox.Text = folderBrowserDialog.SelectedPath;
                serviceInfo.ServiceFilePath = folderBrowserTextBox.Text;
            }
        }

        private void TestServerConnection_Click(object sender, EventArgs e)
        {
            serviceMethods.AddServiceToServer();
        }
    }
}
