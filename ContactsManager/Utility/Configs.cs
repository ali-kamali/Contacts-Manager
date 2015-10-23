using System.Collections.Generic;

namespace ContactsManager.Utility
{
    public static class Configs
    {
       public static object[] CallType = {"شماره همراه",
            "شماره خانه",
            "شماره دفتر"};
       public static object[] EmailType = {"شخصی",
            "کاری"};
       public static object[] AddressType = {"منزل",
            "دفتر کار"};

       public static List<DataModel> DataModels=new List<DataModel>()
       {
           new DataModel(){ModelId = 1,ModelName = "نام"},
           new DataModel(){ModelId = 1,ModelName = "نام خانوادگی"}
       }; 
    }

    public class DataModel
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
    }
}