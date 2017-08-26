using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HubsIoT.Models.DbEntities
{
    public class AvaibleDigitalPort
    {
        public int Id { get; set; }
        public string NameDigitalPort { get; set; }
        public bool Enabling { get; set; }
    }
}