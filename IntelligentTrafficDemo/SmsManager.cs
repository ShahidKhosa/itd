using System;
using System.Net;
using System.Web;

namespace IntelligentTrafficDemo
{
    public class SmsManager
    {

        public static void SendSMS(EventInfo info, string phone = "923366487047")
        {
            string MyUsername   = "923336106762";       //Your Username At Sendpk.com 
            string MyPassword   = "4623";               //Your Password At Sendpk.com 
            string toNumber     = phone;       //Recepient cell phone number with country code 
            string Masking      = "JAMVI";              //Your Company Brand Name or Sender Name
            string MessageText  = string.Format("{0} is passed through Channel {1} at {2}", info.PlateNumber, info.Index, info.Time);

            string jsonResponse = ProcessSMS(Masking, toNumber, MessageText, MyUsername , MyPassword); Console.Write(jsonResponse); 
            //Console.Read(); //to keep console window open if trying in visual studio
        }

    
       public static string ProcessSMS(string Masking, string toNumber, string MessageText, string MyUsername, string MyPassword)
        {
            String URI = "http://sendpk.com" +
            "/api/sms.php?" +
            "username=" + MyUsername +
            "&password=" + MyPassword +
            "&sender=" + Masking +
            "&mobile=" + toNumber +
            "&message=" + Uri.UnescapeDataString(MessageText); // Visual Studio 10-15
            try
            {
                WebRequest req = WebRequest.Create(URI);
                WebResponse resp = req.GetResponse();
                var sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {
                var httpWebResponse = ex.Response as HttpWebResponse;

                if (httpWebResponse != null)
                {
                    switch (httpWebResponse.StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            return "404:URL not found :" + URI;
                            break;
                        case HttpStatusCode.BadRequest:
                            return "400:Bad Request";
                            break;
                        default:
                            return httpWebResponse.StatusCode.ToString();
                    }
                }
            }

            return null;
        }
    

        public static void sendSMS_old(string message = "Test Message from core Lib")
        {
            string baseURL = "http://sendpk.com/api/sms.php?username=923336106762&password=4623&sender=JAMVI&mobile=923366487047&message=" + message;
            //string reqUrl = string.Format("billing/customerDetails/{0}/billarrangement/{1}/bill/{2}getbillSummary?uan={3}", cID, aNo, bId, UAN);

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(baseURL);
            req.Method = "GET";
            //req.Credentials = CredentialCache.DefaultCredentials;
            //req.Accept = "text/json";

            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(resp);
                }
            }
        }

    }
}
