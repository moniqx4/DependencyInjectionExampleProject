namespace PageObjects.WebKiosk
{
    public interface IWebKioskDetails
    {
        IWebKioskDetails SetRecentActivityCheckbox(bool isEnabled);

        IWebKioskDetails SetTimeCorrectionCheckbox(bool isEnabled);
    }
}