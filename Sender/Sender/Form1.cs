using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbFileSend.Value = 0;
        }

        private void bnBrowse_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            //openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 1;

            //openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                tbFile.Text = openFileDialog1.FileName;
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            pbFileSend.Value = 0;
            try
            {
                if (!File.Exists(tbFile.Text))
                    throw new Exception("File not found");
                if(tbIP.Text==string.Empty) throw new Exception("Enter IP");
                System.Net.Sockets.TcpClient clnt = new System.Net.Sockets.TcpClient(tbIP.Text, 11001);
                clnt.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TcpClient tcpclient = new TcpClient();

            try
            {
                tcpclient.Connect(tbIP.Text, 11001); //use IPaddress as in the server
                //Console.WriteLine("Connected to server");
                NetworkStream stm = tcpclient.GetStream();
                if (stm.CanWrite && stm.CanRead)
                {
                    //do write
                    FileInfo fi = new FileInfo(tbFile.Text);
                    long total = fi.Length;
                    long rdby = 0;
                    bool check = true;
                    int i = 0;
                    pbFileSend.Maximum =(int) total;
                    pbFileSend.Step = 4096;

                    //FileStreams to the file to be Uploaded
                    //when uploading file should be locked to other processes

                    FileStream fin = fi.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                    byte[] reader = new byte[4096];
                    //Loop till the File is totaly read
                    while (rdby < total && check)
                    {
                        //Read from the File
                        i = fin.Read(reader, 0, reader.Length);
                        //Send the Bytes to the Server
                        stm.Write(reader, 0, reader.Length);
                        rdby = rdby + i;
                        pbFileSend.PerformStep();
                    }
                    stm.Flush();
                    fin.Close();
                    pbFileSend.Value = pbFileSend.Maximum;
                    MessageBox.Show("Finished sending file");
                }
                else if (!stm.CanRead)
                {
                    Console.WriteLine("You cannot write to this stream");
                    //tcpclient.Close();
                }
                tcpclient.Close();
            }
            catch { }

        }
    }
}
