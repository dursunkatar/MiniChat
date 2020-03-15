using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatServerCoklu
{
    public class SocketClient
    {
        public string ClientID { get; private set; }
        public string ClientName { get; private set; }
        private readonly Socket socket;
        private readonly ChatEngine chatEngine;
        private readonly NetworkStream networkStream;
        private readonly StreamReader streamReader;
        private readonly StreamWriter streamWriter;
        private byte[] test = new byte[] { 0, 13, 10 };

        public SocketClient(Socket socket, ChatEngine chatEngine)
        {
            this.socket = socket;
            this.chatEngine = chatEngine;
            networkStream = new NetworkStream(socket);
            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);
            init();
        }

        private void init()
        {
            var th = new Thread(() =>
            {
                try
                {
                    string[] bilgi = streamReader.ReadLine().Trim().Split('|');


                    if (bilgi[0] != "\0")
                    {
                        ClientID = bilgi[0];
                        ClientName = bilgi[1];

                        MesajGonder(chatEngine.kisilerBilgisi());
                        mesajBekle();
                    }
                }
                catch { }

            });
            th.IsBackground = false;
            th.Start();
        }

        public void MesajGonder(string mesaj)
        {
            try
            {
                streamWriter.WriteLine(mesaj);
                streamWriter.Flush();
            }
            catch { }
        }

        public bool BaglantiTest()
        {
            if (ClientID == null)
            {
                kapat();
                return false;
            }
            try
            {
                socket.Send(test);
                return true;
            }
            catch
            {
                kapat();
                return false;
            }

        }
        private void kapat()
        {
            try
            {
                socket.Disconnect(false);
            }
            catch { }

            socket.Dispose();
        }
        private void mesajBekle()
        {
            var th = new Thread(() =>
              {
                  try
                  {
                      while (networkStream.CanRead)
                      {
                          if (socket.Available > 0)
                          {
                              var gelen = streamReader.ReadLine().Trim();
                              if (gelen != "\0")
                              {
                                  chatEngine.gelen(gelen);
                              }
                          }
                      }
                  }
                  catch { }
              });
            th.IsBackground = false;
            th.Start();
        }
    }
}
