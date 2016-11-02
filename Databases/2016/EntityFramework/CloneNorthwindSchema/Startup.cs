using Northwind.Data;
using System;
using System.Configuration;
using System.Data.Entity;

namespace CloneNorthwindSchema
{
    public class Startup
    {
        public static void Main()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings connectionStringSettings =
                    new ConnectionStringSettings("NorthwindEntities",
                   @"metadata=res://*/NorthwindModel.csdl|res://*/NorthwindModel.ssdl|res://*/NorthwindModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=NorthwindTwin;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;", "System.Data.EntityClient");

            ConnectionStringsSection connectionStringSection = config.ConnectionStrings;
            connectionStringSection.ConnectionStrings.Add(connectionStringSettings);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);

            using (var northwindEntities = new NorthwindEntities())
            {
                var result = northwindEntities.Database.CreateIfNotExists();
                Console.WriteLine(result);
            }
        }
    }
}
