using UnityEngine;
using System.Net;
using System.IO;

public class testServer : MonoBehaviour
{
    public void test()
    {
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://url");
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            string json = "";
            using (StreamReader r = new StreamReader(Application.dataPath + "/save.json"))
            {
                json = r.ReadToEnd();
            }
            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
