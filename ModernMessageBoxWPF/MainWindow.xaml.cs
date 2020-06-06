using ModernMessageBoxWPF.AprovalWindows;
using System.Windows;

namespace ModernMessageBoxWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMBOk_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxOk messageOk = new MessageBoxOk("Information..", "This is Information about ..........", 200, 500, @"/Images/information.png", @"/Images/askquestion.png");
            messageOk.Owner = this;
            messageOk.ShowDialog();
        }

        private void btnMBYesNo_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxYesNo messageYesNo =  new MessageBoxYesNo("Ask For Aproval..", "This is Need Aproval ..........?", 200, 500, @"/Images/askquestion.png", @"/Images/askquestion.png");
            messageYesNo.Owner = this;
            messageYesNo.ShowDialog();

            if (messageYesNo.DialogResultRetern)
            {
                lblYesNoRetern.Content = "Retern True :) " ;
            }
            else
            {
                lblYesNoRetern.Content = "Retern False :( ";
            }
        }

        private void btnMBYesNoCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxYesNoCancel messageBoxYesNoCancel = new MessageBoxYesNoCancel("Ask For 3 Aproval..", "This is Need Aproval 3 ..........?", 200, 500, @"/Images/error.png", @"/Images/error.png");
            messageBoxYesNoCancel.Owner = this;
            messageBoxYesNoCancel.ShowDialog();

            if (messageBoxYesNoCancel.DialogResultRetern == "yes")
            {
                lblYesNoCancelRetern.Content = "Retern Yes :) ";
            }
            else if(messageBoxYesNoCancel.DialogResultRetern == "no")
            {
                lblYesNoCancelRetern.Content = "Retern No :( ";
            }
            else
            {
                lblYesNoCancelRetern.Content = "Retern Cancel :'( ";
            }
        }
    }
}
