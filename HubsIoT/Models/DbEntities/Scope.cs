using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HubsIoT.Models.DbEntities
{
    public class Scope
    {
        public int Id { get; set; }
        public string NameScope { get; set; }
        public int UserId { get; set; }
        public int ProtocolId { get; set; }
        public int DeviceId { get; set; }
        
    }
}