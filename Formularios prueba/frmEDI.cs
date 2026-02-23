using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EdiProcessor;
using EF_CRUD;
using System.IO;
using CrystalReport;


namespace FormsEDI
{
    public partial class frmEDI : Form
    {
        EdiParser edi = new EdiParser();
        string path;

        List<int> ordersIDs = new List<int>();

        public frmEDI()
        {
            InitializeComponent();
            btnOpenCristal.Enabled = false;
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            string ftpPath = Path.Combine(Application.StartupPath, "FTP");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = ftpPath;
            openFileDialog.Filter = "Archivos edi (*.edi)|*.edi|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                txtPath.Text = rutaArchivo;
                lbStatus.Items.Add($"Status: Path selected [{rutaArchivo}]");
                path = rutaArchivo;
                btnOpenCristal.Enabled = true;
            }
            else
            {
                lbStatus.Items.Add("Status: Error, de file is not selected");
                btnOpenCristal.Enabled = false;
                txtPath.Clear();
            }
        }
        
        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                int orderid = edi.ReadEDI(path);
                ordersIDs.Add(orderid);
                lbStatus.Items.Add("Status: File readed and database updated");
                lbStatus.Items.Add($"Status: Order {orderid}");
            }
            catch (Exception a)
            {
                lbStatus.Items.Add($"Error: {a}");
            }
        }

        private void lbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStatus.SelectedItem != null)
            {
                textBox1.Text = lbStatus.SelectedItem.ToString();
            }
        }

        private void btnOpenCristal_Click(object sender, EventArgs e)
        {
            frmCrystalReport frm = new frmCrystalReport(ordersIDs);
            frm.Show();
        }
    }
}
