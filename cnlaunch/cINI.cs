//A simple INI class for C# by Ben Jones

// Filename the ini file you want to open
// SetValue sets a new ini key value
// GetValue gets a keys value
// DeleteSelection will delete a selection includeing keys and values
// DeleteKey will delete a key and it's value
// GetSelections will return selections names into an arraylist

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections;

namespace INIReader
{
    public class cINI
    {
        private static string _Filename;

        public static string INIFilename
        {
            get
            {
                return _Filename;
            }
            set
            {
                _Filename = value;
            }
        }

        [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section,
            string key, string val, string Filename);

        [DllImport("kernel32")]
            private static extern long GetPrivateProfileString(string section,
            string key, string DefaultValue, StringBuilder retVal,
            int size, string Filename);

        public string GetValue(string Selection, string KeyName, string DefaultValue)
        {
            //Read INI value
            long RetVal;
            //Create buffer to hold value
            StringBuilder str = new StringBuilder(260);
            //Get value form ini file
            RetVal = GetPrivateProfileString(Selection, KeyName, DefaultValue, str, 260, INIFilename);
            //Return the string
            return str.ToString();
        }

        public long SetValue(string Selection, string KeyName, string KeyValue)
        {
            //Write new value to ini file
            return WritePrivateProfileString(Selection, KeyName, KeyValue, INIFilename);
        }

        public long DeleteSelection(string Selection)
        {
            //Delete a selection form ini
            return WritePrivateProfileString(Selection, null, null, INIFilename);
        }

        public long DeleteKey(string Selection, string KeyName)
        {
            //Deletes a key and it's value
            return WritePrivateProfileString(Selection, KeyName, null, INIFilename);
        }

        public ArrayList GetSelections()
        {
            string sline = "";
            ArrayList list = new ArrayList();

            StreamReader sr = new StreamReader(INIFilename);

            while (sline != null)
            {
                sline = sr.ReadLine();
                //Read while we no null
                if (sline != null)
                {   //Check for a vaild length
                    if (Convert.ToBoolean(sline.Length))
                    {
                        //Check for opening bracket [
                        if (sline.Substring(0, 1) == "[")
                        {
                            //Check for closeing bracket ]
                            if (sline.Substring(sline.Length - 1, 1) == "]")
                            {
                                //Extract the selection name and add to the arraylist
                                list.Add(sline.Substring(1, sline.Length - 2));
                            }
                        }
                    }
                }
            }
            return list;
            // sr.Close();
        }
    }
}
