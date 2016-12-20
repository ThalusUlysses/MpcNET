using LibMpc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace LibMpcTest
{
    public class MpcMock : IDisposable
    {
        public MpcMock()
        {
            Client = new Mpc(new IPEndPoint(IPAddress.Loopback, 6600));

            var connected = Task.Run(async () => await Client.ConnectAsync()).Result;
            TestUtils.WriteLine($"Connected to MPD : {connected}");
        }

        public Mpc Client { get; }

        public void Dispose()
        {
            Client?.DisconnectAsync().GetAwaiter().GetResult();
            TestUtils.WriteLine($"Disconnected from MPD.");
        }
    }
}