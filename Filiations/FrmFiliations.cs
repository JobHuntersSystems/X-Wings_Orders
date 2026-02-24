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

namespace Filiations
{
	public partial class FrmFiliations : FormsDesigner.frmBase
	{

		FiliationsEntities db;
		BindingSource bs;

		bool isNew = false;
		Color originalForeColor;

		public FrmFiliations(string tableName)
		{
			InitializeComponent();
			base._tableName = tableName;
			db = new FiliationsEntities();
			bs = new BindingSource();
		}

        #region Methods

        private void ReadData()
        {
            bs.DataSource = db.Filiations.ToList();
            dgvBase.DataSource = bs;
        }

        private void dgvConfiguration()
        {
            dgvBase.Columns["idFiliation"].Visible = false;
            dgvBase.Columns["CodeFiliation"].HeaderText = "Code";
            dgvBase.Columns["DescFiliations"].HeaderText = "Description";
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
                Filiation fil = new Filiation()
                {
                    CodeFiliation = txtCode.Text,
                    DescFiliations = txtDesc.Text
                };

                db.Filiations.Add(fil);
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

		#region EVENTS

		protected override void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
            var ent = e.Row.DataBoundItem as Filiation;
            if (ent == null) return;

            if (db.Entry(ent).State != EntityState.Added)
            {
                db.Entry(ent).State = EntityState.Deleted;
            }

            db.SaveChanges();
        }

		private void FrmFiliations_Load(object sender, EventArgs e)
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
            try
            {
                UpdateData();

                lblLog.Visible = true;
                lblLog.Text = "Registers updated successfully";
                LogsTimer.Start();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                lblLog.Visible = true;
                lblLog.Text = "Error: " + ex.Message;
                LogsTimer.Start();
            }
            catch (Exception)
            {
                lblLog.Visible = true;
                lblLog.Text = "The fields cannot be empty";
                LogsTimer.Start();
            }
        }

		private void LogsTimer_Tick(object sender, EventArgs e)
		{
            LogsTimer.Stop();
            lblLog.Text = "";
            lblLog.Visible = false;
        }

		#endregion
	}
}
