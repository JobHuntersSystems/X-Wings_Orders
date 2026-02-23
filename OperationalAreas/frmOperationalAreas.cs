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

        #region Methods
        private void ReadData()
        {
            bs.DataSource = db.OperationalAreas.ToList(); 
            dgvBase.DataSource = bs;
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
        private void SetNormalMode()
        {
            btnCreate.Text = "Create";
            btnCreate.ForeColor = originalForeColor;

            Bind();
            isNew = false;
        }
        private void CreateRegister()
        {
            if (txtCode.Text.Trim().Length != 0 && txtDesc.Text.Trim().Length != 0)
            {
                OperationalAreas opar = new OperationalAreas()
                {
                    CodeOperationalArea = txtCode.Text,
                    DescOperationalArea = txtDesc.Text
                };
                db.OperationalAreas.Add(opar);
            }
            else
            {
                throw new Exception("The code can't be null");
            }
        }
        private void UpdateData()
        {
            if (isNew)
            {
                CreateRegister();
                SetNormalMode();
            }
            bs.EndEdit();
            db.SaveChanges();
            ReadData();
        }
        #endregion

        #region events
        protected override void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var ent = e.Row.DataBoundItem as OperationalAreas;
            if (ent == null) return;

            if (db.Entry(ent).State != EntityState.Added)
            {
                db.Entry(ent).State = EntityState.Deleted;
            }
            db.SaveChanges();            
        }
          
        private void frmOperationalAreas_Load(object sender, EventArgs e)
        {
            try
            {
                ReadData();
                dgvConfiguration();
                Bind();
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
                UpdateData();

                lblLog.Visible = true;
                lblLog.Text = "Registers updated successfully";
                logsTimer.Start(); 
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                lblLog.Visible = true;
                lblLog.Text = "Error:" + ex.Message;
                logsTimer.Start();
            }
            catch(Exception ex)
            {
                lblLog.Visible = true;
                lblLog.Text = "the fields cannot be empty";
                logsTimer.Start();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isNew) 
                {
                    isNew = true;
                    NoBind();
                    txtCode.Focus();

                    originalForeColor = btnCreate.ForeColor;
                    btnCreate.Text = "Cancel";
                    btnCreate.ForeColor = Color.Red;
                }
                else 
                {
                    SetNormalMode();
                }
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
        }
        #endregion
    }
}
