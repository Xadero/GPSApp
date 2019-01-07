using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        string url = "https://api.jsonbin.io/b/5c2e073705d34b26f201420d/latest";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGoogleDrive_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text.Contains("Google Drive Manager"))
                {
                    MessageBox.Show("Google Drive Manager is already opened!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            var GDriveForm = new GoogleDriveManager();
            GDriveForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Filename", 150, HorizontalAlignment.Left);

            coordinates.View = View.Details;
            coordinates.Columns.Add("Longitude", 150, HorizontalAlignment.Left);
            coordinates.Columns.Add("Lantitude", 150, HorizontalAlignment.Left);

            RereshDownloadedFilesList(listView1);

            JsonUrl.Text = url;

            map.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.Position = new PointLatLng(51.9377277, 18.4417374);
            map.MinZoom = 10;
            map.MaxZoom = 100;
            map.Zoom = 10;
        }

        public void RefreshButton_Click(object sender, EventArgs e)
        {
            RereshDownloadedFilesList(listView1);
        }

        private void DeleteAllFiles_Click(object sender, EventArgs e)
        {

            var dialogResult = MessageBox.Show("Do you really want to delete all downloaded files?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var di = new DirectoryInfo(JsonHelper.File_Path);

                try
                {
                    foreach (var file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (var dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }

                    var dialogSubmit = MessageBox.Show("All files has been deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogSubmit == DialogResult.OK)
                    {
                        RereshDownloadedFilesList(listView1);
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Folder with Json files doesn't exist. Try to download some files from Google Drive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RereshDownloadedFilesList(ListView listview)
        {
            listview.Items.Clear();
            try
            {
                var dir = new DirectoryInfo(JsonHelper.File_Path);
                var Files = dir.GetFiles("*.json");
                foreach (var file in Files)
                {
                    string[] filename = { file.Name };
                    var item = new ListViewItem(filename);

                    listview.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Folder with Json files doesn't exist. Try to download some files from Google Drive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Visible = true;
            RefreshButton.Visible = true;
            ChooseFile.Visible = true;
            DeleteAllFiles.Visible = true;
            OpenGoogleDrive.Visible = true;
            OpenFileLocation.Visible = true;

            GetJsonFile.Visible = false;
            JsonUrl.Visible = false;
            checkBox1.Visible = false;
            RestoreDefaultUrl.Visible = false;

            GenerateButton.Enabled = false;
            PutMarkers.Enabled = false;

            label1.Text = "Files:";
            label1.Top = 91;

            coordinates.Items.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Visible = false;
            RefreshButton.Visible = false;
            ChooseFile.Visible = false;
            DeleteAllFiles.Visible = false;
            OpenGoogleDrive.Visible = false;
            GenerateButton.Enabled = false;
            PutMarkers.Enabled = false;
            OpenFileLocation.Visible = false;

            GetJsonFile.Visible = true;
            JsonUrl.Visible = true;
            checkBox1.Visible = true;
            RestoreDefaultUrl.Visible = true;

            label1.Text = "URL:";
            label1.Top = 59;

            var openedForms = Application.OpenForms;
            if (openedForms.Count > 1)
            {
                openedForms[1].Close();
            }

            coordinates.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                JsonUrl.Enabled = false;
            }
            else
            {
                JsonUrl.Enabled = true;
            }
        }

        private void GetJsonFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(JsonUrl.Text))
            {
                coordinates.Items.Clear();
                GetJsonFileFromUrl(JsonUrl.Text, coordinates, GenerateButton, PutMarkers);
            }
            else
            {
                MessageBox.Show("Url textbox cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task GetJsonFileFromUrl(string url, ListView listView, Button button, Button button2)
        {
            HttpClient client = new HttpClient();
            var responseJson = await client.GetStringAsync(url);

            var cooridantesList = JsonHelper.GetCoordinatesFromJson(listView, button, button2, responseJson);
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                coordinates.Items.Clear();
                using (StreamReader r = new StreamReader(JsonHelper.File_Path + listView1.SelectedItems[0].Text))
                {
                    try
                    {
                        string json = r.ReadToEnd();
                        var coordinatesList = JsonHelper.GetCoordinatesFromJson(coordinates, GenerateButton, PutMarkers, json);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Json file cannot be read or is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            map.Overlays.Clear();
            var latLngPoint = JsonHelper.GetPointsList(coordinates);
            map.Zoom = 15;
            for (int i = 0; i < latLngPoint.Count - 1; i++)
            {
                var provider = OpenStreetMapProvider.Instance.GetRoute(latLngPoint[i], latLngPoint[i + 1], false, false, 15);
                var route = new GMapRoute(provider.Points, "Myroutes");
                var routesOverlay = new GMapOverlay("Myroutes");
                routesOverlay.Routes.Add(route);
                map.Overlays.Add(routesOverlay);
                route.Stroke.Width = 2;
                route.Stroke.Color = Color.SeaGreen;
            }
            map.Position = latLngPoint.Last();
        }

        private void PutMarkers_Click(object sender, EventArgs e)
        {
            map.Overlays.Clear();
            var latLngPoint = JsonHelper.GetPointsList(coordinates);
            map.Zoom = 15;
            for (int i = 0; i < latLngPoint.Count - 1; i++)
            {
                var point = new PointLatLng(latLngPoint[i].Lat, latLngPoint[i].Lng);
                var marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                var markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);

                map.Overlays.Add(markers);
            }
            map.Position = latLngPoint.First();

            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 0.0001;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.0001;

            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(coordinates.Items.Cast<ListViewItem>().Max(x => double.Parse(x.SubItems[0].Text)));
            chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(coordinates.Items.Cast<ListViewItem>().Min(x => double.Parse(x.SubItems[0].Text)));

            chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(coordinates.Items.Cast<ListViewItem>().Max(x => double.Parse(x.SubItems[1].Text)));
            chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(coordinates.Items.Cast<ListViewItem>().Min(x => double.Parse(x.SubItems[1].Text)));

            for (int i = 0; i < latLngPoint.Count - 1; i++)
            {
                chart1.Series["Coordinates"].Points.AddXY(latLngPoint[i].Lng, latLngPoint[i].Lat);
            }
        }

        private void OpenFileLocation_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (File.Exists(JsonHelper.File_Path + listView1.SelectedItems[0].Text))
                {
                    Process.Start("explorer.exe", JsonHelper.File_Path);
                }
            }
            else
            {
                MessageBox.Show("Please selecet a file. \n If file list is empty then download file from Google Drive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestoreDefaultUrl_Click(object sender, EventArgs e)
        {
            JsonUrl.Text = url;
        }
    }
}

