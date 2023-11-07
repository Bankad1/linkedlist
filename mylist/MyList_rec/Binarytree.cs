using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList_rec
{
    internal class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;

        public BinaryTree()
        {
            root = null;
        }

        public void BuildTreeFromList(MyList<T> list)
        {
            if (list.first != null)
            {
                root = BuildTreeFromListRecursive(list.first);
            }
        }

        private BinaryTreeNode<T> BuildTreeFromListRecursive(Element<T> current)
        {
            if (current == null)
            {
                return null;
            }

            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(current.MyData);
            newNode.Left = BuildTreeFromListRecursive(current.next);

            return newNode;
        }

        
    }
}
