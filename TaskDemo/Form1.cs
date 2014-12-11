using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskDemo
{
    public partial class Form1 : Form
    {
        Uri uri = new Uri(@"http://api.spotify.com/v1/search?type=artist&q=Pharrell+Williams");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtResultJSON.Text = "";
            Cursor.Current = Cursors.WaitCursor;

            var response = RequestUri(uri);
            var data = ReadResponse(response);
            SetResult(data);

            Cursor.Current = Cursors.Default;
        }

        private void btnSearchAsync_Click(object sender, EventArgs e)
        {
            txtResultJSON.Text = "";
            Cursor.Current = Cursors.WaitCursor;

            RequestUriAsync(uri)
                .ContinueWith<String>(ReadFutureResponse)
                .MainUIContinueWith(SetFutureResult);

            Cursor.Current = Cursors.Default;
        }

        private HttpWebResponse RequestUri(Uri uri)
        {
            var request = (HttpWebRequest)HttpWebRequest.Create(uri);
            request.Proxy = new WebProxy("http://proxy.chemtech.com.br:3128", true);
            return (HttpWebResponse)request.GetResponse();
        }
        private Task<HttpWebResponse> RequestUriAsync(Uri uri)
        {
            return Task.Factory.StartNew<HttpWebResponse>(() => RequestUri(uri));
        }

        private String ReadResponse(HttpWebResponse response)
        {
            return (new StreamReader(response.GetResponseStream(), UTF8Encoding.UTF8)).ReadToEnd();
        }
        private String ReadFutureResponse(Task<HttpWebResponse> responseAsync)
        {
            return ReadResponse(responseAsync.Result);
        }

        private void SetResult(String data)
        {
            Console.WriteLine(data);
            txtResultJSON.Text = data;
        }
        private void SetFutureResult(Task<String> dataAsync)
        {
            SetResult(dataAsync.Result);
        }


        private void imgCover_Click(object sender, EventArgs e)
        {

        }

        private void txtResultJSON_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
