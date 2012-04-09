using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceiveTCP(11001);
        }
        public static void ReceiveTCP(int portN)
        {
            TcpListener Listener = null;
            try
            {
                Listener = new TcpListener(IPAddress.Any, portN);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int BufferSize = 4096;
            byte[] RecData = new byte[BufferSize];
            int RecBytes;

            for (; ; )
            {
                TcpClient client = null;
                NetworkStream netstream = null;
                //Status = string.Empty;
                try
                {
                    string message = "Accept the Incoming File ";
                    string caption = "Incoming Connection";
                    //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    //DialogResult result;
                    

                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        //Status = "Connected to a client\n";
                        //result = MessageBox.Show(message, caption, buttons);
                        Console.WriteLine("Connected to a sender");
                        string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string SaveFileName = dirPath+"\\"+string.Format("RecvdFile-{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);
                            if (SaveFileName != string.Empty)
                            {
                                int totalrecbytes = 0;
                                FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
                                while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                                {
                                    Fs.Write(RecData, 0, RecBytes);
                                    totalrecbytes += RecBytes;
                                }
                                Fs.Close();
                            }
                            netstream.Close();
                            client.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //netstream.Close();
                }
            }
        }
    }
}
