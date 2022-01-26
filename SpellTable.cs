using System;
using System.Collections.Generic;
using System.Text;

namespace EdsACPlugin
{
    public class Spells
    {

        // Note: the only way spells can work is by int, string... otherwise, there are 
        // duplicates in the spell table that will overwrite the string, and the wrong ID for
        // the spell will be returned.  Only the ID integer is guaranteed to be unique.

        public static Dictionary<int, string> byID = new Dictionary<int, string>();

        public Spells() { 
            var path = "C:/Users/ekozl/plugins/EdsACPlugin/spells.csv";
            var csvRows = System.IO.File.ReadAllLines(path, Encoding.Default);
            int index = 0;
            foreach (var row in csvRows)
            {
                if(index == 0)
                {
                    index += 1;
                    continue;
                }
                var columns = row.Split(',');
                int id = int.Parse(columns[0]);
                string spellName = columns[1];
                spellName = spellName.Replace("\"", String.Empty);
                byID.Add(id, spellName);
            }
        }

        public List<int> getByString(string s)
        {
            var list = new List<int>();
            foreach(KeyValuePair<int, string> entry in byID)
            {
                if (entry.Value.IndexOf(s) != -1)
                {
                    list.Add(entry.Key);
                }
            }
            return list;
        }

        public string getByID(int id)
        {
            return byID[id];
        }
    }
}