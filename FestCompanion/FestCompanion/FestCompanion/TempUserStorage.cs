using System;
using System.Collections.Generic;
using System.Text;

namespace FestCompanion
{
    public class Concert
    {
        public string Artist { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string When { get; set; }
    }

    public class Stage
    {
        public string Text { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public Concert[] Concerts { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
    }

    public static class TempUserStorage
    {
        public static List<Stage> stages = new List<Stage>();
    }

}
