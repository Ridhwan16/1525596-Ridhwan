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
                    MailMessage mailmessage = new MailMessage();
                    mailmessage.From = new MailAddress(TextEmail.Text);
                    mailmessage.To.Add("kasutbolabrunei@gmail.com");
                    mailmessage.Subject = TextSubject.Text;

                    mailmessage.Body = "<b>Sender Name : </b>" + TextName.Text + "<br/>"
                        + "<b>Sender's Email : </b>" + TextEmail.Text + "<br/>"
                        + "<b>Comments : </b>" + TextComment.Text ;
                    mailmessage.IsBodyHtml = true;

                    SmtpClient smtpClient = new SmtpClient("Smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential("kasutbolabrunei@gmail.com", "kasutbola123");
                    smtpClient.Send(mailmessage);

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