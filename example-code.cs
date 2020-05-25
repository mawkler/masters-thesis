using System;

public class LinkedList
{
    private Node head;
    private Node tail;

    public void Add(Object data)
    {
        if (head == null)
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
