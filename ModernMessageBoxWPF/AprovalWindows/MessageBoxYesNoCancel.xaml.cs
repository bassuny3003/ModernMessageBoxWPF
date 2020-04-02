using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ModernMessageBoxWPF.AprovalWindows
{
    /// <summary>
    /// Interaction logic for MessageBoxYesNoCancel.xaml
    /// </summary>
    public partial class MessageBoxYesNoCancel : Window
    {
        public string DialogResultRetern;

        public MessageBoxYesNoCancel(string MessageHeader, string Message, int CustomHeight, int CustomWidth, string IconHeader, string ImageMessage)
        {
            InitializeComponent();

            btnCancel.Focus();

            this.Height = CustomHeight;
            this.Width = CustomWidth;

            txtHeader.Text = MessageHeader;
            txtMassage.Text = Message;

            imgIconHeader.Source = new BitmapImage(new Uri(IconHeader, UriKind.RelativeOrAbsolute));
            imgMassage.Source = new BitmapImage(new Uri(ImageMessage, UriKind.RelativeOrAbsolute));
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                brdrYesNoCancel.Opacity = 0.7;
                DragMove();
            }

            if (e.LeftButton == MouseButtonState.Released)
            {
                brdrYesNoCancel.Opacity = 1;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = "cancel";
            Close();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = "yes";
            Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = "no";
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResultRetern = "cancel";
            Close();
        }
    }
}
