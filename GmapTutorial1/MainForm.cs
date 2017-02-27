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


namespace GmapTutorial1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
            gmaps.ShowTileGridLines = true;


            gmaps.MapProvider = BingHybridMapProvider.Instance;
            //GMaps.Instance.Mode = AccessMode.ServerOnly;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            // gmap.SetPositionByKeywords("Paris, France");
            gmaps.Position = new GMap.NET.PointLatLng(48.866383, 2.323575);
            gmaps.ShowCenter = false;
            gmaps.ShowTileGridLines = true;



            GMapOverlay polygons = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(48.866383, 2.323575));
            points.Add(new PointLatLng(48.863868, 2.321554));
            points.Add(new PointLatLng(48.861017, 2.330030));
            points.Add(new PointLatLng(48.863727, 2.331918));
            GMapPolygon polygon = new GMapPolygon(points, "Jardin des Tuileries");
            polygons.Polygons.Add(polygon);
            gmaps.Overlays.Add(polygons);



            #region "create a new instance of GMapOverlay"
            GMapOverlay myOverlayForMarkers = new GMapOverlay("myOverlayForMarkers");
            #endregion

            #region "create a marker"
            //We create a new instance of GMarkerGoogle  
            //(which is a specialization of GMapMarker )
            //and provide it with a location (a PointLatLng ) and a marker type.

            GMapMarker myMarker = new GMarkerGoogle(new PointLatLng(48.8617774, 2.349272), GMarkerGoogleType.blue_pushpin);
            GMapMarker myMarker2 = new GMarkerGoogle(new PointLatLng(48.8617774, 2.549272), GMarkerGoogleType.blue_dot);
            #endregion

            /* ---- to add your own image use below code -------
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(48.8617774, 2.349272), new Bitmap("nalogo.jpg"));
            ----------------------------------------------------
            */
            //We add the newly created marker to our overlay.            
            myOverlayForMarkers.Markers.Add(myMarker);
            myOverlayForMarkers.Markers.Add(myMarker2);

            //We add the overlay containing marker to our map.            
            gmaps.Overlays.Add(myOverlayForMarkers);

            // Add tooltips to your markers 
            myMarker.ToolTipText = "hello\nout there";

            #region"styling markers tool tip"
            myMarker.ToolTip.Fill = Brushes.Black;
            myMarker.ToolTip.Foreground = Brushes.White;
            myMarker.ToolTip.Stroke = Pens.Black;
            myMarker.ToolTip.TextPadding = new Size(20, 20);
            #endregion

            #region "setting marker tool tip mode"
            myMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            #endregion

            #region "setting map location"
            //gmap.Location = new System.Drawing.Point(20, 20);
            #endregion  

            #region "to set map border style"
            gmaps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            #endregion

            #region "to set emptytiles border color"
            gmaps.EmptyTileBorders.Color = (Color.DarkRed);
            #endregion




        }
    }
}
