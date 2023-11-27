using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Models
{
    public static class Session
    {
        public static string CurrentUser { get; set; }
        public static string OTP { get; set; }
        public static bool isSuccesful { get; set; }


        //method for generating OTP
        public static void SendOTP(string email)
        {
            string otp_char = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            OTP = "";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {

                var random_char = otp_char[rnd.Next(1, otp_char.Length)];
                OTP += random_char;

            }

            string msg = OTP;
            string senderEmail, senderPass, receiverEmail;
            receiverEmail = email;
            senderEmail = "timyvillarmia@gmail.com"; //Change this to your Sender's Gmail Email Address
            senderPass = "hufl pdtj sqty ourk";  //Gmail's App Password Change this to your Sender's Gmail App Password

            MimeMessage message = new MimeMessage(); // Creating object for Message
            message.From.Add(new MailboxAddress("BudgetBuddy - OTP", senderEmail)); //Sender's information
            message.To.Add(MailboxAddress.Parse(receiverEmail)); //Receiver's Information

            message.Subject = "One-Time-Password"; //Email's Subject

            //Email's Body
            message.Body = new TextPart("plain") //Plain text
            {
                Text = msg  //MSG = OTP
            };

            SmtpClient client = new SmtpClient(); // allows sending of e-mail notifications using a SMTP server

            try
            {
                client.Connect("smtp.gmail.com", 465, true); //Gmail's smtp server, PORT: 465
                client.Authenticate(senderEmail, senderPass); //Login sender's email and password
                client.Send(message); //
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to generate OTP, please try again");
                return;
            }
            finally
            {
                client.Disconnect(true); // always Disconnect the service.
                client.Dispose(); //Releases all resource used by the MailService object.
            }
        }
    }
}
