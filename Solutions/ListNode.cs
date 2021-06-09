namespace Solutions
{
    public class ListNode<T>
    {
        T _val;
        public ListNode<T> Next;

        public T val
        {
            get
            {
                return _val;
            }
        }
        public ListNode(T val)
        {
            _val = val;
        }
    }
}