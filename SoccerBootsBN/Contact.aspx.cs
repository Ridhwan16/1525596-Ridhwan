using System;
using System.Net.Mail;

namespace SoccerBootsBN
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    MailMessage gmailmessage = new MailMessage();
                    gmailmessage.From = new MailAddress(TextEmail.Text);
                    gmailmessage.To.Add("kasutbolabrunei@gmail.com");
                    gmailmessage.Subject = TextSubject.Text;

                    gmailmessage.Body = "<b>Sender Name : </b>" + TextName.Text + "<br/>"
                        + "<b>Sender's Email : </b>" + TextEmail.Text + "<br/>"
                        + "<b>Comments : </b>" + TextComment.Text ;
                    gmailmessage.IsBodyHtml = true;

                    SmtpClient mainClient = new SmtpClient("Smtp.gmail.com", 587);
                    mainClient.EnableSsl = true;
                    mainClient.Credentials = new System.Net.NetworkCredential("kasutbolabrunei@gmail.com", "kasutbola123");
                    mainClient.Send(gmailmessage);

                    Label1.ForeColor = System.Drawing.Color.Blue;
                    Label1.Text = "Thank you for contacting us";

                    TextName.Enabled = false;
                    TextEmail.Enabled = false;
                    TextComment.Enabled = false;
                    TextSubject.Enabled = false;
                    Button1.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                Label1.ForeColor = System.Drawing.Color.Blue;
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "There is something wrong with the server. Please try again later";
            }




        }
    }
}