using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharpLaba2
{
    internal interface IGenerateListsClass
    {
        List<int> GenerateList();
        LinkedList<int> GenerateLinkedList();
    }
}
