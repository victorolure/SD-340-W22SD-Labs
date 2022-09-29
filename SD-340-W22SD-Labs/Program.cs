

LinkedList<int> list = new LinkedList<int> ();
list.Add(7);
list.Add(8);
list.Add(9);

list.PrintIndividualNode();


class LinkedList<T>
{
    public Node<T> Head { get; set; }

    public List<Node<T>> Nodes { get; set; } = new List<Node<T>>();

    public void Add(T data)
    {
        Node<T> node = new Node<T>();
        node.Data = data;
        node.Next = Head;
        Head = node;
        Nodes.Add(node);
    }

    public void PrintIndividualNode()
    {
        foreach(Node<T> node in Nodes)
        {
            node.PrintNodeData();
        }
    }
 
}

class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public void PrintNodeData()
    {
        Console.WriteLine(Data);
    }
}

