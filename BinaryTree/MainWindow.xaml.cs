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
        
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
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

            unsortedList.Text = s;
            
            //input the new value in the Tree
            myTree.AddRc(Int32.Parse(input.Text));
            
            //print sorted tree
            string treeString = "";
            myTree.Print(null, ref treeString);
            sortedList.Text = treeString;
            
            //clear the input field
            input.Clear();
        }
    }
}