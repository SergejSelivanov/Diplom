   M S B A M L   `   `   `  ����F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  5   	       LIS_Labtech.AnalSeeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LIS_Labtech     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$6  0Директор по исследованиям��5	   	   $	��520��6+   $	��500��68    � Icon$ Resources/LisLogo.png��6D    � WindowStartupLocation$ CenterScreen=�6a   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   � ���#61D89F � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��Bottom=�6%   
�������$��20��6X   �� 5      -   5         ��Name$ 
ButtonExit��5   "   $��0��6   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 50��63   �� 5        � ��
 �����67   �� 5!       �@�Cursor$
 Hand��63   �� 5"       � �� 5#      �� 5$   "   	 �� 
TargetType"	 ��62   .R�5%   &   A� $��30��6.   $��30��69   
 �� Stretch$
 UniformToFill=�6E   
�������$��2��6l   ��5&   *   �� 5'   .    �� ImageSource$ Resources/CloseLogo.png��69   5)   '   5*   #   5,      5-      5/      50      � 51   
   $��1��6   ���#8AECBD.+�52      ��  �� CornerRadius$ 20��6   $��15q�6'   
�������$��Stretch=�6F    �� Padding$ 15q�6b    J� Effect 53      3  -System.Windows.Media.Effects.DropShadowEffect  54         
BlurRadius$ 60Q�6'      Color$ 	LightGray��67      ShadowDepth$ 1Q�6I   ._�56      �� .+�57      �� $)��#Результаты анализа��6    $��22(�6:   $
��Bold"�6H   $��0 0 0 30q�6Z   $��Center=�6l   �� 58      -   5         ��Name$ 	Nameblock��58       $��Название��63   $��14(�6C   $
��Bold"�6Q   $��0 0 0 10q�6c   $��Center=�6u   �� 59      -   5        $ Metblock��59       $��Название��62   $��14(�6B   $
��Bold"�6P   $��0 0 0 10q�6b   $��Center=�6t   �� 5:      -   5        $ Resblock��5:       $��Название��62   $��14(�6B   $
��Bold"�6P   $��0 0 0 10q�6b   $��Center=�6t   � 5;       5<      �� 5=      �� 5>      .+�5@      �� $	��210��6!   $	��160��6.   $��0��6;   $ 40��6K   $��10q�6]   
�������$��Center=�6|   $
��Left=�6�   $ 20q�6�    5A        5B   "   $ 20Q�63   $ 	#FF673AB7��6C   $ 1Q�6U   ._�5D      �� .+�5E   "   �� -   5        $ 
TextBlock1��5E   ,   $��Первый шаг��6@   $��14(�6R   $
��Bold"�6`   $��0 0 0 30q�6r   $��Center=�6�   �� 5F   "   -   5        $ 
TextBlock2��5F   ,   $��Первый шаг��6@   $��14(�6R   $
��Bold"�6`   $��0 0 0 30q�6r   $��Center=�6�   �� 5G   "   -   5        $ 
TextBlock3��5G   ,   $��Первый шаг��6@   $��14(�6R   $
��Bold"�6`   $��0 0 0 30q�6r   $��Center=�6�   �� 5H   "   -   5        $ 
TextBlock4��5H   ,   $��Первый шаг��6@   $��14(�6R   $
��Bold"�6`   $��0 0 0 0q�6r   $��Center=�6�   5I      5K      �� 5L      $	��210��6!   $	��160��6.   $��1��6:   $ 40��6J   $��10q�6\   
�������$��Center=�6{   $��Right=�6�   $ 20q�6�    5M        5N   "   $ 20Q�63   $ 	#FF673AB7��6C   $ 1Q�6U   ._�5P      �� .+�5Q   "   �� -	   5        $ 
TextBlock5��5Q   ,   $��Нормативы:��6@   $��14(�6R   $
��Bold"�6`   $��0 0 0 30q�6r   $��Center=�6�   �� 5R   "   -
   5        $ 
TextBlock6��5R   ,   $��Первый шаг��6@   $��14(�6R   $
��Bold"�6`   $��0 0 0 30q�6r   $��Center=�6�   �� 5S   "   -   5        $ 
TextBlock7��5S   ,   $��Первый шаг��6@   $��14(�6R   $
��Bold"�6`   $��0 0 0 30q�6r   $��Center=�6�   5T      5V      5W      5X      5Y      5Z      5[      5\      