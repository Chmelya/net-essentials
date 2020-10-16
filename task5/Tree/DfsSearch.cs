using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class DfsSearch
    {
        private Dictionary<int, Node> DictionaryByNum { get; }
        private Dictionary<string, Node> DictionaryByName { get; }

        public DfsSearch(Node tree)
        {
            DictionaryByName = new Dictionary<string, Node>();
            DictionaryByNum = new Dictionary<int, Node>();

            FindNodeIndex(tree, 0);
        }

        void FindNodeIndex(Node n, int count)
        {
            if (n == null)
            {
                return;
            }

            DictionaryByNum.Add(count, n);
            DictionaryByName.Add(n.Val, n);

            count++;

            if (n.Left != null) FindNodeIndex(n.Left, count);
            if (n.Right != null) FindNodeIndex(n.Right, count);
        }

        public Node this[int index]
        {
            get => DictionaryByNum[index];
        }

        public Node this[string val]
        {
            get => DictionaryByName[val];
        }
    }
}