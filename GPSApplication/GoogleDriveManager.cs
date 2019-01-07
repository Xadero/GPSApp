using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace WindowsFormsApp1
{
    public partial class GoogleDriveManager : Form
    {
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "NMEAProvider";
        UserCredential credential;
        public GoogleDriveManager()
        {
            InitializeComponent();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            GoogleDriveProvider.GetItemsFromGoogleDrive(credential, ApplicationName, listView1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Filename", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("FileId", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Size (bytes)", 150, HorizontalAlignment.Left);

            credential = GoogleDriveProvider.GetCredentials(Scopes);

            GoogleDriveProvider.GetItemsFromGoogleDrive(credential, ApplicationName, listView1);

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }


        private void ChangeAccount_Click(object sender, EventArgs e)
        {
            var credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

            var dir = new DirectoryInfo(credPath);
            dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
            dir.Delete(true);

            credential = GoogleDriveProvider.GetCredentials(Scopes);

            listView1.Items.Clear();
            GoogleDriveProvider.GetItemsFromGoogleDrive(credential, ApplicationName, listView1);
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            var fileId = listView1.SelectedItems[0].SubItems[1].Text;
            var filename = listView1.SelectedItems[0].Text;
            var request = service.Files.Get(fileId);
            var stream = new MemoryStream();
            request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case DownloadStatus.Downloading:
                        {
                            Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                    case DownloadStatus.Completed:
                        {
                            DirectoryInfo di = Directory.CreateDirectory(JsonHelper.File_Path);
                            using (var file = new FileStream(JsonHelper.File_Path + filename, FileMode.Create, FileAccess.Write))
                            {
                                stream.WriteTo(file);
                            }

                            MessageBox.Show("Download has ben completed!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case DownloadStatus.Failed:
                        {
                            MessageBox.Show("Download has ben failed!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }
            };
            request.Download(stream);
        }
    }
}
