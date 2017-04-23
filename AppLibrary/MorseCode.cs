using System.Collections.Generic;

namespace AppLibrary
{
    public class MorseCode
    {
        public static readonly Dictionary<char, List<Sound>> morseCode = new Dictionary<char, List<Sound>>()
        {
            { 'A', new List<Sound>(){ Sound.Dot, Sound.Dash} },
            { 'B', new List<Sound>(){ Sound.Dash, Sound.Dot, Sound.Dot, Sound.Dot } },
            { 'C', new List<Sound>(){ Sound.Dash, Sound.Dot, Sound.Dash, Sound.Dot } },
            { 'D', new List<Sound>(){ Sound.Dash, Sound.Dot, Sound.Dot} },
            { 'E', new List<Sound>(){ Sound.Dot} },
            { 'F', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dash, Sound.Dot } },
            { 'G', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dot } },
            { 'H', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dot, Sound.Dot } },
            { 'I', new List<Sound>(){ Sound.Dot, Sound.Dot } },
            { 'J', new List<Sound>(){ Sound.Dot, Sound.Dash, Sound.Dash, Sound.Dash } },
            { 'K', new List<Sound>(){ Sound.Dash, Sound.Dot, Sound.Dash } },
            { 'L', new List<Sound>(){ Sound.Dot, Sound.Dash, Sound.Dot, Sound.Dot } },
            { 'M', new List<Sound>(){ Sound.Dash, Sound.Dash } },
            { 'N', new List<Sound>(){ Sound.Dash, Sound.Dot } },
            { 'O', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dash } },
            { 'P', new List<Sound>(){ Sound.Dot, Sound.Dash, Sound.Dash , Sound.Dot } },
            { 'Q', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dot, Sound.Dash } },
            { 'R', new List<Sound>(){ Sound.Dot, Sound.Dash, Sound.Dot } },
            { 'S', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dot} },
            { 'T', new List<Sound>(){ Sound.Dash } },
            { 'U', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dash } },
            { 'V', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dot, Sound.Dash } },
            { 'W', new List<Sound>(){ Sound.Dot, Sound.Dash, Sound.Dash } },
            { 'X', new List<Sound>(){ Sound.Dash, Sound.Dot, Sound.Dot, Sound.Dash } },
            { 'Y', new List<Sound>(){ Sound.Dash, Sound.Dot, Sound.Dash, Sound.Dash } },
            { 'Z', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dot, Sound.Dot } },
            { '0', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dash, Sound.Dash, Sound.Dash }  },
            { '1', new List<Sound>(){ Sound.Dot, Sound.Dash, Sound.Dash, Sound.Dash, Sound.Dash }  },
            { '2', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dash, Sound.Dash, Sound.Dash }  },
            { '3', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dot, Sound.Dash, Sound.Dash }  },
            { '4', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dot, Sound.Dot, Sound.Dash }  },
            { '5', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dot, Sound.Dot, Sound.Dot }  },
            { '6', new List<Sound>(){ Sound.Dash, Sound.Dot, Sound.Dot, Sound.Dot, Sound.Dot }  },
            { '7', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dot, Sound.Dot, Sound.Dot }  },
            { '8', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dash, Sound.Dot, Sound.Dot }  },
            { '9', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dash, Sound.Dash, Sound.Dot }  },
            { '.', new List<Sound>(){ Sound.Dot, Sound.Dash, Sound.Dot, Sound.Dash, Sound.Dot, Sound.Dash }  },
            { ',', new List<Sound>(){ Sound.Dash, Sound.Dash, Sound.Dot, Sound.Dot, Sound.Dash, Sound.Dash }  },
            { '?', new List<Sound>(){ Sound.Dot, Sound.Dot, Sound.Dash, Sound.Dash, Sound.Dot, Sound.Dot }  },
        };
    }
}