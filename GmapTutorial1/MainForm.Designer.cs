namespace GmapTutorial1
{
    partial class MainForm
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
            this.gmaps = new GMap.NET.WindowsForms.GMapControl();
            this.btnGoto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gmaps
            // 
            this.gmaps.Bearing = 0F;
            this.gmaps.CanDragMap = true;
            this.gmaps.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmaps.GrayScaleMode = false;
            this.gmaps.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmaps.LevelsKeepInMemmory = 5;
            this.gmaps.Location = new System.Drawing.Point(240, 12);
            this.gmaps.MarkersEnabled = true;
            this.gmaps.MaxZoom = 2;
            this.gmaps.MinZoom = 2;
            this.gmaps.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmaps.Name = "gmaps";
            this.gmaps.NegativeMode = false;
            this.gmaps.PolygonsEnabled = true;
            this.gmaps.RetryLoadTile = 0;
            this.gmaps.RoutesEnabled = true;
            this.gmaps.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmaps.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmaps.ShowTileGridLines = false;
            this.gmaps.Size = new System.Drawing.Size(1040, 567);
            this.gmaps.TabIndex = 0;
            this.gmaps.Zoom = 0D;
            // 
            // btnGoto
            // 
            this.btnGoto.Location = new System.Drawing.Point(13, 87);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(221, 23);
            this.btnGoto.TabIndex = 1;
            this.btnGoto.Text = "Goto";
            this.btnGoto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 591);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGoto);
            this.Controls.Add(this.gmaps);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmaps;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}