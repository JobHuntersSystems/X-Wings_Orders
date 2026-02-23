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

namespace Factories
{
    public partial class frmFactories : FormsDesigner.frmBase
    {
        FactoriesEntity ctx;
        BindingSource bsFactories;
        public frmFactories(string tableName)
        {
            InitializeComponent();
            base._tableName = tableName;
            ctx = new FactoriesEntity();
            bsFactories = new BindingSource();
        }


        bool isNew;
        Color originalForeColor;

        #region Methods
        private void loadData()
        {
            bsFactories.DataSource = ctx.Factories.ToList();
            dgvBase.DataSource = bsFactories;
        }
        private void bindControls()
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox txt = ((TextBox)ctrl);
                    txt.DataBindings.Clear();
                    txt.DataBindings.Add("Text", bsFactories, txt.Tag.ToString(), false, DataSourceUpdateMode.OnValidation);
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
            dgvBase.Columns["idFactory"].Visible = false;
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
            Factory f = new Factory
            {
                codeFactory = code,
                DescFactory = desc
            };
            ctx.Factories.Add(f);
        }
        private void updateData()
        {
            if (isNew)
            {
                createRegister();
                setNormalMode();
            }
            bsFactories.EndEdit();
            ctx.SaveChanges();
            loadData();
        }
        #endregion
        #region Events
        protected override void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var ent = e.Row.DataBoundItem as Factory;

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
            catch(SqlException sql_ex)
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
                lblLog.Text = "Error:"+ex.Message;
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

        private void logsTimer_Tick(object sender, EventArgs e)
        {
            logsTimer.Stop();
            lblLog.Text = "";
            lblLog.Visible = false;
            logsTimer.Dispose();
        }
    }
}
