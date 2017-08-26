using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HubsIoT.Models.DbEntities
{
    public class Protocol
    {
        public int Id { get; set; }
        public string NameProtocol { get; set; }
        public string Client { get; set; }
        public string Server { get; set; }
        public string Port { get; set; }
    }
}