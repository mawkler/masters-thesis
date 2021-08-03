using System;

public class LinkedList
{
    private Node head;
    private Node tail;

    // Static counter used by Concatenate()
    public static int numberOfConcatenates;

    // Returns length of list
    public static int Length(LinkedList list)
    {
        Node current = list.head;
        int length = 0;

        while (current != null)
        {
            length++;
            current = current.next;
        }
        return length;
    }

    // Removes item at an index from list.
    // Assumes that list is non-empty and
    // that index is non-negative and less
    // than list's length
    public static void Remove(int index, LinkedList list)
    {
        if (index == 0)
        {
            list.head = list.head.next;
        }
        else
        {
            Node pre = list.head;

            for (int i = 0; i < index - 1; i++)
            {
                pre = pre.next;
            }
            pre.next = pre.next.next;

            if (index == Length(list)) // last element
            {
                list.tail = pre;
            }
        }
    }

    // Appends data to the list
    public void Add(Object data)
    {
        if (LinkedList.Length(this) == 0)
        {
            head = new Node(data);
            tail = head;
        }
        else
        {
            Node addedNode = new Node(data);
            tail.next = addedNode;
            tail = addedNode;
        }
    }

    // Concatenates two lists by
    // appending a list to the end of
    // this list
    public void Concatenate(LinkedList list)
    {
        if (head == null) head = list.head;
        else
        {
            this.tail.next = list.head;
            this.tail = list.tail;
            list.head = this.head;

            // This gives the method a
            // side-effect
            numberOfConcatenates++;
        }
    }

    // Overloading of Concatenate that
    // allows passing both lists as
    // parameters
    public static void Concatenate(LinkedList l1, LinkedList l2)
    {
        l1.Concatenate(l2);
    }

    // public override string ToString()
    // {
    //     if (head == null) return "";
    //     else
    //     {
    //         string result = "";
    //         Node current = head;
    //         do
    //         {
    //             result += current.ToString() + ", ";
    //             current = current.next;
    //         }
    //         while (current != null);
    //         return result;
    //     }
    // }

    private class Node
    {
        public Node next;
        public Object data;

        // public Node() { }

        public Node(Object data)
        {
            this.data = data;
        }

        /* public override string ToString() => data.ToString(); */
    }

    // public static void Main(string[] args)
    // {
    //     LinkedList l = new LinkedList();
    //     l.Add("foo");
    //     l.Add("bar");
    //     l.Add("baz");
    //     l.Add("faz");
    //     Console.WriteLine(l.ToString());
    //     LinkedList.Remove(3, l);
    //     Console.WriteLine(l.ToString());
    //     LinkedList.Remove(1, l);
    //     Console.WriteLine(l.ToString());
    //     LinkedList.Remove(0, l);
    //     Console.WriteLine(l.ToString());
    //     Console.WriteLine(l.head);
    //     Console.WriteLine(l.tail);
    //     LinkedList l2 = new LinkedList();
    //     l2.Add("far");
    //     l.Concatenate(l2);
    //     Console.WriteLine(l);
    // }
}
