using System.Net;
using System.Net.Sockets;
using System.Text;



namespace App2
{
    class ClientSocket
    {      
        public static NetworkStream socket;
        private enum Message
        {
            Ac_on = 101,
            Ac_off = 102,
            Ac_soon_on = 103,
            Ac_soon_off = 104,
            Tv_on = 201,
            Tv_off = 202,
            Tv_soon_on = 203,
            Tv_soon_off = 204,
            Switch_on = 301,
            Switch_off = 302,
            Switch_soon_on = 303,
            Switch_soon_off = 304,
            Lock_on = 401,
            Lock_off = 402,
            Lock_soon_on = 403,
            Lock_soon_off = 404,
            Succes = 100,
            Error = 000,
            Warning = 011
        };

      
        public static bool Connect()
        {
            try
            {
                TcpClient client = new TcpClient();
                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("10.0.0.15"), 8826);
                client.Connect(serverEndPoint);
                socket = client.GetStream();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public static void SendMessage(string message)
        {
            try
            {
                byte[] buffer;
                buffer = new ASCIIEncoding().GetBytes(message);//sending the card
                socket.Write(buffer, 0, message.Length);
                socket.Flush();
            }
            catch
            {

            }
        }

        public static string ReadFromServer()
        {
            try
            {
                string input;
                byte[] bufferIn = new byte[4];
                int bytesRead = socket.Read(bufferIn, 0, 4);
                input = new ASCIIEncoding().GetString(bufferIn);
                return input;
            }
            catch
            {
                return "0";
            }
        }

    }





}
