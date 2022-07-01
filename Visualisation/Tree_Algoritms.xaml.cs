using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Visualisation
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Tree_Algoritms : Window
    {
        public Tree_Algoritms()
        {
            InitializeComponent();
        }
        Anim_Button act_anim = new Anim_Button();
        Algoritms.BinaryTree Tree = new Algoritms.BinaryTree();
        InputData window = new InputData();
        private void Action_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            act_anim.Old_Effect = Action_Button.Effect;
            Action_Button.Effect = act_anim.effect;
        }
        private void Action_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Action_Button.Effect = act_anim.Old_Effect;
        }

        private void EditData_CheckBox_Checked(object sender, EventArgs e)
        {
            EditData_Label.TextDecorations = TextDecorations.Underline;
            CreateTree_Grid.IsEnabled = false;
            CreateTree_Grid.Opacity = 0.5;
            OutputData_Grid.IsEnabled = false;
            OutputData_Grid.Opacity = 0.5;
        }

        private void CreateTree_CheckBox_Checked(object sender, EventArgs e)
        {
            CreateTree_Label.TextDecorations = TextDecorations.Underline;
            EditData_Grid.IsEnabled = false;
            EditData_Grid.Opacity = 0.5;
            OutputData_Grid.IsEnabled = false;
            OutputData_Grid.Opacity = 0.5;
        }

        private void OutputData_CheckBox_Checked(object sender, EventArgs e)
        {
            OutputData_Label.TextDecorations = TextDecorations.Underline;
            CreateTree_Grid.IsEnabled = false;
            CreateTree_Grid.Opacity = 0.5;
            EditData_Grid.IsEnabled = false;
            EditData_Grid.Opacity = 0.5;
        }

        private void EditData_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            EditData_Label.TextDecorations = null;
            CreateTree_Grid.IsEnabled = true;
            CreateTree_Grid.Opacity = 1;
            OutputData_Grid.IsEnabled = true;
            OutputData_Grid.Opacity = 1;
        }

        private void CreateTree_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CreateTree_Label.TextDecorations = null;
            EditData_Grid.IsEnabled = true;
            EditData_Grid.Opacity = 1;
            OutputData_Grid.IsEnabled = true;
            OutputData_Grid.Opacity = 1;
        }

        private void OutputData_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            OutputData_Label.TextDecorations = null;
            CreateTree_Grid.IsEnabled = true;
            CreateTree_Grid.Opacity = 1;
            EditData_Grid.IsEnabled = true;
            EditData_Grid.Opacity = 1;
        }

        private void Action_Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)EditData_CheckBox.IsChecked)
            {
                if ((bool)AddData_RB.IsChecked) 
                {
                    this.Visibility = Visibility.Collapsed;
                    window.Show();
                    if (window.Visibility == Visibility.Hidden)
                    {
                        int Value;
                        int.TryParse(window.Data_TextBox.Text, out Value);
                        Tree.Add(Value);
                        this.Visibility = Visibility.Visible;
                    }
                }
                else if ((bool)FindData_RB.IsChecked) 
                {

                }
                else if ((bool)RemoveData_RB.IsChecked) 
                {

                }
                else if ((bool)ReplaceData_RB.IsChecked) 
                {

                }
            }
        }
    }
}
