using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNlaunch
{
    class Tools
    {
        private static int _ButtonPress;
        private static string _Port;
        private static string _DataFiles;

        public static string DataFiles
        {
            get
            {
                return _DataFiles;
            }
            set
            {
                _DataFiles = value;
            }
        }

        public static string Port
        {
            get
            {
                return _Port;
            }
            set
            {
                _Port = value;
            }
        }

        public static int ButtonPress
        {
            get
            {
                return _ButtonPress;
            }
            set
            {
                _ButtonPress = value;
            }
        }

        public static string FixPath(string localname)
        {
            if (localname.EndsWith(@"\"))
            {
                return localname;
            }
            return localname + @"\";
        }

        public static string GetWadTitle(string wadname)
        {
            //This just resturns the games title from a given wad
            switch (wadname.ToLower())
            {
                case "doom.wad":
                    return "Ultimate Doom";
                case "doom1.wad":
                    return "Ultimate Doom, shareware";
                case "doomu.wad":
                    return "Ultimate Doom";
                case "doom2.wad":
                    return "Doom 2: Hell On Earth";
                case "tnt.wad":
                    return "Final Doom: TNT Evilution";
                case "plutonia.wad":
                    return "Final Doom: The Plutonia experiment";
                case "heretic.wad":
                    return "Heretic: Shadow of the serpent riders";
                case "heretic1.wad":
                    return "Heretic: City of the Damned";
                case "hexen.wad":
                    return "Hexen: Beyond Heretic";
                case "hexdd.wad":
                    return "Hexen: Deathkings of the Dark Citadel";
                case "strife1.wad":
                    return "Strife: Quest for the sigil";
                case "freedm064.wad":
                    return "Free DM";
                case "freedm.wad":
                    return "Free DM";
                case "av.wad":
                    return "Alien Vendetta";
                case "hr.wad":
                    return "Hell Revealed";
                case "hr2.wad":
                    return "Hell Revealed II";
                case "hr2final.wad":
                    return "Hell Revealed II";
                case "mm.wad":
                    return "Memento Mori";
                case "mm11fix.wad":
                    return "MM MAP11 fix";
                case "mm2.wad":
                    return "Memento Mori II";
                case "mm2info.wad":
                    return "Memento Mori II secret";
                case "requiem.wad":
                    return "Requiem";
                case "req21fix.wad":
                    return "Requiem MAP21 fix";
                case "class_ep.wad":
                    return "Classic Episode";
                case "icarus.wad":
                    return "Icarus";
                case "pl2.wad":
                    return "Plutonia 2";
                default:
                    //Return default filename
                    return wadname.ToLower();
            }
        }
    }
}
