   M S B A M L   `   `   `  ����F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  5   	   &     LIS_Labtech.AddTaskChooseLWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LIS_Labtech     5   	     � Title$=  7Менеджер по контролю качества��5      $	��550��61   $	��900��6>    � Icon$ Resources/LisLogo.png��6J    � WindowStartupLocation$ CenterScreen=�6g   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��50 �6   �� 5      .+�5   
   � ���#61D89F � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��Bottom=�6%   
�������$��20��6X   �� 5      -   5         ��Name$ 
ButtonExit��5   "   $��0��6   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 50��63   �� 5        � ��
 �����67   �� 5!       �@�Cursor$
 Hand��63   �� 5"       � �� 5#      �� 5$   "   	 �� 
TargetType"	 ��62   .R�5%   &   A� $��30��6.   $��30��69   
 �� Stretch$
 UniformToFill=�6E   
�������$��2��6l   ��5&   *   �� 5'   .    �� ImageSource$ Resources/CloseLogo.png��69   5)   '   5*   #   5,      5-      5/      50      � 51   
   $��1��6   ���#8AECBD.+�52      ��  �� CornerRadius$ 20��6   $��30q�6'   
�������$��Stretch=�6F    �� Padding$ 30q�6b    J� Effect 53      3  -System.Windows.Media.Effects.DropShadowEffect  54         
BlurRadius$ 60Q�6'      Color$ 	LightGray��67      ShadowDepth$ 1Q�6I   ._�56      �  57      �� 58      $��60 �6(   �� 59      .+�5;      �� $��0��6    $T��NВыберите лаборанта для проведения анализа��6-   $��22(�6^   $
��Bold"�6l   $��50, 20, 0 ,0q�6~   �� 5<      -   5         ��Name$ 	listUsers��5<   -   $��1��6   $	��Top=�6A    �� View 5=      �� 5>      .P�5?   "   �� $��
Логин��61    �� DisplayMemberBinding 6A   �� *Login+�� 5@   "   $��Имя��61    6>   �� *Name+�� 5A   "   $��Фамилия��61    6C   �� *	SurName+�� 5B   "   $��Отчество��61    6D   �� *
FatherName+�� 5C   "   $��Телефон��61    6C   �� *	Telefon+�� 5D   "   $��Должность��61    6E   �� *
Position+5E      5G      5H      5I      5J      5K      5L      