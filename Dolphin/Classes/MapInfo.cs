using SharpDX;
using System;
using System.Text.RegularExpressions;

using static Dolphin.Classes.GlobalVariables;
using static hazedumper.signatures;

namespace Dolphin.Classes
{
    class MapInfo
    {
        public struct map
        {
            public Vector2 topLeft;
            public Vector2 bottomRight;
        }

        public static string[] mapnames = { "cache", "cbble", "dust2", "inferno", "mirage", "nuke", "overpass", "season", "train" };

        public static string fixMapName(string currentMapName)
        {
            foreach (string name in mapnames)
                if (currentMapName == name)
                    return name;
                else if (currentMapName.Contains(name) && currentMapName != name)
                    return name;
            return "unknown";
        }

        public static System.Drawing.Bitmap getCurrentMapImage(string currentMap)
        {
            switch (currentMap)
            {
                case "cache":
                    return Properties.Resources.cache;
                case "cbble":
                    return Properties.Resources.cbble;
                case "dust2":
                    return Properties.Resources.dust2;
                case "inferno":
                    return Properties.Resources.inferno;
                case "mirage":
                    return Properties.Resources.mirage;
                case "nuke":
                    return Properties.Resources.nuke;
                case "overpass":
                    return Properties.Resources.overpass;
                case "season":
                    return Properties.Resources.season;
                case "train":
                    return Properties.Resources.train;
                default:
                    return Properties.Resources.unknown;
            }
        }

        public static string getCurrentMapName(ProcessMemory Mem)
        {
            byte[] mapnamedata = new byte[32];

            int clientState = Mem.ReadInt(dwEngine + dwClientState);
            mapnamedata = Mem.ReadMem(clientState + dwClientState_Map, 256);

            Regex rgx = new Regex("[^a-zA-Z0-9 _-]");

            var currentmapname = System.Text.ASCIIEncoding.Default.GetString(mapnamedata);

            currentmapname = rgx.Replace(currentmapname, "");

            int index = currentmapname.IndexOf('\0');

            if (index > 0)
                currentmapname = currentmapname.Substring(0, index);

            index = currentmapname.IndexOf("dss");

            if (index > 0)
                currentmapname = currentmapname.Substring(0, index);

            currentmapname = currentmapname.Replace("de_", "");
            currentmapname = currentmapname.Replace("e_", "");
            currentmapname = currentmapname.Replace("dmg_", "");
            currentmapname = currentmapname.Replace("ar_", "");
            currentmapname = currentmapname.Replace("coop_", "");
            currentmapname = currentmapname.Replace("cs_", "");
            currentmapname = currentmapname.Replace("gd_", "");
            currentmapname = currentmapname.Replace("training1_", "");
            
            currentmapname = fixMapName(currentmapname);

            return currentmapname;
        }

        public static map getCurrentMapInfo(string mapname)
        {
            switch (mapname)
            {
                case "cache":
                    return cache;
                case "cbble":
                    return cbble;
                case "dust2":
                    return dust2;
                case "inferno":
                    return inferno;
                case "mirage":
                    return mirage;
                case "nuke":
                    return nuke;
                case "overpass":
                    return overpass;
                case "season":
                    return season;
                case "train":
                    return train;
                default:
                    return unknown;
            }
        }

        public static map cache
        {
            get
            {
                map temp;
                temp.topLeft.X = -1950;
                temp.topLeft.Y = 3150;
                temp.bottomRight.X = 3600;
                temp.bottomRight.Y = -2400;
                return temp;
            }
        }

        public static map cbble
        {
            get
            {
                map temp;
                temp.topLeft.X = -3700;
                temp.topLeft.Y = 2950;
                temp.bottomRight.X = 2300;
                temp.bottomRight.Y = -3000;
                return temp;
            }
        }

        public static map dust2
        {
            get
            {
                map temp;
                temp.topLeft.X = -2395;
                temp.topLeft.Y = 3370;
                temp.bottomRight.X = 2070;
                temp.bottomRight.Y = -1080;
                return temp;
            }
        }

        public static map inferno
        {
            get
            {
                map temp;
                temp.topLeft.X = -2000;
                temp.topLeft.Y = 3850;
                temp.bottomRight.X = 2950;
                temp.bottomRight.Y = -1200;
                return temp;
            }
        }

        public static map mirage
        {
            get
            {
                map temp;
                temp.topLeft.X = -3220;
                temp.topLeft.Y = 1760;
                temp.bottomRight.X = 1850;
                temp.bottomRight.Y = -3450;
                return temp;
            }
        }

        public static map nuke
        {
            get
            {
                map temp;
                temp.topLeft.X = -3450;
                temp.topLeft.Y = 2950;
                temp.bottomRight.X = 3680;
                temp.bottomRight.Y = -4450;
                return temp;
            }
        }

        public static map overpass
        {
            get
            {
                map temp;
                temp.topLeft.X = -4780;
                temp.topLeft.Y = 1820;
                temp.bottomRight.X = 440;
                temp.bottomRight.Y = -3640;
                return temp;
            }
        }

        public static map season
        {
            get
            {
                map temp;
                temp.topLeft.X = 0;
                temp.topLeft.Y = 0;
                temp.bottomRight.X = 0;
                temp.bottomRight.Y = 0;
                return temp;
            }
        }

        public static map train
        {
            get
            {
                map temp;
                temp.topLeft.X = -2430;
                temp.topLeft.Y = 2430;
                temp.bottomRight.X = 2290;
                temp.bottomRight.Y = -2470;
                return temp;
            }
        }

        public static map unknown
        {
            get
            {
                int topLeftAverageX = (int)((cache.topLeft.X + cbble.topLeft.X + dust2.topLeft.X + inferno.topLeft.X + mirage.topLeft.X + nuke.topLeft.X + overpass.topLeft.X) / 8);
                int topLeftAverageY = (int)((cache.topLeft.Y + cbble.topLeft.Y + dust2.topLeft.Y + inferno.topLeft.Y + mirage.topLeft.Y + nuke.topLeft.Y + overpass.topLeft.Y) / 8);
                int bottomRightAverageX = (int)((cache.bottomRight.X + cbble.bottomRight.X + dust2.bottomRight.X + inferno.bottomRight.X + mirage.bottomRight.X + nuke.bottomRight.X + overpass.bottomRight.X) / 8);
                int bottomRightAverageY = (int)((cache.bottomRight.Y + cbble.bottomRight.Y + dust2.bottomRight.Y + inferno.bottomRight.Y + mirage.bottomRight.Y + nuke.bottomRight.Y + overpass.bottomRight.Y) / 8);

                map temp;
                temp.topLeft.X = topLeftAverageX;
                temp.topLeft.Y = topLeftAverageY;
                temp.bottomRight.X = bottomRightAverageX;
                temp.bottomRight.Y = bottomRightAverageY;
                return temp;
            }
        }
    }
}
