﻿using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public interface ICheckBox
    {

        ICheckBox ClickCheckBox(LocatorModel locatorModel);

        ICheckBox ClickCheckBox(LocatorModel locatorModel, bool isEnabled);

        bool IsCheckboxChecked(LocatorModel locatorModel);

        bool IsCheckboxEnabled(LocatorModel locatorModel);

    }
}