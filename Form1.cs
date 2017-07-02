using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Security.Principal;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Mail;

namespace JustScan
{
    public partial class Form1 : Form
    {
        int dot = DateTime.Now.TimeOfDay.ToString().IndexOf(".");


        //WHOIS------------------------------
        TcpClient tcpWhois;
        NetworkStream nsWhois;
        BufferedStream bfWhois;
        StreamWriter strmSend;
        StreamReader strmRecive;

        //WHOIS------------------------------
        //PORT SCANNER START-----------------
        protected int StartPort;
        protected int EndPort;
        protected int StartIP;
        protected int EndIP;
        //PORT SCANNER STOP------------------
        //WIFI START----------------
        bool connect = false;
        bool PScanning = false;
        //WIFI END------------------
        //void Add(string m)
        //{
        //    add.Items.Add(m);
        //}
        /// <summary>
        /// The main entry point for the application.
        /// </summary
        //WIFI START-------------------------------------------
        public static bool IsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal p = new WindowsPrincipal(id);
            return p.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public void RestartElevated()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = true;
            startInfo.WorkingDirectory = Environment.CurrentDirectory;
            startInfo.FileName = System.Windows.Forms.Application.ExecutablePath;
            startInfo.Verb = "runas";
            try
            {
                Process p = Process.Start(startInfo);
            }
            catch
            {

            }

            System.Windows.Forms.Application.Exit();
        }
        //WIFI END---------------------------------------------------

        public Form1()
        {

            InitializeComponent();
            LoadMe();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }
        void LoadMe()
        {
            hostName.Text = Dns.GetHostName();
            //MessageBox.Show(Dns.GetHostEntry());

            IPHostEntry ip = Dns.GetHostEntry(Dns.GetHostName());

            if (ip.AddressList.Count() > 1)
            {

                int Nip = ip.AddressList.Count();
                //  MessageBox.Show(Nip.ToString());
                IPMenu.Items.Add("127.0.0.1");//*Added
                while (Nip != 0)
                {
                    // MessageBox.Show(ip.AddressList[Nip - 1].AddressFamily.ToString());
                    //Here InterNetwork=IPv4 and InterNetworkV6=IPv6 
                    if (ip.AddressList[Nip - 1].AddressFamily.ToString() == "InterNetwork")
                    { //*Added
                        IPMenu.Items.Add(ip.AddressList[Nip - 1].ToString());

                    }

                    Nip--;

                }

            }


        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            //When pressing the use use button
            try
            {
                // IPHostEntry ip = Dns.GetHostByName(Dns.GetHostName());
                IPHostEntry ip = Dns.GetHostEntry(Dns.GetHostName());
                //ipFrom.Text = ip.AddressList[1].ToString();
                //ipTo.Text = ip.AddressList[1].ToString();
                ipFrom.Text = IPMenu.SelectedItem.ToString();
                ipTo.Text = IPMenu.SelectedItem.ToString();
            }
            catch { MessageBox.Show("Please Choose an IP"); }
        }
        Thread sercher;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (ScanType.SelectedItem.ToString() == "Dns Entries")
                {
                    sercher = new Thread(new ThreadStart(FindUsingDns));
                    // add.Items.Clear();
                    try
                    {
                        IPAddress from = IPAddress.Parse(ipFrom.Text);
                        IPAddress to = IPAddress.Parse(ipTo.Text);

                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                        return;
                    }
                    sercher.Name = "Network searching thread";
                    sercher.Start();
                    //add.Items.Add("    -->> >>> Please wait while processing is done <<< <<--");
                    IPScan.AppendText("    -->> >>> Please wait while processing is done <<< <<--" + "\n");
                    //Thread.Sleep(1);

                }
                else if (ScanType.SelectedItem.ToString() == "Ping Scan")
                {
                    // MessageBox.Show("You Chose Ping Scan");
                    sercher = new Thread(new ThreadStart(FindUsingPing));
                    // add.Items.Clear();
                    try
                    {
                        IPAddress from = IPAddress.Parse(ipFrom.Text);
                        IPAddress to = IPAddress.Parse(ipTo.Text);

                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                        return;
                    }
                    sercher.Name = "Network searching thread";
                    sercher.Start();
                    // add.Items.Add("    -->> >>> Please wait while processing is done <<< <<--");
                    IPScan.AppendText("    -->> >>> Please wait while processing is done <<< <<--" + "\n");
                    //Thread.Sleep(1);
                }
                // else { MessageBox.Show("Please Choose The Scan Type"); }
            }
            catch { MessageBox.Show("Please Choose The Scan Type"); }


        }
        /// <summary>
        /// 
        /// </summary>
        void FindUsingDns() // 
        {
            // add.Items.Add("    -- >>> >> >>> Found station <<< << <<< -- ");
            // add.Items.Add("Host Name                   IP  Address");
            IPScan.AppendText("    -- >>> >> >>> Found station <<< << <<< -- " + "\n");
            IPScan.AppendText("Host Name                   IP  Address" + "\n");
            int lastF = ipFrom.Text.LastIndexOf(".");
            int lastT = ipTo.Text.LastIndexOf(".");
            string frm = ipFrom.Text.Substring(lastF + 1);
            string tto = ipTo.Text.Substring(lastT + 1);
            int result = 0;

            // Store values from the NumericUpDown to variables
            StartIP = int.Parse(frm);
            EndIP = int.Parse(tto);
            // Reset the progress bar
            prgIPScanning.Value = 0;
            // Set the max value of the progress bar
            prgIPScanning.Maximum = EndIP - StartIP + 1;
            MessageBox.Show("From" + frm + "To " + tto + " Maximum" + (EndIP - StartIP + 1));
            // Let the user know the application is busy
            Cursor.Current = Cursors.WaitCursor;

            System.Diagnostics.Debug.WriteLine(frm + " " + tto);
            for (int i = int.Parse(frm); i <= int.Parse(tto); i++)
            {
                try
                {
                    string address = ipTo.Text.Substring(0, lastT + 1);
                    System.Diagnostics.Debug.WriteLine(ipTo.Text.Substring(0, lastT + 1) + i);
                    IPHostEntry he = Dns.GetHostByAddress(address + i);
                    // IPHostEntry Ipe = Dns.GetHostEntry();
                    //  add.Items.Add(he.HostName+"                  "+address+i);
                    IPScan.AppendText(he.HostName + "                  " + address + i + "\n");

                    //foreach (DataGridView row in ScanGrid.Rows)
                    //{

                    //    // ScanGrid.UpdateCellValue(0,0) = address + i;



                    //}


                    //        add.Items.Add(he.HostName+"      "+address+i.ToString());
                    result += 1;
                }

                catch (SocketException)
                {
                    // in cazul unei erori
                }
                catch (Exception)
                {
                    // previne bloacarea programului
                }

                prgIPScanning.PerformStep();
            }
            // Set the cursor back to normal

            Cursor.Current = Cursors.Arrow;


        }

        void FindUsingPing()
        {
            string host = null; int attempts = 1;
            //int timeout=0; //Time to wait for replies In Milliseconds
            //add.Items.Add("    -- >>> >> >>> Found station <<< << <<< -- ");
            //add.Items.Add("Host Name                   IP  Address");
            IPScan.AppendText("    -- >>> >> >>> Found station <<< << <<< -- " + "\n");
            IPScan.AppendText("Host Name                   IP  Address" + "\n");
            int lastF = ipFrom.Text.LastIndexOf(".");
            int lastT = ipTo.Text.LastIndexOf(".");
            string frm = ipFrom.Text.Substring(lastF + 1);
            string tto = ipTo.Text.Substring(lastT + 1);
            int result = 0;

            // Store values from the NumericUpDown to variables
            StartIP = int.Parse(frm);
            EndIP = int.Parse(tto); ;
            // Reset the progress bar
            prgIPScanning.Value = 0;
            // Set the max value of the progress bar
            prgIPScanning.Maximum = EndIP - StartIP + 1;
            //MessageBox.Show("From"+frm+"To "+tto+" Maximum"+(EndIP-StartIP+1));
            // Let the user know the application is busy
            Cursor.Current = Cursors.WaitCursor;

            Ping ping = new Ping();

            PingReply pingReply;
            //-----------------------------------------------------------------------------------

            System.Diagnostics.Debug.WriteLine(frm + " " + tto);
            for (int i = int.Parse(frm); i <= int.Parse(tto); i++)
            {
                try
                {
                    string address = ipTo.Text.Substring(0, lastT + 1);
                    System.Diagnostics.Debug.WriteLine(ipTo.Text.Substring(0, lastT + 1) + i);
                    IPHostEntry he = Dns.GetHostByAddress(address + i);
                    // IPHostEntry Ipe = Dns.GetHostEntry();
                    ////add.Items.Add(he.HostName + "                  " + address + i);
                    host = address + i.ToString();

                    for (int j = 0; j < attempts; j++)
                    {
                        try
                        {
                            // pingReply = ping.Send(host, timeout);
                            pingReply = ping.Send(host);

                            // If there is a successful ping then return true.
                            if (pingReply != null &&
                                pingReply.Status == System.Net.NetworkInformation.IPStatus.Success)
                            {
                                //return true;
                                // add.Items.Add(he.HostName + "                  " + address + i);
                                IPScan.AppendText(he.HostName + "                      " + address + i + "\n");
                            }



                        }
                        catch
                        {
                            // Do nothing and let it try again until the attempts are exausted.
                            // Exceptions are thrown for normal ping failurs like address lookup
                            // failed.  For this reason we are supressing errors.
                        }
                    }

                    // Return false if we can't successfully ping the server after several attempts.
                    // return false;



                    //        add.Items.Add(he.HostName+"      "+address+i.ToString());
                    result += 1;

                }

                catch (SocketException)
                {
                    // in cazul unei erori
                }
                catch (Exception)
                {
                    // previne bloacarea programului
                }
                prgIPScanning.PerformStep();


            }
            MessageBox.Show("IP Scanning Done..!");
            // Set the cursor back to normal

            Cursor.Current = Cursors.Arrow;
            //-----------------------------------------------------------------------------------------------------------




        }

        private void wifi_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(IsAdmin().ToString());
            string ssid = textBox1.Text, key = textBox2.Text;
            if (!connect)
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("SSID cannot be left blank !",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (textBox2.Text == null || textBox2.Text == "")
                    {
                        MessageBox.Show("Key value cannot be left blank !",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (key.Length >= 8)
                        {
                            Hotspot(ssid, key, true);
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            wifi.Text = "Stop";
                            connect = true;
                        }
                        else
                        {
                            MessageBox.Show("Key should be more then or Equal to 8 Characters !",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                Hotspot(null, null, false);
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                wifi.Text = "Start";
                connect = false;
            }
        }
        private void Hotspot(string ssid, string key, bool status)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                if (status)
                {
                    process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + key);
                    process.StandardInput.WriteLine("netsh wlan start hosted network");


                    process.StandardInput.Close();
                }
                else
                {
                    process.StandardInput.WriteLine("netsh wlan stop hostednetwork");
                    process.StandardInput.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                RestartElevated();
            }
            cmbServer.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hotspot(null, null, false);
            sercher.Abort();
            PScan.Abort();
            Application.Exit();

        }

        Thread PScan;
        private void btnScan_Click(object sender, EventArgs e)
        {

            if (!PScanning)
            {
                PScan = new Thread(new ThreadStart(PortScan));
                PScan.Name = "Port Scanning Thread";
                txtIP.Enabled = false;
                numEnd.Enabled = false;
                numStart.Enabled = false;
                btnScan.Text = "Stop";
                PScan.Start();
                PScanning = true;

                //  while (PScan.IsAlive) { };
                //MessageBox.Show("Done..!");
            }
            else
            {
                PScan.Abort();
                txtIP.Enabled = true;
                numEnd.Enabled = true;
                numStart.Enabled = true;
                btnScan.Text = "Start";
                PScanning = false;
            }
            //if (PScan.IsAlive)
            //{
            //    PScan.Abort();
            //    MessageBox.Show("Done..!");
            //}


        }

        void PortScan()
        {
            // Store values from the NumericUpDown to variables
            StartPort = Convert.ToInt32(numStart.Value);
            EndPort = Convert.ToInt32(numEnd.Value);
            // Reset the progress bar
            prgScanning.Value = 0;
            // Set the max value of the progress bar
            prgScanning.Maximum = EndPort - StartPort + 1;
            // Let the user know the application is busy
            Cursor.Current = Cursors.WaitCursor;
            // Loop through the ports between start port and end port
            for (int CurrPort = StartPort; CurrPort <= EndPort; CurrPort++)
            {
                TcpClient TcpScan = new TcpClient();
                if (CurrPort == StartPort)
                {
                    txtLog.AppendText("For  The IP " + txtIP.Text + " :-\r\n");
                    txtLog.AppendText("---------------------------------------------\r\n");
                }
                try
                {
                    // Try to connect
                    TcpScan.Connect(txtIP.Text, CurrPort);
                    // If there's no exception, we can say the port is open
                    txtLog.AppendText("Port " + CurrPort + " open\r\n");
                }
                catch
                {
                    // An exception occured, thus the port is probably closed
                    txtLog.AppendText("Port " + CurrPort + " closed\r\n");
                }
                // Increase the progress on the progress bar
                prgScanning.PerformStep();
            }

            txtIP.Enabled = true;
            numEnd.Enabled = true;
            numStart.Enabled = true;
            btnScan.Text = "Start";
            PScanning = false;


            // Set the cursor back to normal
            Cursor.Current = Cursors.Arrow;
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            Thread WhoIs = new Thread(new ThreadStart(WhoIS));
            WhoIs.Name = "WhoIs Thread";
            WhoIs.Start();
        }

        void WhoIS()
        {

            if (txtHostName.Text == null)
            {
                label6.Visible = true;
            }
            try
            {
                //CONNECT TO TCP CLIENT OF WHOIS
                tcpWhois = new TcpClient(cmbServer.SelectedItem.ToString(), 43);

                //SETUP THE NETWORK STREAM
                nsWhois = tcpWhois.GetStream();

                //GET THE DATA IN THE BUFFER FROM THE NETWORK STREAM
                bfWhois = new BufferedStream(nsWhois);

                strmSend = new StreamWriter(bfWhois);

                strmSend.WriteLine(txtHostName.Text);

                strmSend.Flush();

                txtxResponse.Clear();


                try
                {
                    strmRecive = new StreamReader(bfWhois);
                    string response;

                    while ((response = strmRecive.ReadLine()) != null)
                    {
                        txtxResponse.Text += response + "\r\n";
                        if (progressBar1.Value < 100)
                            progressBar1.Value += 10;
                    }
                }

                catch
                {
                    MessageBox.Show("WHOis Server Error :x");
                }

            }

            catch
            {
                MessageBox.Show("No Internet Connection or Any other Fault", "Error");
            }

            //SEND THE WHO_IS SERVER ABOUT THE HOSTNAME

            finally
            {
                try
                {
                    tcpWhois.Close();
                }
                catch
                {
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (UsrName.Text.Contains("@gmail.com"))
            {

                MailThroughGMail();
                // MessageBox.Show( txtLog.Text);
            }
        }
        void MailThroughGMail()
        {
            String from, to, pass, text, subject;

            string Time = DateTime.Now.TimeOfDay.ToString().Substring(0, dot);
            //MessageBox.Show(MailPro.SelectedItem.ToString());


            try
            {
                // Attachment a = new Attachment("d:\\one.docx");
                from = UsrName.Text;
                pass = Pass.Text;
                to = To.Text;
                subject = "SharpScan Network Scan Report";
                text = "Hello Sir/Mam, \nThis is an Autogenerated Network Scan Report By SharpScan \nThe Scan Was Conducted On: "
                        + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "  At:  " + Time + "  From the Host: "
                        + Dns.GetHostName() + " \nFollowing is the Summary of Obtained Results:-\nList Of Live  Hosts: \n"
                        + IPScan.Text + "\nResults of Port Scan:\n "
                        + txtLog.Text + " \n\nWhoIs Report:\n " + txtxResponse.Text + "\nThanks for Using SharpScan. ";

                // MessageBox.Show(text);
                MailMessage Report = new MailMessage(from, to, subject, text);
                Report.From = new MailAddress(UsrName.Text.ToString());
                //MessageBox.Show(UsrName.Text.ToString() + "@" + MailPro.SelectedItem.ToString());
                //  Report.Sender.DisplayName.Equals("SharpScan Report");
                Report.Subject = subject;
                Report.Body = text;
                foreach (string s in To.Text.Split(','))
                    Report.To.Add(s);
                //Report.Attachments.Add(a);


                SmtpClient Client;
                Client = new SmtpClient("smtp.gmail.com", 587);
                NetworkCredential c = new NetworkCredential(from, pass);
                Client.UseDefaultCredentials = false;
                Client.Credentials = c;
                Client.EnableSsl = true;
                Client.Send(Report);
                MessageBox.Show("Report Sent");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void ipFrom_MouseEnter(object sender, EventArgs e)
        {
            this.ipFrom.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void ipFrom_MouseLeave(object sender, EventArgs e)
        {
            this.ipFrom.BackColor = System.Drawing.Color.White;
        }

        private void ipTo_MouseEnter(object sender, EventArgs e)
        {
            this.ipTo.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void ipTo_MouseLeave(object sender, EventArgs e)
        {
            this.ipTo.BackColor = System.Drawing.Color.White;
        }

        private void hostName_MouseEnter(object sender, EventArgs e)
        {
            this.hostName.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void hostName_MouseLeave(object sender, EventArgs e)
        {
            this.hostName.BackColor = System.Drawing.Color.White;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.textBox1.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.textBox1.BackColor = System.Drawing.Color.White;
        }

        private void txtIP_MouseEnter(object sender, EventArgs e)
        {
            this.txtIP.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void txtIP_MouseLeave(object sender, EventArgs e)
        {
            this.txtIP.BackColor = System.Drawing.Color.White;
        }

        private void txtHostName_MouseEnter(object sender, EventArgs e)
        {
            this.txtHostName.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void txtHostName_MouseLeave(object sender, EventArgs e)
        {
            this.txtHostName.BackColor = System.Drawing.Color.White;
        }

        private void UsrName_MouseEnter(object sender, EventArgs e)
        {
            this.UsrName.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void UsrName_MouseLeave(object sender, EventArgs e)
        {
            this.UsrName.BackColor = System.Drawing.Color.White;
        }

        private void Pass_MouseEnter(object sender, EventArgs e)
        {
            this.Pass.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void To_MouseEnter(object sender, EventArgs e)
        {
            this.To.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void To_MouseLeave(object sender, EventArgs e)
        {
            this.To.BackColor = System.Drawing.Color.White;
        }

        private void Pass_MouseLeave(object sender, EventArgs e)
        {
            this.Pass.BackColor = System.Drawing.Color.White;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = System.Drawing.Color.White;
        }

        private void IPScan_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void IPScan_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = System.Drawing.Color.White;
        }

        private void txtLog_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void txtLog_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = System.Drawing.Color.White;
        }

        private void numStart_Enter(object sender, EventArgs e)
        {
            this.numStart.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void numStart_Leave(object sender, EventArgs e)
        {
            this.numStart.BackColor = System.Drawing.Color.White;
        }

        private void numEnd_Enter(object sender, EventArgs e)
        {
            this.numEnd.BackColor = System.Drawing.Color.GreenYellow;
        }

        private void numEnd_Leave(object sender, EventArgs e)
        {
            this.numEnd.BackColor = System.Drawing.Color.White;
        }



        private void tabPage4_Click(object sender, EventArgs e)
        {


            //Report.AppendText("Hello Sir/Mam,\n ");

            //Report.AppendText("This is an Autogenerated Network Scan Report By SharpScan \nThe Scan Was Conducted On: "
            //         + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "  At:  " + Time + "  From the Host: "
            //         + Dns.GetHostName() );
            //Report.AppendText("Following is the Summary of Obtained Results:-\nList Of Live  Hosts: \n");
            //Report.AppendText(IPScan.Text);
            //Report.AppendText("\nResults of Port Scan:\n ");
            //Report.AppendText(txtLog.Text);
            //Report.AppendText("WhoIs Report:\n ");
            //Report.AppendText(txtxResponse.Text );
            //Report.AppendText( "Thanks for Using SharpScan. ");

        }

        string text, Time, path;
        private void SaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                text = "Hello Sir/Mam, \nThis is an Autogenerated Network Scan Report By SharpScan \nThe Scan Was Conducted On: "
        + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "  At:  " + Time + "  From the Host: "
        + Dns.GetHostName() + " \nFollowing is the Summary of Obtained Results:-\nList Of Live  Hosts: \n"
        + IPScan.Text + "\nResults of Port Scan:\n "
        + txtLog.Text + " \n\nWhoIs Report:\n " + txtxResponse.Text + "\nThanks for Using SharpScan. ";
                Time = DateTime.Now.TimeOfDay.ToString().Substring(0, dot);

                //SaveFileDialog ofd = new SaveFileDialog();
                //    if (ofd.ShowDialog() == DialogResult.OK)
                //        path = ofd.FileName;
                //else { MessageBox.Show("Please Choose a file location."); }
                //    StreamWriter sw = new StreamWriter(File.Create(text));
                //    sw.WriteLine(path);
                //    sw.Dispose();
                //}
                //catch (Exception efd){
                //    MessageBox.Show(efd.ToString());
                SaveFileDialog ofd = new SaveFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                    path = ofd.FileName;
                else { MessageBox.Show("Please Choose a file location."); }
                StreamWriter sw = new StreamWriter(File.Create(path));
                sw.WriteLine(text);

                sw.Dispose();
            }
            catch (Exception efd)
            {
                MessageBox.Show(efd.ToString());

            }
        }

        //private void MouseIn(object sender, EventArgs e)
        //{

        //    this.ipFrom.BackColor = System.Drawing.Color.GreenYellow;

        //}
        //private void MouseOut(object sender, EventArgs e)
        //{

        //    this.ipFrom.BackColor = System.Drawing.Color.GreenYellow;

        //}


    }
}
