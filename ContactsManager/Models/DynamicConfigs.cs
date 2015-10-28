using System.Linq;

namespace ContactsManager.Models
{
    public class DynamicConfigs
    {
        public string Password { get; set; }
        public string Version { get; set; }
        public string CheckVersionUrl { get; set; }

        public static DynamicConfigs GetConfigs()
        {
            var conf=new DynamicConfigs();
            ContactsEntities db=new ContactsEntities();
            foreach (Configs configse in db.Configs.ToList())
            {
                switch (configse.ConfigKey.ToLower())
                {
                    case "password":
                        conf.Password = configse.ConfigValue;
                        break;
                    case "version":
                        conf.Version = configse.ConfigValue;
                        break;
                    case "checkversionurl":
                        conf.CheckVersionUrl = configse.ConfigValue;
                        break;
                }
            }
            return conf;
        }
    }

}