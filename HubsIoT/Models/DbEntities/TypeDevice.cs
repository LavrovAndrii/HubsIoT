using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HubsIoT.Models.DbEntities
{
    public class TypeDevice
    {
        public int Id { get; set; }
        public string NameTypeDevice { get; set; }
        public int InternetModuleId { get; set; }
        public string Description { get; set; }
        public string ExampleSketchFilePath { get; set; }
        public string ExampleSketchFileName { get; set; }
        public int AvailableAnalogPortId { get; set; }
        public int  AvaibleDigitalPortId { get; set; }

    }
}