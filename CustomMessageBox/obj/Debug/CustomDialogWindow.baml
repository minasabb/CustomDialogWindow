   M S B A M L   `   `   `  ����  CustomMessageBox)    #CustomMessageBox.CustomDialogWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35N JIQ.Core.Common, Version=4.11.2.27736, Culture=neutral, PublicKeyToken=nullR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  CustomDialogWindow��5      $
��Auto��5      $	��400��5      
������� J� SnapsToDevicePixels .  � SizeToContent$ Height=�5	       � WindowStartupLocation$ CenterScreen=�5
      $��0,0,0,0q�5       � WindowStyle$
 None=�5      .��5      � $
��Auto��5   	   $
��Auto��5   	   $��
10,10,0,10q�5   	    � ColumnDefinitions 5   
   �� 5      $
��Auto �5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �5      �� 5      $
��Auto �5      �� 5      $
��Auto �5      �� 5      $
��Auto �5      �� 5       $
��Auto �5!      .+�5#   
   �� -   5         ��Name$ imgInstructionIcon��5&      $
��Left=�5$      $��0,0,10,0q�5%      $	��Top=�5'      $
��Auto��5(      $
��Auto��5)      $!��CustomDialogInformation.png��5*      $��1��5+      $��0��5,      �� 5-   
   -   5         ��Name$ tbInstructionHeading��50      $��Stretch=�5.      $��0,0,0,0q�5/      $��Center=�51      $
��Auto��52      $��Instruction Heading��53      $
��Wrap=�54      $��1��55      $��1��56      $��1��57         MediumBoldTextBlockStyle#���   58      �� 59   
   -   5        $ tbInstructionText��5;      $��Stretch=�5:      $
��Auto��5<      $��0,10,0,0q�5=       ! RegularGrayBoldTextBlockStyle#���  5>      $��Instruction��5?      $
��Wrap=�5@      $��1��5A      $��1��5B      $��1��5C      $��1��5D      �� 5E   
   -   5        $ tbAdditionalDetailsText��5F      $��Stretch=�5G      $
��Auto��5H        RegularGrayTextBlockStyle#���  5I      $��Additional Details Text��5J      $
��Wrap=�5K      $
��0,10q�5L      $��Arial)�5M      $��1��5N      $��2��5O      $y�	Collapsed=�5P      �� 5Q   
   $��0,20,0,0q�5R      $	��Top=�5S      $��2��5T      $��3��5U      ._�5V      ]� $��0,8,0,8q�5W      $
��Auto��5X      $
��Auto��5Y      .+�5[      d� -   5        	 d�Name$	 expAdditionalDetails��5]      }�.  $
��Left=�5\      $��Center=�5^        TextOnlyToggleButtonStyle#���  5_      $��Show Details��5`      6,   �� 5a      -   5        
 ��Name$
 btnYes��5b      $��60��5c      $
��Auto��5d      $	��Yes��5e      $��Right=�5f      $��0,0,10,0q�5g      $��Center=�5h        PrimaryBlueButtonStyle#���  5i      $��Right=�5j      5k      �� 5m      -   5        $
 btnOK��5n      $��60��5o      $
��Auto��5p      $��OK��5q      #���  5r      $��Right=�5s      $��0,0,10,0q�5u      $��Center=�5v      $��Right=�5w      �� 5x      -   5        $
 	btnCancel��5y      $��60��5z      $
��Auto��5{        SecondaryButtonStyle#���  5|      $��Cancel��5}      $��Right=�5~      $��0,0,10,0q�5      $��Center=�5�      $��Right=�5�      �� 5�      -	   5        $
 btnNo��5�      $��60��5�      $
��Auto��5�      $��No��5�      $��Right=�5�      $��0,0,10,0q�5�      #���  5�      $��Center=�5�      $��Right=�5�      5�      5�      5�      5�      