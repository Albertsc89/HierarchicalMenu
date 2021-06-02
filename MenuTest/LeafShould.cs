using System;
using System.Collections.Generic;
using Xunit;
using HierarchicalMenu;
namespace XUnitTestProject1
{
    public class LeafShould
    {
        [Fact]
        public void BeARootLeaf()
        {

            var leaf = new Leaf( 1 , "Name", 0);
         
            
            var isRoot = leaf.IsRootLeaf();
            var expected = true;


            Assert.Equal(expected, isRoot);
            
        }

        [Fact]
        public void PrintPreety()
        {
            var leaf = new Leaf( 1 , "Name", 0);
            var leaf2 = new Leaf(2, "names", 1);
            var leaf4 = new Leaf(4, "Manolo", 2);
            var leaf3 = new Leaf(3, "names", 1);

            var tree = new Tree(new List<Leaf>(){leaf,leaf2,leaf3,leaf4});
           var result =  tree.ToString();
           Assert.Equal("-Name\r\n\t-names\r\n\t\t-Manolo\r\n\t-names\r\n", result);


        }
    }
}
