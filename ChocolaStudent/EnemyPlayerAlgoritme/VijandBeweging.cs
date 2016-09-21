using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyPlayerAlgoritme
{
    public class VijandBeweging
    {
        public bool eersteZet = true;
        bool[,] bord;
        bool[,] bordVorigeSpeler;
        int countPrev = 0;
        int countCurrent = 0;
        int aantalGegeten = 0;
        int sizeX;
        int sizeY;

        public int RandomBeweging()
        {
            if(eersteZet == true)
            {
                eersteZet = false;
                return 1;
            }
            else
            {
                return aantalGegeten;
            }
        }

        public VijandBeweging(bool[,] _bord, int _sizeX, int _sizeY)
        {
            bordVorigeSpeler = bord;
            bord = _bord;
            foreach (var item in bordVorigeSpeler)
            {
                if (item == true)
                {
                    countPrev++;
                }
            }
            foreach (var item in _bord)
            {
                if (item == true)
                {
                    countCurrent++;
                }
            }
            aantalGegeten = countPrev - countCurrent;

            sizeX = _sizeX;
            sizeY = _sizeY;
        }

    }
}
