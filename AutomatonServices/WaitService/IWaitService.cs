namespace AutomationServices.WaitService
{
    public interface IWaitService
    {
        void PauseBetweenPunches();

        void SetCustomWaitTime(int milliseconds);

        void SetWaitByStrategy();  // this would be an enum to select strategies for examp, PageLoad, or element display, or whatever the current built in strategy doesn't cover


    }
}
