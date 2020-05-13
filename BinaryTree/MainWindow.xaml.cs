using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Binary_Tree.BinaryTree;

namespace BinaryTree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private string s;
        Tree myTree = new Tree();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrintLists(ref string unsorted, ref string sortedLH, ref string sortedHL)
        {
            unsortedList.Text = unsorted;
            sortedListLH.Text = sortedLH;
            sortedListHL.Text = sortedHL;
        }

        private void Add_OnClick(object sender, RoutedEventArgs e)
        {
            int number;
            if (input.Text != "" || Int32.TryParse(input.Text, out number))
            {
                //input the new value in the unsorted list
                if (unsortedList.Text == "")
                {
                    s = input.Text;
                }
                else
                {
                    s += " " + input.Text;
                }

                //input the new value in the Tree
                myTree.AddRc(Int32.Parse(input.Text));

                PrintValues();
            }
            else if (input.Text != "")
            {
                MessageBox.Show("Wrong input value given.", "Wrong input detected");
            }
            else
            {
                MessageBox.Show("No value is given.", "No input detected");
            }
           
            //clear the input field
            input.Clear();
        }

        private void LH_OnClick(object sender, RoutedEventArgs e){
            if (sortedText.Visibility == Visibility.Hidden)
                sortedText.Visibility = Visibility.Visible;
            else if (sortedText.Visibility == Visibility.Visible && sortedListHLText.Visibility == Visibility.Hidden)
                sortedText.Visibility = Visibility.Hidden;

            if (sortedListLHText.Visibility == Visibility.Hidden)
            {
                sortedListLHText.Visibility = Visibility.Visible;
                sortedListLH.Visibility = Visibility.Visible;
            }
            else
            {
                sortedListLHText.Visibility = Visibility.Hidden;
                sortedListLH.Visibility = Visibility.Hidden;
            }
        }

        private void HL_OnClick(object sender, RoutedEventArgs e)
        {
            if (sortedText.Visibility == Visibility.Hidden)
                sortedText.Visibility = Visibility.Visible;
            else if (sortedText.Visibility == Visibility.Visible && sortedListLHText.Visibility == Visibility.Hidden)
                sortedText.Visibility = Visibility.Hidden;

            if (sortedListHLText.Visibility == Visibility.Hidden)
            {
                sortedListHLText.Visibility = Visibility.Visible;
                sortedListHL.Visibility = Visibility.Visible;
            }
            else
            {
                sortedListHLText.Visibility = Visibility.Hidden;
                sortedListHL.Visibility = Visibility.Hidden;
            }
        }

        private void Random_OnClick(object sender, RoutedEventArgs e)
        {
            int number;
            if (Int32.TryParse(randomAmount.Text, out number))
            {
                var rand = new Random();
                for (int i = 0; i < Int32.Parse(randomAmount.Text); i++)
                {
                    int value = rand.Next(101);
                    
                    if (unsortedList.Text == "")
                    {
                        s = value.ToString();
                    }
                    else
                    {
                        s += " " + value;
                    }
                    
                    myTree.AddRc(value);
                    PrintValues();
                }
            }
            else
            {
                MessageBox.Show("No value is given.", "No input detected");
            }
            
            randomAmount.Clear();
        }

        private void PrintValues()
        {
            //make sorted tree list
            string treeString1 = "";
            string treeString2 = "";
            myTree.PrintLH(null, ref treeString1);
            myTree.PrintHL(null, ref treeString2);

            //print the lists
            PrintLists(ref s, ref treeString1, ref treeString2);
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            myTree.deleteTree(myTree.top);
            myTree.top = null;
            unsortedList.Text = "";
            sortedListLH.Text = "";
            sortedListHL.Text = "";
        }

        private void Show_OnClick(object sender, RoutedEventArgs e)
        {
            string message = "this will be the tree";
            string title = "Binary tree visualisation";
            MessageBox.Show(message, title);
        }
    }
}