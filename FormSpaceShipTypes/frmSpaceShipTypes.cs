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

namespace FormSpaceShipTypes
{
    public partial class frmSpaceShipTypes : FormsDesigner.frmBase
    {
        SpaceShipEntitie context;
        BindingSource spaceShipSource;

        bool isNew;
        Color originalForeColor;

        public frmSpaceShipTypes(string tableName)
        {
            InitializeComponent();
            base._tableName = tableName;
            context = new SpaceShipEntitie();
            spaceShipSource = new BindingSource();
        }

        #region Methods
        private void loadData()
        {
            spaceShipSource.DataSource = context.SpaceShipTypes.Include(n => n.Filiation).Include(n => n.SpaceShipCategory).ToList();
            dgvBase.DataSource = spaceShipSource;
        }

        private void configurateDataGridView()
        {
            foreach (DataGridViewColumn columna in dgvBase.Columns)
            {
                if (columna.Name.ToLower().Contains("id"))
                {
                    columna.Visible = false;
                }
            }

            if (dgvBase.Columns.Contains("Filiation"))
                dgvBase.Columns["Filiation"].Visible = false;

            if (dgvBase.Columns.Contains("SpaceShipCategory"))
                dgvBase.Columns["SpaceShipCategory"].Visible = false;
        }

        private void bindControls()
        {
            cbFilliations.DataSource = context.Filiations.ToList();
            cbFilliations.DisplayMember = "DescFiliations";
            cbFilliations.ValueMember = "idFiliation";

            cbSpaceShipCategory.DataSource = context.SpaceShipCategories.ToList();
            cbSpaceShipCategory.DisplayMember = "DescSpaceShipCategory";
            cbSpaceShipCategory.ValueMember = "idSpaceShipCategory";


            foreach (Control ctrl in this.Controls)
            {
                if ((ctrl.Tag != null) && (ctrl is TextBox))
                {
                    TextBox txt = ((TextBox)ctrl);
                    txt.DataBindings.Clear();

                    txt.DataBindings.Add("Text", spaceShipSource, txt.Tag.ToString(), true, DataSourceUpdateMode.OnPropertyChanged);
                }
                else if ((ctrl.Tag != null) && (ctrl is ComboBox))
                {
                    ComboBox cb = ((ComboBox)ctrl);
                    cb.DataBindings.Clear();
                    cb.DataBindings.Add("SelectedValue", spaceShipSource, cb.Tag.ToString(), true, DataSourceUpdateMode.OnPropertyChanged);
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
                else if (ctrl is ComboBox)
                {
                    ComboBox cb = ((ComboBox)ctrl);
                    cb.DataBindings.Clear();
                    cb.SelectedIndex = -1;
                }
            }
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
            if (cbFilliations.SelectedValue == null || cbSpaceShipCategory.SelectedValue == null)
            {
                throw new Exception("Please select a valid Filiation and SpaceShip Category.");
            }

            int idFiliation = int.Parse(cbFilliations.SelectedValue.ToString());
            int idSpaceShipCategory = int.Parse(cbSpaceShipCategory.SelectedValue.ToString());
            string codeSpaceShipType = txtcodeSpaceShipType.Text;
            string descSpaceShipType = txtDescSpaceShipType.Text;

            SpaceShipType spaceShipType = new SpaceShipType()
            {
                CodeSpaceShipType = codeSpaceShipType,
                DescSpaceShipType = descSpaceShipType,
                idFiliation = idFiliation,
                idSpaceShipCategory = idSpaceShipCategory
            };

            context.SpaceShipTypes.Add(spaceShipType);
        }

        private void updateData()
        {
            if (isNew)
            {
                createRegister();
                setNormalMode();
            }
            spaceShipSource.EndEdit();
            context.SaveChanges();
            loadData();
        }
        #endregion

        #region Events

        protected override void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var ent = e.Row.DataBoundItem as SpaceShipType;

            if (ent == null)
                return;

            if (context.Entry(ent).State != EntityState.Added)
            {
                context.Entry(ent).State = EntityState.Deleted;
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
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                lblLog.Visible = true;
                lblLog.Text = "Error: " + ex.Message;
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

        private void logsTimer_Tick(object sender, EventArgs e)
        {
            logsTimer.Stop();
            lblLog.Text = "";
            lblLog.Visible = false;
            logsTimer.Dispose();
        }

        private void frmSpaceShipTypes_Load(object sender, EventArgs e)
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
                    "Connection Error",
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
        #endregion
    }
}