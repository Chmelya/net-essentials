using System;

namespace Tree
{
    public class Node
    {
        public Node(Node left, Node right, string val)
            => (Left, Right, Val) = (left, right, val);

        public Node Left { get; }
        public Node Right { get; }
        public string Val { get; }
    }
}
