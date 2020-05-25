using System;

public class LinkedList
{
    private Node head;
    private Node tail;

    // For the sake of this example this method is static
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

    // Removes item at index from list. Assumes that list is non-empty and that
    // index is less than list's length
    //
    // For the sake of this example this method is static.
    static public LinkedList Remove(int index, LinkedList list)
    {
        for (int i = 0; i < Length(list); i++)
        {
            //...
        }
    }

    public static void PrintLength(LinkedList list)
    {
        Console.WriteLine(Length(list));
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
        PrintLength(l);
    }
}
