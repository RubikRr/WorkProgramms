using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
//y0_AgAAAAA70-eBAAm40AAAAADhOu20bMWhQNcRTE-CjdYFRdXguiyskJE --основной акк

namespace YandexDiskConsole
{
    
    internal class Program
    {
        const string token = "y0_AgAAAABqAWpkAAm40AAAAADhPcdIEO4ATZKVTtm2iMVXkL6yrp_wLEg";//progtestchakalov
        static HttpClient client=new HttpClient();

        public static async void GetToken()
        {
            var clientId = @"84bd7c464eab4688bef6c06a43b362a2";
            var clientSecret = @"b51bed6067af4692ab73446c935def9f";
            var code = "1953829";
   

            string uri = @"https://oauth.yandex.ru/token";
         
      
            //OAuth - токен y0_AgAAAAA70 - eBAAm2 - gAAAADhG4FMpwtMzvqvQ3mxPLJXJLAprm06gXI

            var values = new Dictionary<string, string>
            {
                { "grant_type", "authorization_code" },
                { "code", code },
                { "client_id", clientId },
                { "client_secret", clientSecret }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(uri, content);

            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);

        }

        public static async Task<string> GetURL()
        {
            string uploadUrl = "https://cloud-api.yandex.net/v1/disk/resources/upload?path=/&overwrite=true";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "OAuth " + token);

            var response = await client.GetAsync(uploadUrl);
            var str = await response.Content.ReadAsStringAsync();
            var ans = JsonConvert.DeserializeObject<Test>(str);
            return ans.Href;

           
        }
        //
        static async Task Main(string[] args)
        {

            //var url = GetURL();
            //await Console.Out.WriteLineAsync(url.Result);


            var url = "https://uploader10j.disk.yandex.net:443/upload-target/20230429T022513.232.utd.d0xdmsp7gzc3ovjmbqkuxcw7q-k10j.690099";

            client.DefaultRequestHeaders.Add("Authorization", "OAuth " + token);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.openxmlformats-officedocument.wordprocessingml.document"));
            client.DefaultRequestHeaders.ExpectContinue = false;


          
            var filePath = "C:\\Users\\vovac\\OneDrive\\Рабочий стол\\Курсач\\Tests\\Рабочая программа (шаблон).docx";

            using var multipartFormContent = new MultipartFormDataContent();

            byte[] fileToBytes = await File.ReadAllBytesAsync(filePath);
            var fileContent = new ByteArrayContent(fileToBytes);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = "test"
            };

            multipartFormContent.Add(fileContent);
            HttpResponseMessage response = client.PostAsync(url, multipartFormContent).Result;

            var responseText = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseText);

        }
    }
    record Test(string Href);

}

