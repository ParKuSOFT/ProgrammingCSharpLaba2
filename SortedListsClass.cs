using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharpLaba2
{
    internal class SortedListsClass
    {
        public void SortList1(List<int> list)
        {
            if (list == null || list.Count < 2)
            {
                return; // Nothing to do for null or lists with fewer than 2 elements
            }
            int absFirstElement = Math.Abs(list[0]); // Absolute value of the first element

            for (int i = list.Count - 1; i >= 1; i--) // Iterate from the end (excluding the first element)
            {
                int absCurrentElement = Math.Abs(list[i]);

                if (absCurrentElement % absFirstElement == 0 || absFirstElement % absCurrentElement == 0)
                {
                    list.RemoveAt(i); // Remove the element if it's a multiple or a divisor of the first element
                }
            }
        }

        public void SortList2(List<int> list)
        {
            if (list == null || list.Count < 2)
            {
                return; // Nothing to do for empty or single-element lists
            }

            for (int i = 1; i < list.Count; i++)
            {
                int a = list[i - 1] % 2;
                int b = list[i] % 2;

                if (a == b) // Elements have the same parity
                {
                    list.Insert(i, 0);
                    i++; // Skip over the inserted 0 in the next iteration
                }
            }
        }

        public void SortLinkedList1(LinkedList<int> list)
        {
            int firstElement = list.First.Value; // Получаем значение первого элемента
            if (firstElement == 0)
            {
                list.Clear(); // Очищаем список, если первый элемент равен 0
                return;
            }
            LinkedListNode<int> currentNode = list.First.Next; // Начинаем со второго элемента

            while (currentNode != null)
            {
                LinkedListNode<int> nextNode = currentNode.Next; // Сохраняем ссылку на следующий узел

                if (currentNode.Value % firstElement == 0) // Проверяем, делится ли текущий элемент на первый
                {
                    list.Remove(currentNode); // Удаляем текущий узел
                }

                currentNode = nextNode; // Переходим к следующему узлу
            }
        }

        public void SortLinkedList(LinkedList<int> list)
        {
            LinkedListNode<int> currentNode = list.First.Next; // Начинаем со второго элемента
            LinkedListNode<int> previousNode = list.First;

            while (currentNode != null)
            {
                if ((currentNode.Value % 2) == (previousNode.Value % 2))
                {
                    list.AddBefore(currentNode, 0); // Вставляем 0
                    previousNode = currentNode.Previous;  //Предыдущий теперь добавленный ноль
                    if (currentNode.Next != null)
                        currentNode = currentNode.Next;  // А этот тот же самый элемент
                }
                else
                {
                    previousNode = currentNode; // Переходим к следующему элементу
                }
                if (currentNode.Next != null)
                    currentNode = currentNode.Next;  //Переходим к следующему
                else break;
            }
        }
    }
}
