   M S B A M L   `   `   `  ���� U  QDistanceEducation(Windows), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:DistanceEducation_Windows_.Components%DistanceEducation_Windows_.Components  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� BasedOn �� 
TargetType   MenuButtonTheme �� Property �� Value �� 
TargetType �� CornerRadius �� Orientation �� BitmapScalingMode �� RelativeSource	 �� AncestorType
 �� Triggers P� Property P� Value  AccountButton  AuthorizationTextBox �� Mode �� Path?    9DistanceEducation_Windows_.Components.BindablePasswordBox  PasswordBox    Password  AuthorizationButton3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   
BlurRadius   Color  ListInstitutions  FocusVisual �� StrokeDashArray J� SnapsToDevicePixels  OptionMarkFocusVisual ! RadioButton.Static.Background �� Color 	 RadioButton.Static.Border 
 RadioButton.Static.Glyph $  RadioButton.MouseOver.Background   RadioButton.MouseOver.Border  RadioButton.MouseOver.Glyph " RadioButton.Pressed.Background  RadioButton.Pressed.Border  RadioButton.Pressed.Glyph # RadioButton.Disabled.Background  RadioButton.Disabled.Border  RadioButton.Disabled.Glyph �Name � ColumnDefinitions ��Name ��Name �� Triggers �� 
TargetName�� H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml     A	component3clr-namespace:DistanceEducation_Windows_.Components  %c  &	        7d�&	 �    7d�&	 �    &	 >    &	 �    &	 :    &	 �    &	 	    &	 ^	    &		 s	    &	
 �	    &	 �	    &	 �	    &	 �	    &	 �	    &	 �	    &	 
    &	 
    &	 *
    &	 ?
    '	� T
    7  7  7  7  7  7  7  �� 8    " 	����  � �� �� " 	�
MenuButton��.R��� $��Stretch=�$��Stretch=�#��z��$ 	0,10,10,0��$��0,0,10,0q�._��� $ 
Horizontal=�.+��� $ HighQuality=�$��24��$��24��$��	24,0,16,0q�$��Center=�$��Center=����� *Tag+ �� *FindAncestor+"	 	��� #��z��$��Center=�#��z��$��20(���  � ��
 ���� ��  � ��$ 0q���  �@�Cursor$
 Hand����  � ��$ Center=���  � ��
 �������  � ��$ 50��
 P�  �@d�	IsChecked$
 TrueY�. ���  � �� �#2F3CED��  � ��
 �����P�  �@J�IsMouseOver$
 True��. ���  � �� �#2F3CED��  � ��
 ������� 8    " 	����  � �� �� " 	�
MenuButton��.R��� #��z��$ 10,10,10,10��$��	15,0,10,0q�._��� ��  � ��
 ���� ��  � ��$ 0q���  �@�Cursor$
 Hand����  � ��$ Center=���  � ��
 �������  � ��$ 50��
 P�  �@J�IsMouseOver$
 True��. ���  � ��
 �   ���  � ��$ 1q��� " �����  � �� �#EEF6FB��  � ��$	 400����  � ��$ 50����  � �� �� " ��
AuthButton��.R��� $��Stretch=�$��Stretch=�#��z��$ 8��$��0,0,0,0q�._��� $��0q�$��Center=�
������ $��16(�$��	20,0,20,0q�����  �� *TemplatedParent+$ TwoWay=�$
 Text��� "   ���  � �� �#EEF6FB��  � ��$	 400����  � ��$ 50����  � �� �� "   PassBox��.R��� $��Stretch=�$��Stretch=�#��z��$ 8��$��0,0,0,0q�._�   $��0q�$��Center=�
������ $��16(�$��	20,0,20,0q� ��  �� *TemplatedParent+$ TwoWay=�$ Password��� " �����  � �� �#2F3CED��  � ��$	 140����  � ��$ 40����  �@�Cursor$
 Hand����  �@J�Effect   $ 0Q�$ 10Q�$
 Gray��
Shadow����  � �� �� " ��
Button��.R��� $��Stretch=�$��Stretch=�#��z��$ 8��$��0,0,0,0q�._��� #��z��$��16(����#FFFFFF$��Center=�$��Center=�
 P�  �@J�IsMouseOver$
 True��. ���  � ��$ 45����  � ��$	 145���� " �����  � �� �#EEF6FB��  � ��$	 400����  � ��$ 50����  �@��CornerRadius$ 8���� .���  � �� �� .R��� $��2q�$	 1 2R�#��� ��$
 true��$��1���� .���  � �� �� .R��� $��14,0,0,0q�$	 1 2R�#��� ��$
 true��$��1���� $ 	#FFFFFFFF���� $ 	#FF707070���� $ #A0D7E7���� $ 	#FFF3F9FF���� $ 	#FF5593FF���� $ #A0D7E7���� $ 	#FFD9ECFF���� $ 	#FF3C77DD���� $ #A0D7E7���� $ 	#FFE6E6E6���� $ 	#FFBCBCBC���� $ 	#FF707070���� " 	�.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 0q���  � �� �� " 	�.R�� $ templateRoot��
������ $
 True�� �� $
��Auto ��� $��* �.+��� $ radioButtonBorder��$��4��$��4��#��z��#��z��#��z��$	 100��#��z��$��1,1,2,1q�#��z���� $ contentPresenter��$��1��$|�False��#��z��#��z��$
��True��# z #��z�� P�  � ��$
 true��. ��� 8   �@�FocusVisualStyle��  � ��$ 4,-1,0,0q�P�  �@J�IsMouseOver$
 true��. ��� $ radioButtonBorder��8   � ��P�  � {�$ false��. ��� $ radioButtonBorder�� � ��$ 4���� $ radioButtonBorder�� � ��$ 4���� $ radioButtonBorder�� � ��$ 0q�P�  � ��$
 true��. ��� $ radioButtonBorder��8   � ���� $ radioButtonBorder��8   � ��P�  �@d�	IsChecked$
 trueY�. ��� $ radioButtonBorder�� � ��$ 8���� $ radioButtonBorder�� � ��$ 8���� $ radioButtonBorder�� � ��$ 2q�