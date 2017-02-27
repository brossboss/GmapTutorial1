using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using GMap.NET.MapProviders;
using GMap.NET.CacheProviders;
using System.Drawing.Printing;
using System.IO;

namespace GmapTutorial1
{
    public partial class Form1 : Form
    {
        GMapOverlay overlayOne = new GMapOverlay();
        public Form1()
        {
            #region
            
            #region "comment"
            //Configure a map provider: Set the MapProvider  property to an instance of any of the map providers supported by GMap.
            //example
            
            //gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            #endregion
            //gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            #region "comment"
            //Set the GMap working mode to use only server data:
            //GMap can fetch data from 
            //a server, 
            //from both a server and the local cache, 
            //or the local cache only.
            //In this example, we prefer to always fetch data from the server,
            //so we set the Mode  property to GMap.NET.AccessMode.ServerOnly .
            //Note that this applies to all instances of the GMap control that you create in your application, and you only need to set this value once.
            //example
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            #endregion
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            #region "comment"
            /*There are two things to note regarding centering the map. 
            First, in older versions of GMap.NET the required method was called SetCurrentPositionByKeywords, so be careful if you’re using an previous version.
            Second, you won’t always have keywords to center your map with, especially if you’re showing a region where there are few points of reference.
            Therefore, you can also center your map by writing a coordinate straight to the control’s Position  property:
            
            EXAMPLE 1 
               gmap.SetPositionByKeywords("Paris, France");
            EXAMPLE 2 
               gmap.Position = new GMap.NET.PointLatLng(48.8589507, 2.2775175);
            This will, once again, center your map on Paris, France.
            
            While running the program, you will notice that the map can be dragged with the right mouse button, and zooming is done with the mouse wheel. 
            If these operations do not work, then check that you’ve set the GMap.NET control’s properties correctly in the Properties panel – you may have inadvertently turned off dragging, or fixed the zooming level.
            
            */
            #endregion
            //gmap.SetPositionByKeywords("Paris, France");
            #region "comment"
            //Getting rid of the little red cross in the middle of the map
            #endregion
            // gmap.ShowCenter = false;
            #region "comment"
            //showing gridlines
            #endregion
            #endregion


            InitializeComponent();
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            
            // GMaps.Instance.Mode = AccessMode.ServerOnly;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.SetPositionByKeywords("lagos, nigeria");
            // gmap.Position = new PointLatLng(35.571458, -85.547961);
            gmap.DragButton = MouseButtons.Left;
            gmap.MinZoom = 3;
            gmap.MaxZoom = 20;
            gmap.Zoom = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {      
             
            //gmap.Position = new GMap.NET.PointLatLng(48.866383, 2.323575);
            gmap.ShowCenter = true;
            
            // "create a new instance of GMapOverlay"
            GMapOverlay myOverlayForMarkersold = new GMapOverlay("markers");            

            //"create a marker or markers"            
            GMapMarker myMarker = new GMarkerGoogle(new PointLatLng(48.8617774, 2.349272), GMarkerGoogleType.blue_pushpin);
            GMapMarker myMarker2 = new GMarkerGoogle(new PointLatLng(48.8617774, 2.549272), GMarkerGoogleType.blue_dot);
            /* ---- to add your own image use below code -------
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(48.8617774, 2.349272), new Bitmap("nalogo.jpg"));
            ----------------------------------------------------
            */
            //We add the newly created marker to our overlay.            
            myOverlayForMarkersold.Markers.Add(myMarker);
            myOverlayForMarkersold.Markers.Add(myMarker2);

            //We add the overlay containing marker to our map.            
            gmap.Overlays.Add(myOverlayForMarkersold);
           

            // Add tooltips to your markers 
            myMarker.ToolTipText = "hello\nout there";
            myMarker2.ToolTipText = "ststic tool tip";

            #region"styling markers tool tip"
            myMarker.ToolTip.Fill = Brushes.Black;
            myMarker.ToolTip.Foreground = Brushes.White;
            myMarker.ToolTip.Stroke = Pens.Black;
            myMarker.ToolTip.TextPadding = new Size(20, 20);
            #endregion


            #region "setting marker tool tip mode"
            myMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            // to make tooltip text always visible
            myMarker2.ToolTipMode = MarkerTooltipMode.Always;
            #endregion

            #region "setting map location"
            //gmap.Location = new System.Drawing.Point(20, 20);
            #endregion  

            #region "to set map border style"
            gmap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            #endregion

            #region "to set emptytiles border color"
            gmap.EmptyTileBorders.Color = (Color.DarkRed);
            #endregion

            // to set trackbar value after loading
            trackBar1.Value = Convert.ToInt16(gmap.Zoom);

        }

        
       

        #region "BUTTON TO GOTO A COORDINATE"
        // BUTTON TO GOTO A COORDINATE
        private void btnGoto_Click(object sender, EventArgs e)
        {
            GMapOverlay overlayForMarker = new GMapOverlay("markers");
            double lat;
            double lon;
            if (txtBoxLon.Text.Trim() != "" && txtBoxLat.Text.Trim() != "")
            {
                try
                {
                    lat = Convert.ToDouble(txtBoxLat.Text);
                    lon = Convert.ToDouble(txtBoxLon.Text);
                     }
                catch (Exception)
                {
                    MessageBox.Show("Please check values");
                    throw;
                }
                gmap.Position = new GMap.NET.PointLatLng(lat, lon);
                // to convert txtBoxBorderSize value to text 
                int test = Convert.ToInt16(txtBoxBorderSize.Text);
                string markerToolTip = txtBoxToolTip.Text;

                // method to 
                ShowMarkerPosition(overlayForMarker, lon, lat, test, markerToolTip);
            }
        }

        #endregion
        
        #region "function to show marker position"
        public void ShowMarkerPosition(GMapOverlay overlayForMarker, double lon, double lat, int intTextPaddingSize, string stringToolTipText)
        {
            
            GMapMarker myMarkerToPlace = new GMarkerGoogle(new PointLatLng(lon, lat), GMarkerGoogleType.black_small);
            
            //GMapMarker marker = new GMarkerGoogle(new PointLatLng(48.8617774, 2.349272), new Bitmap("mybitmap.jpg"));

            #region "styleToolTip-------------------------------"
            if (intTextPaddingSize <= 1)
            {
                intTextPaddingSize = 20;
            }
            // Add tooltips to your markers 
            myMarkerToPlace.ToolTipText = stringToolTipText + "\n LONGITUDE = " + lon + "\n LATTITUDE = " + lat;

            myMarkerToPlace.ToolTip.Fill = Brushes.Black;
            myMarkerToPlace.ToolTip.Foreground = Brushes.White;
            myMarkerToPlace.ToolTip.Stroke = Pens.Black;
            myMarkerToPlace.ToolTip.TextPadding = new Size(intTextPaddingSize, intTextPaddingSize);
           

            //setting marker tool tip mode"
            myMarkerToPlace.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            #endregion

            overlayForMarker.Markers.Add(myMarkerToPlace);
            gmap.Overlays.Add(overlayForMarker);

           
            //------------------------------------------------------------------------
        }


        #endregion
     
        #region "// button to draw polygon"
        private void btnPolygons_Click(object sender, EventArgs e)
        {
            gmap.MapProvider = BingHybridMapProvider.Instance;
            GMapOverlay OverLaypolygons = new GMapOverlay("OverLaypolygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(48.866383, 2.323575));
            points.Add(new PointLatLng(48.863868, 2.321554));
            points.Add(new PointLatLng(48.861017, 2.330030));
            points.Add(new PointLatLng(48.863727, 2.331918));
            GMapPolygon polygon = new GMapPolygon(points, "Jardin des Tuileries");
            OverLaypolygons.Polygons.Add(polygon);
            gmap.Overlays.Add(OverLaypolygons);

            gmap.Position = new GMap.NET.PointLatLng(48.866383, 2.323575);
        }
        #endregion

        #region "seach location using textbox"
        private void btnLagos_Click(object sender, EventArgs e)
        {
            string textBoxSearch = txtBoxState.Text;
            string textBoxCountry = txtBoxCountry.Text;
            gmap.SetPositionByKeywords(textBoxSearch + "," + textBoxCountry);
        }
        #endregion

        #region "showing lines grid lines"
        private void btnShowGridLines_Click(object sender, EventArgs e)
        {
            
            if (btnShowGridLines.Text == "Show GridLines")
            {
                gmap.ShowTileGridLines = true;
                btnShowGridLines.Text = "Remove GridLines";              
                
            }
            if (btnShowGridLines.Text != "Show GridLines")
            {
                gmap.ShowTileGridLines = true;
                btnShowGridLines.Text = "Show GridLines";

            }



        }


        #endregion

        #region CREATING ROUTES
        private void btnAddPoints_Click(object sender, EventArgs e)
        {

            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(-11.000000, 20.00000));
            points.Add(new PointLatLng(-11.000000, 4.000000));
            points.Add(new PointLatLng(-5.000000, 4.000000));
           // points.Add(new PointLatLng(49.861017, 2.330030));
            GMapRoute route = new GMapRoute(points, "A walk in the park");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gmap.Overlays.Add(routes);

            gmap.Position = new GMap.NET.PointLatLng(-11.000000, 20.00000);
        }

        #endregion

        #region "showing all markers "
        private void btnZoom_Click(object sender, EventArgs e)
        {

            gmap.ZoomAndCenterMarkers("markers");

        }

        #endregion

        #region Update trackBar Value from map
        private void btnZoom_Click_1(object sender, EventArgs e)
        {
            // to set trackbar value after loading
            trackBar1.Value = Convert.ToInt16(gmap.Zoom);

        }
        #endregion

        #region track bar control for zoomimg ..... towards a marker
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int increment = trackBar1.Value;
            //to zoom map to TRACKBAR VALUE
            gmap.Zoom = increment;

            string zoomLevel = Convert.ToString(gmap.Zoom);
            lblZoomValue.Text = " X " + zoomLevel;

            /*
            GMapOverlay OverlayToTestCentering = new GMapOverlay("markers");
            GMapMarker myMarker1 = new GMarkerGoogle(new PointLatLng(48.8617774, 45.549272), GMarkerGoogleType.blue_dot);

            OverlayToTestCentering.Markers.Add(myMarker1);

            gmap.Overlays.Add(OverlayToTestCentering);

            gmap.ZoomAndCenterMarkers("myMarker1");
            
             */
        }
        #endregion

       
        #region "add multiple markers and show them"
        private void btnAddMultipleMarkers_Click(object sender, EventArgs e)
        {
           
            GMapOverlay OverlayToTestCentering = new GMapOverlay ("markers");
            GMapMarker myMarker1 = new GMarkerGoogle(new PointLatLng(48.8617774, 45.549272), GMarkerGoogleType.blue_dot);
            GMapMarker myMarker2 = new GMarkerGoogle(new PointLatLng(20.8617774, 23.549272), GMarkerGoogleType.blue_dot);
            GMapMarker myMarker3 = new GMarkerGoogle(new PointLatLng(05.8617774, 78.549272), GMarkerGoogleType.blue_dot);
            GMapMarker myMarker4 = new GMarkerGoogle(new PointLatLng(22.8617774, 56.549272), GMarkerGoogleType.blue_dot);
            GMapMarker myMarker5 = new GMarkerGoogle(new PointLatLng(15.8617774, 20.549272), GMarkerGoogleType.blue_dot);

            OverlayToTestCentering.Markers.Add(myMarker1);
            OverlayToTestCentering.Markers.Add(myMarker2);
            OverlayToTestCentering.Markers.Add(myMarker3);
            OverlayToTestCentering.Markers.Add(myMarker4);
            OverlayToTestCentering.Markers.Add(myMarker5);
            
            gmap.Overlays.Add(OverlayToTestCentering);

            gmap.ZoomAndCenterMarkers("markers");

        }

        #endregion

        #region  clear overlay
        private void btnClearMarkers_Click(object sender, EventArgs e)
        {
            int howmany = gmap.Overlays.Count();
            MessageBox.Show("before " + Convert.ToString(howmany));
            gmap.Overlays.Clear();
            int howmany2 = gmap.Overlays.Count();
            MessageBox.Show("after " + Convert.ToString(howmany2));

        }
        #endregion

        #region TO GET TOTAL NUMBER OF OVERLAY
        private void btnGetNumOfOverlay_Click(object sender, EventArgs e)
        {
            int howmany = gmap.Overlays.Count();
            lblNoOfOverlay.Text = Convert.ToString(howmany);
        }

        #endregion

        #region GET COORDINATE OF MAOUSE POSITION
        private void mapexplr_MouseMove(object sender, MouseEventArgs e)
        {
            #region To show coordinates of mouse position
            base.OnMouseMove(e);

            double X = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = gmap.FromLocalToLatLng(e.X, e.Y).Lat;

            string longitude = X.ToString();
            string latitude = Y.ToString();
            lblLONG.Text = longitude;
            lblLAT.Text = latitude;
            #endregion


            #region To SHOW GRID REF OF A PARTICULAR POINT ie where an object it


            int labelXPotn = Convert.ToInt16(lblGridRef.Location.X);
            int labelYPotn = Convert.ToInt16(lblGridRef.Location.Y);

            double X2 = gmap.FromLocalToLatLng(labelXPotn, labelYPotn).Lng;
            double Y2 = gmap.FromLocalToLatLng(labelXPotn, labelYPotn).Lat;


            string longitude2 = X2.ToString();
            string latitude2 = Y2.ToString();


            lblGridRef.Text = "longitude = " + longitude2 + " --- lattitude  = " + latitude2;
            #endregion
        }


        #endregion

        private void gmap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //initiate the trackbar to be in current zoom mode
            trackBar1.Value = Convert.ToInt16(gmap.Zoom);
            //get value to increase zoom
            int newZoomLevel;
            if (radioBtnZoomOut.Checked == true)
            {
                newZoomLevel = trackBar1.Value - 2;
            }
            else
            {
                newZoomLevel = trackBar1.Value + 2;
            }
            
            
            //GET MOUSE POSITION IN LONG AND LAT ...we get this from lalels lon and lat
            double Long = Convert.ToDouble(lblLONG.Text);
            double Lat = Convert.ToDouble(lblLAT.Text);
           
            //MAKE MOUSE POSITION CENTER OF MAP
            gmap.Position = new PointLatLng(Lat, Long);
            //ZOOM IN WITH REFERENCE TO MOUSE POSITION X 2

            int increment = newZoomLevel;
            //to zoom map to TRACKBAR VALUE
            gmap.Zoom = increment;

            string zoomLevel = Convert.ToString(gmap.Zoom);
            lblZoomValue.Text = " X " + zoomLevel;


            

            //CENTER MAP TOWARDS THAT POSITION
        }
       
        
        #region TO CONTROL RADIO BUTTONS OF ZOOM TYPE
        private void radioBtnZoomOut_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnZoomOut.Checked == true)
            {
                radioBtnZoomIn.Checked = false;
            }
        }

        private void radioBtnZoomIn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnZoomIn.Checked == true)
            {
                radioBtnZoomOut.Checked = false;
            }
        }




        #endregion

        private void btnPrintMap_Click(object sender, EventArgs e)
        {
            gmap.ReloadMap();
        }

        private void btnAutoRoute_Click(object sender, EventArgs e)
        {
/*
            PointLatLng start = new PointLatLng(-25.974134, 32.593042);
            PointLatLng end = new PointLatLng(-25.959048, 32.592827);
            MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(
              start, end, false, false, 15);
            gmap.Position = new PointLatLng(25.974134, -32.593042);

    */
            //string start = "Avenida Armando Tivane, Maputo, Mozambique";
            //string end = "Rua 1301, Maputo, Mozambique";

            PointLatLng start = new PointLatLng(-25.974134, 32.593042);
            PointLatLng end = new PointLatLng(-25.959048, 32.592827);
            MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(start, end, false, false, 10);

            
            GMapRoute r = new GMapRoute(route.Points, "My route");
            
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            gmap.Overlays.Add(routesOverlay);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBoxMapType.Text)
            {
                case "GoogleMapProvider":
                    gmap.MapProvider = GoogleMapProvider.Instance;
                    break;
                case "GoogleSatelliteMapProvider":
                    gmap.MapProvider = GoogleSatelliteMapProvider.Instance;
                    break;
                case "ArcGIS_DarbAE_Q2_2011_NAVTQ_Eng_V5_MapProvider":
                    gmap.MapProvider = ArcGIS_DarbAE_Q2_2011_NAVTQ_Eng_V5_MapProvider.Instance;
                    break;
                case "ArcGIS_ShadedRelief_World_2D_MapProvider":
                    gmap.MapProvider = ArcGIS_ShadedRelief_World_2D_MapProvider.Instance;
                    break;
                case "ArcGIS_StreetMap_World_2D_MapProvider":
                    gmap.MapProvider = ArcGIS_StreetMap_World_2D_MapProvider.Instance;
                    break;
                case "ArcGIS_Topo_US_2D_MapProvider":
                    gmap.MapProvider = ArcGIS_Topo_US_2D_MapProvider.Instance;
                    break;
                case "ArcGIS_World_Physical_MapProvider":
                    gmap.MapProvider = ArcGIS_World_Physical_MapProvider.Instance;
                    break;
                case "ArcGIS_World_Topo_MapProvider":
                    gmap.MapProvider = ArcGIS_World_Topo_MapProvider.Instance;
                    break;

                case "BingMapProvider":
                    gmap.MapProvider = BingMapProvider.Instance;
                    break;

                default:
                    MessageBox.Show("Sorry: we donot have that map provider source");
                    break;
            }
        }

       
    }
}
