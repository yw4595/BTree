using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTreeVisualizer;

/*
 * Author: Yanzhi Wang
 * Purpose: This class implements a binary search tree data structure using a BTree node representation.
 *          It supports various operations such as insert, search, traversal, and deletion.
 * Restrictions: The class assumes that the data stored in the BTree nodes are either strings, integers, or Person objects.
 *               The class does not handle duplicate nodes with the same data.
 */


namespace BTree
{


    public partial class BTreeForm : Form
    {


        public BTreeForm()
        {

            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }

            InitializeComponent();

            this.randomButton.Click += new EventHandler(RandomButton__Click);
            this.unbalancedButton.Click += new EventHandler(UnbalancedButton__Click);
            this.primedButton.Click += new EventHandler(PrimedButton__Click);
            this.button1.Click += new EventHandler(Exercise1__Click);
            this.button2.Click += new EventHandler(Exercise2__Click);
            this.button3.Click += new EventHandler(Exercise3__Click);
            this.button4.Click += new EventHandler(Exercise4__Click);
            this.button5.Click += new EventHandler(Exercise5__Click);
            this.button6.Click += new EventHandler(Exercise6__Click);
            this.button7.Click += new EventHandler(Exercise7__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // give the BTree class objects access to Form1
            BTree.bTreeForm = this;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RandomButton__Click(object sender, EventArgs e)
        {
            // load a tree with random numbers
            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(random.Next(100), root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\nAscending order:";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\nDescending order:";
            BTree.TraverseDescending(root);


            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void UnbalancedButton__Click(object sender, EventArgs e)
        {
            // load a tree in data-ascending order, 
            // which will cause it to be unbalanced and poor-performing
            BTree root = null;
            BTree node;

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(i, root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void PrimedButton__Click(object sender, EventArgs e)
        {
            // Prime a tree to hold alphabetical information

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;

            node = new BTree("M", null);
            root = node;

            node = new BTree("F", root);
            node = new BTree("C", root);
            node = new BTree("B", root);
            node = new BTree("A", root);
            node = new BTree("E", root);
            node = new BTree("D", root);

            node = new BTree("J", root);
            node = new BTree("I", root);
            node = new BTree("H", root);
            node = new BTree("G", root);
            node = new BTree("L", root);
            node = new BTree("K", root);

            node = new BTree("P", root);
            node = new BTree("O", root);
            node = new BTree("N", root);
            node = new BTree("T", root);
            node = new BTree("S", root);
            node = new BTree("R", root);
            node = new BTree("Q", root);

            node = new BTree("W", root);
            node = new BTree("V", root);
            node = new BTree("U", root);
            node = new BTree("X", root);
            node = new BTree("Y", root);
            node = new BTree("Z", root);

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise1__Click(object sender, EventArgs e)
        {
            // Exercise #1
            // insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();




            for (int i = 0; i < 30; ++i)
            {
                node = new BTree(random.Next(1, 52), root);
                if (i == 0)
                {
                    root = node;
                }
            }


            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise2__Click(object sender, EventArgs e)
        {
            // Exercise #2
            // prime the tree for numbers between 1 and 51
            // with 7 optimally distributed data points (setting isData = false) 
            // then insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();





            node = new BTree(26, root, false);
            root = node;
            node = new BTree(13, root, false);
            node = new BTree(6, root, false);
            node = new BTree(19, root, false);
            node = new BTree(39, root, false);
            node = new BTree(32, root, false);
            node = new BTree(45, root, false);


            for (int i = 0; i < 30; ++i)
            {
                node = new BTree(random.Next(1, 52), root);
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise3__Click(object sender, EventArgs e)
        {
            // Exercise #3
            // insert 15 random uppercase strings

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            // Loop to insert 15 random uppercase strings
            for (int i = 0; i < 15; i++)
            {
                // Generate a random uppercase string
                string randomString = "";
                for (int j = 0; j < 5; j++)
                {
                    char c = (char)random.Next(65, 91);
                    randomString += c;
                }

                // Create a new BTree node with the random string
                node = new BTree(randomString, root);
                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }


        private void Exercise4__Click(object sender, EventArgs e)
        {
            // Exercise #4
            // prime the tree using the code in Button3_Click()
            // then insert the 15 random uppercase strings from Exercise #3

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            Random random = new Random();

            // prime the tree using the code in Exercise3 button
            for (int i = 0; i < 15; i++)
            {
                // Generate a random uppercase string
                string randomString = "";
                for (int j = 0; j < 5; j++)
                {
                    char c = (char)random.Next(65, 91);
                    randomString += c;
                }

                // Create a new BTree node with the random string
                node = new BTree(randomString, root);
                if (i == 0)
                {
                    root = node;
                }
            }

            // insert the 15 random uppercase strings from Exercise3 button
            node = new BTree("KLMNO", root, false);
            node = new BTree("ABCDE", root, false);
            node = new BTree("FGHIJ", root, false);
            node = new BTree("PQRST", root, false);
            node = new BTree("UVWXY", root, false);
            node = new BTree("Z", root, false);

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }


        private void Exercise5__Click(object sender, EventArgs e)
        {
            // Exercise #5
            // use the code in Button3_Click to add the 26 letters to the tree
            // then remove nodes "C", "I" and "A" 
            // using this code to remove each node:
            //     // create new freestanding node for "C"
            //     nodeToDelete = new BTree("C", null);
            //     BTree.DeleteNode(nodeToDelete, root);
            // add the newline and call BTree.TraverseAscending() after each delete

            this.richTextBox.Clear();

            BTree node = null;
            BTree nodeToDelete = null;
            BTree root = null;

            // add the 26 letters to the tree
            node = new BTree("M", root, false);
            root = node;
            node = new BTree("Q", root, false);
            node = new BTree("K", root, false);
            node = new BTree("G", root, false);
            node = new BTree("C", root, false);
            node = new BTree("A", root, false);
            node = new BTree("E", root, false);
            node = new BTree("I", root, false);
            node = new BTree("O", root, false);
            node = new BTree("S", root, false);
            node = new BTree("U", root, false);
            node = new BTree("Y", root, false);
            node = new BTree("W", root, false);
            node = new BTree("R", root, false);
            node = new BTree("N", root, false);
            node = new BTree("L", root, false);
            node = new BTree("H", root, false);
            node = new BTree("D", root, false);
            node = new BTree("B", root, false);
            node = new BTree("F", root, false);
            node = new BTree("J", root, false);
            node = new BTree("P", root, false);
            node = new BTree("T", root, false);
            node = new BTree("V", root, false);
            node = new BTree("X", root, false);
            node = new BTree("Z", root, false);

            // remove node "C"
            nodeToDelete = new BTree("C", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            // remove node "I"
            nodeToDelete = new BTree("I", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            // remove node "A"
            nodeToDelete = new BTree("A", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }


        private void Exercise6__Click(object sender, EventArgs e)
        {
            // Exercise #6
            // there are operator overloads to compare 2 BTree objects for BTree.data being string or int
            // enhance the overloads to support the Person object and compare using Person.age using:                
            //     if (a.data.GetType() == typeof(Person))

            // create at least 15 new Person objects which correspond to members of your family
            // insert them into the tree starting with yourself
            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;

            // the Person class is defined below
            //Person person = null;

            // Your code here

            // create new Person objects
            Person myself = new Person("John Doe", 30);
            Person father = new Person("Tom Doe", 60);
            Person mother = new Person("Jane Doe", 55);
            Person sibling1 = new Person("Jack Doe", 25);
            Person sibling2 = new Person("Jill Doe", 20);
            Person grandparent1 = new Person("Joe Smith", 80);
            Person grandparent2 = new Person("Jane Smith", 75);
            Person aunt1 = new Person("Ann Smith", 50);
            Person uncle1 = new Person("Bob Smith", 55);
            Person cousin1 = new Person("Chris Smith", 30);
            Person cousin2 = new Person("Carla Smith", 25);
            Person cousin3 = new Person("Cathy Smith", 20);
            Person cousin4 = new Person("Charlie Smith", 15);
            Person cousin5 = new Person("Chloe Smith", 10);
            Person cousin6 = new Person("Cameron Smith", 5);

            // insert the Person objects into the tree
            node = root = new BTree(myself, null);
            node = BTree.Insert(new BTree(father, null), root);
            node = BTree.Insert(new BTree(mother, null), root);
            node = BTree.Insert(new BTree(sibling1, null), root);
            node = BTree.Insert(new BTree(sibling2, null), root);
            node = BTree.Insert(new BTree(grandparent1, null), root);
            node = BTree.Insert(new BTree(grandparent2, null), root);
            node = BTree.Insert(new BTree(aunt1, null), root);
            node = BTree.Insert(new BTree(uncle1, null), root);
            node = BTree.Insert(new BTree(cousin1, null), root);
            node = BTree.Insert(new BTree(cousin2, null), root);
            node = BTree.Insert(new BTree(cousin3, null), root);
            node = BTree.Insert(new BTree(cousin4, null), root);
            node = BTree.Insert(new BTree(cousin5, null), root);
            node = BTree.Insert(new BTree(cousin6, null), root);

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }


        // there are operator overloads to compare 2 BTree objects for BTree.data being string or int
        // enhance the overloads to support the Person object and compare using Person.age using:                
        //     if (a.data.GetType() == typeof(Person))
        public static bool operator < (BTree a, BTree b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            if (a.data.GetType() == typeof(Person) && b.data.GetType() == typeof(Person))
            {
                return ((Person)a.data).age < ((Person)b.data).age;
            }
            else if (a.data.GetType() == typeof(string) && b.data.GetType() == typeof(string))
            {
                return string.Compare((string)a.data, (string)b.data) < 0;
            }
            else if (a.data.GetType() == typeof(int) && b.data.GetType() == typeof(int))
            {
                return (int)a.data < (int)b.data;
            }
            else
            {
                throw new ArgumentException("Invalid data type for BTree node.");
            }
        }

        public static bool operator ==(BTree a, BTree b)
        {
            // If both BTree objects are null, they are equal
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            {
                return true;
            }

            // If either BTree object is null, they are not equal
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            // If the types of the BTree data do not match, they are not equal
            if (a.data.GetType() != b.data.GetType())
            {
                return false;
            }

            // If the BTree data types are string, int, or Person, compare their values for equality
            if (a.data is string && b.data is string)
            {
                return (string)a.data == (string)b.data;
            }
            else if (a.data is int && b.data is int)
            {
                return (int)a.data == (int)b.data;
            }
            else if (a.data is Person && b.data is Person)
            {
                return ((Person)a.data).Equals((Person)b.data);
            }

            // If the BTree data types are not supported, throw an exception
            throw new ArgumentException("Invalid data type for BTree node.");
        }

        public static bool operator !=(BTree a, BTree b)
        {
            return !(a == b);
        }


        public static bool operator >(BTree a, BTree b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            if (a.data.GetType() == typeof(Person) && b.data.GetType() == typeof(Person))
            {
                return ((Person)a.data).age > ((Person)b.data).age;
            }
            else if (a.data.GetType() == typeof(string) && b.data.GetType() == typeof(string))
            {
                return string.Compare((string)a.data, (string)b.data) > 0;
            }
            else if (a.data.GetType() == typeof(int) && b.data.GetType() == typeof(int))
            {
                return (int)a.data > (int)b.data;
            }
            else
            {
                throw new ArgumentException("Invalid data type for BTree node.");
            }
        }








        private void Exercise7__Click(object sender, EventArgs e)
        {
            // Exercise #7
            // given the age range of people in Exercise #6, 
            // prime the tree with nodes containing Person objects (set isData = false for the seed nodes)
            // containing the optimal ages to balance the tree
            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;

            // the Person class is defined below
            //Person person = null;

            // create new Person objects
            Person myself = new Person("John Doe", 30);
            Person father = new Person("Tom Doe", 60);
            Person mother = new Person("Jane Doe", 55);
            Person sibling1 = new Person("Jack Doe", 25);
            Person sibling2 = new Person("Jill Doe", 20);
            Person grandparent1 = new Person("Joe Smith", 80);
            Person grandparent2 = new Person("Jane Smith", 75);
            Person aunt1 = new Person("Ann Smith", 50);
            Person uncle1 = new Person("Bob Smith", 55);
            Person cousin1 = new Person("Chris Smith", 30);
            Person cousin2 = new Person("Carla Smith", 25);
            Person cousin3 = new Person("Cathy Smith", 20);
            Person cousin4 = new Person("Charlie Smith", 15);
            Person cousin5 = new Person("Chloe Smith", 10);
            Person cousin6 = new Person("Cameron Smith", 5);

            // insert the Person objects into the tree
            node = root = new BTree(null, null, false);
            node = BTree.Insert(new BTree(grandparent1, null, true), root);
            node = BTree.Insert(new BTree(grandparent2, null, true), root);
            node = BTree.Insert(new BTree(father, null, true), root);
            node = BTree.Insert(new BTree(mother, null, true), root);
            node = BTree.Insert(new BTree(aunt1, null, true), root);
            node = BTree.Insert(new BTree(uncle1, null, true), root);
            node = BTree.Insert(new BTree(sibling1, null, true), root);
            node = BTree.Insert(new BTree(sibling2, null, true), root);
            node = BTree.Insert(new BTree(cousin1, null, true), root);
            node = BTree.Insert(new BTree(cousin2, null, true), root);
            node = BTree.Insert(new BTree(cousin3, null, true), root);
            node = BTree.Insert(new BTree(cousin4, null, true), root);
            node = BTree.Insert(new BTree(cousin5, null, true), root);
            node = BTree.Insert(new BTree(cousin6, null, true), root);

            // balance the tree by setting the ages of the internal nodes to the median age of their children
            root.SetOptimalAges();

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

    }
}
