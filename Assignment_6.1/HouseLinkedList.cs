using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._1
{
    class HouseNode
    {
        public int HouseNumber { get; set; }
        public string HouseAddress { get; set; }
        public string HouseType { get; set; }
        public HouseNode next;

        public HouseNode(int dataNumber, string houseAddress, string dataType)
        {
            HouseNumber = dataNumber;
            HouseAddress = houseAddress;
            HouseType = dataType;
            next = null;
        }

        public override string ToString()
        {
            return $"{HouseNumber} {HouseAddress}, {HouseType}";
        }
    }

    internal class HouseLinkedList
    {
        private HouseNode _head;
        private HouseNode _tail;
        private int _size;
        public int Size { get { return _size; } }

        public HouseLinkedList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public void AddFirst(int houseNumber,string houseAddress, string houseTypes)
        {
            HouseNode newNode = new HouseNode(houseNumber,houseAddress, houseTypes);

            if (IsEmpty())
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.next = _head;
                _head = newNode;
            }

            _size++;
        }

        public void AddLast(int houseNumber,string houseAddress, string houseType)
        {
            HouseNode newNode = new HouseNode(houseNumber, houseAddress, houseType);

            if (IsEmpty())
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.next = newNode;
                _tail = newNode;
            }

            _size++;
        }

        public bool Search(int houseNumber)
        {
            HouseNode node = _head;

            while (node != null)
            {
                if(node.HouseNumber == houseNumber) return true;

                node = node.next;
            }

            return false;
        }

        public void DisplayHouseNumbers()
        {
            HouseNode node = _head;
            int i = 1;

            while(node != null)
            {
                Console.WriteLine($"{i}. {node.HouseNumber}");
                node = node.next;
                i++;
            }
        }

        public void Display(int houseNumber)
        {
            HouseNode node = _head;

            while(node != null)
            {
                if(node.HouseNumber == houseNumber)
                {
                    Console.WriteLine(node.ToString());
                    return;
                }
                node = node.next;
            }

            Console.WriteLine("House Number was not found...");
        }
    }
}
