using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharpLaba2
{
    internal class GenerateListsClass: IGenerateListsClass
    {
        Random rnd = new Random();
        public List<int> GenerateList()
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 1000000; i++)
            {
                list.Add(rnd.Next(-100, 100));
            }
            return list;
        }

        public LinkedList<int> GenerateLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < 1000000; i++)
            {
                list.AddLast(rnd.Next(-100, 100));
            }
            return list;
        }
    }
}
