   M S B A M L   `   `   `  ����F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  5   	   "    LIS_Labtech.SucsessAccWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LIS_Labtech     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$6  0Директор по исследованиям��5	   	   $	��550��6+   $	��900��68    � Icon$ Resources/LisLogo.png��6D    � WindowStartupLocation$ CenterScreen=�6a   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   � ���#61D89F � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��Bottom=�6%   
�������$��20��6X   �� 5      -   5         ��Name$ 
ButtonExit��5   "   $��0��6   ��5      �� 5       �� 
TargetType" ��6   .�5       ��  �� Property � �� �� Value$ 50��63   �� 5!       � ��
 �����67   �� 5"       �@�Cursor$
 Hand��63   �� 5#       � �� 5$      �� 5%   "   	 �� 
TargetType"	 ��62   .R�5&   &   A� $��30��6.   $��30��69   
 �� Stretch$
 UniformToFill=�6E   
�������$��2��6l   ��5'   *   �� 5(   .    �� ImageSource$ Resources/CloseLogo.png��69   5*   '   5+   #   5-      5.      50      51      � 52   
   $��1��6   ���#8AECBD.+�53      ��  �� CornerRadius$ 20��6   $��30q�6'   
�������$��Stretch=�6F    �� Padding$ 30q�6b    J� Effect 54      3  -System.Windows.Media.Effects.DropShadowEffect  55         
BlurRadius$ 60Q�6'      Color$ 	LightGray��67      ShadowDepth$ 1Q�6I   ._�57      �  58      �� 59      $��35 �6(   �� 5:      $	��160 �6(   �� 5;      $��35 �6(   �� 5<      $	��150 �6(   .+�5>      �� $��0��6    $/��)Ожидают подтверждения��6-   $��22(�6J   $
��Bold"�6X   $��50, 0, 0 ,0q�6j   �� 5?      -   5         ��Name$ 	listUsers��5?   ,   $��1��6   $	��Top=�6m    �� View 5@      �� 5A      .P�5B   "   �� $��
Логин��61    �� DisplayMemberBinding 6A   �� *Login+�� 5C   "   $��Имя��61    6>   �� *Name+�� 5D   "   $��Фамилия��61    6C   �� *	SurName+�� 5E   "   $��Отчество��61    6D   �� *
FatherName+�� 5F   "   $��Телефон��61    6C   �� *	Telefon+�� 5G   "   $��Должность��61    6E   �� *
Position+5H      5J      �� 5K      $��2��6    $3��-Подтвержденные аккаунты��6-   $��22(�6L   $
��Bold"�6Z   $��50, 0, 0 ,0q�6l   �� 5L      -   5        $ 
listUsers1��5L   -   $��3��6   $	��Top=�6q    5M      �� 5N      .P�5O   "   �� $��
Логин��61    6A   �� *Login+�� 5P   "   $��Имя��61    6?   �� *Name+�� 5Q   "   $��Фамилия��61    6C   �� *	SurName+�� 5R   "   $��Отчество��61    6D   �� *
FatherName+�� 5S   "   $��Телефон��61    6C   �� *	Telefon+�� 5T   "   $��Должность��61    6E   �� *
Position+5U      5W      5X      5Y      5Z      5[      5\      