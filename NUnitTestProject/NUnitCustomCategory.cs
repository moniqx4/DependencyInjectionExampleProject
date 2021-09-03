using NUnit.Framework;
using System;

namespace NUnitTestProject
{
    
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    class EEDashboardAttribute: CategoryAttribute
    {
    }
    
}
