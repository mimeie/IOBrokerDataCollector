using System;
using System.Net;

using Newtonsoft.Json;

namespace IOBrokerDataCollectorBusinessLogic
{
    public class Collector
    {
        public int getIntValue(string id)
        {
            try
            {
                
                using (WebClient wc = new WebClient())
                {
                  

                    string downString = AccessData.IOBrokerApi + id;
                    Console.WriteLine("Download String '{0}'", downString);

                    var json = wc.DownloadString(downString);                    

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim lesen der Leistung", ex);
                throw;
            }

            return 0;
        }
    }
}
