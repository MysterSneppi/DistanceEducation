   M S B A M L   `   `   `  ����U  QDistanceEducation(Windows), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:DistanceEducation_Windows_.Pages DistanceEducation_Windows_.Pages  5   	   ]3clr-namespace:DistanceEducation_Windows_.ViewModels%DistanceEducation_Windows_.ViewModels  5   	   ]3clr-namespace:DistanceEducation_Windows_.Components%DistanceEducation_Windows_.Components  6H   :    4DistanceEducation_Windows_.Pages.AuthorizationWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:DistanceEducation_Windows_.Pages     5   	   Bvm3clr-namespace:DistanceEducation_Windows_.ViewModels     5   	   J
components3clr-namespace:DistanceEducation_Windows_.Components     6H   $	��700��5	   	   $	��900��6     � WindowStartupLocation$  CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � DataContext 5      B  <DistanceEducation_Windows_.ViewModels.AuthorizationViewModel  5   
   .��5      � ��5   
   �� 5   
    �� ImageSource$* $/Resources/Images/AuthBackground.png��6    j� Stretch$ UniformToFill=�6H   .+�5   
   �� $��Center=�6    �� CornerRadius$ 12��5      $��Center=�5      
�������$	��500��5      $	��500��5      ._�5      � $��50,50,50,20q�6   .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��18(�6    $��Авторизация��5        $
��Bold"�5!       $��Center=�5"       $��Center=�5#       $��0,0,0,27q�5$       ���#092C4C5%       �� 5'      $'��!Учебное заведение��6    $��16(�5(       $
��Bold"�5)       $��0,7,0,12q�5*       ���#092C4C5+       �� 5.         ListInstitutions#��[  6   ._�5/      �� -   5         ��Name$ Institutions��52      $��	20,0,20,0q�50   #    �� DisplayMemberPath$
 Name��51      	 �� SelectedValuePath$
	 Name��54      $
 �� IsSynchronizedWithCurrentItem$

 TrueY�55        ComboBoxStyleREGISTRATION#��[ 56       � Cursor$
 Hand��6j   ��5/   #   �� *ListInstitutions+ �� SelectedItem 53      �� *CurrenntSelection+��56   S   Z� 6j   58      �� 5=      $��
Логин��6    $��16(�5>       $
��Bold"�5?       $��0,7,0,12q�5@       ���#092C4C5A       �� 5B        AuthorizationTextBox#��[ 5C      ��5B      �� *Login+ �� UpdateSourceTrigger$ PropertyChanged=�5C      �� 5F      $��Пароль��6    $��16(�5G       $
��Bold"�5H       $��	0,24,0,12q�5I       ���#092C4C5J       ?   9DistanceEducation_Windows_.Components.BindablePasswordBox  5L        PasswordBox#��[ 6S      Password 65   �� *
Password+6S   �� 5O      $��
Войти��5P      $��0,40,0,0q�5Q        AuthorizationButton#��[ 5R      ��5O      �� *
SendData+5R      5S      5T      5V      5W      5X      