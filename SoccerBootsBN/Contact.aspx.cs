using System;
using System.Net.Mail;
//source taken from https://www.youtube.com/watch?v=ngldKCSXA6U and https://www.youtube.com/watch?v=Fw1X7HLZfos-->
namespace SoccerBootsBN
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SbmtGmailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    MailMessage gmailmessages = new MailMessage();
                    gmailmessages.From = new MailAddress(TextEmail.Text);
                    gmailmessages.To.Add("kasutbolabrunei@gmail.com");
                    gmailmessages.Subject = TextSubject.Text;
                    gmailmessages.Body = "<b>Sender Name : </b>" + TextName.Text + "<br/>"
                        + "<b>Sender's Email : </b>" + TextEmail.Text + "<br/>"
                        + "<b>Comments : </b>" + TextComment.Text ;
                    gmailmessages.IsBodyHtml = true;

                    SmtpClient mainClient = new SmtpClient("Smtp.gmail.com", 587);
                    mainClient.EnableSsl = true;
                    mainClient.Credentials = new System.Net.NetworkCredential("kasutbolabrunei@gmail.com", "kasutbola123");
                    mainClient.Send(gmailmessages);

                    NotesLabel.ForeColor = System.Drawing.Color.Blue;
                    NotesLabel.Text = "Thank you for contacting us";

                    TextName.Enabled = false;
                    TextEmail.Enabled = false;
                    TextComment.Enabled = false;
                    TextSubject.Enabled = false;
                    SbmtGmailBtn.Enabled = false;
                }
            }
            catch(Exception)
            {
                NotesLabel.ForeColor = System.Drawing.Color.Blue;
                NotesLabel.ForeColor = System.Drawing.Color.Red;
                NotesLabel.Text = "There is something wrong with the server. Please try again later";
            }




        }
    }
}