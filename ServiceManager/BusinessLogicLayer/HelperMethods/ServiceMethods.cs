using Microsoft.PowerShell;
using ServiceManager.DataAccessLogic;
using ServiceManager.DatabaseConnections;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ServiceManager.Methods
{
    public class ServiceMethods
    {
        // Adds Service but does not start it.
        public void AddService(string serviceName, string servicePath)
        {
            if (serviceName.Trim() != "" && serviceName != "Service Name Here" && servicePath != "")
            {
                try
                {
                    PowerShell powerShell = PowerShell.Create();
                    powerShell.AddCommand("Set-Location")
                        .AddParameter("Path", servicePath)
                        .AddStatement()
                        .AddCommand("New-Service")
                        .AddParameter("Name", serviceName)
                        .AddParameter("BinaryPathName", serviceName + ".exe")
                        .Invoke();
                    MessageBox.Show($"Service Added. Go to manage tab to start or stop service.", "Service Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Adding Service - {ex.Message}", "Error - Service Starting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 
            else
            {
                MessageBox.Show("Error Adding Service - Service Name Or Folder Path Is NULL", "Error - Service Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void DeleteService(string serviceName, string servicePath) 
        {
            if (serviceName != "" && serviceName != "Service Name Here" && servicePath != "")
            {
                try
                {
                    PowerShell powerShell = PowerShell.Create();
                    powerShell.AddCommand("Remove-Service")
                        .AddParameter("Name", '"' + serviceName + '"')
                        .AddStatement()
                        .AddCommand("sc.exe delete" + '"' + serviceName + '"')
                        .Invoke();
                    MessageBox.Show($"Service Deleted.", "Service Deleted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Deleting Service - {ex.Message}", "Error - Service Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } 
            else
            {
                MessageBox.Show("Error Deleting Service - Service Name Or Folder Path Is NULL", "Error - Service Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void StartService()
        {

        }
        public void StopService()
        {

        }

        public void RestartService() 
        { 
        
        }
        public void AddServiceToServer()
        {
            ServicesProcedures servicesProcedures = new ServicesProcedures();
            servicesProcedures.SelectAllServices();
        }

        public void DeleteServiceFromServer()
        {

        }
    }
}
