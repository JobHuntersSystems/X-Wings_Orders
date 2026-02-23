using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FormSpaceShipTypes
{
    public partial class frmSpaceShipType : Form
    {
        SpaceShipEntitie context = new SpaceShipEntitie();
        BindingSource spaceShipSource;
        bool isNewMode = false;

        public frmSpaceShipType()
        {
            InitializeComponent();
        }

        #region basic operations

        private void LoadDataSource()
        {
            spaceShipSource = new BindingSource();
            spaceShipSource.DataSource = context.SpaceShipTypes.Include(n => n.Filiation).Include(n => n.SpaceShipCategory).ToList();
        }

        private void ConfigureDGV()
        {
            foreach (DataGridViewColumn columna in dvgSpaceShip.Columns)
            {
                if (columna.Name.ToLower().Contains("id"))
                {
                    columna.Visible = false;
                }
            }

            dvgSpaceShip.Columns["Filiation"].Visible = false;
            dvgSpaceShip.Columns["SpaceShipCategory"].Visible = false;
        }

        private void BindControls()
        {
            LoadDataSource();

            cbFilliations.DataSource = context.Filiations.ToList();
            cbFilliations.DisplayMember = "DescFiliations";
            cbFilliations.ValueMember = "idFiliation";

            cbSpaceShipCategory.DataSource = context.SpaceShipCategories.ToList();
            cbSpaceShipCategory.DisplayMember = "DescSpaceShipCategory";
            cbSpaceShipCategory.ValueMember = "idSpaceShipCategory";

            foreach (Control ctrl in this.pnlData.Controls)
            {
                if ((ctrl.Tag != null) && (ctrl is TextBox))
                {
                    ctrl.DataBindings.Add("Text", spaceShipSource, ctrl.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.DataBindings.Add("SelectedValue", spaceShipSource, ctrl.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);
                }
            }

            dvgSpaceShip.DataSource = spaceShipSource;
            ConfigureDGV();
        }

        private void ClearControls()
        {
            foreach (Control control in this.pnlData.Controls)
            {
                if (control is TextBox)
                {
                    control.DataBindings.Clear();
                }
                else if (control is ComboBox)
                {
                    control.DataBindings.Clear();
                }
            }
            dvgSpaceShip.DataSource = null;
        }

        private void SetNewMode()
        {
            isNewMode = true;
            foreach (Control control in this.pnlData.Controls)
            {
                if (control is TextBox)
                {
                    control.DataBindings.Clear();
                    control.Text = "";
                }
                else if (control is ComboBox)
                {
                    control.DataBindings.Clear();
                }
            }
            btnCreate.Enabled = false;
            btnUpdate.Text = "Confirm";
            btnDelete.Text = "Cancel";
            dvgSpaceShip.Enabled = false;
        }

        private void SetNormalMode()
        {
            isNewMode = false;
            ClearControls();
            BindControls();
            btnCreate.Enabled = true;
            btnUpdate.Text = "Save Changes";
            btnDelete.Text = "Delete";
            dvgSpaceShip.Enabled = true;
        }



        #endregion

        #region CRUD operations
        private void Update()
        {
            if (isNewMode)
            {
                string codeSpaceShipType;
                string descSpaceShipType;
                int idFiliation;
                int idSpaceShipCategory;


                idFiliation = int.Parse(cbFilliations.SelectedValue.ToString());
                idSpaceShipCategory = int.Parse(cbSpaceShipCategory.SelectedValue.ToString());
                codeSpaceShipType = txtcodeSpaceShipType.Text;
                descSpaceShipType = txtDescSpaceShipType.Text;

                SpaceShipType spaceShipType = new SpaceShipType()
                {
                    CodeSpaceShipType = codeSpaceShipType,
                    DescSpaceShipType = descSpaceShipType,
                    idFiliation = idFiliation,
                    idSpaceShipCategory = idSpaceShipCategory
                };

                context.SpaceShipTypes.Add(spaceShipType);
                context.SaveChanges();

                SetNormalMode();
            }
            else
            {
                spaceShipSource.EndEdit();
                context.SaveChanges();
                ClearControls();
                BindControls();
            }
        }

        private void DeleteCharacter()
        {
            if (isNewMode)
            {
                SetNormalMode();
            }
            else
            {
                var spaceShip = spaceShipSource.Current as SpaceShipType;
                if (spaceShip == null) return;
                context.SpaceShipTypes.Remove(spaceShip);
                spaceShipSource.RemoveCurrent();
            }
        }

        #endregion

        #region Events
        private void frmSpaceShipType_Load(object sender, EventArgs e)
        {
            BindControls();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SetNewMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCharacter();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
