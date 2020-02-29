using System;

namespace bintree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            tree.Insert(75);
            tree.Insert(57);
            tree.Insert(90);
            tree.Insert(32);
            tree.Insert(7);
            tree.Insert(44);
            tree.Insert(60);
            tree.Insert(86);
            tree.Insert(93);
            tree.Insert(99);

            // Console.WriteLine("In Order");
        
            // tree.inOrderTraversal(tree.root);

            // Console.WriteLine("Pre Order");
            // tree.preOrderTraversal(tree.root);

            // Console.WriteLine("Post Order");
            // tree.postOrderTraversal(tree.root);           

            if (tree.FindNodeRecursive(tree.root, 55) != null) {            
                Console.WriteLine("Node was found");
            }
            else {
                Console.WriteLine("Node was not found");
            }

            Console.WriteLine("The height of the tree is {0}", tree.getHeight(tree.root));

        }
    }

    class Node
    {
        int _value;
        public Node left {get; set;}
        public Node right {get; set;}

        public int value
        {
            get{
                return this._value;
            }
        }
        public Node(int v)
        {
            this._value = v;
        }
    }


    class BinaryTree
    {
        Node _root;

        public Node root {
            get{
                return _root;
            }
        }

        public BinaryTree()
        {
            _root = null;
        } 

        public void Insert(int value)
        {
            if (this._root == null)
            {
                this._root = new Node(value);
            }
            else
            {
               InsertTo(this._root, value);
            }
        }

        void  InsertTo(Node node, int value)
        {
             Node current = node;
            //  greater than the current node so it goes to the rigth
             if (current.value < value)
             {
                   if (current.right == null)
                   {
                       current.right = new Node(value);                       
                   }
                   else
                    {
                        this.InsertTo(current.right, value);
                    }
            }
            else 
            // it goes to the left
            {                
                if (current.left == null)
                {
                    current.left = new Node(value);  
                }
                else
                {
                    this.InsertTo(current.left, value);             
                }
            }            
        }

        public Boolean Contains(int value)
        {
            if (this._root == null)
            return false;
        
            Node parent;
            return FindNode(this._root, value, out parent) != null;
        }


        // find iterative
        public Node FindNode(int value)
        { 
            if (this._root == null)
                    return null;
            
            var currentnode = this._root;
            while (currentnode != null)
            {
                if (value == currentnode.value)
                    return currentnode;
                else if (value > currentnode.value)
                    currentnode = currentnode.right;
                else
                    currentnode = currentnode.left;
             }
             return null;
        }


        //find recursive
        public Node FindNodeRecursive(Node current, int value)
        { 
            if (this._root == null)
                    return null;    

            if (current == null)
                return current;

           if (current.value == value)        
              return current;
            else if (current.value > value)
                return FindNodeRecursive(current.left, value);
            else
                return FindNodeRecursive(current.right, value);
        }


        Node FindNode(Node current, int value, out Node parent)
        {
            parent = null;
            
            if (this.root.value == value){
                parent = null;
                return this.root;
            }
               
            while (current != null)
             {
                if (current.value == value)
                  return current;
                
                if (current.value > value)
                {
                    parent = current;
                    current =current.left;
                }
                if (current.value < value)
                {
                    parent = current;
                    current = current.right;
                }
             }              
            return null;
        }


        // time complexity of this is O(n)
        // because we have to go all over the tree
        public int getHeight(Node node)
        {                    
            if (node == null)
               return -1;

            int leftHeight = -1;
            int rightHeight = -1;

            if (node.left != null)
                leftHeight = getHeight(node.left);

            if(node.right != null)
                rightHeight = getHeight(node.right);
            
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public void inOrderTraversal(Node node)
        {
            if (node != null)
            {
                inOrderTraversal(node.left);
                Console.WriteLine(node.value);
                inOrderTraversal(node.right);
            }
        }

        public void preOrderTraversal(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.value);
                preOrderTraversal(node.left);
                preOrderTraversal(node.right);
            }
        }

        public void postOrderTraversal(Node node)
        {
            if (node != null)
            {
                postOrderTraversal(node.left);
                postOrderTraversal(node.right);
                Console.WriteLine(node.value);
            }
        }
        public void PrintTree(Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
              Node current = node;
              if (current.left != null)
              {
                  PrintTree(current.left);
              }
              
              Console.WriteLine(current.value);  

              if (current.right != null)
              {
                  PrintTree(current.right);
              }
            }
        }

        public Boolean Remove(int value)
        {
            //locate the node and its parent
            Node parent = null;
            var node = FindNode(this.root, value, out parent);
            if (node != null)
            {
                // Check if the node is a leaf node
                // We only point to null its parent pointer

                // Otherwise is a non leaf node
                // First step is to find the child who will replace the node to be deleted


            }
            return false;
        }
    }

}
