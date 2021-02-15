namespace Solutions
{
    public class TreeNode<T>
    {
        T _val;
        public TreeNode<T> left;
        public TreeNode<T> right;


        public T val
        {
            get
            {
                return _val;
            }
        }
        public TreeNode(T val, TreeNode<T> left = null, TreeNode<T> right = null)
        {
            _val = val;
            this.left = left;
            this.right = right;
        }
    }
}