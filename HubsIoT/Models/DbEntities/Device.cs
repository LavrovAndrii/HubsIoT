using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HubsIoT.Models.DbEntities
{
    public class Device
    {
        public int  Id { get; set; }
        public string NameDevice { get; set; }
        public int TypeDeviceId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}