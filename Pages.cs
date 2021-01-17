namespace DependencyInjectionExampleProject
{
    public class Pages : IPages
    {
        private IEmployeeDashboard _employeeDashboard;
        private IPunchComponent _punchComponent;       

        public Pages(IEmployeeDashboard employeeDashboard, IPunchComponent punchComponent)
        {
            _employeeDashboard = employeeDashboard;
            _punchComponent = punchComponent;
            //_employeeDashboardV2 = employeeDashboardV2;
        }

        public void GetPages()
        {
           _employeeDashboard.GetEmployeeDashboard();    

           _punchComponent.GetPunchcomponent();
           
        }
    }
}
