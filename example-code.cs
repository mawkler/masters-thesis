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
            // Console.WriteLine(tail.data);
        }
    }

    // public override string ToString()
    // {
    //     Node current = head;
    //     string output = "[";

    //     while (current != null)
    //     {
    //         output += current.data.ToString() + ", ";
    //         current = current.next;
    //     }
    //     Console.WriteLine(output.Remove(output.Length - 1, 1) + "]");
    //     output = output.Remove(output.Length - 1, 1) + "]";
    //     return output;
    // }

    public void PrintLength()
    {
        Node current = head;
        int length = 0;

        while (current != null)
        {
            length++;
            current = current.next;
        }
        Console.WriteLine(length);
    }

    public Object First()
    {
        return head.data;
    }

    public Object Last()
    {
        return tail.data;
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
        Console.WriteLine(l.First());
        l.PrintLength();
    }
}
