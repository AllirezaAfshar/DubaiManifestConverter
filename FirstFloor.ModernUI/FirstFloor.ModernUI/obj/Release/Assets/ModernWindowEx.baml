   M S B A M L   `   `   `  ���� N  JFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:FirstFloor.ModernUI.Windows.Controls$FirstFloor.ModernUI.Windows.Controls  9!clr-namespace:FirstFloor.ModernUIFirstFloor.ModernUI  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   EmptyWindow �� 
TargetType7    1FirstFloor.ModernUI.Windows.Controls.ModernWindow �� BasedOn �� Property �� Value �� 
TargetType ��Name%  System.Windows.SystemParameters$   WindowNonClientFrameThickness	 �� Source  WindowBackgroundColor
 �� Color � 	Resources  Key �� 
TargetName �� TargetProperty	 �� To g� Duration �Name � RowDefinitions    BackgroundContent � ColumnDefinitions � Title  ModernWindowTitle    IsTitleVisible � DataContext   BooleanToVisibilityConverter �� 	Converter 
 Accent    LogoData  NullToVisibilityConverter �� ConverterParameter �� Stretch �� Orientation'  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome#   FirstFloor.ModernUI.Resources   Minimize � ToolTip  SystemButton#  System.Windows.SystemCommands   MinimizeWindowCommand  �� RelativeSource! �� Mode" �� AncestorType# ��Name$   Restore%   RestoreWindowCommand& � UseLayoutRounding'   Maximize(   MaximizeWindowCommand)   Close  SystemCloseButton*   CloseWindowCommand+   ResizeGripDirection 	 
WindowText, �� Triggers- P� Property. P� Value 
 WindowBorderActive/ �� 
TargetName0 ]� 
Conditions1 �� Property2 �� Value  BlankWindow�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     ?controls2clr-namespace:FirstFloor.ModernUI.Windows.Controls  .modernui!clr-namespace:FirstFloor.ModernUI    �� $7 1/FirstFloor.ModernUI;component/Assets/Button.xaml?��� $; 5/FirstFloor.ModernUI;component/Assets/Converters.xaml?��� $: 4/FirstFloor.ModernUI;component/Assets/TextBlock.xaml?�%�
  &	        7  7  7  7  7  7  7  7  &	 �
    7   �� "   8   .���  � ��$ 8q���  �@  IsTitleVisible . ��  � �� �� "   .R��� $ WindowBorder������ #	 Z ���� WindowBorderBackground��#
 �   ���� BackgroundAnimation .���� $ WindowBorderBackground��$ Color�# �  $ 0:0:.6D�._��� #��z��$��1q�._��� .u�� $ 
LayoutRoot�� �� $��36 ��� $��* �.+��� $��2��#��z �� $��1��#��z���  �� $��* ��� $
��Auto ��� $��96 �.+��� #��z $	��8,0q�$��Center=�8�� # z y��� 8  �� $��1��#���  $��36��$��36��$	��8,0q�# z y��� 8  $ inverse��._�F� $
 Fill=�
�������$��24��$��24��$��Center=�$��Center=����� �� $��2��$ 
Horizontal=�$	��Top=� . .+��� # Z 8�� ���� #	 Z ��� $��13��$��12��$z�1,0,0,1,0,1W�.+�F� ����    ��[ � z ��[ 	$��8��$��7��$��Center=�$��Center=�$��2������ *
Foreground+  �� $! FindAncestor=�$" ButtonL�� $��1,0,1,0q�.+��� $# Restore��# Z$ 8�� $y�Hidden=����� #	 Z% ��� $��13��$��12��& . $z�1,0,0,1,.5,.5W�.+�F� X���Ѐ�     � z     � z ��[ �    ��- р�[ ��- �    �� р�[ �� р�[  z �     z 	$��8��$��8��$��Center=�$��Center=�$��1������ *
Foreground+  �� $! FindAncestor=�$" ButtonL��� $# Maximize��# Z' 8�� ���� #	 Z( ��� $��13��$��12��.+�F� +����    @B �@T� @B �@T�  z �     z 	$��9��$��8��$��Center=�$��Center=�$��2������ *
Foreground+  �� $! FindAncestor=�$" ButtonL��� # Z) 8�� ���� #	 Z* ��� $��13��$��12��$z�1,0,0,1,0,1W�.+�F� +����        � z ��j � z     �    ��j 	$��8��$��7��$��Center=�$��Center=�$	��1.5������ *
Foreground+  �� $! FindAncestor=�$" ButtonL�� $ 
ResizeGrip��$��1��
������ $y�	Collapsed=�$��Right=�$��Bottom=�$+ BottomRight=�.+�F� $��12��$��12��$��1q�#��� 	 $��1��$
 None=������@B ��� ���- ��� �@KL ��� ���j ��� �@T� ��� ��ا ��� Ѐ� @T� р� �ا Ѐ�[ @T� р�[ �ا Ѐ�� @T� р�� �ا �@KL ��[ ���j ��[ �@T� ��[ ��ا ��[ Ѐ�[ @KL р�[ ��j Ѐ�� @KL р�� ��j �@T� �� ��ا �� Ѐ�� @B р�� ��- , P� - �@�IsActive. . . ��� # � 
  � ��P� - �@�WindowState$. 	Maximized=�. ��� $/ Maximize�� � y�$ 	Collapsed=��� $/ Restore�� � y�$ Visible=��� $/ 
LayoutRoot�� � ��$ 7q�P� - �@�WindowState$. Normal=�. ��� $/ Maximize�� � y�$ Visible=��� $/ Restore�� � y�$ 	Collapsed=�]� 0 �� 1 �@�
ResizeMode$2 CanResizeWithGrip=��� 1 �@�WindowState$2 Normal=�./��� $/ 
ResizeGrip�� � y�$ Visible=��� "   8   