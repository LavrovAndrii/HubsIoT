using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HubsIoT.Models.DbEntities
{
    public class AvaibleAnalogPort
    {
        public int Id { get; set; }
        public string NameAnalogPort { get; set; }
        public bool Enabling { get; set; }
    }
}   