using System.ComponentModel;


namespace AutomationServices.SharedServices.ValidationServices
{
        public static class StyleAssertions
        {
            public static void AssertBackgroundColor(this Component element, string expectedBackgroundColor)
            {                
                element.AssertBackgroundColor(expectedBackgroundColor);
            }

            public static void AssertBorderColor(this Component element, string expectedBorderColor)
            {
               
                element.AssertBorderColor(expectedBorderColor);
            }

            public static void AssertColor(this Component element, string expectedColor)
            {               
                element.AssertColor(expectedColor);
            }

            public static void AssertFontFamily(this Component element, string expectedFontFamily)
            {                
                element.AssertFontFamily(expectedFontFamily);
            }

            public static void AssertFontWeight(this Component element, string expectedFontWeight)
            {
                element.AssertFontWeight(expectedFontWeight);
            }

            public static void AssertFontSize(this Component element, string expectedFontSize)
            {
                element.AssertFontSize(expectedFontSize);
            }

            public static void AssertTextAlign(this Component element, string expectedTextAlign)
            {
                element.AssertTextAlign(expectedTextAlign);
            }

            public static void AssertVerticalAlign(this Component element, string expectedVerticalAlign)
            {               
                element.AssertVerticalAlign(expectedVerticalAlign);
            }
        }    
}
