   M S B A M L   `   `   `  ���� F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech      LIS_Labtech.EducGetPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:LIS_Labtech     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  EducGetPage��.��� .+�� ���#61D89F.+��� $��10q�
������� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName��%V  '��       �� " ��.���  � �� �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P� 	 �@��
IsSelected
 . . ��� $ Border�� � ��
 ��·�P� 	 �@��
IsSelected
 .  . ��� $ Border�� � ��
 �����.@��� $3��-Результаты тестирования����� .+��  � RowDefinitions �� $	��400 ��� .+��� -    ��Name$ 	listUsers��$��0��$	��Top=� �� View �� .P��� $��
Логин�� �� DisplayMemberBinding �� *Login+�� $��Имя�� �� *Name+�� $��Фамилия�� �� *	SurName+�� $��Отчество�� �� *
FatherName+�� $��Методика�� �� *
NameEduc+�� $��Результат�� �� *Result+�� -    ��Name$ TextBox��$��1��$��12(�$��0, 10, 0 ,0q�$	��200��$��Bottom=�$
��Left=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$&  Поиск по названию�� %  !MaterialDesignFloatingHintTextBox#��[  