namespace DataModelLibrary
{
    public class LocatorModel
    {

        public LocatorModel(LocatorType locatorType, string locator, ElementType? elementType)
        {
            LocatorType = locatorType;
            Locator = locator;
            ElementType = elementType;
        }

        public LocatorType LocatorType { get; }
        public string Locator { get; }
        public ElementType? ElementType { get; }
    }
}
