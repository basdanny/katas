using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Find common ancestor of two supplied nodes in a binary tree
 */
namespace Interview
{
    public class Node<T>
    {
        public string name = string.Empty;
        public T data = default(T);
        public int value;
        public Node<T> left = null;
        public Node<T> right = null;

        public Node(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public static Node<T> LeastCommonAncestor(Node<T> root, Node<T> first, Node<T> second)
        {
            if (root == null)
                return null;

            if (root == first || root == second) //found one of the elements
                return root;

            Node<T> left = LeastCommonAncestor(root.left, first, second);
            Node<T> right = LeastCommonAncestor(root.right, first, second);

            if (left != null && right != null)
                return root;
            if (left != null)
                return left;
            if (right != null)
                return right;

            return null;
        }

        /// <summary>
        /// non recursive print - level by level (BFS)
        /// </summary>
        public static void PrintLevelByLevel(Node<T> root)
        {
            Queue<Node<T>> nodes = new Queue<Node<T>>();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                Node<T> currentNode = nodes.Dequeue();
                Console.Write($"{currentNode.name}  ");
                if (currentNode.left != null)
                    nodes.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    nodes.Enqueue(currentNode.right);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// (DFS) preorder recursive print
        /// </summary>        
        public static void PrintRecursive(Node<T> node)
        {
            if (node == null)
                return;

            Console.Write(node.name + "\t");
            PrintRecursive(node.left);
            PrintRecursive(node.right);            
        }
    }
}
