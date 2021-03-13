using System.Collections.Generic;

namespace PageObjects.Shared
{
    public class CommonTasks
    {

        public CommonTasks()
        {

        }

        public static bool DoesListContain(List<T> dataList, T chkValue) => dataList.Contains(chkValue);
      

    }

    public delegate void T();
}
