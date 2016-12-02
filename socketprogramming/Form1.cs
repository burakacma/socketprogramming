using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace socketprogramming
{
    public partial class Form1 : Form
    {
        // Kullanılacak olan tanımlamalar
        Socket S;    
        EndPoint epYerel, epUzak;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tanımlamış olduğumuz Socket i baslangıç ayarları 
            S = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            S.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            // Local ip mizi otomatik olarak ip yerlerine yazılması "GetLocalIP();" bu fonksiyonu kendimiz yazdık
            txb_ipgonderen.Text = GetLocalIP();
            tbx_ipalici.Text = GetLocalIP();

            // *********** bu kod Thread çakışmaları için yapılır..
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        public string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void btn_baglan_Click(object sender, EventArgs e)
        {
            try { 
            epYerel = new IPEndPoint(IPAddress.Parse(txb_ipgonderen.Text),Convert.ToInt32(tbx_portgonderen.Text));
            S.Bind(epYerel);

            epUzak = new IPEndPoint(IPAddress.Parse(tbx_ipalici.Text),Convert.ToInt32(tbx_portalici.Text));
            S.Connect(epUzak);

            buffer = new byte[1500];
            S.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epUzak,new AsyncCallback(MessageCallBack),buffer);
           
            listBox_massage.Items.Add("Bağlantı Başarılı");
             }
            catch (Exception)
            {
                listBox_massage.Items.Add("bağlantı başarılı değil ");
            }
        }
        private void MessageCallBack(IAsyncResult aSonuc)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aSonuc.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                listBox_massage.Items.Add("Gelen :" + receivedMessage);

                buffer = new byte[1500];
                S.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epUzak, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception exc) {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage =new byte[1500];
            sendingMessage = aEncoding.GetBytes(textBox_textmassage.Text);
            S.Send(sendingMessage);
            listBox_massage.Items.Add("Gönderen: " + textBox_textmassage.Text);
            textBox_textmassage.Text = "";


        }


    }
}
