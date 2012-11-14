using System;
using System.Windows;


namespace CustomMessageBox
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

        private void BtnOneClick1(object sender, RoutedEventArgs e)
        {
            var obj = new CustomDialog
                {
                    AdditionalDetailsText = "These are additional details",
                    Buttons = CustomDialogButtons.OKCancel,
                    DefaultButton = CustomDialogResults.OK,
                    InstructionHeading = "This is the instruction heading",
                    InstructionIcon = CustomDialogIcons.Question,
                    InstructionText = "Do you want to proceed with the next task?"
                };

            var objResults= obj.Show();

            tbResults.Text = String.Format("Last dialog result was {0}", objResults.ToString());
        }



        private void BtnTwoClick1(object sender, RoutedEventArgs e)
        {
            var obj = new CustomDialog
                {
                    Buttons = CustomDialogButtons.OK,
                    DefaultButton = CustomDialogResults.OK,
                    InstructionHeading = "This is the instruction heading",
                    InstructionIcon = CustomDialogIcons.Information,
                    InstructionText = "Here is the information for this dialog"
                };
            var objResults = obj.Show();

            tbResults.Text = String.Format("Last dialog result was {0}", objResults.ToString());
        }

        private void BtnThreeClick1(object sender, RoutedEventArgs e)
        {
            var obj = new CustomDialog
                {
                    AdditionalDetailsText = "You are using a very cool WPF dialog box that works :-)",
                    Buttons = CustomDialogButtons.OKCancel,
                    DefaultButton = CustomDialogResults.OK,
                    InstructionHeading = "Unable to Process this Payment",
                    InstructionIcon = CustomDialogIcons.Warning,
                    InstructionText = "What caused the problem? Was it something I said?"
                };
            var objResults = obj.Show();

            tbResults.Text = String.Format("Last dialog result was {0}", objResults.ToString());
        }

        private void btnFour_Click_1(object sender, RoutedEventArgs e)
        {
            var obj = new CustomDialog
            {
                Buttons = CustomDialogButtons.YesNo,
                DefaultButton = CustomDialogResults.Yes,
                InstructionHeading = "This is the instruction heading",
                InstructionIcon = CustomDialogIcons.Stop,
                InstructionText = "Do you want to proceed with the next task?"
            };

            var objResults = obj.Show();

            tbResults.Text = String.Format("Last dialog result was {0}", objResults.ToString());
        }

        private void btnFive_Click_1(object sender, RoutedEventArgs e)
        {
            var obj = new CustomDialog
            {
                Buttons = CustomDialogButtons.YesNoCancel,
                DefaultButton = CustomDialogResults.Yes,
                InstructionHeading = "This is the instruction heading",
                InstructionIcon = CustomDialogIcons.Question,
                InstructionText = "Do you want to proceed with the next task?"
            };

            var objResults = obj.Show();

            tbResults.Text = String.Format("Last dialog result was {0}", objResults.ToString());
        }

        private void btnSix_Click_1(object sender, RoutedEventArgs e)
        {
            var obj = new CustomDialog
            {
                AdditionalDetailsText = "Here is more details about this dialog!",
                Buttons = CustomDialogButtons.OK,
                DefaultButton = CustomDialogResults.OK,
                InstructionHeading = "This is the instruction heading",
                InstructionIcon = CustomDialogIcons.Shield,
                InstructionText = "Do you want to proceed with the next task?"
            };

            var objResults = obj.Show();

            tbResults.Text = String.Format("Last dialog result was {0}", objResults.ToString());
        }
    }
}
