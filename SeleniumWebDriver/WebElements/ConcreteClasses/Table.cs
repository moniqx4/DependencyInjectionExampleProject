using DataModelLibrary;
using NLog;
using SeleniumWebDriver.Extensions;
using SeleniumWebDriver.Type;
using LocatorType = DataModelLibrary.LocatorType;

namespace SeleniumWebDriver.WebElements
{   

    public class Table
    {

        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        //private static readonly NLog.Logger Logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger(); .netcore3.x
    
        private readonly ILocatorBuilder _locatorBuilder;

        public Table(ILocatorBuilder locatorBuilder)
        {           
            _locatorBuilder = locatorBuilder;
        }

        /// <summary>
        /// Returns a text representation of the grid or table html like element.
        /// </summary>
        /// <param name="rowLocator">The row locator.</param>
        /// <param name="columnLocator">The column locator.</param>
        /// <returns>
        /// Text representation of the grid or table html like element.
        /// </returns>
        public string[][] GetTable(ElementLocator rowLocator, ElementLocator columnLocator, LocatorModel locatorModel)
        {
            var table = _locatorBuilder.BuildLocator(locatorModel);
            var rows = table.GetElements(rowLocator);

            var result = new string[rows.Count][];
            var i = 0;

            foreach (var row in rows)
            {
                var cells = row.GetElements(columnLocator);
                result[i] = new string[cells.Count];

                var j = 0;
                foreach (var cell in cells)
                {
                    var cellValue = cell.Text;
                    Logger.Debug("Table cell Row {0}, column {1}, Value: {2}", i, j, cellValue);
                    result[i][j++] = cellValue;
                }

                i++;
            }

            return result;
        }

        /* ----- Multiple locators methods -----*/
    }
}
