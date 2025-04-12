using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingCSharpLaba2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            GenerateClass gc = new GenerateClass();
            int[] array = gc.GenerateIntArray();
            int ch, nch = 0;
            foreach (int i in array)
            {
                
            }
            //UsingListAndLinkedList();
            Console.WriteLine("Complite");
        }

        public static void UsingListAndLinkedList()
        {
            DateTime dtStart = DateTime.Now;
            List<int> list = new List<int>();
            LinkedList<int> linked = new LinkedList<int>();
            GenerateClass glc = new GenerateClass();
            SortedListsClass slc = new SortedListsClass();
            list = glc.GenerateList();
            DateTime dtList = DateTime.Now;
            Console.WriteLine("Generate List: " + (dtList - dtStart));
            linked = glc.GenerateLinkedList();
            DateTime dtLinkedList = DateTime.Now;
            Console.WriteLine("Generate LinkedList: " + (dtLinkedList - dtList));
            //await OutputToFile(list, "List.txt");
            //await OutputToFile(linked, "LinkedList.txt");
            DateTime dtEndGenerate = DateTime.Now;
            Console.WriteLine();
            slc.SortList1(list);
            Console.WriteLine(DateTime.Now - dtEndGenerate);
            slc.SortList2(list);
            DateTime dtSortList = DateTime.Now;
            Console.WriteLine("Sort List: " + (dtSortList - dtEndGenerate));
            slc.SortLinkedList1(linked);
            Console.WriteLine(DateTime.Now - dtSortList);
            slc.SortLinkedList(linked);
            DateTime dtSortLinkedList = DateTime.Now;
            Console.WriteLine("Sort LinkedList: " + (dtSortLinkedList - dtSortList));
            //await OutputToFile(list, "SortedList.txt");
            //await OutputToFile(linked, "SortedLinkedList.txt");
        }

        public static async Task OutputToFile(List<int> list, string pat)
        {
            string result = "";
            foreach (int i in list)
            {
                result += i.ToString() + "   ";
            }
            string path = @"C:\Users\Sssof\source\repos\Labacsharp1.1\" + pat;
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                await writer.WriteLineAsync(result);
            }
        }

        public static async Task OutputToFile(LinkedList<int> list, string pat)
        {
            string result = "";
            string path = @"C:\Users\Sssof\source\repos\Labacsharp1.1\" + pat;
            foreach (int i in list)
            {
                result += i.ToString() + "   ";
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                await writer.WriteLineAsync(result);
            }
        }
    }
}
