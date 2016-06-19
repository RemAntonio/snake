using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
    {
    class VerticalLine
        {
        List<Point> pList2;

        public VerticalLine ( int yTop, int yDown, int x, char sym )
            {
            pList2 = new List<Point>();
            for ( int y = yTop ; y <= yDown ; y++ )
                {
                Point p2 = new Point( x, y, sym );
                pList2.Add( p2 );
                }

            }
        public void Drow ( )
            {
            foreach ( Point p2 in pList2 )
                {
                p2.Draw();
                }
            }
        }
    }
