   M S B A M L   `   `   `  ���� F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  $    LIS_Labtech.TheoryChooseWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:LIS_Labtech     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$6  0Директор по исследованиям��$	��600��$	��700�� � Icon$ Resources/LisLogo.png�� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $��50 ��� .+�� ���#61D89F � RowDefinitions �� �� �� �� .+��� $��0��$��Bottom=�
�������$��20���� -    ��Name$ 
ButtonExit��$��0��$��Right=�$��0,2,0,3q�$��50������  �� 
TargetType" ��.���  �� Property � �� �� Value$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� 	 �� 
TargetType"	 ��.R�A� $��30��$��30��
 �� Stretch$
 UniformToFill=�
�������$��2������  �� ImageSource$ Resources/CloseLogo.png��� $��1�����#8AECBD.+�� .+���  �� CornerRadius$ 20��$��30q�
�������$��Center=� �� Padding$ 10q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 60Q�   Color$ 	LightGray��   ShadowDepth$ 1Q�._��� -    ��Name$
 Rich�� �� 
IsReadOnly . 