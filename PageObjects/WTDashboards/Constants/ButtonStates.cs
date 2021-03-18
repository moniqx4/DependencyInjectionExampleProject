using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjects.WTDashboards.Constants
{
    public class ButtonStates
    {
        public string PunchState { get; set; }
        public string ButtonState1 { get; set; }
        public string ButtonState2 { get; set; }

        public string ButtonState3 { get; set; }

        public string ButtonState4 { get; set; }
    }



    public static class ButtonStateColl
    {
        public static readonly ButtonStates[] Items = new ButtonStates[] {
                new ButtonStates { PunchState="ClockIn", ButtonState1="ClockOut", ButtonState2="StartLunch", ButtonState3="EndLunch", ButtonState4="" },
                new ButtonStates { PunchState="ClockOut", ButtonState1="ClockIn", ButtonState2="Movies", ButtonState3="", ButtonState4="" },
                new ButtonStates { PunchState="StartLunch", ButtonState1="ClockIn", ButtonState2="Movies", ButtonState3="", ButtonState4="" },
                new ButtonStates { PunchState="EndLunch", ButtonState1="ClockIn", ButtonState2="Movies", ButtonState3="", ButtonState4="" },
                new ButtonStates { PunchState="StartBreak", ButtonState1="", ButtonState2="Movies", ButtonState3="", ButtonState4="" },
                new ButtonStates { PunchState="EndBreak", ButtonState1="", ButtonState2="Movies", ButtonState3="", ButtonState4="" }
              };
    }

    //var totalButtons = ButtonStateColl.Items.Where(b => b.PunchState == "ClockIn");
}
