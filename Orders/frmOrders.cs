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

namespace Orders
{
    public partial class frmOrders : FormsDesigner.frmBase
    {
        OrdersEntity ctx;
        BindingSource bsOrders;
        public frmOrders(string tableNamer)
        {
            InitializeComponent();
            base._tableName = tableNamer;

            ctx = new OrdersEntity();
            bsOrders = new BindingSource();
        }
        bool isNew;
        Color originalForeColor;
        #region Method
        private void loadData()
        {
            bsOrders.DataSource = ctx.Orders.ToList();
            dgvBase.DataSource = bsOrders;
        }
        private void LoadComboBox(ComboBox cmb, string table)
        {
            string tag = cmb.Tag.ToString();

            switch (table)
            {
                case "Factories":
                    cmb.DataSource = ctx.Factories.ToList();
                    cmb.DisplayMember = "codeFactory";
                    cmb.ValueMember = "idFactory";
                    break;

                case "Priority":
                    cmb.DataSource = ctx.Priorities.ToList();
                    cmb.DisplayMember = "codePriority";
                    cmb.ValueMember = "idPriority";
                    break;

                default:
                    cmb.DataSource = null;
                    break;
            }
        }

        private void bindControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && !((TextBox)ctrl).Tag.ToString().Contains("."))
                {
                    TextBox txt = ((TextBox)ctrl);
                    txt.DataBindings.Clear();
                    txt.DataBindings.Add("Text", bsOrders, txt.Tag.ToString(), false, DataSourceUpdateMode.OnValidation);
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = ((ComboBox)ctrl);
                    string tag = cmb.Tag.ToString();
                    string dataMember = tag.Split('.')[1];
                    string fkTableName = tag.Split('.')[0];

                    cmb.DataBindings.Clear();

                    cmb.DataBindings.Add("SelectedValue", bsOrders, dataMember, false, DataSourceUpdateMode.OnValidation);

                    cmb.SelectedValueChanged -= new EventHandler(ComboBox_SetValue);
                    cmb.SelectedValueChanged += new EventHandler(ComboBox_SetValue);

                    LoadComboBox(cmb, fkTableName);
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
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = ((ComboBox)ctrl);
                    cmb.DataBindings.Clear();
                    cmb.SelectedIndex = -1;
                }
            }
        }
        private void configurateDataGridView()
        {
            //Ocultamos todos los IDs'
            dgvBase.Columns["idOrder"].Visible = false;
            dgvBase.Columns["idFactory"].Visible = false;
            dgvBase.Columns["idPriority"].Visible = false;
            dgvBase.Columns["Factory"].Visible = false;
            dgvBase.Columns["Priority"].Visible = false;
            //Renombramos los headers
            dgvBase.Columns["codeOrder"].HeaderText = "Order Code";
            dgvBase.Columns["dateOrder"].HeaderText = "Order Date";
            //Añadimos las columnas foraneas
            var columnFactory = new DataGridViewComboBoxColumn
            {
                HeaderText = "Factory",
                Name = "Factory",
                DataPropertyName = "idFactory",
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            columnFactory.DataSource = ctx.Factories.ToList();
            columnFactory.DisplayMember = "codeFactory";
            columnFactory.ValueMember = "idFactory";
            dgvBase.Columns.Add(columnFactory);

            var columnPriority = new DataGridViewComboBoxColumn
            {
                HeaderText = "Priority",
                Name = "Priority",
                DataPropertyName = "idPriority",
                DropDownWidth = 160,
                Width = 90,
                MaxDropDownItems = 3,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            columnPriority.DataSource = ctx.Priorities.ToList();
            columnPriority.DisplayMember = "CodePriority";
            columnPriority.ValueMember = "idPriority";
            dgvBase.Columns.Add(columnPriority);
        }
        private void setNormalMode()
        {
            btnCreate.Text = "Create";
            btnCreate.ForeColor = originalForeColor;

            bindControls();
            isNew = false;
        }
        private void logsTimer_Tick(object sender, EventArgs e)
        {
            logsTimer.Stop();
            lblLog.Text = "";
            lblLog.Visible = false;
            logsTimer.Dispose();
        }
        private void createRegister()
        {
            string codeOrder = txtCodeOrder.Text;
            DateTime dateOrder = Convert.ToDateTime(txtDateOrder.Text);
            short idPriority = Convert.ToInt16(cmbPriority.SelectedValue);
            short idFactory = Convert.ToInt16(cmbFactory.SelectedValue);

            Order o = new Order
            {
                codeOrder = codeOrder,
                dateOrder = dateOrder,
                IdPriority = idPriority,
                IdFactory = idFactory
            };
            ctx.Orders.Add(o);
        }
        private void updateData()
        {
            if (isNew)
            {
                createRegister();
                setNormalMode();
            }
            bsOrders.EndEdit();
            ctx.SaveChanges();
            loadData();
        }
        private string findValue(int id, string table)
        {
            string value = "";
            switch (table)
            {
                case "Factories":
                    var factory = from f in ctx.Factories
                              where f.idFactory == id
                              select f.DescFactory;
                    value = factory.First();
                    break;
                case "Priority":
                    var priority = from p in ctx.Priorities
                              where p.idPriority == id
                              select p.DescPriority;
                    value = priority.First();
                    break;
                default:
                    value = "Unkown";
                    break;
            }     
            return value;
        }
        #endregion
        #region Events
        private void ComboBox_SetValue(object sender, EventArgs e)
        {
            ComboBox cmb = ((ComboBox)sender);
            string name = cmb.Name;
            int selectedValue = 0;
            if(cmb.SelectedValue != null)
            {
                if (int.TryParse(cmb.SelectedValue.ToString(), out selectedValue) && selectedValue != 0)
                {
                    string tag = cmb.Tag.ToString();
                    string fkTableName = tag.Split('.')[0];

                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is TextBox && ((TextBox)ctrl).Tag.ToString().Contains(name))
                        {
                            TextBox txt = ((TextBox)ctrl);
                            string value = findValue(selectedValue, fkTableName);
                            txt.Text = value;
                        }
                    }
                }
            }
        }
        protected override void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var ent = e.Row.DataBoundItem as Order;

            if (ent == null)
                return;

            if (ctx.Entry(ent).State != EntityState.Added)
            {
                ctx.Entry(ent).State = EntityState.Deleted;
            }
        }
     
        private void frmOrders_Load(object sender, EventArgs e)
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
    }
    #endregion
}
