using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumWebDriver.WebElements
{
    public class Elements: ReadOnlyCollection<IWebElement>
    {
        private readonly IList<IWebElement> _elements;
        public Elements(IList<IWebElement> list) 
            : base(list)
        {
            _elements = list;
        }

        public By FoundBy { get; set; }

        public bool IsEmpty => Count == 0;

        //public int Count => throw new NotImplementedException();

        //public IEnumerator<Element> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerator<IWebElement> IEnumerable<IWebElement>.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
