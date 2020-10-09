using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class DfsSearch
    {
        int count;
        Dictionary<int, Node> byNum;
        Dictionary<string, Node> byName;

        public DfsSearch(Node tree)
        {
            byName = new Dictionary<string, Node>();
            byNum = new Dictionary<int, Node>();
            count = 0;
            Find(tree);
        }

        void Find(Node n)
        {
            byNum.Add(count, n);
            byName.Add(n.Val, n);

            count++;

            if (n.Left != null) Find(n.Left);
            if (n.Right != null) Find(n.Right);
        }
<<<<<<< HEAD

=======
        
>>>>>>> 2d747092c6b4afbe5a7d6069d16ab2934ed9f969

        public Node this[int index]
        {
            get => byNum[index];
        }

        public Node this[string val]
        {

            get => byName[val];

        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 2d747092c6b4afbe5a7d6069d16ab2934ed9f969
