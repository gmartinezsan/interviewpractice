// using System;

// namespace bintree
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var tree = new BinaryTree();
//             tree.Insert(4);
//             tree.Insert(20);
//             tree.Insert(3);
//             tree.Insert(1);
//             tree.Insert(5);
//             Console.WriteLine("Print tree");
//             tree.PrintTree(tree.root);

//             if (tree.Contains(5))
//             {
//                 Console.WriteLine("Found a match");
//             }
//             else
//             {
//                 Console.WriteLine("Item not found");
//             }
//         }
//     }

//     class Node
//     {
//         int _value;
//         public Node left {get; set;}
//         public Node right {get; set;}

//         public int value
//         {
//             get{
//                 return this._value;
//             }
//         }
//         public Node(int v)
//         {
//             this._value = v;
//         }
//     }


//     class BinaryTree
//     {
//         Node _root;

//         public Node root {
//             get{
//                 return _root;
//             }
//         }

//         public void Insert(int value)
//         {
//             if (this._root == null)
//             {
//                 this._root = new Node(value);
//             }
//             else
//             {
//                InsertTo(this._root, value);
//             }
//         }

//         void InsertTo(Node node, int value)
//         {
//              Node current = node;
//              if (current.value <= value)
//              {
//                    if (current.right == null)
//                    {
//                        current.right = new Node(value);                       
//                    }
//                    else
//                     {
//                         this.InsertTo(current.right, value);
//                     }
//             }
//             else
//             {                
//                 if (current.left == null)
//                 {
//                     current.left = new Node(value);  
//                 }
//                 else
//                 {
//                     this.InsertTo(current.left, value);             
//                 }
//             }            
//         }

//         public Boolean Contains(int value)
//         {
//             if (this._root == null)
//             return false;
        
//             Node parent;
//             return FindNode(this._root, value, out parent) != null;
//         }

//         Node FindNode(Node current, int value, out Node parent)
//         {
//             parent = null;
            
//             if (this.root.value == value){
//                 parent = null;
//                 return this.root;
//             }
               
//             while (current != null)
//              {
//                  if (current.value > value)
//                 {
//                     parent = current;
//                     current =current.left;
//                 }
//                 if (current.value < value)
//                 {
//                     parent = current;
//                     current = current.right;
//                 }
//                 else
//                 {
//                     break;
//                 }
//              }

//             return current;
//         }

//         public void PrintTree(Node node)
//         {
//             if (node == null)
//             {
//                 return;
//             }
//             else
//             {
//               Node current = node;
//               if (current.left != null)
//               {
//                   PrintTree(current.left);
//               }
              
//               Console.WriteLine(current.value);  

//               if (current.right != null)
//               {
//                   PrintTree(current.right);
//               }
//             }
//         }

//         public Boolean Remove(int value)
//         {
//             //locate the node and its parent
//             Node parent = null;
//             var node = FindNode(this.root, value, out parent);
//             if (node != null)
//             {
//                 // Check if the node is a leaf node
//                 // We only point to null its parent pointer

//                 // Otherwise is a non leaf node
//                 // First step is to find the child who will replace the node to be deleted


//             }
//             return false;
//         }
//     }

// }
