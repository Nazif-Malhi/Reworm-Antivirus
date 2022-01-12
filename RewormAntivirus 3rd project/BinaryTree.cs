using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RewormAntivirus_3rd_project
{
    class BinaryTree
    {
        private  string zero, one, two, three, four, five, six, seven, eight, nine, a, b, c, d, e, f;
        private bool for_zero, for_one, for_two, for_three, for_four,
                     for_five, for_six, for_seven, for_eight, for_nine, 
                     for_a, for_b, for_c, for_d, for_e, for_f;
        private string path_zero, path_one, path_two, path_three, path_four, 
                          path_five, path_six, path_seven, path_eight, path_nine, 
                          path_a, path_b, path_c, path_d, path_e, path_f;

        /// <summary>
        /// Initializing and loading all the files in seperate arrays
        /// </summary>

        public BinaryTree()
        {
            path_zero = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\0.md5");
            path_one = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\1.md5");
            path_two = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\2.md5");
            path_three = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\3.md5");
            path_four = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\4.md5");
            path_five = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\5.md5");
            path_six = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\6.md5");
            path_seven = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\7.md5");
            path_eight = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\8.md5");
            path_nine = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\9.md5");
            path_a = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\a.md5");
            path_b = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\b.md5");
            path_c = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\c.md5");
            path_d = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\d.md5");
            path_e = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\e.md5");
            path_f = (@"C:\Users\Nazif\Desktop\Project antivirus Revoation\New hashcodes\f.md5");
        }
      
       
      
        internal class Node //inner class for binary tree node
        {
            public int data; //key data for a node
            public Node left; //left reference
            public Node right; //right reference
        }
        private Node root; //root node of the tree
        private void insert_rec(int data, Node node)
        {
            if (node.data > data)
            {//consider left
                if (node.left == null)
                {//add new node as left child
                    node.left = new Node();
                    node.left.data = data;
                }
                else
                    insert_rec(data, node.left);
            }
            else if (node.data < data)
            {//consider right
                if (node.right == null)
                {//add new node as left child
                    node.right = new Node();
                    node.right.data = data;
                }
                else
                    insert_rec(data, node.right);
            }
        }
        private void insert(int data)
        {
            if (root == null)
            {
                root = new Node();//creating new node
                root.data = data;
                return;
            }
            insert_rec(data, root);
        }
        private int Find_rec(int value, Node parent)
        {
            if (value == parent.data) return value;
            else if (value < parent.data) return Find_rec(value, parent.left);
            else return Find_rec(value, parent.right);
        }
        private int Find(int value)
        {
            return Find_rec(value, root);
        }

        /// <summary>
        /// This will return the array which will be recuired to perform actrion throug the CallBtree Function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string  returnArray(int value)
        {
            switch (value)
            {
                case 48:
                    if (for_zero == true)
                    {
                      
                        return zero;
                    }
                    else
                    {
                        for_zero = true;

                        zero = File.ReadAllText(path_zero);
                       
                        return zero;
                    }
                case 49:
                    if (for_one == true)
                    {
                       
                        return one;
                    }
                    else
                    {
                       
                        for_one = true;
                        one = File.ReadAllText(path_one);
                        return one;
                    }
                case 50:
                    if (for_two == true)
                    {
                       
                        return two;
                    }
                    else
                    {
                       
                        for_two = true;
                        two = File.ReadAllText(path_two);
                        return two;
                    }
                case 51:
                    if (for_three == true)
                    {
                       
                        return three;
                    }
                    else
                    {
                       
                        for_three = true;
                        three = File.ReadAllText(path_three);
                        return three;
                    }
                case 52:
                    if (for_four == true)
                    {
                        
                        return four;
                    }
                    else
                    {
                       
                        for_four = true;
                        four = File.ReadAllText(path_four);
                        return four;
                    }
                case 53:
                    if (for_five == true)
                    {
                       
                        return five;
                    }
                    else
                    {
                        
                        for_five = true;
                        five = File.ReadAllText(path_five);
                        return five;
                    }
                case 54:
                    if (for_six == true)
                    {
                       
                        return six;
                    }
                    else
                    {
                       
                        for_six = true;
                        six = File.ReadAllText(path_six);
                        return six;
                    }
                case 55:
                    if (for_seven == true)
                    {
                       
                        return seven;
                    }
                    else
                    {
                        
                        for_seven = true;
                        seven = File.ReadAllText(path_seven);
                        return seven;
                    }
                case 56:
                    if (for_eight == true)
                    {
                        return eight;
                    }
                    else
                    {
                       
                        for_eight = true;
                        eight = File.ReadAllText(path_eight);
                        return eight;
                    }
                case 57:
                    if (for_nine == true)
                    {
                        
                        return nine;
                    }
                    else
                    {
                       
                        for_nine = true;
                        nine = File.ReadAllText(path_nine);
                        return nine;
                    }
                case 97:
                    if (for_a == true)
                    {
                       
                        return a;
                    }
                    else
                    {
                       
                        for_a = true;
                        a = File.ReadAllText(path_a);
                        return a;
                    }
                case 98:
                    if (for_b == true)
                    {
                       
                        return b;
                    }
                    else
                    {
                        
                        for_b = true;
                        b = File.ReadAllText(path_b);
                        return b;
                    }
                case 99:
                    if (for_c == true)
                    {
                       
                        return c;
                    }
                    else
                    {
                       
                        for_c = true;
                        c = File.ReadAllText(path_c);
                        return c;
                    }
                case 100:
                    if (for_d == true)
                    {
                       
                        return d;
                    }
                    else
                    {
                       
                        for_d = true;
                        d = File.ReadAllText(path_d);
                        return d;
                    }
                case 101:
                    if (for_e == true)
                    {
                       
                        return e;
                    }
                    else
                    {
                        for_e = true;
                        e = File.ReadAllText(path_e);
                       
                        return e;
                    }
                case 102:
                    if (for_f == true)
                    {
                       
                        return f;
                    }
                    else
                    {
                        for_f = true;
                        f = File.ReadAllText(path_f);
                        return f;
                    }
                    
                default:
                    return null;

            }

        }

        public string   callBtree(int value) {
            //////////           0-- > 48;            ////////// 
            //////////           1-- > 49;            //////////
            //////////           2-- > 50;            //////////
            //////////           3-- > 51;            //////////
            //////////           4-- > 52;            //////////
            //////////           5-- > 53;            //////////
            //////////           6-- > 54;            //////////
            //////////           7-- > 55;            //////////
            //////////           8-- > 56;            //////////
            //////////           9-- > 57;            //////////
            //////////           a-- > 97;            //////////
            //////////           b-- > 98;            //////////
            //////////           c-- > 99;            //////////
            //////////           d-- > 100;           //////////
            //////////           e-- > 101;           //////////
            //////////           f-- > 102;           //////////

            int[] insertNumbersOFfilesPath = { 55, 54, 51, 98, 49, 53, 48, 50, 52, 57, 100, 56, 97, 99, 101, 102 };
            foreach (var item in insertNumbersOFfilesPath)
            {
                insert(item);
            }
            return returnArray(Find(value));
        }

       

      

    }
}
