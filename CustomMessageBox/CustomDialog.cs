using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media.Imaging;


namespace CustomMessageBox
{

    public class CustomDialog
    {
        private String _strCallingMethodName = String.Empty;
        private String _strCallingModuleName = String.Empty;
        private String _strCallingReflectedTypeName = String.Empty;
        private CustomDialogButtons _enumButtons = CustomDialogButtons.OK;
        private CustomDialogResults _enumCustomDialogResult = CustomDialogResults.None;
        private CustomDialogResults _enumDefaultButton = CustomDialogResults.None;
        private CustomDialogIcons _enumInstructionIcon = CustomDialogIcons.None;
        private string _strAdditionalDetailsText = String.Empty;
        private string _strInstructionHeading = String.Empty;
        private string _strInstructionText = String.Empty;

        public CustomDialog()
        {
        }

        public CustomDialog(string strInstructionHeading, string strInstructionText, CustomDialogButtons enumButtons , CustomDialogResults enumDefaultButton , CustomDialogIcons enumInstructionIcon )
        {
            _strInstructionHeading = strInstructionHeading;
            _strInstructionText = strInstructionText;
            _enumButtons = enumButtons;
            _enumDefaultButton = enumDefaultButton;
            _enumInstructionIcon = enumInstructionIcon;

        }


    public CustomDialog( string strInstructionHeading, string strInstructionText, string strAdditionalDetailsText, CustomDialogButtons enumButtons, CustomDialogResults enumDefaultButton, CustomDialogIcons enumInstructionIcon)
    {

        _strInstructionHeading = strInstructionHeading;
        _strInstructionText = strInstructionText;
        _strAdditionalDetailsText = strAdditionalDetailsText;
        _enumButtons = enumButtons;
        _enumDefaultButton = enumDefaultButton;
        _enumInstructionIcon = enumInstructionIcon;

    }


        public CustomDialogResults  Show()
        {
            

            var objTrace = new StackTrace();
            if (_strCallingReflectedTypeName.Length == 0)
                _strCallingReflectedTypeName = objTrace.GetFrame(1).GetMethod().ReflectedType.Name;


            if (_strCallingMethodName.Length == 0)
                _strCallingMethodName = objTrace.GetFrame(1).GetMethod().Name;


            if (_strCallingModuleName.Length == 0)
                _strCallingModuleName = objTrace.GetFrame(1).GetMethod().Module.Name;


            var obj = new CustomDialogWindow();

            if (InstructionIcon == CustomDialogIcons.None)
                obj.imgInstructionIcon.Visibility = Visibility.Collapsed;

            else
                obj.imgInstructionIcon.Source = new BitmapImage(GetIcon(InstructionIcon));


            obj.tbInstructionText.Text = InstructionText;

            obj.tbInstructionHeading.Text = InstructionHeading;

            if(AdditionalDetailsText.Length > 0)
                obj.tbAdditionalDetailsText.Text = AdditionalDetailsText;
            else
                obj.expAdditionalDetails.Visibility = Visibility.Collapsed;


            SetButtons(obj);


            obj.ShowInTaskbar = false;

            obj.ShowDialog();
            _enumCustomDialogResult = obj.CustomDialogResult;

            LogDialog();

            return _enumCustomDialogResult;
        }
        
        private Uri GetIcon(CustomDialogIcons enumCustomDialogIcon)
        {
            switch (enumCustomDialogIcon)
            {

                case CustomDialogIcons.Information:
                    return new Uri("CustomDialogInformation.png", UriKind.Relative);

                case CustomDialogIcons.None:
                    return null;

                case CustomDialogIcons.Question:
                    return
                        new Uri
                            ("CustomDialogQuestion.png",
                             UriKind.Relative);

                case
                    CustomDialogIcons.Shield:
                    return
                        new Uri
                            ("CustomDialogShield.png",
                             UriKind.Relative);

                case
                    CustomDialogIcons.Stop:
                    return
                        new Uri
                            ("CustomDialogStop.png",
                             UriKind.Relative);

                case
                    CustomDialogIcons.Warning:
                    return
                        new Uri
                            ("CustomDialogWarning.png",
                             UriKind.Relative);

                default:
                    return null;
            }

        }

        private void LogDialog()
        {
            // developers, you can log the result here.  There is rich information within this class to provides great tracking of your users dialog box activities.
            //ensure that you review each property and include them in your log entry
            //don't forget to log the Windows user name also
        }

        private void SetButtons(CustomDialogWindow obj)
        {
            switch (Buttons)
            {

                case
                    CustomDialogButtons.OK:
                    obj.btnCancel.Visibility = Visibility.Collapsed;
                    obj.btnNo.Visibility = Visibility.Collapsed;
                    obj.btnYes.Visibility = Visibility.Collapsed;
                    break;
                case
                    CustomDialogButtons.OKCancel:
                    obj.btnNo.Visibility = Visibility.Collapsed;
                    obj.btnYes.Visibility = Visibility.Collapsed;
                     break;
                case
                    CustomDialogButtons.YesNo:
                     obj.btnOK.Visibility = Visibility.Collapsed;
                     obj.btnCancel.Visibility = Visibility.Collapsed;
                    break;
                case
                    CustomDialogButtons.YesNoCancel:
                    obj.btnOK.Visibility = Visibility.Collapsed;
                     break;

            }

            switch (DefaultButton)
            {

                    case
                CustomDialogResults.Cancel:
                    obj.btnCancel.IsDefault = true;
                    break;
                    case
                CustomDialogResults.No:
                    obj.btnNo.IsDefault = true;
                    obj.btnCancel.IsCancel = true;
                    break;
                    case
                CustomDialogResults.None:
                    obj.btnCancel.IsCancel = true;
                    break;
                case
                CustomDialogResults.OK:
                    obj.btnOK.IsDefault = true;
                    obj.btnCancel.IsCancel = true;
                    break;
                    case 
                CustomDialogResults.Yes:
                    obj.btnYes.IsDefault = true;
                    obj.btnCancel.IsCancel = true;
                    break;


            }

        }


        public string AdditionalDetailsText
        {
            get { return _strAdditionalDetailsText; }
            set { _strAdditionalDetailsText = value; }
        }


        public CustomDialogButtons Buttons
        {
            get { return _enumButtons; }
            set { _enumButtons = value; }
        }

        public string CallingMethodName
        {
            get { return _strCallingMethodName; }
            set { _strCallingMethodName = value; }
        }


        public string CallingModuleName
        {
            get { return _strCallingModuleName; }
            set { _strCallingModuleName = value; }
        }


        public string CallingReflectedTypeName
        {
            get { return _strCallingReflectedTypeName; }
            set { _strCallingReflectedTypeName = value; }
        }

        public CustomDialogResults DefaultButton
        {
            get { return _enumDefaultButton; }
            set { _enumDefaultButton = value; }
        }


        public String InstructionHeading
        {
            get { return _strInstructionHeading; }
            set { _strInstructionHeading = value; }
        }


        public CustomDialogIcons InstructionIcon
        {
            get { return _enumInstructionIcon; }
            set { _enumInstructionIcon = value; }
        }


        public String InstructionText
        {
            get { return _strInstructionText; }
            set { _strInstructionText = value; }
        }
    }
}
