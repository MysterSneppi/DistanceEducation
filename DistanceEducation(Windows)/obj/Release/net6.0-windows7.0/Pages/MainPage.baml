   M S B A M L   `   `   `  ���� U  QDistanceEducation(Windows), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:DistanceEducation_Windows_.Pages DistanceEducation_Windows_.Pages  S.clr-namespace:DistanceEducation_Windows_.Views DistanceEducation_Windows_.Views  ]3clr-namespace:DistanceEducation_Windows_.ViewModels%DistanceEducation_Windows_.ViewModels  /    )DistanceEducation_Windows_.Pages.MainPage   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:DistanceEducation_Windows_.Pages     ?view.clr-namespace:DistanceEducation_Windows_.Views     I	viewmodel3clr-namespace:DistanceEducation_Windows_.ViewModels       � DataContext  K  EDistanceEducation_Windows_.ViewModels.MainPageLessonItemListViewModel  .���  � RowDefinitions �� $��0.15* ��� $��0.75* �.+�� $��0��.+��  � ColumnDefinitions �� $
��0.6* ��� $
��0.4* �.+��� $/��)Почему ещё не на уроке?��$��40(�$
��Bold"�$��Center=�$��0��$��30,0,0,0q�]� $��1��$��False�����#F5FBFF.+���  �� CornerRadius$ 30��$��Right=�
�������$��Center=�$��48��$��48��$��0,0,60,0q�._��� $��24��$��24��$��/Resources/Icons/bell.png�� �� BitmapScalingMode$ HighQuality=�� $��1�� �� $
��0.6* ��� $
��0.4* �.+�� $��0�� �� $
��0.6* ��� $
��0.4* �.+�8   2DistanceEducation_Windows_.Views.ImageCarouselView  $��0��$��34,0,0,0q�$
��Left=��� $��1��$��Center=�$��28,0,0,0q����� .R��  � Orientation$ 
Horizontal=�.@�;   5DistanceEducation_Windows_.Views.MainPageChatItemView      � $��1��$��24,20,38,45q����#F5FBFF �� $	��64* ��� $
��103* ��� $
��469* �.+��� $$��Занятия сегодня:��$��18(�$
��Bold"�$��0��$��
24,0,0,102q�$��2���� $��Hidden=�$��1��$��2��.���� $��1������ *items+���� .R�� $ Vertical=�