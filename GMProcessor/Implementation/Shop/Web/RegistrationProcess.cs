using DatabaseModule;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GMProcessor
{
    public class RegistrationProcess : IRegistrationProcess
    {
        private readonly IInsertTokenProcess insertToken;

        public RegistrationProcess(IInsertTokenProcess insertTokenProcess)
        {
            this.insertToken = insertTokenProcess;
        }

        public bool Register(Guid shopId)
        {
            string token = insertToken.Insert(shopId);

            string url = $"https://localhost:5001/home/RegisterNewPointOfSaleAccount?token={token}";

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            var httpClient = new HttpClient(clientHandler);

            var result = httpClient.GetAsync(url);

            while (result.IsCompleted) { }

            return true;
        }
    }
}
