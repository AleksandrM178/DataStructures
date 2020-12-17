using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        public int Length { get; private set; }
        private Node _root { get; set; }
        public LinkedList()
        {
            _root = null;
            Length = 0;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
            Length = 1;
        }
        public LinkedList(int[] array)
        {
            Length = array.Length;
            if (Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }
            }
            else
            {
                _root = null;
            }
        }
        public void Add(int value)
        {
            if (Length == 0)
            {
                _root = new Node(value);
                Length = 1;
            }
            else
            {
                Node tmp = GetNode(Length - 1);
                Node newNode = new Node(value);
                tmp.Next = newNode;
                Length++;
            }

        }
        public void Add(int[] array)
        {
            if (array.Length == 0)
            {
                return;
            }
            Node tmp;
            if (Length == 0)
            {
                _root = new Node(array[0]);
                tmp = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }
                Length += array.Length;
            }
            else
            {
                tmp = GetNode(Length - 1);
                for (int i = 0; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }
                Length += array.Length;
            }

        }
        public void AddByIndex(int index, int value)
        {
            if (index == 0)
                AddFirst(value);
            else if (index < Length)
            {
                Node newNode = new Node(value);
                Node crnt = GetNode(index - 1);
                newNode.Next = crnt.Next;
                crnt.Next = newNode;
                Length++;
            }
            else if (index == Length)
                Add(value);
        }
        public void AddByIndex(int index, int[] array)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (array.Length == 0)
            {
                return;
            }
            if (index == Length)
            {
                Add(array);
            }
            if (index == 0)
            {
                AddFirst(array);
            }
            else
            {
                Node firstNode = GetNode(index - 1);
                Node lastNode = firstNode.Next;
                Node newNode = new Node(array[0]);
                firstNode.Next = newNode;
                for (int i = 1; i < array.Length; i++)
                {
                    newNode.Next = new Node(array[i]);
                    newNode = newNode.Next;
                }
                newNode.Next = lastNode;
                Length += array.Length;
            }
        }
        public void AddFirst(int value)
        {
            if (Length == 0)
            {
                _root = new Node(value);
                Length = 1;
            }
            else
            {
                Node newNode = new Node(value);
                newNode.Next = _root;
                _root = newNode;
                Length++;
            }

        }
        public void AddFirst(int[] array)
        {
            if (array.Length != 0)
            {
                Node crnt = new Node(array[0]);
                Node tmp = crnt;
                for (int i = 1; i < array.Length; i++)
                {
                    crnt.Next = new Node(array[i]);
                    crnt = crnt.Next;
                }
                crnt.Next = _root;
                _root = tmp;
                Length += array.Length;
            }
            if (Length == 0)
            {
                Add(array);
            }
        }
        public void Remove(int num = 1)
        {
            if (num == 0)
            {
                return;
            }
            if (num >= Length)
            {
                Clean();
            }
            else
            {
                GetNode(Length - num).Next = null;
                Length -= num;
            }
        }

        public void RemoveFirst(int num = 1)
        {
            if (Length != 0 && num < Length)
            {
                _root = GetNode(num);
                Length -= num;
            }
            else
                Clean();
        }
        public void RemoveByIndex(int index, int num = 1)
        {
            if (num == 0)
                return;
            if (index + num > Length)
                num = Length - index;
            if (index >= Length || index < 0)
                throw new NullReferenceException();
            if (Length != 0 && num < Length)
            {
                if (index == 0)
                    _root = GetNode(num);
                else
                {
                    Node crnt = GetNode(index - num);
                    crnt.Next = GetNode(index + num);
                }
                Length -= num;
            }
            else
                Clean();
        }
        public void RemoveByValue(int value)
        {
            RemoveByIndex(IndexOfElement(value));
        }
        public void RemoveAllByValue(int value)
        {
            if (_root == null)
            {
                throw new NullReferenceException("List length can't be null");
            }

            Node prev = null;
            Node curr = _root;
            while (curr != null)
            {
                if (curr.Value == value)
                {
                    if (prev == null)
                    {
                        _root = curr.Next;
                        Length--;
                    }
                    else
                    {
                        prev.Next = curr.Next;
                        Length--;
                    }
                }
                else
                {
                    prev = curr;
                }
                curr = curr.Next;
            }
        }
        public int IndexOfElement(int element)
        {
            Node crnt = _root;
            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value == element)
                    return i;
                crnt = crnt.Next;
            }
            throw new Exception();
        }

        public void Reverse()
        {
            if (Length > 1)
            {
                LinkedList reversed_list = new LinkedList(this[Length - 1]);
                for (int i = 1; i < Length; i++)
                {
                    reversed_list.Add(this[Length - i - 1]);
                }
                _root = reversed_list.GetFirstNode();
            }
        }

        public int FindMax()
        {
            if (Length == 0)
                throw new Exception();
            int max = _root.Value;
            Node crnt = _root.Next;
            for (int i = 1; i < Length; i++)
            {
                if (crnt.Value > max)
                    max = crnt.Value;
                crnt = crnt.Next;
            }
            return max;
        }

        public int FindMin()
        {
            if (Length == 0)
                throw new Exception();
            int min = _root.Value;
            Node crnt = _root.Next;
            for (int i = 1; i < Length; i++)
            {
                if (crnt.Value < min)
                    min = crnt.Value;
                crnt = crnt.Next;
            }
            return min;
        }

        public int FindIndexMin()
        {
            if (Length == 0)
                throw new Exception();
            int index = IndexOfElement(FindMin());

            return index;
        }

        public int FindIndexMax()
        {
            if (Length == 0)
                throw new Exception();
            int index = IndexOfElement(FindMax());

            return index;
        }
        public void SortIncrease()
        {
            int min;
            for (int i = 0; i < Length; i++)
            {
                min = i;
                for (int j = i + 1; j < Length; j++)
                {
                    if (this[j] < this[min])
                    {
                        min = j;
                    }
                }
                Swap(i, min);
            }
        }
        public void SortDecrease()
        {
            int max;
            for (int i = 0; i < Length; i++)
            {
                max = i;
                for (int j = i + 1; j < Length; j++)
                {
                    if (this[j] > this[max])
                    {
                        max = j;
                    }
                }
                Swap(i, max);
            }
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            AddByIndex(secondIndex, this[firstIndex]);
            AddByIndex(firstIndex, this[secondIndex + 1]);
            RemoveByIndex(firstIndex + 1);
            RemoveByIndex(secondIndex + 1);
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Node tmp = GetNode(index);
                return tmp.Value;
            }
            set
            {
                if (index < 0 || index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
                if (index == Length)
                {
                    Add(value);
                }
                Node tmp = GetNode(index);
                tmp.Value = value;
            }
        }
        private Node GetNode(int index)
        {
            Node tmp = _root;
            for (int i = 0; i < index; i++)
            {
                tmp = tmp.Next;
            }
            return tmp;
        }
        private Node GetFirstNode() { return _root; }

        private void Clean()
        {
            _root = null;
            Length = 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            LinkedList linkedList = (LinkedList)obj;

            if (Length != linkedList.Length)
                return false;
            for (int i = 0; i < Length; i++)
            {
                if (this[i] != linkedList[i])
                    return false;
            }
            return true;
        }
    }
}