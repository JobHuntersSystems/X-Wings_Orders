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
    public partial class frmFiliations : FormsDesigner.frmBase
    {
        FiliationsEntities ctx;
        BindingSource bsFiliations;
        public frmFiliations(string tableName)
        {
            InitializeComponent();
            base._tableName = tableName;
            ctx = new FiliationsEntities();
            bsFiliations = new BindingSource();
        }


        bool isNew;
        Color originalForeColor;

        #region Methods
        private void loadData()
        {
            bsFiliations.DataSource = ctx.Filiations.ToList();
            dgvBase.DataSource = bsFiliations;
        }
        private void bindControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = ((TextBox)ctrl);
                    txt.DataBindings.Clear();
                    txt.DataBindings.Add("Text", bsFiliations, txt.Tag.ToString(), false, DataSourceUpdateMode.OnValidation);
                }
            }
        }
        private void unbindControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = ((TextBox)ctrl);
                    txt.DataBindings.Clear();
                    txt.Text = "";
                }
            }
        }
        private void configurateDataGridView()
        {
            dgvBase.Columns["idFiliation"].Visible = false;
        }
        private void setNormalMode()
        {
            btnCreate.Text = "Create";
            btnCreate.ForeColor = originalForeColor;

            bindControls();
            isNew = false;
        }
        private void createRegister()
        {
            string code = txtCode.Text;
            string desc = txtDesc.Text;

            if (string.IsNullOrWhiteSpace(code))
            {
                throw new Exception("The code can't be null");
            }
            Filiations f = new Filiations
            {
                CodeFiliation = code,
                DescFiliations = desc
            };
            ctx.Filiations.Add(f);
        }
        private void updateData()
        {
            if (isNew)
            {
                createRegister();
                setNormalMode();
            }
            bsFiliations.EndEdit();
            ctx.SaveChanges();
            loadData();
        }
        #endregion
        #region Events
        protected override void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var ent = e.Row.DataBoundItem as Filiations;

            if (ent == null)
                return;

            if (ctx.Entry(ent).State != EntityState.Added)
            {
                ctx.Entry(ent).State = EntityState.Deleted;
            }
        }
        private void frmFactories_Load(object sender, EventArgs e)
        {
            isNew = false;
            try
            {
                loadData();
                bindControls();
                configurateDataGridView();
            }
            catch (SqlException sql_ex)
            {
                MessageBox.Show(
                   $"SQL Server exception:\n{sql_ex.Message}",
                   "Error de conexión",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Generic exception:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                updateData();
                lblLog.Visible = true;
                lblLog.Text = "Registers updated successfully";
                logsTimer.Start();

            }
            catch (SqlException sql_ex)
            {
                MessageBox.Show(
                   $"SQL Server exception:\n{sql_ex.Message}",
                   "Error de conexión",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );

            }
            catch (Exception ex)
            {
                lblLog.Visible = true;
                lblLog.Text = "Error:" + ex.Message;
                logsTimer.Start();
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                originalForeColor = btnCreate.ForeColor;
                btnCreate.Text = "Cancel";
                btnCreate.ForeColor = Color.Red;

                unbindControls();
                isNew = true;
            }
            else
            {
                setNormalMode();
            }
        }
        #endregion


        private void logsTimer_Tick_1(object sender, EventArgs e)
        {
            logsTimer.Stop();
            lblLog.Text = "";
            lblLog.Visible = false;
            logsTimer.Dispose();
        }
    }
}
