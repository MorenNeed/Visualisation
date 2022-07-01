using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Visualisation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        Anim Binary_Search_Tree_anim = new Anim("Binary_Tree_Search(Base)", "Binary_Tree_Search(gif)");
        private async void Binary_Search_Tree_MouseEnter(object sender, MouseEventArgs e)
        {
            
            Binary_Search_Tree_anim.Old_Effect = Binary_Search_Tree.Effect;
            Binary_Search_Tree_gif.Source = Binary_Search_Tree_anim.Old_Source;
            Binary_Search_Tree.Effect = Binary_Search_Tree_anim.effect;
            int i = 0;
            if(Binary_Search_Tree_gif.Source == Binary_Search_Tree_anim.Old_Source) 
            {
                do
                {
                    Binary_Search_Tree_anim.bitmapSource = Binary_Search_Tree_anim.decoder.Frames[i];
                    Binary_Search_Tree_gif.Source = Binary_Search_Tree_anim.bitmapSource;
                    await Task.Delay(800);
                    i++;
                } while (i != 4);
            }
            Binary_Search_Tree_gif.Source = Binary_Search_Tree_anim.Old_Source;
        }
        private void Binary_Search_Tree_MouseLeave(object sender, MouseEventArgs e)
        {
            Binary_Search_Tree.Effect = Binary_Search_Tree_anim.Old_Effect;
        }

        private void Binary_Search_Tree_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Tree_Algoritms Window = new Tree_Algoritms();
            Window.Show();
        }
    }
}
