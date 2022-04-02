using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaEliteDangerousHelperPlugin.VA
{
    public class vaColor
    {
        private static string[] _colors={"blank","red","blue","green","yellow","orange","purple","black","gray","pink"};

        public enum Color
        { 
            Blank =0,
            Red,
            Blue,
            Green,
            Yellow,
            Orange,
            Purple,
            Black,
            Gray,
            Pink
        }
        public static string GetColor(Color value)
        {
            return _colors[(int)value];
        }
    }
}
