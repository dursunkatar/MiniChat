using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatServerCoklu
{
    public class ChatEngine
    {
        private static volatile object obj = new object();

        private readonly TcpListener listen;
        private readonly List<SocketClient> clients;


        public ChatEngine()
        {
            clients = new List<SocketClient>();
            listen = new TcpListener(IPAddress.Parse("0.0.0.0"), 1496);
            listen.Start(100);
            bekle();
        }

        private void bekle()
        {
            var th = new Thread(() =>
            {
                while (true)
                {
                    var socket = listen.AcceptSocket();
                    lock (obj)
                    {
                        clients.Add(new SocketClient(socket, this));
                    }
                }
            });
            th.IsBackground = false;
            th.Start();
        }

        public string kisilerBilgisi()
        {
            string bilgiler = "[kisiler]";
            clients.ForEach(m =>
            {
                bilgiler += m.ClientID + "|" + m.ClientName + ",";
            });
            return bilgiler;
        }

        public void onlineKisileriYenile()
        {
            lock (obj)
            {
                clients.ForEach(m =>
                {
                    if (!m.BaglantiTest())
                    {
                        clients.Remove(m);
                    }
                });

            }
            clients.ForEach(m =>
            {
                m.MesajGonder(kisilerBilgisi());
            });
        }

        public void gelen(string mesaj)
        {
            SocketClient client;
            string clientID = mesaj.Split('|')[2];
            lock (obj)
            {
                client = clients.FirstOrDefault(m => m.ClientID == clientID);
            }

            client.MesajGonder(mesaj);
        }
    }
}
