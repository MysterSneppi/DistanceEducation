   M S B A M L   `   `   `  ���� U  QDistanceEducation(Windows), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:DistanceEducation_Windows_.Pages DistanceEducation_Windows_.Pages  ]3clr-namespace:DistanceEducation_Windows_.ViewModels%DistanceEducation_Windows_.ViewModels  ]3clr-namespace:DistanceEducation_Windows_.Components%DistanceEducation_Windows_.Components  :    4DistanceEducation_Windows_.Pages.AuthorizationWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @local.clr-namespace:DistanceEducation_Windows_.Pages     Bvm3clr-namespace:DistanceEducation_Windows_.ViewModels     J
components3clr-namespace:DistanceEducation_Windows_.Components     $	��700��$	��900��  � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � DataContext B  <DistanceEducation_Windows_.ViewModels.AuthorizationViewModel  .��� ����  �� ImageSource$* $/Resources/Images/AuthBackground.png�� j� Stretch$ UniformToFill=�.+��� $��Center=� �� CornerRadius$ 12��$��Center=�
�������$	��500��$	��500��._�� $��50,50,50,20q�.+���  �� Orientation$ Vertical=�.+��� $��18(�$��Авторизация��$
��Bold"�$��Center=�$��Center=�$��0,0,0,27q����#092C4C�� $'��!Учебное заведение��$��16(�$
��Bold"�$��0,7,0,12q����#092C4C��    ListInstitutions#��[  ._��� -    ��Name$ Institutions��$��	20,0,20,0q� �� DisplayMemberPath$
 Name��	 �� SelectedValuePath$
	 Name��$
 �� IsSynchronizedWithCurrentItem$

 TrueY�  ComboBoxStyleREGISTRATION#��[  � Cursor$
 Hand������ *ListInstitutions+ �� SelectedItem �� *CurrenntSelection+��Z� �� $��
Логин��$��16(�$
��Bold"�$��0,7,0,12q����#092C4C��   AuthorizationTextBox#��[ ���� *Login+ �� UpdateSourceTrigger$ PropertyChanged=��� $��Пароль��$��16(�$
��Bold"�$��	0,24,0,12q����#092C4C?   9DistanceEducation_Windows_.Components.BindablePasswordBox    PasswordBox#��[    Password �� *
Password+�� $��
Войти��$��0,40,0,0q�  AuthorizationButton#��[ ���� *
SendData+