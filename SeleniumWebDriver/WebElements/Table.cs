using NLog;
using SeleniumWebDriver.Extensions;
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{   

    public class Table
    {

        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        //private static readonly NLog.Logger Logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger(); .netcore3.x
    
        private readonly Element _element;

        public Table(Element element)
        {
            element = _element;
        }

         /// <summary>
        /// Returns a text representation of the grid or table html like element.
        /// </summary>
        /// <param name="rowLocator">The row locator.</param>
        /// <param name="columnLocator">The column locator.</param>
        /// <returns>
        /// Text representation of the grid or table html like element.
        /// </returns>
        public string[][] GetTable(ElementLocator rowLocator, ElementLocator columnLocator)
        {
            var table = _element;
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
    }
}
