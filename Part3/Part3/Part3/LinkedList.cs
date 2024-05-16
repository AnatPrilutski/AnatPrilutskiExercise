using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class LinkedList
    {
        private Node<int> Head { get; set; }
        private Node<int> Tail { get; set; }
        private Node<int> Max { get; set; }
        private Node<int> Min { get; set; }
        public LinkedList(Node<int> head) 
        {
            this.Head = head;
            this.Tail = head;
            this.Max = head;
            this.Min = head;
        }
        public void Append(int valueToAdd)
        {
            Node <int> nodeToAdd = new Node<int>(valueToAdd);
            if (this.Head == null)
            {
                this.Head = nodeToAdd;
            }
            else
            {
                this.Tail.Next = nodeToAdd;
                this.Tail = nodeToAdd;
            }
            checkMinWhenAdding(nodeToAdd);
            checkMaxWhenAdding(nodeToAdd);
        }
        public void Prepend(int valueToAdd)
        {
			Node <int> nodeToAdd = new Node<int>(valueToAdd, this.Head);
            this.Head = nodeToAdd;
			checkMinWhenAdding(nodeToAdd);
			checkMaxWhenAdding(nodeToAdd);
		}
        public void checkMinWhenAdding(Node<int> nodeAdded) 
        {
            if (this.Min.Value > nodeAdded.Value)
            {
                this.Min = nodeAdded;
            }
        }
		public void checkMaxWhenAdding(Node<int> nodeAdded)
		{
			if (this.Max.Value < nodeAdded.Value)
			{
				this.Max = nodeAdded;
			}
		}
        public void checkMinWhenRemoving(Node<int> nodeRemoved) 
        {
            if (this.Min.Value != nodeRemoved.Value) 
            {
                return;
            }
            
            Node<int> pointer = this.Head;
            this.Min = this.Head;
            while (pointer != null) 
            {
                if (pointer.Value < this.Min.Value) 
                {
                    this.Min = pointer;
                }

                pointer = pointer.Next;
            }
        }
		public void checkMaxWhenRemoving(Node<int> nodeRemoved)
		{
			if (this.Max.Value != nodeRemoved.Value)
			{
				return;
			}

			Node<int> pointer = this.Head;
			this.Max = this.Head;
			while (pointer != null)
			{
				if (pointer.Value > this.Max.Value)
				{
					this.Max = pointer;
				}

				pointer = pointer.Next;
			}
		}
        public int Pop()
        {
            Node<int> pointer = this.Head;
            while (pointer.Next.Next != null) 
            {
                pointer = pointer.Next;
            }

            Node<int> removedNode = pointer.Next;
            pointer.Next = null;
			checkMinWhenRemoving(removedNode);
			checkMaxWhenRemoving(removedNode);
			return removedNode.Value;
        }
        public int Unqueue() 
        {
            Node<int> removedNode = this.Head;
            this.Head = this.Head.Next;
			checkMinWhenRemoving(removedNode);
			checkMaxWhenRemoving(removedNode);
			return removedNode.Value;
        }
        public IEnumerable<int> ToList() 
        {
            Node<int> pointer = this.Head;
            while (pointer.Next != null)
            {
                yield return pointer.Value;
                pointer = pointer.Next;
            }
        }
        public bool IsCircular()
        {
            return this.Tail.Next != null;
        }
        public void Sort()
        {
            List<int> allValues = turnLinkedListToList();
            allValues.Sort();
            Node<int> newSortedHead = new Node<int>(allValues[0]);
            Node<int> pointer = newSortedHead;
            for (int i = 1; i < allValues.Count; i++)
            {
                pointer.Next = new Node<int>(allValues[i]);
                pointer = pointer.Next;
            }

            this.Head = newSortedHead;
            this.Tail = pointer;
        }
        public List<int> turnLinkedListToList()
        {
            List<int> list = new List<int>();
            Node<int> pointer = this.Head;
            while (pointer != null)
            {
                list.Add(pointer.Value);
                pointer = pointer.Next;
            }

            return list;
        }
        public Node<int> GetMaxNode()
        {
            return this.Max;
        }
        public Node<int> GetMinNode()
        {
            return this.Min;
        }
    }
}
