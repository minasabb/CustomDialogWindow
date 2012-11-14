using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace CustomMessageBox
{
    /// <summary>
    /// Interaction logic for CustomDialogWindow.xaml
    /// </summary>
    public partial class CustomDialogWindow : Window
    {
        private CustomDialogResults _enumCustomDialogResult;

        public CustomDialogWindow()
       {
           InitializeComponent();

           if (Environment.OSVersion.Version.Major < 6)
               AllowsTransparency = true;

           Closing += CustomDialogWindowClosing;
           Loaded += CustomDialogWindowLoaded;
       }

        public  CustomDialogResults CustomDialogResult { get { return _enumCustomDialogResult; } }


       void CustomDialogWindowLoaded(object sender, RoutedEventArgs e)
       {
           tbAdditionalDetailsText.Visibility = Visibility.Collapsed;

           if (ResizeMode != ResizeMode.NoResize)
           {
               MinHeight = ActualHeight;
               MaxHeight = ActualHeight;

               MinWidth = ActualWidth;
               MaxWidth = ActualWidth;
           }

       }



       void CustomDialogWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
       {
           if (DialogResult.HasValue && DialogResult.Value)
               e.Cancel = false;
           else
               e.Cancel = true;
       }

       private void BtnYesClick(object sender, RoutedEventArgs e)
       {
           _enumCustomDialogResult = CustomDialogResults.Yes;
           DialogResult = true;
       }

       private void BtnOkClick(object sender, RoutedEventArgs e)
       {
           _enumCustomDialogResult = CustomDialogResults.OK;
           DialogResult = true;
       }

       private void BtnNoClick(object sender, RoutedEventArgs e)
       {
           _enumCustomDialogResult = CustomDialogResults.No;
           DialogResult = true;
       }

       private void BtnCancelClick(object sender, RoutedEventArgs e)
       {
           _enumCustomDialogResult = CustomDialogResults.Cancel;
           DialogResult = true;
       }


       private void ExpAdditionalDetailsClick(object sender, RoutedEventArgs e)
       {
           var tgButton = sender as ToggleButton;

           var ischecked = tgButton != null && (tgButton.IsChecked.HasValue && (bool)tgButton.IsChecked);

           if (ischecked)
           {
               if (ResizeMode != ResizeMode.NoResize)
                   MaxHeight = Double.PositiveInfinity;


               expAdditionalDetails.Content = "Hide Details";
               tbAdditionalDetailsText.Visibility = Visibility.Visible;
               UpdateLayout();

               if (ResizeMode != ResizeMode.NoResize)
                   MaxHeight = ActualHeight;
           }
           else
           {
               expAdditionalDetails.Content = "Show Details";
               tbAdditionalDetailsText.Visibility = Visibility.Collapsed;
               UpdateLayout();

               if (ResizeMode != ResizeMode.NoResize)
                   MaxHeight = ActualHeight;
           }
       }
    }
}
