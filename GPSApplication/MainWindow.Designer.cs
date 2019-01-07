namespace WindowsFormsApp1
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.OpenGoogleDrive = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteAllFiles = new System.Windows.Forms.Button();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.GetJsonFile = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.JsonUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coordinates = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PutMarkers = new System.Windows.Forms.Button();
            this.OpenFileLocation = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RestoreDefaultUrl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.map);
            this.panel1.Location = new System.Drawing.Point(343, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 460);
            this.panel1.TabIndex = 0;
            // 
            // map
            // 
            this.map.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.map.AutoSize = true;
            this.map.BackColor = System.Drawing.SystemColors.ControlDark;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(770, 460);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // OpenGoogleDrive
            // 
            this.OpenGoogleDrive.Location = new System.Drawing.Point(16, 35);
            this.OpenGoogleDrive.Name = "OpenGoogleDrive";
            this.OpenGoogleDrive.Size = new System.Drawing.Size(255, 26);
            this.OpenGoogleDrive.TabIndex = 2;
            this.OpenGoogleDrive.Text = "OpenGoogleDrive";
            this.OpenGoogleDrive.UseVisualStyleBackColor = true;
            this.OpenGoogleDrive.Click += new System.EventHandler(this.OpenGoogleDrive_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(18, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 234);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(169, 67);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(102, 23);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DeleteAllFiles
            // 
            this.DeleteAllFiles.Location = new System.Drawing.Point(172, 354);
            this.DeleteAllFiles.Name = "DeleteAllFiles";
            this.DeleteAllFiles.Size = new System.Drawing.Size(102, 23);
            this.DeleteAllFiles.TabIndex = 5;
            this.DeleteAllFiles.Text = "Delete all files";
            this.DeleteAllFiles.UseVisualStyleBackColor = true;
            this.DeleteAllFiles.Click += new System.EventHandler(this.DeleteAllFiles_Click);
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(15, 67);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(131, 23);
            this.ChooseFile.TabIndex = 6;
            this.ChooseFile.Text = "Chooose";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Google Drive";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "URL";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // GetJsonFile
            // 
            this.GetJsonFile.Location = new System.Drawing.Point(16, 35);
            this.GetJsonFile.Name = "GetJsonFile";
            this.GetJsonFile.Size = new System.Drawing.Size(129, 21);
            this.GetJsonFile.TabIndex = 9;
            this.GetJsonFile.Text = "Get Json File";
            this.GetJsonFile.UseVisualStyleBackColor = true;
            this.GetJsonFile.Visible = false;
            this.GetJsonFile.Click += new System.EventHandler(this.GetJsonFile_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(22, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // JsonUrl
            // 
            this.JsonUrl.Enabled = false;
            this.JsonUrl.Location = new System.Drawing.Point(43, 70);
            this.JsonUrl.Name = "JsonUrl";
            this.JsonUrl.Size = new System.Drawing.Size(277, 20);
            this.JsonUrl.TabIndex = 11;
            this.JsonUrl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Files";
            // 
            // coordinates
            // 
            this.coordinates.Location = new System.Drawing.Point(12, 402);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(324, 351);
            this.coordinates.TabIndex = 13;
            this.coordinates.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Coordinates";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Location = new System.Drawing.Point(12, 759);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(160, 43);
            this.GenerateButton.TabIndex = 15;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // PutMarkers
            // 
            this.PutMarkers.Enabled = false;
            this.PutMarkers.Location = new System.Drawing.Point(176, 759);
            this.PutMarkers.Name = "PutMarkers";
            this.PutMarkers.Size = new System.Drawing.Size(160, 43);
            this.PutMarkers.TabIndex = 16;
            this.PutMarkers.Text = "Put markers";
            this.PutMarkers.UseVisualStyleBackColor = true;
            this.PutMarkers.Click += new System.EventHandler(this.PutMarkers_Click);
            // 
            // OpenFileLocation
            // 
            this.OpenFileLocation.Location = new System.Drawing.Point(18, 354);
            this.OpenFileLocation.Name = "OpenFileLocation";
            this.OpenFileLocation.Size = new System.Drawing.Size(102, 23);
            this.OpenFileLocation.TabIndex = 17;
            this.OpenFileLocation.Text = "Open file location";
            this.OpenFileLocation.UseVisualStyleBackColor = true;
            this.OpenFileLocation.Click += new System.EventHandler(this.OpenFileLocation_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(343, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Coordinates";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(773, 323);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // RestoreDefaultUrl
            // 
            this.RestoreDefaultUrl.Location = new System.Drawing.Point(169, 34);
            this.RestoreDefaultUrl.Name = "RestoreDefaultUrl";
            this.RestoreDefaultUrl.Size = new System.Drawing.Size(113, 23);
            this.RestoreDefaultUrl.TabIndex = 19;
            this.RestoreDefaultUrl.Text = "Restore default URL";
            this.RestoreDefaultUrl.UseVisualStyleBackColor = true;
            this.RestoreDefaultUrl.Visible = false;
            this.RestoreDefaultUrl.Click += new System.EventHandler(this.RestoreDefaultUrl_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 838);
            this.Controls.Add(this.RestoreDefaultUrl);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.OpenFileLocation);
            this.Controls.Add(this.PutMarkers);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coordinates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JsonUrl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.GetJsonFile);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.DeleteAllFiles);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.OpenGoogleDrive);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "GPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OpenGoogleDrive;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteAllFiles;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button GetJsonFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox JsonUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView coordinates;
        public System.Windows.Forms.Button GenerateButton;
        public GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button PutMarkers;
        private System.Windows.Forms.Button OpenFileLocation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button RestoreDefaultUrl;
    }
}

