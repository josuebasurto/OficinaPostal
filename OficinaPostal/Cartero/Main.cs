using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Está seguro de enviar el correo?", "¿Está seguro de enviar el correo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) {
                try
                {
                    var smtp = new System.Net.Mail.SmtpClient
                    {
                        Host = txtServer.Text,
                        Port = toInt(txtPort.Text, 587),
                        EnableSsl = cbSSL.Checked,
                        DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(txtUser.Text, txtPass.Text)
                    };
                    using (var message = new System.Net.Mail.MailMessage(txtFrom.Text, txtTo.Text)
                    {
                        Subject = txtSubj.Text,
                        Body = txtMessage.Text
                    })
                    {
                        smtp.Send(message);
                        MessageBox.Show("Mensaje Enviado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int toInt(string numero, int defaultValue)
        {
            try
            {
                return Convert.ToInt32(numero);
            }
            catch { }
            return defaultValue;
        }
    }
}
