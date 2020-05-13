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
            //input the new value in the unsorted list
            if (unsortedList == null)
            {
                s = input.Text;
            }
            else
            {
                s += " " + input.Text;
            }

            //input the new value in the Tree
            myTree.AddRc(Int32.Parse(input.Text));

            //make sorted tree list
            string treeString1 = "";
            string treeString2 = "";
            myTree.PrintLH(null, ref treeString1);
            myTree.PrintHL(null, ref treeString2);

            //print the lists
            PrintLists(ref s, ref treeString1, ref treeString2);

            //clear the input field
            input.Clear();
        }

        private void LH_OnClick(object sender, RoutedEventArgs e)
        {
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
    }
}