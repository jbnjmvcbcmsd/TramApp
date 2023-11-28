using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramApp
{
    internal class departures
    {
        public string id { get; }
        public string delayInSeconds { get; }
        public string estimatedTime { get; }
        public string headsign { get; }
        public string routeId { get; }
        public string scheduledTripStartTime { get; }
        public string tripId { get; }
        public string status { get; }
        public string theoreticalTime { get; }
        public string timestamp { get; }
        public string trip { get; }
        public string vehicleCode { get; }
        public string vehicleId { get; }
        public string vehicleService { get; }

        public departures(string id, string delayInSeconds, string estimatedTime, string headsign, string routeId, string scheduledTripStartTime,
            string tripId, string status, string theoreticalTime, string timestamp, string trip, string vehicleCode, string vehicleId, string vehicleService)
        {
            this.id = id;
            this.delayInSeconds = delayInSeconds;
            this.estimatedTime = estimatedTime;
            this.headsign = headsign;
            this.routeId = routeId;
            this.scheduledTripStartTime = scheduledTripStartTime;
            this.tripId = tripId;
            this.status = status;
            this.theoreticalTime = theoreticalTime;
            this.timestamp = timestamp;
            this.trip = trip;
            this.vehicleCode = vehicleCode;
            this.vehicleId = vehicleId;
            this.vehicleService = vehicleService;

        }
    }
}
