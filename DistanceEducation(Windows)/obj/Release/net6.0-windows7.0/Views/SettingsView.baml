   M S B A M L   `   `   `  ���� U  QDistanceEducation(Windows), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:DistanceEducation_Windows_.Views DistanceEducation_Windows_.Views  3    -DistanceEducation_Windows_.Views.SettingsView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:DistanceEducation_Windows_.Views     .���   � ColumnDefinitions  �� ��  � RowDefinitions �� $��2* ��� �� �� �� �� �� .+��� $��2�� �� CornerRadius$ 12��$��
10,0,10,24q�����  j� Stretch$
 Fill=� �� ImageSource$. (/Resources/Images/BackgroundSettings.png��._�� $��24q�  �� �� .+��� $��50��$��50��$��1��$��Right=�$��Bottom=� � Cursor$
 Hand������ .R��� $ 45�����#FFFFFF._��� $��20��$��20�� �� BitmapScalingMode$ HighQuality=�$&�� /Resources/Icons/AccountExit.png���� $	��100��$	��100��$ 50�����#FFFFFF$
��Left=�$��Bottom=�._��� $
 Hand������ .R��� ���#2F3CED$��32��$��32��$ 45��$��Bottom=�$��Right=�._��� $*��$/Resources/Icons/UserPhotoChange.png��$ HighQuality=�$��20��$��20���� $��1��$��0��$��	10,0,10,0q�.+��� $��Ваша фамилия��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$��0,12,0,0q��� $��1��$��1��$��	10,0,10,0q�.+��� $��Ваша имя��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$��0,12,0,0q��� $��2��$��0��$��	10,0,10,0q�.+��� $��Email��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$��0,12,0,0q��� $��2��$��1��$��	10,0,10,0q�.+��� $!��Номер телефона��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$��0,12,0,0q��� $��3��$��2��$��	10,0,10,0q�.+��� $'��!Учебное заведение��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$��0,12,0,0q��� $��4��$��0��$��	10,0,10,0q�.+��� $!��Выбрать камеру��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$
��Auto��$��0,12,0,0q�   ListInstitutions#��[  ._��� $��	20,0,20,0q� �� DisplayMemberPath$
 Name�� �� SelectedValuePath$
 Name��$	 �� IsSynchronizedWithCurrentItem$
	 TrueY�  ComboBoxStyleREGISTRATION#��[ $
 Hand������ *ListInstitutions+
 �� SelectedItem
 �� *CurrenntSelection+��Z� �� $��4��$��1��$��	10,0,10,0q�.+��� $!��Качество видео��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$
��Auto��$��0,12,0,0q�#��[  ._��� $��	20,0,20,0q�$
 Name��$
 Name��$
	 TrueY�#��[ $
 Hand������ *ListInstitutions+
 �� *CurrenntSelection+��Z� �� $��5��$��0��$��	10,0,10,0q�.+��� $%��Выбрать микрофон��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$
��Auto��$��0,12,0,0q�#��[  ._��� $��	20,0,20,0q�$
 Name��$
 Name��$
	 TrueY�#��[ $
 Hand������ *ListInstitutions+
 �� *CurrenntSelection+��Z� �� $��5��$��1��$��	10,0,10,0q�.+��� $4��.Цветовая тема приложения��$��16(�$
��Bold"��� $ 8�����#EEF6FB$��50��$
��Auto��$��0,12,0,0q�#��[  ._��� $��	20,0,20,0q�$
 Name��$
 Name��$
	 TrueY�#��[ $
 Hand������ *ListInstitutions+
 �� *CurrenntSelection+��Z� �� $��Center=�$��7��$��2��$��	10,0,10,0q� �� Orientation$ 
Horizontal=�.+��� $-��'Версия программы - 1.001��$��Center=����#092C4C$
��Bold"��� ���#2F3CED$ 8��$��30��$	��320��$��13q�._��� $<��6Проверить наличие обновлений��$��Center=�$��Center=�$��16(����#FFFFFF�� ���#EAEEF4$ 8��$��30��$	��220��$��13q�._��� $)��#Обновить программу��$��Center=�$��Center=����#7E92A2$��16(�