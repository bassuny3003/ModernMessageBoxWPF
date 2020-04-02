using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ModernMessageBoxWPF.AprovalWindows
{
    /// <summary>
    /// Interaction logic for MessageBoxYesNo.xaml
    /// </summary>
    public partial class MessageBoxYesNo : Window
    {

        public bool DialogResultRetern = false;

        public MessageBoxYesNo(string MessageHeader, string Message, int CustomHeight, int CustomWidth, string IconHeader, string ImageMessage)
        {
            InitializeComponent();

            btnNo.Focus();

            this.Height = CustomHeight;
            this.Width = CustomWidth;

            txtHeader.Text = MessageHeader;
            txtMassage.Text = Message;

            imgIconHeader.Source = new BitmapImage(new Uri(IconHeader, UriKind.RelativeOrAbsolute));
            imgMassage.Source = new BitmapImage(new Uri(ImageMessage, UriKind.RelativeOrAbsolute));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                brdrYesNo.Opacity = 0.7;
                DragMove();
            }

            if (e.LeftButton == MouseButtonState.Released)
            {
                brdrYesNo.Opacity = 1;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = false;
            Close();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = true;
            Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = false;
            Close();
        }
    }
}
