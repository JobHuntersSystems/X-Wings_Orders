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
using System.Data.SqlClient;

namespace Routes
{
    public partial class frmRoutes : FormsDesigner.frmBase
    {
        RoutesEntities db;
        BindingSource bs;
        public frmRoutes(string tableName)
        {
            InitializeComponent();
            base._tableName = tableName;
            db = new RoutesEntities();
            bs = new BindingSource();
        }
        bool isNew = false;
        Color originalForeColor;

        List<Planets> plo, pld;
        List<RouteTypes> ty;

        #region Method
        private void GetData()
        {
            var query = from r in db.Routes
                        join p in db.Planets on r.idPlanetDest equals p.idPlanet
                        join p2 in db.Planets on r.idPlanetOr equals p2.idPlanet
                        join t in db.RouteTypes on r.idRouteType equals t.idRouteType
                        select new
                        {
                            Code = r.CodeRoute,
                            Description = r.DescRoute,

                            CodeType = t.CodeRouteType,
                            DescriptionType = t.DescRouteType,

                            CodeOrigin = p2.CodePlanet,
                            Origin = p2.DescPlanet,
                            PortOrigin = p2.PortPlanet,

                            CodeDestination = p.CodePlanet,
                            Destination = p.DescPlanet,
                            PortDestination = p.PortPlanet1,

                            idRoute = r.idRoute,
                            idRouteType = r.idRouteType,
                            idPlanetOr = r.idPlanetOr,
                            idPlanetDest = r.idPlanetDest,
                        };
            bs.DataSource = query.ToList();
            dgvBase.DataSource = bs;
        }
        private void CmbConfiguration()
        {
            plo = db.Planets.ToList();
            pld = db.Planets.ToList();
            ty = db.RouteTypes.ToList();

            cmbOrigin.DataSource = plo;
            cmbOrigin.DisplayMember = "CodePlanet";
            cmbOrigin.ValueMember = "idPlanet";

            cmbOrigin.DataBindings.Add("SelectedValue", bs, cmbOrigin.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);

            cmbDestination.DataSource = pld;
            cmbDestination.DisplayMember = "CodePlanet";
            cmbDestination.ValueMember = "idPlanet";

            cmbDestination.DataBindings.Add("SelectedValue", bs, cmbDestination.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);

            cmbType.DataSource = ty;
            cmbType.DisplayMember = "CodeRouteType";
            cmbType.ValueMember = "idRouteType";

            cmbType.DataBindings.Add("SelectedValue", bs, cmbType.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);
        }
        private void DgvConfiguration()
        {
            dgvBase.Columns["idRoute"].Visible = false;
            dgvBase.Columns["idRouteType"].Visible = false;
            dgvBase.Columns["idPlanetOr"].Visible = false;
            dgvBase.Columns["idPlanetDest"].Visible = false;
        }
        private void SetNormalMode()
        {
            btnCreate.Text = "Create";
            btnCreate.ForeColor = originalForeColor;

            Bind();
            isNew = false;
        }
        private void NoBind()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.DataBindings.Clear();
            }
        }
        private void Bind()
        {
            string tag;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.DataBindings.Clear();
                    tag = txt.Tag.ToString();

                    if (!tag.Contains("."))
                    {
                        txt.DataBindings.Add("Text", bs, tag, true, DataSourceUpdateMode.OnValidation);
                    }
                }
            }
        }
        private void UpdateData()
        {
            bs.EndEdit();
            if (isNew)
            {
                CreateRegister();
                SetNormalMode();
            }
            else
            {
                int row = (int)dgvBase.CurrentRow.Cells["idRoute"].Value;
                var route = db.Routes.Single(x => x.idRoute == row);

                route.CodeRoute = txtCodeRuta.Text;
                route.DescRoute = txtDesc.Text;
                route.idPlanetOr = (int)cmbOrigin.SelectedValue;
                route.idPlanetDest = (int)cmbDestination.SelectedValue;
                route.idRouteType = (int)cmbType.SelectedValue;
            }            
            db.SaveChanges();
            GetData();
        }
        private void CreateRegister()
        {
            Routes r = new Routes
            {
                CodeRoute = txtCodeRuta.Text,
                DescRoute = txtDesc.Text,
                idPlanetOr = (int)cmbOrigin.SelectedValue,
                idPlanetDest = (int)cmbDestination.SelectedValue,
                idRouteType = (int)cmbType.SelectedValue
            };
            db.Routes.Add(r);
        }

        #endregion

        #region event
        private void frmRoutes_Load(object sender, EventArgs e)
        {
            try
            {
                GetData();
                CmbConfiguration();
                DgvConfiguration();
                Bind();
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
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOriginPlanet.DataBindings.Clear();
            txtOriginPlanet.DataBindings.Add("Text", cmbOrigin, "SelectedItem" + txtOriginPlanet.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);

            txtOriginPort.DataBindings.Clear();
            txtOriginPort.DataBindings.Add("Text", cmbOrigin, "SelectedItem" + txtOriginPort.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDestinationPlanet.DataBindings.Clear();
            txtDestinationPlanet.DataBindings.Add("Text", cmbDestination, "SelectedItem" + txtDestinationPlanet.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);

            txtDestinationPort.DataBindings.Clear();
            txtDestinationPort.DataBindings.Add("Text", cmbDestination, "SelectedItem" + txtDestinationPort.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtType.DataBindings.Clear();
            txtType.DataBindings.Add("Text", cmbType, "SelectedItem" + txtType.Tag.ToString(), true, DataSourceUpdateMode.OnValidation);
        }
 
        protected override void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int idDelete = (int)dgvBase.CurrentRow.Cells["idRoute"].Value;
            db.Routes.Remove(db.Routes.Find(idDelete));
            db.SaveChanges();
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
            catch (SqlException sql_ex)
            {
                MessageBox.Show(
                   $"SQL Server exception:\n{sql_ex.Message}",
                   "Error de conexión",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
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
                if (!isNew)
                {
                    isNew = true;
                    NoBind();
                    txtCodeRuta.Focus();

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
