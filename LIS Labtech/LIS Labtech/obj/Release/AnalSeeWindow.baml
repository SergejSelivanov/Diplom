   M S B A M L   `   `   `  ���� F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech      LIS_Labtech.AnalSeeWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:LIS_Labtech     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$6  0Директор по исследованиям��$	��520��$	��500�� � Icon$ Resources/LisLogo.png�� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $��50 ��� .+�� ���#61D89F � RowDefinitions �� �� �� �� �� �� �� �� .+��� $��0��$��Bottom=�
�������$��20���� -    ��Name$ 
ButtonExit��$��0������  �� 
TargetType" ��.���  �� Property � �� �� Value$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� 	 �� 
TargetType"	 ��.R�A� $��30��$��30��
 �� Stretch$
 UniformToFill=�
�������$��2������  �� ImageSource$ Resources/CloseLogo.png��� $��1�����#8AECBD.+���  �� CornerRadius$ 20��$��15q�
�������$��Stretch=� �� Padding$ 15q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 60Q�   Color$ 	LightGray��   ShadowDepth$ 1Q�._��� .+��� $)��#Результаты анализа��$��22(�$
��Bold"�$��0 0 0 30q�$��Center=��� -    ��Name$ 	Nameblock��$��Название��$��14(�$
��Bold"�$��0 0 0 10q�$��Center=��� -   $ Metblock��$��Название��$��14(�$
��Bold"�$��0 0 0 10q�$��Center=��� -   $ Resblock��$��Название��$��14(�$
��Bold"�$��0 0 0 10q�$��Center=��  �� �� .+��� $	��210��$	��160��$��0��$ 40��$��10q�
�������$��Center=�$
��Left=�$ 20q�   $ 20Q�$ 	#FF673AB7��$ 1Q�._��� .+��� -   $ 
TextBlock1��$��Первый шаг��$��14(�$
��Bold"�$��0 0 0 30q�$��Center=��� -   $ 
TextBlock2��$��Первый шаг��$��14(�$
��Bold"�$��0 0 0 30q�$��Center=��� -   $ 
TextBlock3��$��Первый шаг��$��14(�$
��Bold"�$��0 0 0 30q�$��Center=��� -   $ 
TextBlock4��$��Первый шаг��$��14(�$
��Bold"�$��0 0 0 0q�$��Center=��� $	��210��$	��160��$��1��$ 40��$��10q�
�������$��Center=�$��Right=�$ 20q�   $ 20Q�$ 	#FF673AB7��$ 1Q�._��� .+��� -	   $ 
TextBlock5��$��Нормативы:��$��14(�$
��Bold"�$��0 0 0 30q�$��Center=��� -
   $ 
TextBlock6��$��Первый шаг��$��14(�$
��Bold"�$��0 0 0 30q�$��Center=��� -   $ 
TextBlock7��$��Первый шаг��$��14(�$
��Bold"�$��0 0 0 30q�$��Center=�