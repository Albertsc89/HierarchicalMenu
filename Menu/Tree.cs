using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HierarchicalMenu
{
    public class Tree
    {
        private readonly List<Leaf> _tree;

        public Tree(List<Leaf> tree)
        {
            _tree = tree;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            Recursive(_tree, 0,0,ref sb);
           

            return sb.ToString();
        }

        private void Recursive(List<Leaf> branch, int parent, int level,ref StringBuilder sb)
        {
            var tabs = new string('\t', level);
            foreach (var leaf in branch.Where(leaf => leaf.WhoIsMyParent() == parent))
            {
                sb.AppendLine(tabs + leaf.name);
                Recursive(_tree, leaf.id, level+1, ref sb);
            }
        }
    }
}