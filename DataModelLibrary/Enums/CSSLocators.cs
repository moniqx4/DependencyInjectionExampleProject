namespace DataModelLibrary.Enums
{
    public enum CSSLocators
    {
        ByTitle,
        ByChecked,
        ByType,
        ByFocus,
        ByPFirstChild,
        ByPLastChild,
        ByListFirstChild,
        ByListLastChild,
        ByDisabled,
        ByEnabled,
        ByLanguage,
        ByEmpty,
        ByParagraphFirstLine,
        ByTypeOnlyChild, //b:only-child, pass in type(b)
        ByTypeNthChild, //li:nth-child(1), pass in type and value of child        
        ByTypeNthLastChild, //li:nth-last-child(1), pass in type and value of child
        ByTypeNthChildEven, //li:nth-child(even), pass in type , Selects all even <type> elements.
        ByTypeNthChildOdd, //li:nth-child(odd), pass in type , Selects all even <type> elements.
        ByFirstLetter, //p::first-letter, pass in the type, Selects the first letter of all <p> elements.
        ByFirstOfType, //p:first-of-type, pass in type, Selects all <p> elements that are the first <p> element of their parent.
        ByValidInput, //input: valid
        ByInvalidInput, ///input: invalid
        ByInputInRange, //input:in-of-range
        ByInputOutOfRange, //input:out-of-range,  Selects all <input> elements with a max and/or min value, where the value is outside the specific range.
        ByTypeHover, //h1:hover
        ByParentElementAndTag, // div > p , Selects all <p> elements where the parent is a <div> element.
        ByNextToElement, // ul + p, Selects all <p> elements that are next to <ul> elements.
        ByClassWithElement, // .intro, #Lastname Selects all elements with class="intro", and the element with id="Lastname"
        ByTableList, // ul ~ table, Selects all <table> elements that are siblings of a <ul> element.
        ByAttributeEndingWith, //[id$={value} Selects all elements with an id attribute value ending with "ess", pass in element, and sttribute value
        ByAttributeStartingWith, //[id^={value} Selects all elements with an id attribute value ending with "ess", pass in element, and sttribute value
        ByAttributeEqualToOrStartingWith, // [id| =my] , Selects all elements with an id attribute value equal to "my" or starting with "my" followed by a hyphen (-)
        //By

    }
}
