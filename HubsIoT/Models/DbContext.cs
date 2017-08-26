using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HubsIoT.Models.DbEntities;

namespace HubsIoT.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Device> Devices { set; get; }
        public DbSet<InternetModule> InternetModules { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Scope> Scopes { get; set; }
        public DbSet<TypeDevice> TypeDevices { get; set; }
        public DbSet<AvaibleAnalogPort> AvaibleAnalogPorts { get; set; }
        public DbSet<AvaibleDigitalPort> AvaibleDigitalPorts { get; set; }
    }
}