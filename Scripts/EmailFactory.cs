using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class EmailFactory : MonoBehaviour
{
    public void SendEmail()
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        mail.From = new MailAddress("pscX19.tdah@gmail.com");
        mail.To.Add("pscX19.tdah@gmail.com");
        mail.Subject = "player data";
        mail.Body = "";

        System.Net.Mail.Attachment attachment;
        attachment = new System.Net.Mail.Attachment(Application.dataPath + "/save.json");
        mail.Attachments.Add(attachment);

        SmtpServer.Port = 587;
        SmtpServer.Credentials = new System.Net.NetworkCredential("pscX19.tdah@gmail.com", "sy2B9BcWTvYm23D");
        SmtpServer.EnableSsl = true;

        SmtpServer.Send(mail);
    }
}
