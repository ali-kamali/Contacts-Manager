using System.Collections.Generic;
using ContactsManager.Models;

namespace ContactsManager.Utility
{
    public static class MyConfigs
    {
        public static object[] CallType =
        {
            "شماره همراه",
            "شماره خانه",
            "شماره دفتر"
        };

        public static object[] EmailType =
        {
            "شخصی",
            "کاری"
        };

        public static object[] AddressType =
        {
            "منزل",
            "دفتر کار"
        };

        public static List<DataModel> DataModels = new List<DataModel>()
        {
            new DataModel() {ModelId = 0, Modelkey = DataModelKey.None, ModelName = "--"},
            new DataModel() {ModelId = 1, Modelkey = DataModelKey.FirstName, ModelName = "نام"},
            new DataModel() {ModelId = 2, Modelkey = DataModelKey.LastName, ModelName = "نام خانوادگی"},
            new DataModel() {ModelId = 3, Modelkey = DataModelKey.PostName, ModelName = "سمت"},
            new DataModel() {ModelId = 4, Modelkey = DataModelKey.BirthDate, ModelName = "تاریخ تولد"},
            new DataModel() {ModelId = 5, Modelkey = DataModelKey.MobilePhone, ModelName = "شماره همراه"},
            new DataModel() {ModelId = 6, Modelkey = DataModelKey.HomePhone, ModelName = "شماره خانه"},
            new DataModel() {ModelId = 7, Modelkey = DataModelKey.WorkPhone, ModelName = "شماره دفتر"},
            new DataModel() {ModelId = 8, Modelkey = DataModelKey.PersonalEmail, ModelName = "رایانامه شخصی"},
            new DataModel() {ModelId = 9, Modelkey = DataModelKey.WorkEmail, ModelName = "رایانامه کاری"},
            new DataModel() {ModelId = 10, Modelkey = DataModelKey.HomeAddress, ModelName = "آدرس منزل"},
            new DataModel() {ModelId = 11, Modelkey = DataModelKey.WorkAddress, ModelName = "آدرس محل کار"},
        };

        public static string DbPassword = "BrA73S@yXn3mZ";
        public static string AppVersion = "v1.0";
        public static bool IsDbPassActive = true;
        public static bool IsAppPassActive = true;
    }
}