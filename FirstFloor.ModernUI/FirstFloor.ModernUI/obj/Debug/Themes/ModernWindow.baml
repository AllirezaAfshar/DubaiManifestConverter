   M S B A M L   `   `   `  ����N  JFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FirstFloor.ModernUIFirstFloor.ModernUI  5      [2clr-namespace:FirstFloor.ModernUI.Windows.Controls$FirstFloor.ModernUI.Windows.Controls  5      _4clr-namespace:FirstFloor.ModernUI.Windows.Navigation&FirstFloor.ModernUI.Windows.Navigation  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source7    1FirstFloor.ModernUI.Windows.Controls.ModernWindow �� 
TargetType �� Property   WindowBackgroundContent �� Value  DefaultFontFamily  DefaultFontSize  
WindowText  WindowBorder&   System.Windows.Media.TextOptions �� 
TargetType ��Name%  System.Windows.SystemParameters$   WindowNonClientFrameThickness �� Source  WindowBackgroundColor	 �� Color
 � 	Resources  Key �� 
TargetName �� TargetProperty	 �� To g� Duration �Name � RowDefinitions    BackgroundContent � ColumnDefinitions `� IsLocked c� OverflowMode � Cursor    
TitleLinks'  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome �� Orientation ��Name	 �� X1	 �� Y1	 �� X2	 �� Y2  SeparatorBackground  SystemButtonLink �� ElementName �� Triggers  �� Binding! �� RelativeSource" �� Value# �� 
TargetName 
	 Accent$    LogoData% � DataContext 
 NullToVisibilityConverter& �� 	Converter' �� ConverterParameter( �� Stretch#   FirstFloor.ModernUI.Resources)   Minimize* � ToolTip  SystemButton#  System.Windows.SystemCommands+   MinimizeWindowCommand, �� Mode- �� AncestorType. ��Name/   Restore0   RestoreWindowCommand1 � UseLayoutRounding2   Maximize3   MaximizeWindowCommand4   Close  SystemCloseButton5   CloseWindowCommand5   /FirstFloor.ModernUI.Windows.Controls.ModernMenu6    MenuLinkGroups7   
LinkGroups8   SelectedSource9 �� Mode6   0FirstFloor.ModernUI.Windows.Controls.ModernFrame:  Name;    ContentLoader<   ContentLoader=   Source>   ResizeGripDirection? �� Triggers@ P� PropertyA P� Value  WindowBorderActiveB ]� 
ConditionsC �� PropertyD �� ValueE   CornerRadiusF   GlassFrameThicknessG   UseAeroCaptionButtonsH   NonClientFrameEdges�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .modernui!clr-namespace:FirstFloor.ModernUI  5      ?controls2clr-namespace:FirstFloor.ModernUI.Windows.Controls  5      C
navigation4clr-namespace:FirstFloor.ModernUI.Windows.Navigation  5        5      �� 5   
   $7 1/FirstFloor.ModernUI;component/Assets/Button.xaml?�6   �� 5	   
   $; 5/FirstFloor.ModernUI;component/Assets/Converters.xaml?�6   �� 5
   
   $: 4/FirstFloor.ModernUI;component/Assets/TextBlock.xaml?�6   %�  '         7  7 
 7  7  7  7  �� 5      "   6   .�5   
   ��  �@  BackgroundContent# �   6.   �� 5   
    � ��# �  6'   �� 5   
    � ��# �  6%   �� 5   
    � ��# �  6'   �� 5   
    � ��# �  6(   �� 5   
    � ��$	 800��6"   �� 5   
    � ��$	 640��6#   �� 5   
    � ��$	 320��6%   �� 5   
    � ��$	 320��6&   �� 5   
    �@�
ResizeMode$ CanResizeWithGrip=�6'   �� 5   
    �@�UseLayoutRounding . 6.   �� 5   
    �@ TextFormattingMode$ Display=�6;   �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� $ WindowBorder��6   ��63   �� # Z ��5      �� 5       WindowBorderBackground��#	 �  6N   
 5"      ���� 5#      BackgroundAnimation .��5$   "   �� $ WindowBorderBackground��61   $ Color�6`   # �  6�   $ 0:0:.6D�6�   5%      5&      ._�5(      �� #��z��6!   $��1q�6M   ._�5)      �� .u�5*   "   � $ 
LayoutRoot��6'    5+   &   �� 5,   *   $
��Auto �68   �� 5-   *   $
��Auto �68   �� 5.   *   $��* �68   .+�52   &   �� $��5��65   #��z 6F   � 55   &    56   *   �� 57   .   $��* �6?   �� 58   .   $
��Auto �6?   �� 59   .   $
��Auto �6?   �� 5:   .   $��96 �6?   .+�5=   *   `� $��toolbar��6F    . }�. $	��220��6j   $
��Left=�6v   {�. .�5>   .   c� $ Never=�66   $��
-5,0,-13,0q�6K   $��5,0,0,0q�6_   .@�5?   2   �� $
��10 5q�69   $��ApplicationCommands.New��6H   $
 Hand��6j   .��5@   6   �� $-��'/Manifest;component/Assets/new_file.png��6<   5A   3   �� 5B   2   $
��10 5q�69   $��ApplicationCommands.Open��6H   $
 Hand��6k   .��5C   6   �� $.��(/Manifest;component/Assets/open_file.png��6<   5D   3   �� 5E   2   $
��10 5q�69   $ ��ApplicationCommands.SaveAs��6H   $
 Hand��6n   .��5F   6   �� $)��#/Manifest;component/Assets/save.png��6<   5G   3   �� 5H   2   $
��10 5q�69   $!��NavigationCommands.GoToPage��6H   $ ��/UI\Template\Settings.xaml��6n   $
 Hand��6�   .��5I   6   �� $-��'/Manifest;component/Assets/settings.png��6<   5J   3   5K   /   5L   +   �� 5T   *   $��1��67   #��z 6G   $��0,0,24,0q�6r    . ��5U   .   �� 5V   2   .R�5W   6   �� $ 
Horizontal=�6A   5X   3   ��5Z   .   �� 5[   2   .R�5\   6   �� $ 
Horizontal=�6A   .+�5]   :   �� $ 	Separator��6?   $ .5��6R   $ 3��6Z   $ .5��6a   $ 12��6i   $	��5,0q�6q   $��Center=�6~   #���  6�   �� 5_   :   $*��$navigation:LinkCommands.NavigateLink��5`   A   8��  ��5_   A   �� *DisplayName+��5a   A   �� *Source+��5b   A   �� $ ContentFrame��5c   A   5d   7    5e   6   �� 5f   :     6F   �� ! �� *PreviousData+" 6�   Z� .a�5g   >   �� $# 	Separator��6[    � y�$ 	Collapsed=�6r   5h   ;   5j   3   5l   +   �� 5o   *   $��2��61   #��� 	 6A   $��36��6g   $��36��6r   $	��8,0q�6~   #% z$ 5p   1   y�5q   1   �� 8&  $' inverse��._�5r   .   F� $
( Fill=�6D   
�������$��24��6`   $��24��6k   $��Center=�6w   $��Center=�6�   ��63   �� 6�   5s   +   �� 5v   *   $��3��65   $ 
Horizontal=�6E   $	��Top=�6^    . .+�5w   .   �� #* Z) 6�   8�� ��65   �� # Z+ ��5x   2   � 5y   6   $��13��6;   $��12��6F   $z�1,0,0,1,0,1W�6R   .+�5z   :   F� ����    ��[ � z ��[ 	$��8��6R   $��7��6\   $��Center=�6g   $��Center=�6�   $��2��5{   �   ��6?   �� *
Foreground+! �� $, FindAncestor=�$- ButtonL�6�   5|   7   5~   /   � 5   .   $��1,0,1,0q�63   .+�5�   2   �� $. Restore��69   #* Z/ 6�   8�� $y�	Collapsed=�6�   ��6J   �� # Z0 ��5�   6   � 5�   :   $��13��6?   $��12��6J   1 . $z�1,0,0,1,.5,.5W�6o   .+�5�   >   F� X���Ѐ�     � z     � z ��[ �    ��- р�[ ��- �    �� р�[ �� р�[  z �     z 	$��8��6y   $��8��6�   $��Center=�6�   $��Center=�6�   $��1��5�   �   ��6C   �� *
Foreground+! �� $, FindAncestor=�$- ButtonL�6�   5�   ;   5�   3   �� 5�   2   $. Maximize��69   #* Z2 6�   8�� ��6K   �� # Z3 ��5�   6   � 5�   :   $��13��6?   $��12��6J   .+�5�   >   F� +����    @B �@T� @B �@T�  z �     z 	$��9��6`   $��8��6j   $��Center=�6u   $��Center=�6�   $��2��5�   �   ��6C   �� *
Foreground+! �� $, FindAncestor=�$- ButtonL�6�   5�   ;   5�   3   5�   /   �� 5�   .   #* Z4 6}   8�� ��65   �� # Z5 ��5�   2   � 5�   6   $��13��6;   $��12��6F   $z�1,0,0,1,0,1W�6R   .+�5�   :   F� +����        � z ��j � z     �    ��j 	$��8��6\   $��7��6f   $��Center=�6q   $��Center=�6�   $	��1.5��5�   �   ��6?   �� *
Foreground+! �� $, FindAncestor=�$- ButtonL�6�   5�   7   5�   /   5�   +   5�   '   � 5�   &   $��1��6+    5�   *   �� 5�   .   $
��Auto �6?   �� 5�   .   $��* �6?   .+�5�   *     $��1��6>   #7 z6 5�   >   8 5�   >   �� *Source+$ ContentFrame��$9 TwoWay=�5�   >   5�   '     5�   &   $: ContentFrame��6;   $��3��6Q   $��2��6^   $��
42,8,16,16q�6o   #< z; 6�   = 6�   �� *ContentSource+! �� *TemplatedParent+$9 TwoWay=�6�   � 5�   &   $ 
ResizeGrip��68   $��2��6+   
������ $y�	Collapsed=�6e   $��Right=�6|   $��Bottom=�6�   $> BottomRight=�6�   .+�5�   *   F� $��12��6/   $��12��6:   $��1q�6F   #���  5�   /   $��1��5�   /   $
( None=�5�   /   �����@B ��� ���- ��� �@KL ��� ���j ��� �@T� ��� ��ا ��� Ѐ� @T� р� �ا Ѐ�[ @T� р�[ �ا Ѐ�� @T� р�� �ا �@KL ��[ ���j ��[ �@T� ��[ ��ا ��[ Ѐ�[ @KL р�[ ��j Ѐ�� @KL р�� ��j �@T� �� ��ا �� Ѐ�� @B р�� ��- 5�   /   5�   '   5�   #   5�      5�      5�      ? 5�      P� 5�      @ �@�IsActiveA . . �5�      �� # �  6<    � ��5�      P� 5�      @ �@�WindowState$A 	Maximized=�69   . �5�      �� $# Maximize��6%    � y�$ 	Collapsed=�6Q   �� 5�      $# Restore��6%    � y�$ Visible=�6P   �� 5�      $# 
LayoutRoot��6%    � ��$ 7q�6O   5�      P� 5�      @ �@�WindowState$A Normal=�69   . �5�      �� $# Maximize��6%    � y�$ Visible=�6Q   �� 5�      $# Restore��6%    � y�$ 	Collapsed=�6P   5�      ]� 5�      B 5�      �� 5�   "   C �@�
ResizeMode$D CanResizeWithGrip=�6B   �� 5�   "   C �@�WindowState$D Normal=�6C   ./�5�      �� $# 
ResizeGrip��6%    � y�$ Visible=�6S   5�      5�      5�      �� 5�   
    �@ WindowChrome 5�        5�      $E 0��6   $F 1q�60   G .  $
H None=�6f   5�      5�      5�      