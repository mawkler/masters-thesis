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

    // Removes item at index from list.
    // Assumes that list is non-empty and
    // that index is non-negative and less
    // than list's length
    //
    // For the sake of this example this
    // method is static quite simplified.
    public static void Remove(int index, LinkedList list)
    {
        if (index == 0)
        {
            list.head = list.head.next;
        }
        else
        {
            Node predecessor = list.head;

            for (int i = 0; i < index - 1; i++)
            {
                predecessor = predecessor.next;
            }
            predecessor.next = predecessor.next.next;
        }
    }

    // Concatenates two lists by
    // appending a list to the end of
    // this list
    public LinkedList Concatenate(LinkedList list)
    {
        this.tail.next = list.head;
        this.tail = list.tail
        list.head = this.head;

        // This gives the method a
        // side-effect
        this.numberOfConcatenates++;
    }

    // Overloading of Concatenate that
    // allows passing both lists as
    // parameters
    public static LinkedList Concatenate(LinkedList l1, LinkedList l2)
    {
        l1.Concatenate(LinkedList l2);
    }

    private class Node
    {
        public Node next;
        public Object data;

        public Node() { }

        public Node(Object data)
        {
            this.data = data;
        }
    }

    public static void Main(string[] args)
    {
        LinkedList l = new LinkedList();
        l.Add("foo");
        l.Add("bar");
        l.Add("baz");
        l.Add("faz");
        Console.WriteLine(l.ToString());
        LinkedList.Remove(3, l);
        Console.WriteLine(l.ToString());
        Console.WriteLine(Length(l));
        LinkedList.Remove(1, l);
        Console.WriteLine(l.ToString());
        Console.WriteLine(Length(l));
        LinkedList.Remove(0, l);
        Console.WriteLine(l.ToString());
        Console.WriteLine(Length(l));
        l.PrintLength();
    }
}
