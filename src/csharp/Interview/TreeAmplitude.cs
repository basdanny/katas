using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    /*
     *  Find amplitude of a tree - Find the highest path distance (highest value in path minus lowest value in path). 
     *  in O(n).
     */
    public class TreeAmplitude<T>
    {
        public static int GetTreeAmplitude(Node<T> root)
        {
            if (root == null)
                return 0;

            return TraverseDFS(root, root.value, root.value);
        }

        private static int TraverseDFS(Node<T> root, int min, int max)
        {
            if (root == null)
                return max - min;

            min = Math.Min(min, root.value);
            max = Math.Max(max, root.value);
            return Math.Max(TraverseDFS(root.left, min, max), TraverseDFS(root.right, min, max));
        }
    }
}
