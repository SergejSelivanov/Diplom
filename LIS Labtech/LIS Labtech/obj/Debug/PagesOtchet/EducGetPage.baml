   M S B A M L   `   `   `  ����F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  5          LIS_Labtech.EducGetPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:LIS_Labtech     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        N� Title$  EducGetPage��5
      .��5      � .+�5   
   � ���#61D89F.+�5      �� $��10q�6   
������� � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName��%J  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5   "   " ��62   .R�5   &   �� $��Border��6-   $��1,1,1,0q�6;   
�������$ 4,4,0,0��6m   $	��2,0q�6�   ._�5   *   �� $ ContentSite��6;   $��Center=�5   )   $��Center=�5   )   $��Header��5   )   $
��10,2q�5   )   5   '    5   &   P� 5   *   	 �@��
IsSelected
 . . �5   .   �� $ Border��65    � ��
 ��·�6_   5   +   P� 5   *   	 �@��
IsSelected
 .  . �5    .   �� $ Border��65    � ��
 �����6_   5!   +   5#   #   5%      5&      5'      .@�5(      �� $3��-Результаты тестирования��6   ��5)      � 5*      .+�5+      �  � RowDefinitions 5,   "   �� 5-   &   $	��400 �64   �� 5.   &   .+�50   "   �� -   5         ��Name$ 	listUsers��50   8   $��0��6+   $	��Top=�6L    �� View 51   &   �� 52   *   .P�53   .   �� $��
Логин��6=    �� DisplayMemberBinding 6M   �� *Login+�� 54   .   $��Имя��6=    6J   �� *Name+�� 55   .   $��Фамилия��6=    6O   �� *	SurName+�� 56   .   $��Отчество��6=    6Q   �� *
FatherName+�� 57   .   $��Методика��6=    6P   �� *
NameEduc+�� 58   .   $��Результат��6=    6Q   �� *Result+59   +   5;   #   �� 5<   "   -   5         ��Name$ TextBox��5<   *   $��1��6;   $��12(�6I   $��0, 10, 0 ,0q�6X   $	��200��6m   $��Bottom=�6y   $
��Left=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$&  Поиск по названию��6�    %  !MaterialDesignFloatingHintTextBox#��[  6�   6  5=      5>      5@      5A      5B      5C      5D      