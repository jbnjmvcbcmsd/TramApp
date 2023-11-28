using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;

namespace TramApp
{
    internal class TramData
    {
        public string lastUpdate { get; }
        public List<departures>? departures { get; }
        public TramData(string lastUpdate, List<departures>? departures)
        {
            this.lastUpdate = lastUpdate;
            this.departures = departures;
        }
    }
}
