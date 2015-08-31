using System;
using System.Collections.Generic;
using System.Text;

namespace EdsACPlugin
{
    class GameData
    {
        // This class should only ever be updated when the 
        // game's data changes.
        

        private void LoadData()
        {
            Console.WriteLine("foo");
        }

        public GameData()
        {
            LoadData();
        }
    }
}
 