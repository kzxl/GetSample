using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_
{
    internal class clsFunction
    {
        public static List<string>? GetIPv4()
        {
            try
            {
                List<string> lstIP = new List<string>();
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    if (adapter.OperationalStatus == OperationalStatus.Up && adapter.GetIPProperties().GatewayAddresses.Count > 0)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        var ip = properties.UnicastAddresses.Where(ua => ua.Address.AddressFamily == AddressFamily.InterNetwork).Select(ua => ua.Address.ToString()).FirstOrDefault();
                        lstIP.Add(ip);
                    }
                }
                return lstIP;
            }
            catch { return null; }
        }
    }
}
