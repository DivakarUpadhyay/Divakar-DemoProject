using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

public enum HttpVerb
{
    GET,
    POST,
    PUT,
    DELETE
}


namespace ICRA.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public class RestClient
        {
            public string EndPoint { get; set; }
            public HttpVerb Method { get; set; }
            public string ContentType { get; set; }
            public string PostData { get; set; }
            public string userName { get; set; }
            public string userPassword { get; set; }
            public List<KeyValuePair<string, string>> Header { get; set; }

            public RestClient(string contenttype)
            {
                EndPoint = "";
                Method = HttpVerb.GET;
                ContentType = contenttype;
                PostData = "";
            }

            public RestClient(string contenttype, string endpoint)
            {
                EndPoint = endpoint;
                Method = HttpVerb.GET;
                ContentType = contenttype;
                PostData = "";
            }

            public RestClient(string contenttype, string endpoint, HttpVerb method)
            {
                EndPoint = endpoint;
                Method = method;
                ContentType = contenttype;
                PostData = "";
            }

            public RestClient(string contenttype, string endpoint, HttpVerb method, string postData)
            {
                EndPoint = endpoint;
                Method = method;
                ContentType = contenttype;
                PostData = postData;
            }

            public RestClient(string contenttype, string endpoint, HttpVerb method, string postData, List<KeyValuePair<string, string>> header)
            {
                EndPoint = endpoint;
                Method = method;
                ContentType = contenttype;
                PostData = postData;
                Header = header;
            }

            public string MakeRequest()
            {
                return MakeRequest("");
            }

            public string MakeRequest(string parameters)
            {
                try
                {
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                    var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);
                    request.KeepAlive = false;
                    request.Method = Method.ToString();
                    request.ContentLength = 0;
                    request.ContentType = ContentType;
                    //added for header
                    if (Header != null && Header.Count > 0)
                    {
                        foreach (var item in Header)
                        {
                            request.Headers.Add(item.Key, item.Value);
                        }
                    }

                    if (!string.IsNullOrEmpty(PostData) && Method == HttpVerb.POST)
                    {
                        var encoding = new UTF8Encoding();
                        var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
                        request.ContentLength = bytes.Length;
                        using (var writeStream = request.GetRequestStream())
                        {
                            writeStream.Write(bytes, 0, bytes.Length);
                        }
                    }
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        var responseValue = string.Empty;
                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                            throw new ApplicationException(message);
                        }
                        using (var responseStream = response.GetResponseStream())
                        {
                            if (responseStream != null)
                                using (var reader = new StreamReader(responseStream))
                                {
                                    responseValue = reader.ReadToEnd();
                                }
                        }
                        return responseValue;
                    }
                }
                catch (WebException webex)
                {
                    WebResponse errResp = webex.Response;
                    using (Stream respStream = errResp.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(respStream);
                        string text = reader.ReadToEnd();
                        if (string.IsNullOrEmpty(text))
                        {
                            text = webex.Message;
                        }
                        return text;
                    }
                }
            }

            public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                if (sslPolicyErrors == SslPolicyErrors.None)
                    return true;
                return false;
            }
        }
    }
}