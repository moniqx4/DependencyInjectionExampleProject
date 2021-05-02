namespace DataModelLibrary
{
    public class LocatorModel
    {
        public ElementType ElementType { get; set; }

        public BaseLocatorModel BaseLocator { get; set; }        
       
    }

    public class BaseLocatorModel
    {
        public LocatorType LocatorType { get; set; }
        public string Locator { get; set; }

    }
}
