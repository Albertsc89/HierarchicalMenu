using System;
using System.Collections.Generic;

namespace HierarchicalMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaf = new Leaf( 1 , "Administration", 0);
            var leaf2 = new Leaf(2, "User Admin", 1);
            var leaf3 = new Leaf(3, "Reports", 0);
            var leaf4 = new Leaf(4, "Create User", 2);
            var leaf5 = new Leaf(5, "Edit User", 2);
            var leaf6= new Leaf(6, "Product Admin", 1);
            var leaf7= new Leaf(7, "All Products", 6);
            var leaf8= new Leaf(8, "My Products", 7);
            var leaf9= new Leaf(9, "Create Product", 6);
            var leaf10= new Leaf(10, "Order Admin", 1);
            var leaf11= new Leaf(11, "Order Reports", 10);
            var leaf12= new Leaf(12, "Create Order", 10);
            var leaf13= new Leaf(13, "Audit Reports", 11);
            var leaf14= new Leaf(14, "Updated Orders", 13);
            var leaf15= new Leaf(15, "Created Orders", 13);
            var leaf16= new Leaf(16, "Win Tech Report", 3);
            var leaf17= new Leaf(17, "Microsoft Report", 3);

            var tree = new Tree(new List<Leaf>(){leaf,leaf2,leaf3,leaf4,leaf5,leaf6,leaf7,leaf8,
                leaf9,leaf10,leaf11,leaf12,leaf13,leaf14,leaf15,leaf16,leaf17 });

            Console.WriteLine(tree.ToString());
        }
    }
}
