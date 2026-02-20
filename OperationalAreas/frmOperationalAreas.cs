using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OperationalAreas
{
    public partial class frmOperationalAreas : FormsDesigner.frmBase
    {
        OperationalAreasEntities db;
        List<OperationalAreas> oa;

        BindingSource bs;
        public frmOperationalAreas(string tableName)
        {
            InitializeComponent();
            base._tableName = tableName;
            db = new OperationalAreasEntities();
            bs = new BindingSource();
        }        

        bool isNew = false;
        Color originalForeColor;

        private void ReadData()
        {
            oa = db.OperationalAreas.ToList();

            bs.DataSource = oa;

            dgvBase.DataSource = bs;
            Bind();
        }

        private void dgvConfiguration()
        {
            dgvBase.Columns["idOperationalArea"].Visible = false;
            dgvBase.Columns["CodeOperationalArea"].HeaderText = "Code";
            dgvBase.Columns["DescOperationalArea"].HeaderText = "Description";
        }
        private void Bind()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.DataBindings.Clear();
                txt.Clear();
                txt.DataBindings.Add("Text", bs, txt.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);
            }
        }
        private void NoBind()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.DataBindings.Clear();
            }
        }

        private void dgvOperationalArea_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            var ent = e.Row.DataBoundItem as OperationalAreas;
            if (ent == null) return;

            DialogResult dr = MessageBox.Show("Are you sure?", "Confirmr", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                if (db.Entry(ent).State != EntityState.Added)
                {
                    db.Entry(ent).State = EntityState.Deleted;
                }
                db.SaveChanges();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmOperationalAreas_Load(object sender, EventArgs e)
        {
            try
            {
                ReadData();
                dgvConfiguration();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
                if (isNew && txtCode.Text.Trim().Length != 0)
                {
                    OperationalAreas opar = new OperationalAreas()
                    {
                        CodeOperationalArea = txtCode.Text,
                        DescOperationalArea = txtDesc.Text
                    };
                    db.OperationalAreas.Add(opar);
                }
                db.SaveChanges();

                lblLog.Visible = true;
                lblLog.Text = "Registers updated successfully";
                logsTimer.Start(); 

                ReadData();
                isNew = false;

                btnCreate.Text = "Create";
                btnCreate.ForeColor = originalForeColor;

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                lblLog.Visible = true;
                lblLog.Text = "Error:" + ex.Message;
                logsTimer.Start();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                isNew = true;
                NoBind();
                txtCode.Focus();

                originalForeColor = btnCreate.ForeColor;
                btnCreate.Text = "Cancel";
                btnCreate.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logsTimer_Tick(object sender, EventArgs e)
        {
            logsTimer.Stop();
            lblLog.Text = "";
            lblLog.Visible = false;
            logsTimer.Dispose();
        }
    }
}
