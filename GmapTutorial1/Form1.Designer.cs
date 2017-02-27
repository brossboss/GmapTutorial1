namespace GmapTutorial1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btnGoto = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBoxLat = new System.Windows.Forms.ComboBox();
            this.cmbMapProvider2 = new System.Windows.Forms.ComboBox();
            this.txtBoxLon = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbMapProvider = new System.Windows.Forms.ComboBox();
            this.btnProvider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMapProvider = new System.Windows.Forms.Button();
            this.txtBoxToolTip = new System.Windows.Forms.RichTextBox();
            this.txtBoxBorderSize = new System.Windows.Forms.TextBox();
            this.txtBoxNumBorderSize = new System.Windows.Forms.NumericUpDown();
            this.btnPolygons = new System.Windows.Forms.Button();
            this.btnLagos = new System.Windows.Forms.Button();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.btnShowGridLines = new System.Windows.Forms.Button();
            this.btnAddRoutes = new System.Windows.Forms.Button();
            this.btnseeAllMarkers = new System.Windows.Forms.Button();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblZoomValue = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnAddMultipleMarkers = new System.Windows.Forms.Button();
            this.btnClearMarkers = new System.Windows.Forms.Button();
            this.btnGetNumOfOverlay = new System.Windows.Forms.Button();
            this.lblNoOfOverlay = new System.Windows.Forms.Label();
            this.btnCreategridLines = new System.Windows.Forms.Button();
            this.lblLONG = new System.Windows.Forms.Label();
            this.lblLAT = new System.Windows.Forms.Label();
            this.radioBtnZoomOut = new System.Windows.Forms.RadioButton();
            this.radioBtnZoomIn = new System.Windows.Forms.RadioButton();
            this.lblGridRef = new System.Windows.Forms.Label();
            this.btnPrintMap = new System.Windows.Forms.Button();
            this.btnAutoRoute = new System.Windows.Forms.Button();
            this.cmbBoxMapType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNumBorderSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(217, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1081, 576);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 8D;
            this.gmap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseDoubleClick);
            this.gmap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapexplr_MouseMove);
            // 
            // btnGoto
            // 
            this.btnGoto.Location = new System.Drawing.Point(3, 84);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(204, 23);
            this.btnGoto.TabIndex = 2;
            this.btnGoto.Text = "Go To";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(49, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // txtBoxLat
            // 
            this.txtBoxLat.Location = new System.Drawing.Point(3, 31);
            this.txtBoxLat.Name = "txtBoxLat";
            this.txtBoxLat.Size = new System.Drawing.Size(121, 21);
            this.txtBoxLat.TabIndex = 0;
            // 
            // cmbMapProvider2
            // 
            this.cmbMapProvider2.Items.AddRange(new object[] {
            "BingMapProvider",
            "GoogleMapProvider",
            "GoogleSatelliteMapProvider",
            "ArcGIS_DarbAE_Q2_2011_NAVTQ_Eng_V5_MapProvider",
            "ArcGIS_ShadedRelief_World_2D_MapProvider",
            "ArcGIS_StreetMap_World_2D_MapProvider",
            "ArcGIS_Topo_US_2D_MapProvider",
            "ArcGIS_World_Physical_MapProvider",
            "ArcGIS_World_Topo_MapProvider"});
            this.cmbMapProvider2.Location = new System.Drawing.Point(12, 158);
            this.cmbMapProvider2.Name = "cmbMapProvider2";
            this.cmbMapProvider2.Size = new System.Drawing.Size(195, 21);
            this.cmbMapProvider2.TabIndex = 0;
            // 
            // txtBoxLon
            // 
            this.txtBoxLon.Location = new System.Drawing.Point(3, 4);
            this.txtBoxLon.Name = "txtBoxLon";
            this.txtBoxLon.Size = new System.Drawing.Size(121, 21);
            this.txtBoxLon.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // cmbMapProvider
            // 
            this.cmbMapProvider.FormattingEnabled = true;
            this.cmbMapProvider.Items.AddRange(new object[] {
            "GoogleMapProvider",
            "GoogleSatelliteMapProvider",
            "ArcGIS_DarbAE_Q2_2011_NAVTQ_Eng_V5_MapProvider",
            "ArcGIS_ShadedRelief_World_2D_MapProvider",
            "ArcGIS_StreetMap_World_2D_MapProvider",
            "ArcGIS_Topo_US_2D_MapProvider",
            "ArcGIS_World_Physical_MapProvider",
            "ArcGIS_World_Topo_MapProvider"});
            this.cmbMapProvider.Location = new System.Drawing.Point(0, 19);
            this.cmbMapProvider.Name = "cmbMapProvider";
            this.cmbMapProvider.Size = new System.Drawing.Size(172, 21);
            this.cmbMapProvider.TabIndex = 6;
            // 
            // btnProvider
            // 
            this.btnProvider.Location = new System.Drawing.Point(0, 46);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Size = new System.Drawing.Size(172, 23);
            this.btnProvider.TabIndex = 5;
            this.btnProvider.Text = "Map Provider";
            this.btnProvider.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "LON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "LAT";
            // 
            // btnMapProvider
            // 
            this.btnMapProvider.Location = new System.Drawing.Point(13, 186);
            this.btnMapProvider.Name = "btnMapProvider";
            this.btnMapProvider.Size = new System.Drawing.Size(194, 23);
            this.btnMapProvider.TabIndex = 3;
            this.btnMapProvider.Text = "Map provider";
            this.btnMapProvider.UseVisualStyleBackColor = true;
             // 
            // txtBoxToolTip
            // 
            this.txtBoxToolTip.Location = new System.Drawing.Point(130, 4);
            this.txtBoxToolTip.Name = "txtBoxToolTip";
            this.txtBoxToolTip.Size = new System.Drawing.Size(77, 74);
            this.txtBoxToolTip.TabIndex = 6;
            this.txtBoxToolTip.Text = "tool tip";
            // 
            // txtBoxBorderSize
            // 
            this.txtBoxBorderSize.Location = new System.Drawing.Point(3, 59);
            this.txtBoxBorderSize.Name = "txtBoxBorderSize";
            this.txtBoxBorderSize.Size = new System.Drawing.Size(121, 20);
            this.txtBoxBorderSize.TabIndex = 7;
            // 
            // txtBoxNumBorderSize
            // 
            this.txtBoxNumBorderSize.Location = new System.Drawing.Point(3, 114);
            this.txtBoxNumBorderSize.Name = "txtBoxNumBorderSize";
            this.txtBoxNumBorderSize.Size = new System.Drawing.Size(120, 20);
            this.txtBoxNumBorderSize.TabIndex = 8;
            // 
            // btnPolygons
            // 
            this.btnPolygons.Location = new System.Drawing.Point(17, 455);
            this.btnPolygons.Name = "btnPolygons";
            this.btnPolygons.Size = new System.Drawing.Size(194, 23);
            this.btnPolygons.TabIndex = 9;
            this.btnPolygons.Text = "Add Polygons";
            this.btnPolygons.UseVisualStyleBackColor = true;
            this.btnPolygons.Click += new System.EventHandler(this.btnPolygons_Click);
            // 
            // btnLagos
            // 
            this.btnLagos.Location = new System.Drawing.Point(12, 553);
            this.btnLagos.Name = "btnLagos";
            this.btnLagos.Size = new System.Drawing.Size(195, 23);
            this.btnLagos.TabIndex = 10;
            this.btnLagos.Text = "search";
            this.btnLagos.UseVisualStyleBackColor = true;
            this.btnLagos.Click += new System.EventHandler(this.btnLagos_Click);
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(11, 527);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(90, 20);
            this.txtBoxState.TabIndex = 11;
            // 
            // btnShowGridLines
            // 
            this.btnShowGridLines.Location = new System.Drawing.Point(38, 484);
            this.btnShowGridLines.Name = "btnShowGridLines";
            this.btnShowGridLines.Size = new System.Drawing.Size(173, 23);
            this.btnShowGridLines.TabIndex = 12;
            this.btnShowGridLines.Text = "Show GridLines";
            this.btnShowGridLines.UseVisualStyleBackColor = true;
            this.btnShowGridLines.Click += new System.EventHandler(this.btnShowGridLines_Click);
            // 
            // btnAddRoutes
            // 
            this.btnAddRoutes.Location = new System.Drawing.Point(13, 297);
            this.btnAddRoutes.Name = "btnAddRoutes";
            this.btnAddRoutes.Size = new System.Drawing.Size(198, 23);
            this.btnAddRoutes.TabIndex = 14;
            this.btnAddRoutes.Text = "create route";
            this.btnAddRoutes.UseVisualStyleBackColor = true;
            this.btnAddRoutes.Click += new System.EventHandler(this.btnAddPoints_Click);
            // 
            // btnseeAllMarkers
            // 
            this.btnseeAllMarkers.Location = new System.Drawing.Point(17, 327);
            this.btnseeAllMarkers.Name = "btnseeAllMarkers";
            this.btnseeAllMarkers.Size = new System.Drawing.Size(190, 23);
            this.btnseeAllMarkers.TabIndex = 15;
            this.btnseeAllMarkers.Text = "see all markers";
            this.btnseeAllMarkers.UseVisualStyleBackColor = true;
            this.btnseeAllMarkers.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(107, 527);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCountry.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "state";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Country";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "zoom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnZoom_Click_1);
            // 
            // lblZoomValue
            // 
            this.lblZoomValue.AutoSize = true;
            this.lblZoomValue.Location = new System.Drawing.Point(234, 200);
            this.lblZoomValue.Name = "lblZoomValue";
            this.lblZoomValue.Size = new System.Drawing.Size(19, 13);
            this.lblZoomValue.TabIndex = 19;
            this.lblZoomValue.Text = "....";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBar1.Location = new System.Drawing.Point(237, 216);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 221);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btnAddMultipleMarkers
            // 
            this.btnAddMultipleMarkers.Location = new System.Drawing.Point(17, 386);
            this.btnAddMultipleMarkers.Name = "btnAddMultipleMarkers";
            this.btnAddMultipleMarkers.Size = new System.Drawing.Size(181, 23);
            this.btnAddMultipleMarkers.TabIndex = 21;
            this.btnAddMultipleMarkers.Text = "add multiple markers";
            this.btnAddMultipleMarkers.UseVisualStyleBackColor = true;
            this.btnAddMultipleMarkers.Click += new System.EventHandler(this.btnAddMultipleMarkers_Click);
            // 
            // btnClearMarkers
            // 
            this.btnClearMarkers.Location = new System.Drawing.Point(17, 416);
            this.btnClearMarkers.Name = "btnClearMarkers";
            this.btnClearMarkers.Size = new System.Drawing.Size(190, 23);
            this.btnClearMarkers.TabIndex = 22;
            this.btnClearMarkers.Text = "clear markers";
            this.btnClearMarkers.UseVisualStyleBackColor = true;
            this.btnClearMarkers.Click += new System.EventHandler(this.btnClearMarkers_Click);
            // 
            // btnGetNumOfOverlay
            // 
            this.btnGetNumOfOverlay.Location = new System.Drawing.Point(17, 268);
            this.btnGetNumOfOverlay.Name = "btnGetNumOfOverlay";
            this.btnGetNumOfOverlay.Size = new System.Drawing.Size(190, 23);
            this.btnGetNumOfOverlay.TabIndex = 23;
            this.btnGetNumOfOverlay.Text = "Get Num Of Overlay";
            this.btnGetNumOfOverlay.UseVisualStyleBackColor = true;
            this.btnGetNumOfOverlay.Click += new System.EventHandler(this.btnGetNumOfOverlay_Click);
            // 
            // lblNoOfOverlay
            // 
            this.lblNoOfOverlay.AutoSize = true;
            this.lblNoOfOverlay.Location = new System.Drawing.Point(179, 273);
            this.lblNoOfOverlay.Name = "lblNoOfOverlay";
            this.lblNoOfOverlay.Size = new System.Drawing.Size(19, 13);
            this.lblNoOfOverlay.TabIndex = 24;
            this.lblNoOfOverlay.Text = "....";
            // 
            // btnCreategridLines
            // 
            this.btnCreategridLines.Location = new System.Drawing.Point(17, 216);
            this.btnCreategridLines.Name = "btnCreategridLines";
            this.btnCreategridLines.Size = new System.Drawing.Size(190, 23);
            this.btnCreategridLines.TabIndex = 25;
            this.btnCreategridLines.Text = "create gridlines";
            this.btnCreategridLines.UseVisualStyleBackColor = true;
            // 
            // lblLONG
            // 
            this.lblLONG.AutoSize = true;
            this.lblLONG.Location = new System.Drawing.Point(234, 4);
            this.lblLONG.Name = "lblLONG";
            this.lblLONG.Size = new System.Drawing.Size(52, 13);
            this.lblLONG.TabIndex = 27;
            this.lblLONG.Text = "LongStrip";
            // 
            // lblLAT
            // 
            this.lblLAT.AutoSize = true;
            this.lblLAT.Location = new System.Drawing.Point(234, 31);
            this.lblLAT.Name = "lblLAT";
            this.lblLAT.Size = new System.Drawing.Size(43, 13);
            this.lblLAT.TabIndex = 28;
            this.lblLAT.Text = "LatStrip";
            // 
            // radioBtnZoomOut
            // 
            this.radioBtnZoomOut.AutoSize = true;
            this.radioBtnZoomOut.Location = new System.Drawing.Point(237, 59);
            this.radioBtnZoomOut.Name = "radioBtnZoomOut";
            this.radioBtnZoomOut.Size = new System.Drawing.Size(53, 17);
            this.radioBtnZoomOut.TabIndex = 29;
            this.radioBtnZoomOut.TabStop = true;
            this.radioBtnZoomOut.Text = "-zoom";
            this.radioBtnZoomOut.UseVisualStyleBackColor = true;
            this.radioBtnZoomOut.CheckedChanged += new System.EventHandler(this.radioBtnZoomOut_CheckedChanged);
            // 
            // radioBtnZoomIn
            // 
            this.radioBtnZoomIn.AutoSize = true;
            this.radioBtnZoomIn.Location = new System.Drawing.Point(237, 83);
            this.radioBtnZoomIn.Name = "radioBtnZoomIn";
            this.radioBtnZoomIn.Size = new System.Drawing.Size(56, 17);
            this.radioBtnZoomIn.TabIndex = 30;
            this.radioBtnZoomIn.TabStop = true;
            this.radioBtnZoomIn.Text = "+zoom";
            this.radioBtnZoomIn.UseVisualStyleBackColor = true;
            this.radioBtnZoomIn.CheckedChanged += new System.EventHandler(this.radioBtnZoomIn_CheckedChanged);
            // 
            // lblGridRef
            // 
            this.lblGridRef.AutoSize = true;
            this.lblGridRef.Location = new System.Drawing.Point(395, 7);
            this.lblGridRef.Name = "lblGridRef";
            this.lblGridRef.Size = new System.Drawing.Size(39, 13);
            this.lblGridRef.TabIndex = 31;
            this.lblGridRef.Text = "grid ref";
            // 
            // btnPrintMap
            // 
            this.btnPrintMap.Location = new System.Drawing.Point(237, 110);
            this.btnPrintMap.Name = "btnPrintMap";
            this.btnPrintMap.Size = new System.Drawing.Size(75, 23);
            this.btnPrintMap.TabIndex = 32;
            this.btnPrintMap.Text = "Reload Map";
            this.btnPrintMap.UseVisualStyleBackColor = true;
            this.btnPrintMap.Click += new System.EventHandler(this.btnPrintMap_Click);
            // 
            // btnAutoRoute
            // 
            this.btnAutoRoute.Location = new System.Drawing.Point(237, 140);
            this.btnAutoRoute.Name = "btnAutoRoute";
            this.btnAutoRoute.Size = new System.Drawing.Size(106, 23);
            this.btnAutoRoute.TabIndex = 33;
            this.btnAutoRoute.Text = "display routes";
            this.btnAutoRoute.UseVisualStyleBackColor = true;
            this.btnAutoRoute.Click += new System.EventHandler(this.btnAutoRoute_Click);
            // 
            // cmbBoxMapType
            // 
            this.cmbBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMapType.FormattingEnabled = true;
            this.cmbBoxMapType.Items.AddRange(new object[] {
            "BingMapProvider",
            "GoogleMapProvider",
            "GoogleSatelliteMapProvider",
            "ArcGIS_DarbAE_Q2_2011_NAVTQ_Eng_V5_MapProvider",
            "ArcGIS_ShadedRelief_World_2D_MapProvider",
            "ArcGIS_StreetMap_World_2D_MapProvider",
            "ArcGIS_Topo_US_2D_MapProvider",
            "ArcGIS_World_Physical_MapProvider",
            "ArcGIS_World_Topo_MapProvider"});
            this.cmbBoxMapType.Location = new System.Drawing.Point(235, 169);
            this.cmbBoxMapType.Name = "cmbBoxMapType";
            this.cmbBoxMapType.Size = new System.Drawing.Size(199, 21);
            this.cmbBoxMapType.TabIndex = 34;
            this.cmbBoxMapType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 606);
            this.Controls.Add(this.cmbBoxMapType);
            this.Controls.Add(this.btnAutoRoute);
            this.Controls.Add(this.btnPrintMap);
            this.Controls.Add(this.lblGridRef);
            this.Controls.Add(this.radioBtnZoomIn);
            this.Controls.Add(this.radioBtnZoomOut);
            this.Controls.Add(this.lblLAT);
            this.Controls.Add(this.lblLONG);
            this.Controls.Add(this.btnCreategridLines);
            this.Controls.Add(this.lblNoOfOverlay);
            this.Controls.Add(this.btnGetNumOfOverlay);
            this.Controls.Add(this.btnClearMarkers);
            this.Controls.Add(this.btnAddMultipleMarkers);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblZoomValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCountry);
            this.Controls.Add(this.btnseeAllMarkers);
            this.Controls.Add(this.btnAddRoutes);
            this.Controls.Add(this.btnShowGridLines);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.btnLagos);
            this.Controls.Add(this.btnPolygons);
            this.Controls.Add(this.txtBoxNumBorderSize);
            this.Controls.Add(this.txtBoxBorderSize);
            this.Controls.Add(this.txtBoxToolTip);
            this.Controls.Add(this.btnMapProvider);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.cmbMapProvider2);
            this.Controls.Add(this.txtBoxLon);
            this.Controls.Add(this.btnGoto);
            this.Controls.Add(this.txtBoxLat);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNumBorderSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbMapProvider;
        private System.Windows.Forms.Button btnProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtBoxLon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox txtBoxLat;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.ComboBox cmbMapProvider2;
        private System.Windows.Forms.Button btnMapProvider;
        private System.Windows.Forms.RichTextBox txtBoxToolTip;
        private System.Windows.Forms.TextBox txtBoxBorderSize;
        private System.Windows.Forms.NumericUpDown txtBoxNumBorderSize;
        private System.Windows.Forms.Button btnPolygons;
        private System.Windows.Forms.Button btnLagos;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.Button btnShowGridLines;
        private System.Windows.Forms.Button btnAddRoutes;
        private System.Windows.Forms.Button btnseeAllMarkers;
        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblZoomValue;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnAddMultipleMarkers;
        private System.Windows.Forms.Button btnClearMarkers;
        private System.Windows.Forms.Button btnGetNumOfOverlay;
        private System.Windows.Forms.Label lblNoOfOverlay;
        private System.Windows.Forms.Button btnCreategridLines;
        private System.Windows.Forms.Label lblLONG;
        private System.Windows.Forms.Label lblLAT;
        private System.Windows.Forms.RadioButton radioBtnZoomOut;
        private System.Windows.Forms.RadioButton radioBtnZoomIn;
        private System.Windows.Forms.Label lblGridRef;
        private System.Windows.Forms.Button btnPrintMap;
        private System.Windows.Forms.Button btnAutoRoute;
        private System.Windows.Forms.ComboBox cmbBoxMapType;
    }
}

