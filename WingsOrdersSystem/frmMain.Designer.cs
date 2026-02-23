
namespace WingsOrdersSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRectangleTop = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pctSpace2 = new System.Windows.Forms.PictureBox();
            this.xwCloseButton = new XWInheritedControls.XWCloseButton();
            this.pctSpace3 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pctSpace1 = new System.Windows.Forms.PictureBox();
            this.pctTime = new System.Windows.Forms.PictureBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.xwLauchFrmSpaceshipsCategories = new XWUserControls.XWLauchForm();
            this.xwLauchFrmFilliations = new XWUserControls.XWLauchForm();
            this.xwLauchFrmOpeArea = new XWUserControls.XWLauchForm();
            this.xwLauchFrmEDI = new XWUserControls.XWLauchForm();
            this.xwLauchFrmRouts = new XWUserControls.XWLauchForm();
            this.xwLauchFrmOrders = new XWUserControls.XWLauchForm();
            this.xwLauchFrmFTP = new XWUserControls.XWLauchForm();
            this.xwLauchFrmFactories = new XWUserControls.XWLauchForm();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.xwLauchFrmSpaceshipsSpecies = new XWUserControls.XWLauchForm();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpace2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xwCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpace3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTime)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlMain.Controls.Add(this.pnlRectangleTop);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1585, 995);
            this.pnlMain.TabIndex = 12;
            // 
            // pnlRectangleTop
            // 
            this.pnlRectangleTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlRectangleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRectangleTop.Location = new System.Drawing.Point(0, 52);
            this.pnlRectangleTop.Name = "pnlRectangleTop";
            this.pnlRectangleTop.Size = new System.Drawing.Size(1585, 13);
            this.pnlRectangleTop.TabIndex = 14;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.pctSpace2);
            this.pnlTop.Controls.Add(this.xwCloseButton);
            this.pnlTop.Controls.Add(this.pctSpace3);
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Controls.Add(this.pctSpace1);
            this.pnlTop.Controls.Add(this.pctTime);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1585, 52);
            this.pnlTop.TabIndex = 13;
            // 
            // pctSpace2
            // 
            this.pctSpace2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSpace2.ImageLocation = "resources\\jpg\\space.jpg";
            this.pctSpace2.Location = new System.Drawing.Point(362, -84);
            this.pctSpace2.Name = "pctSpace2";
            this.pctSpace2.Size = new System.Drawing.Size(875, 231);
            this.pctSpace2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSpace2.TabIndex = 10;
            this.pctSpace2.TabStop = false;
            // 
            // xwCloseButton
            // 
            this.xwCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xwCloseButton.HoverIconPath = "resources/png/CloseButtonShiny.png";
            this.xwCloseButton.ImageLocation = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\resourc" +
    "es/png/CloseButton.png";
            this.xwCloseButton.Location = new System.Drawing.Point(1534, 5);
            this.xwCloseButton.MainIconPath = "resources/png/CloseButton.png";
            this.xwCloseButton.Name = "xwCloseButton";
            this.xwCloseButton.Size = new System.Drawing.Size(46, 41);
            this.xwCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xwCloseButton.TabIndex = 0;
            this.xwCloseButton.TabStop = false;
            // 
            // pctSpace3
            // 
            this.pctSpace3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSpace3.ImageLocation = "resources\\jpg\\space.jpg";
            this.pctSpace3.Location = new System.Drawing.Point(896, -27);
            this.pctSpace3.Name = "pctSpace3";
            this.pctSpace3.Size = new System.Drawing.Size(690, 231);
            this.pctSpace3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSpace3.TabIndex = 9;
            this.pctSpace3.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTime.Location = new System.Drawing.Point(91, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 49);
            this.lblTime.TabIndex = 6;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctSpace1
            // 
            this.pctSpace1.ImageLocation = "resources\\jpg\\space.jpg";
            this.pctSpace1.Location = new System.Drawing.Point(82, -27);
            this.pctSpace1.Name = "pctSpace1";
            this.pctSpace1.Size = new System.Drawing.Size(715, 229);
            this.pctSpace1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSpace1.TabIndex = 8;
            this.pctSpace1.TabStop = false;
            // 
            // pctTime
            // 
            this.pctTime.ImageLocation = "resources\\gifs\\Robot.gif";
            this.pctTime.Location = new System.Drawing.Point(0, -8);
            this.pctTime.Name = "pctTime";
            this.pctTime.Size = new System.Drawing.Size(76, 70);
            this.pctTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTime.TabIndex = 7;
            this.pctTime.TabStop = false;
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlControls.Controls.Add(this.xwLauchFrmSpaceshipsSpecies);
            this.pnlControls.Controls.Add(this.xwLauchFrmSpaceshipsCategories);
            this.pnlControls.Controls.Add(this.xwLauchFrmFilliations);
            this.pnlControls.Controls.Add(this.xwLauchFrmOpeArea);
            this.pnlControls.Controls.Add(this.xwLauchFrmEDI);
            this.pnlControls.Controls.Add(this.xwLauchFrmRouts);
            this.pnlControls.Controls.Add(this.xwLauchFrmOrders);
            this.pnlControls.Controls.Add(this.xwLauchFrmFTP);
            this.pnlControls.Controls.Add(this.xwLauchFrmFactories);
            this.pnlControls.Location = new System.Drawing.Point(168, 153);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1248, 746);
            this.pnlControls.TabIndex = 12;
            // 
            // xwLauchFrmSpaceshipsCategories
            // 
            this.xwLauchFrmSpaceshipsCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmSpaceshipsCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmSpaceshipsCategories.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmSpaceshipsCategories.HoverBackColor = "23;23;23";
            this.xwLauchFrmSpaceshipsCategories.HoverFontColor = "233;233;233";
            this.xwLauchFrmSpaceshipsCategories.HoverImagePath = "resources\\png\\rocket_launch.png";
            this.xwLauchFrmSpaceshipsCategories.InitialImagePath = "resources\\png\\rocket.png";
            this.xwLauchFrmSpaceshipsCategories.Location = new System.Drawing.Point(1014, 17);
            this.xwLauchFrmSpaceshipsCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmSpaceshipsCategories.Name = "xwLauchFrmSpaceshipsCategories";
            this.xwLauchFrmSpaceshipsCategories.Size = new System.Drawing.Size(230, 225);
            this.xwLauchFrmSpaceshipsCategories.TabIndex = 10;
            this.xwLauchFrmSpaceshipsCategories.Title = "Spaceships Categories";
            this.xwLauchFrmSpaceshipsCategories.ButtonClick += new System.EventHandler(this.xwLauchFrmSpaceshipsCategories_ButtonClick);
            // 
            // xwLauchFrmFilliations
            // 
            this.xwLauchFrmFilliations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmFilliations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmFilliations.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmFilliations.HoverBackColor = "23;23;23";
            this.xwLauchFrmFilliations.HoverFontColor = "233;233;233";
            this.xwLauchFrmFilliations.HoverImagePath = "resources\\png\\darth_vader_hover.png";
            this.xwLauchFrmFilliations.InitialImagePath = "resources\\png\\darth_vader.png";
            this.xwLauchFrmFilliations.Location = new System.Drawing.Point(765, 17);
            this.xwLauchFrmFilliations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmFilliations.Name = "xwLauchFrmFilliations";
            this.xwLauchFrmFilliations.Size = new System.Drawing.Size(225, 225);
            this.xwLauchFrmFilliations.TabIndex = 9;
            this.xwLauchFrmFilliations.Title = "Filliations";
            // 
            // xwLauchFrmOpeArea
            // 
            this.xwLauchFrmOpeArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmOpeArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmOpeArea.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmOpeArea.HoverBackColor = "23;23;23";
            this.xwLauchFrmOpeArea.HoverFontColor = "233;233;233";
            this.xwLauchFrmOpeArea.HoverImagePath = "resources\\png\\Settings.png";
            this.xwLauchFrmOpeArea.InitialImagePath = "resources\\png\\Settings.png";
            this.xwLauchFrmOpeArea.Location = new System.Drawing.Point(253, 17);
            this.xwLauchFrmOpeArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmOpeArea.Name = "xwLauchFrmOpeArea";
            this.xwLauchFrmOpeArea.Size = new System.Drawing.Size(225, 225);
            this.xwLauchFrmOpeArea.TabIndex = 6;
            this.xwLauchFrmOpeArea.Title = "Operational Area";
            this.xwLauchFrmOpeArea.ButtonClick += new System.EventHandler(this.xwLauchFrmOpeArea_ButtonClick);
            // 
            // xwLauchFrmEDI
            // 
            this.xwLauchFrmEDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmEDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmEDI.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmEDI.HoverBackColor = "23;23;23";
            this.xwLauchFrmEDI.HoverFontColor = "233;233;233";
            this.xwLauchFrmEDI.HoverImagePath = "resources\\png\\shield_police.png";
            this.xwLauchFrmEDI.InitialImagePath = "resources\\png\\shield_alert.png";
            this.xwLauchFrmEDI.Location = new System.Drawing.Point(764, 266);
            this.xwLauchFrmEDI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmEDI.Name = "xwLauchFrmEDI";
            this.xwLauchFrmEDI.Size = new System.Drawing.Size(479, 225);
            this.xwLauchFrmEDI.TabIndex = 4;
            this.xwLauchFrmEDI.Title = "EDI Processor";
            // 
            // xwLauchFrmRouts
            // 
            this.xwLauchFrmRouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmRouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmRouts.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmRouts.HoverBackColor = "23;23;23";
            this.xwLauchFrmRouts.HoverFontColor = "233;233;233";
            this.xwLauchFrmRouts.HoverImagePath = "resources\\png\\star.png";
            this.xwLauchFrmRouts.InitialImagePath = "resources\\png\\star_shine.png";
            this.xwLauchFrmRouts.Location = new System.Drawing.Point(509, 17);
            this.xwLauchFrmRouts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmRouts.Name = "xwLauchFrmRouts";
            this.xwLauchFrmRouts.Size = new System.Drawing.Size(225, 225);
            this.xwLauchFrmRouts.TabIndex = 3;
            this.xwLauchFrmRouts.Title = "Rutas";
            this.xwLauchFrmRouts.ButtonClick += new System.EventHandler(this.xwLauchFrmRouts_ButtonClick);
            // 
            // xwLauchFrmOrders
            // 
            this.xwLauchFrmOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmOrders.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmOrders.HoverBackColor = "23;23;23";
            this.xwLauchFrmOrders.HoverFontColor = "233;233;233";
            this.xwLauchFrmOrders.HoverImagePath = "resources\\png\\death_star.png";
            this.xwLauchFrmOrders.InitialImagePath = "resources\\png\\death_star_hover.png";
            this.xwLauchFrmOrders.Location = new System.Drawing.Point(508, 266);
            this.xwLauchFrmOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmOrders.Name = "xwLauchFrmOrders";
            this.xwLauchFrmOrders.Size = new System.Drawing.Size(225, 225);
            this.xwLauchFrmOrders.TabIndex = 2;
            this.xwLauchFrmOrders.Title = "Orders";
            this.xwLauchFrmOrders.ButtonClick += new System.EventHandler(this.xwLauchFrmOrders_ButtonClick);
            // 
            // xwLauchFrmFTP
            // 
            this.xwLauchFrmFTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmFTP.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmFTP.HoverBackColor = "23;23;23";
            this.xwLauchFrmFTP.HoverFontColor = "233;233;233";
            this.xwLauchFrmFTP.HoverImagePath = "resources\\png\\planet_earth.png";
            this.xwLauchFrmFTP.InitialImagePath = "resources\\png\\planet_search.png";
            this.xwLauchFrmFTP.Location = new System.Drawing.Point(3, 266);
            this.xwLauchFrmFTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmFTP.Name = "xwLauchFrmFTP";
            this.xwLauchFrmFTP.Size = new System.Drawing.Size(474, 225);
            this.xwLauchFrmFTP.TabIndex = 1;
            this.xwLauchFrmFTP.Title = "FTP Server";
            // 
            // xwLauchFrmFactories
            // 
            this.xwLauchFrmFactories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmFactories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmFactories.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmFactories.HoverBackColor = "23;23;23";
            this.xwLauchFrmFactories.HoverFontColor = "233;233;233";
            this.xwLauchFrmFactories.HoverImagePath = "resources\\png\\charger.png";
            this.xwLauchFrmFactories.InitialImagePath = "resources\\png\\charger_electric.png";
            this.xwLauchFrmFactories.Location = new System.Drawing.Point(4, 17);
            this.xwLauchFrmFactories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmFactories.Name = "xwLauchFrmFactories";
            this.xwLauchFrmFactories.Size = new System.Drawing.Size(225, 225);
            this.xwLauchFrmFactories.TabIndex = 0;
            this.xwLauchFrmFactories.Title = "Factories";
            this.xwLauchFrmFactories.ButtonClick += new System.EventHandler(this.xwLauchFrmFactories_ButtonClick);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // xwLauchFrmSpaceshipsSpecies
            // 
            this.xwLauchFrmSpaceshipsSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xwLauchFrmSpaceshipsSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwLauchFrmSpaceshipsSpecies.ForeColor = System.Drawing.Color.White;
            this.xwLauchFrmSpaceshipsSpecies.HoverBackColor = "23;23;23";
            this.xwLauchFrmSpaceshipsSpecies.HoverFontColor = "233;233;233";
            this.xwLauchFrmSpaceshipsSpecies.HoverImagePath = "resources\\png\\sith.png";
            this.xwLauchFrmSpaceshipsSpecies.InitialImagePath = "resources\\png\\sith.png";
            this.xwLauchFrmSpaceshipsSpecies.Location = new System.Drawing.Point(508, 517);
            this.xwLauchFrmSpaceshipsSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xwLauchFrmSpaceshipsSpecies.Name = "xwLauchFrmSpaceshipsSpecies";
            this.xwLauchFrmSpaceshipsSpecies.Size = new System.Drawing.Size(225, 225);
            this.xwLauchFrmSpaceshipsSpecies.TabIndex = 11;
            this.xwLauchFrmSpaceshipsSpecies.Title = "Spaceships Species";
            this.xwLauchFrmSpaceshipsSpecies.ButtonClick += new System.EventHandler(this.xwLauchFrmSpaceshipsSpecies_ButtonClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 995);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSpace2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xwCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpace3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTime)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XWUserControls.XWLauchForm xwLauchFrmFactories;
        private XWUserControls.XWLauchForm xwLauchFrmFTP;
        private XWUserControls.XWLauchForm xwLauchFrmOrders;
        private XWUserControls.XWLauchForm xwLauchFrmRouts;
        private XWUserControls.XWLauchForm xwLauchFrmEDI;
        private XWUserControls.XWLauchForm xwLauchFrmOpeArea;
        private XWUserControls.XWLauchForm xwLauchFrmFilliations;
        private XWUserControls.XWLauchForm xwLauchFrmSpaceshipsCategories;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlTop;
        private XWInheritedControls.XWCloseButton xwCloseButton;
        private System.Windows.Forms.Panel pnlRectangleTop;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pctTime;
        private System.Windows.Forms.PictureBox pctSpace1;
        private System.Windows.Forms.PictureBox pctSpace3;
        private System.Windows.Forms.PictureBox pctSpace2;
        private XWUserControls.XWLauchForm xwLauchFrmSpaceshipsSpecies;
    }
}

