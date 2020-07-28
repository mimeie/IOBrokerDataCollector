using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net;

using Newtonsoft.Json;


namespace IOBrokerDataCollector.BusinessLogic
{
    public class Collector
    {
        public int getIntValue(string id)
        {
            try
            {

                using (WebClient wc = new WebClient())
                {
                    IOBrokerJSONGet ioJson = new IOBrokerJSONGet();

                    string downString = AccessData.IOBrokerApi + id;
                    Console.WriteLine("Download String '{0}'", downString);

                    var json = wc.DownloadString(downString);
                    ioJson = JsonConvert.DeserializeObject<IOBrokerJSONGet>(json);
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
