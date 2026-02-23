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
            // --- Configuración General ---
            dgvBase.BorderStyle = BorderStyle.None;
            dgvBase.BackgroundColor = Color.FromArgb(30, 30, 30); 
            // --- Encabezados ---
            dgvBase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(90, 30, 30);
            dgvBase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBase.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvBase.ColumnHeadersHeight = 45; // Un poco más alto para darle presencia
            dgvBase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // --- Filas (Color base) ---
            dgvBase.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45); 
            dgvBase.DefaultCellStyle.ForeColor = Color.WhiteSmoke; 
            dgvBase.DefaultCellStyle.SelectionBackColor = Color.FromArgb(130, 45, 45);
            dgvBase.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBase.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dgvBase.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            // --- Alternancia de filas (Efecto intercalado) ---
            dgvBase.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);

            // --- Bordes ---
            dgvBase.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBase.GridColor = Color.FromArgb(65, 65, 65);

            // --- Ajuste de columnas y filas ---
            dgvBase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBase.RowTemplate.Height = 35; 
            dgvBase.RowHeadersVisible = true;
            dgvBase.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; 
            dgvBase.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvBase.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(130, 45, 45);
            dgvBase.RowHeadersWidth = 35;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _tableName;
            configurateDataGridView();
        }
    }

}
