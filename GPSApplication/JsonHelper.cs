using GMap.NET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class JsonHelper
    {
        public static string File_Path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DownloadedFiles\\";
        public static Sheets GetCoordinatesFromJson(ListView listView, Button button, Button button2, string responseJson)
        {
            var jsonfile = JsonConvert.DeserializeObject<Sheets>(responseJson);

            foreach (var json in jsonfile.Sheet)
            {
                string[] filename = { json.latitude.ToString(), json.longitude.ToString() };
                ListViewItem item = new ListViewItem(filename);

                listView.Items.Add(item);
            }

            if (listView.Items.Count > 0)
            {
                button.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button.Enabled = false;
                button2.Enabled = false;
            }

            return jsonfile;
        }

        public static List<PointLatLng> GetPointsList(ListView listview)
        {
            List<Point> points = new List<Point>();
            foreach (ListViewItem item in listview.Items)
            {
                points.Add(new Point()
                {
                    CordX = Convert.ToDouble(item.SubItems[0].Text),
                    Cordy = Convert.ToDouble(item.SubItems[1].Text)
                });
            }
            var latLngPoint = new List<PointLatLng>();

            foreach (var routePoints in points)
            {
                latLngPoint.Add(new PointLatLng(routePoints.CordX, routePoints.Cordy));
            }

            return latLngPoint;
        }
    }
}
