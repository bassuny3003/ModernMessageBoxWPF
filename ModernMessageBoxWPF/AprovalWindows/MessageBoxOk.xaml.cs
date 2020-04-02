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
    /// Interaction logic for MessageBoxOk.xaml
    /// </summary>
    public partial class MessageBoxOk : Window
    {
        public MessageBoxOk(string MessageHeader, string Message, int CustomHeight, int CustomWidth, string IconHeader, string ImageMessage)
        {
            InitializeComponent();

            btnOk.Focus();

            this.Height = CustomHeight;
            this.Width = CustomWidth;

            txtHeader.Text = MessageHeader;
            txtMessage.Text = Message;

            imgIconHeader.Source = new BitmapImage(new Uri(IconHeader, UriKind.RelativeOrAbsolute));
            imgMessage.Source = new BitmapImage(new Uri(ImageMessage, UriKind.RelativeOrAbsolute));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                brdrOk.Opacity = 0.7;
                DragMove();
            }

            if (e.LeftButton == MouseButtonState.Released)
            {
                brdrOk.Opacity = 1;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
