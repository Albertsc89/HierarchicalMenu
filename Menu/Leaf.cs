namespace HierarchicalMenu
{
    public class Leaf
    {
        private int _id;
        private string _name;
        private readonly int _parentId;

        public Leaf(int id, string name, int parentID)
        {
            this._id = id;
            this._name = name;
            this._parentId = parentID;
        }

        public int id => _id;
        public string name => $"-{_name}";
        public int WhoIsMyParent() => _parentId;
        public bool IsRootLeaf() => _parentId == 0;
    }
}