   M S B A M L   `   `   `  ����F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  5   	       LIS_Labtech.AddApplWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LIS_Labtech     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$6  0Директор по исследованиям��5	   	   $	��550��6+   $	��900��68    � Icon$ Resources/LisLogo.png��6D    � WindowStartupLocation$ CenterScreen=�6a   .��5
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
BlurRadius$ 60Q�6'      Color$ 	LightGray��67      ShadowDepth$ 1Q�6I   ._�57      �  58      �� 59      $��60 �6(   �� 5:      .+�5<      �� $��0��6    $E��?Выберите менеджера для назначения��6-   $��22(�6V   $
��Bold"�6d   $��50, 20, 0 ,0q�6v   �� 5=      -   5         ��Name$ 	listUsers��5=   -   $��1��6   $	��Top=�6A    �� View 5>      �� 5?      .P�5@   "   �� $��Имя��61    �� DisplayMemberBinding 6>   �� *Name+�� 5A   "   $��Фамилия��61    6B   �� *	SurName+�� 5B   "   $��Отчество��61    6C   �� *
FatherName+�� 5C   "   $��
Логин��61    6@   �� *Login+5D      5F      5G      5H      5I      5J      5K      