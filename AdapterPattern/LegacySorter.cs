using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CSAnim.DesignPatterns
{
    static class LegacySorter
    {
        static List<iCircle> _circles = new List<iCircle>();
        public static List<iCircle> Circles => _circles;
        public static void AddSortedItem(iCircle circle)
        {
            _circles.Add(circle);
            _circles = _circles.OrderBy(o => o.Radius).ToList();
            printList();
        }
        static void printList(){
            StringBuilder strBuilder = new StringBuilder();
            foreach(iCircle circle in _circles){
                strBuilder.Append($"{circle.Radius},");
            }
            Console.WriteLine(strBuilder);
        }
    }
}