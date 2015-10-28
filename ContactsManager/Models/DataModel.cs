namespace ContactsManager.Models
{
    public class DataModel
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public DataModelKey Modelkey { get; set; }
    }

    public enum DataModelKey
    {
        None,
        FirstName,
        LastName,
        PostName,
        BirthDate,
        MobilePhone,
        HomePhone,
        WorkPhone,
        PersonalEmail,
        WorkEmail,
        HomeAddress,
        WorkAddress,
    }
}