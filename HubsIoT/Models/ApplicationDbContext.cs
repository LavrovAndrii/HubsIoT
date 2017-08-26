using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HubsIoT.Models.DbEntities;

namespace HubsIoT.Models
{
    public class ScopeDbContext : DbContext
    {
        public DbSet<Device> Devices { set; get; }
        public DbSet<InternetModule> InternetModules { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Scope> Scopes { get; set; }
        public DbSet<TypeDevice> TypeDevices { get; set; }
        public DbSet<AvaibleAnalogPort> AvaibleAnalogPorts { get; set; }
        public DbSet<AvaibleDigitalPort> AvaibleDigitalPorts { get; set; }
    }

    public class ScopeDbInitializer : DropCreateDatabaseAlways<ScopeDbContext>
    {
        protected override void Seed(ScopeDbContext db)
        {
          //  db.Devices.Add(new Device {NameDevice = "Arduino Uno R3", TypeDeviceId = 1, });
        }
    }

    public class ApplicationDbInitializer : DropCreateDatabaseAlways<ScopeDbContext>
    {
        protected override void Seed(ScopeDbContext db)
        {
            //  db.Devices.Add(new Device {NameDevice = "Arduino Uno R3", TypeDeviceId = 1, });
        }
    }
}   