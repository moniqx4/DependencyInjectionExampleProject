namespace DataModelLibrary
{
    public class LocatorModel
    {
        public ElementType ElementType { get; set; }

        public BaseLocatorModel BaseLocator { get; set; }        
       
    }

    public class BaseLocatorModel
    {
        public BaseLocatorModel(LocatorType locatorType, string locator)
        {
            LocatorType = locatorType;
            Locator = locator;
        }

        public LocatorType LocatorType { get; }
        public string Locator { get; }

    }
}
