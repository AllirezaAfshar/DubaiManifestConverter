   M S B A M L   `   `   `  ���� N  JFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FirstFloor.ModernUIFirstFloor.ModernUI  [2clr-namespace:FirstFloor.ModernUI.Windows.Controls$FirstFloor.ModernUI.Windows.Controls  _4clr-namespace:FirstFloor.ModernUI.Windows.Navigation&FirstFloor.ModernUI.Windows.Navigation  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089b ^Microsoft.Windows.Shell, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� MergedDictionaries �� Source7    1FirstFloor.ModernUI.Windows.Controls.ModernWindow �� 
TargetType �� Property   WindowBackgroundContent �� Value  DefaultFontFamily  DefaultFontSize  
WindowText  WindowBorder&   System.Windows.Media.TextOptions �� 
TargetType ��Name/  )Microsoft.Windows.Shell.SystemParameters2   Current �� Source	 �� Path  WindowBackgroundColor
 �� Color � 	Resources  Key �� 
TargetName �� TargetProperty	 �� To g� Duration �Name � RowDefinitions    BackgroundContent � ColumnDefinitions `� IsLocked c� OverflowMode � Cursor    
TitleLinks*  $Microsoft.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome �� Orientation ��Name	 �� X1	 �� Y1	 �� X2	 �� Y2  SeparatorBackground  SystemButtonLink �� ElementName  �� Triggers! �� Binding" �� RelativeSource# �� Value$ �� 
TargetName 
	 Accent%    LogoData& � DataContext 
 NullToVisibilityConverter' �� 	Converter( �� ConverterParameter) �� Stretch#   FirstFloor.ModernUI.Resources*   Minimize+ � ToolTip  SystemButton,  &Microsoft.Windows.Shell.SystemCommands,   MinimizeWindowCommand- �� Mode. �� AncestorType/ ��Name0   Restore1   RestoreWindowCommand2 � UseLayoutRounding3   Maximize4   MaximizeWindowCommand5   Close  SystemCloseButton6   CloseWindowCommand5   /FirstFloor.ModernUI.Windows.Controls.ModernMenu7    MenuLinkGroups8   
LinkGroups9   SelectedSource: �� Mode6   0FirstFloor.ModernUI.Windows.Controls.ModernFrame;  Name<    ContentLoader=   ContentLoader>   Source?   ResizeGripDirection@ �� TriggersA P� PropertyB P� Value  WindowBorderActiveC ]� 
ConditionsD �� PropertyE �� ValueF   CornerRadiusG   GlassFrameThicknessH   UseAeroCaptionButtonsI   NonClientFrameEdges�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     .modernui!clr-namespace:FirstFloor.ModernUI  ?controls2clr-namespace:FirstFloor.ModernUI.Windows.Controls  C
navigation4clr-namespace:FirstFloor.ModernUI.Windows.Navigation  Kshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell    �� $7 1/FirstFloor.ModernUI;component/Assets/Button.xaml?��� $; 5/FirstFloor.ModernUI;component/Assets/Converters.xaml?��� $: 4/FirstFloor.ModernUI;component/Assets/TextBlock.xaml?�%�  '         7  7 
 7  7  7  7  �� "   .���  �@  BackgroundContent# �   ��  � ��# �  ��  � ��# �  ��  � ��# �  ��  � ��# �  ��  � ��$	 800����  � ��$	 640����  � ��$	 320����  � ��$	 320����  �@�
ResizeMode$ CanResizeWithGrip=���  �@�UseLayoutRounding . ��  �@ TextFormattingMode$ Display=���  � �� �� "   .R��� $ WindowBorder������ # Z $#	 WindowNonClientFrameThickness����� WindowBorderBackground��#
 �   ���� BackgroundAnimation .���� $ WindowBorderBackground��$ Color�# �  $ 0:0:.6D�._��� #��z��$��1q�._��� .u�� $ 
LayoutRoot�� �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��5��#��z �  �� $��* ��� $
��Auto ��� $
��Auto ��� $��96 �.+�`� $��toolbar�� . }�. $	��222��$
��Left=�{�. .�c� $ Never=�$��
-5,0,-13,0q�$��5,0,0,0q�.@��� $
��10 5q�$��ApplicationCommands.New��$
 Hand��.���� $-��'/Manifest;component/Assets/new_file.png���� $
��10 5q�$��ApplicationCommands.Open��$
 Hand��.���� $.��(/Manifest;component/Assets/open_file.png���� $
��10 5q�$ ��ApplicationCommands.SaveAs��$
 Hand��.���� $)��#/Manifest;component/Assets/save.png���� $
��10 5q�$!��NavigationCommands.GoToPage��$ ��/UI\Template\Settings.xaml��$
 Hand��.���� $-��'/Manifest;component/Assets/settings.png���� $��1��#��z $��0,0,24,0q� . ���� .R��� $ 
Horizontal=����� .R��� $ 
Horizontal=�.+��� $ 	Separator��$ .5��$ 3��$ .5��$ 12��$	��5,0q�$��Center=�#���  �� $*��$navigation:LinkCommands.NavigateLink��8��  ���� *DisplayName+���� *Source+���� $ ContentFrame��  �� ! �� " �� *PreviousData+# Z� .a��� $$ 	Separator�� � y�$ 	Collapsed=��� $��2��#��� 	 $��36��$��36��$	��8,0q�#& z% y��� 8'  $( inverse��._�F� $
) Fill=�
�������$��24��$��24��$��Center=�$��Center=����� �� $��3��$ 
Horizontal=�$	��Top=� . .+��� #+ Z* 8�� ���� # Z, ��� $��13��$��12��$z�1,0,0,1,0,1W�.+�F� ����    ��[ � z ��[ 	$��8��$��7��$��Center=�$��Center=�$��2������ *
Foreground+" �� $- FindAncestor=�$. ButtonL�� $��1,0,1,0q�.+��� $/ Restore��#+ Z0 8�� $y�	Collapsed=����� # Z1 ��� $��13��$��12��2 . $z�1,0,0,1,.5,.5W�.+�F� X���Ѐ�     � z     � z ��[ �    ��- р�[ ��- �    �� р�[ �� р�[  z �     z 	$��8��$��8��$��Center=�$��Center=�$��1������ *
Foreground+" �� $- FindAncestor=�$. ButtonL��� $/ Maximize��#+ Z3 8�� ���� # Z4 ��� $��13��$��12��.+�F� +����    @B �@T� @B �@T�  z �     z 	$��9��$��8��$��Center=�$��Center=�$��2������ *
Foreground+" �� $- FindAncestor=�$. ButtonL��� #+ Z5 8�� ���� # Z6 ��� $��13��$��12��$z�1,0,0,1,0,1W�.+�F� +����        � z ��j � z     �    ��j 	$��8��$��7��$��Center=�$��Center=�$	��1.5������ *
Foreground+" �� $- FindAncestor=�$. ButtonL�� $��1�� �� $��42 ��� $��* �.+�  $��1��#8 z7 9 �� *Source+$ ContentFrame��$: TwoWay=�  $; ContentFrame��$��3��$��2��$��
42,8,16,16q�#= z< > �� *ContentSource+" �� *TemplatedParent+$: TwoWay=�� $ 
ResizeGrip��$��2��
������ $y�	Collapsed=�$��Right=�$��Bottom=�$? BottomRight=�.+�F� $��12��$��12��$��1q�#���  $��1��$
) None=������@B ��� ���- ��� �@KL ��� ���j ��� �@T� ��� ��ا ��� Ѐ� @T� р� �ا Ѐ�[ @T� р�[ �ا Ѐ�� @T� р�� �ا �@KL ��[ ���j ��[ �@T� ��[ ��ا ��[ Ѐ�[ @KL р�[ ��j Ѐ�� @KL р�� ��j �@T� �� ��ا �� Ѐ�� @B р�� ��- @ P� A �@�IsActiveB . . ��� # �   � ��P� A �@�WindowState$B 	Maximized=�. ��� $$ Maximize�� � y�$ 	Collapsed=��� $$ Restore�� � y�$ Visible=��� $$ 
LayoutRoot�� � ��$ 7q�P� A �@�WindowState$B Normal=�. ��� $$ Maximize�� � y�$ Visible=��� $$ Restore�� � y�$ 	Collapsed=�]� C �� D �@�
ResizeMode$E CanResizeWithGrip=��� D �@�WindowState$E Normal=�./��� $$ 
ResizeGrip�� � y�$ Visible=���  �@ WindowChrome   $F 0��$G 1q�H .  $
I None=�