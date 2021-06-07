using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationServices.SharedServices.ValidationServices
{
        public static class StyleAssertions
        {
            public static void AssertBackgroundColor(this Component element, string expectedBackgroundColor)
            {
                Assert.AreEqual(expectedBackgroundColor, element.GetCssValue("background-color"));
            }

            public static void AssertBorderColor(this Component element, string expectedBorderColor)
            {
                Assert.AreEqual(expectedBorderColor, element.GetCssValue("border-color"));
            }

            public static void AssertColor(this Component element, string expectedColor)
            {
                Assert.AreEqual(expectedColor, element.GetCssValue("color"));
            }

            public static void AssertFontFamily(this Component element, string expectedFontFamily)
            {
                Assert.AreEqual(expectedFontFamily, element.GetCssValue("font-family"));
            }

            public static void AssertFontWeight(this Component element, string expectedFontWeight)
            {
                Assert.AreEqual(expectedFontWeight, element.GetCssValue("font-weight"));
            }

            public static void AssertFontSize(this Component element, string expectedFontSize)
            {
                Assert.AreEqual(expectedFontSize, element.GetCssValue("font-size"));
            }

            public static void AssertTextAlign(this Component element, string expectedTextAlign)
            {
                Assert.AreEqual(expectedTextAlign, element.GetCssValue("text-align"));
            }

            public static void AssertVerticalAlign(this Component element, string expectedVerticalAlign)
            {
                Assert.AreEqual(expectedVerticalAlign, element.GetCssValue("vertical-align"));
            }
        }    
}
