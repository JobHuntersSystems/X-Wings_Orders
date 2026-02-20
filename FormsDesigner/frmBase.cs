using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDesigner
{
    public partial class frmBase : Form
    {
        protected string _tableName;
        public frmBase()
        {
            InitializeComponent();
            if (DesignMode) return;
            dgvBase.UserDeletingRow += new DataGridViewRowCancelEventHandler(dgv_UserDeletingRow);
        }
        protected virtual void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
        }

        private void configurateDataGridView()
        {
            // General
            dgvBase.BorderStyle = BorderStyle.None;
            dgvBase.BackgroundColor = Color.White;
            //dgvBase.EnableHeadersVisualStyles = false;
            //dgvBase.AllowUserToAddRows = false;
            //dgvBase.AllowUserToResizeRows = false;
            //dgvBase.RowHeadersVisible = false;

            // Encabezados
            dgvBase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dgvBase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBase.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvBase.ColumnHeadersHeight = 35;

            // Filas
            dgvBase.DefaultCellStyle.BackColor = Color.White;
            dgvBase.DefaultCellStyle.ForeColor = Color.Black;
            dgvBase.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 240, 255);
            dgvBase.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvBase.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Alternancia de filas
            dgvBase.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Bordes
            dgvBase.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Ajuste de columnas
            dgvBase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _tableName;
            configurateDataGridView();
        }
    }

}
