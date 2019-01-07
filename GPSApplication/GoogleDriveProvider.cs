using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class GoogleDriveProvider
    {
        public static void GetItemsFromGoogleDrive(Google.Apis.Http.IConfigurableHttpClientInitializer credential, string ApplicationName, ListView listView)
        {
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            string pageToken = null;

            do
            {
                ListFiles(service, ref pageToken, listView);
            }
            while (pageToken != null);
        }

        public static UserCredential GetCredentials(string[] Scopes)
        {
            UserCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            return credential;
        }

        public static void ListFiles(DriveService service, ref string pageToken, ListView listView)
        {
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 30;
            listRequest.Fields = "nextPageToken, files(name), files(id), files(size)";
            listRequest.PageToken = pageToken;
            listRequest.Q = "mimeType='application/json'";

            var request = listRequest.Execute();

            if (request.Files != null && request.Files.Count > 0)
            {
                foreach (var file in request.Files)
                {
                    string[] filename = { file.Name, file.Id, file.Size.ToString() };
                    ListViewItem item = new ListViewItem(filename);

                    listView.Items.Add(item);
                }
            }
        }
    }
}
