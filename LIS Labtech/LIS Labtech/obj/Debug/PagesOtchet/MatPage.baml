   M S B A M L   `   `   `  ����F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  5          LIS_Labtech.MatPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:LIS_Labtech     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  MatPage��5
      .��5      � ���#61D89F.+�5   
   �� $��10q�6   
������� � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName��%J  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6.   .R�5   "   �� $��Border��6)   $��1,1,1,0q�67   
�������$ 4,4,0,0��6i   $	��2,0q�6�   ._�5   &   �� $ ContentSite��67   $��Center=�5   )   $��Center=�5   )   $��Header��5   )   $
��10,2q�5   )   5   #    5   "   P� 5   &   	 �@��
IsSelected
 . . �5   *   �� $ Border��61    � ��
 ��·�6[   5   '   P� 5   &   	 �@��
IsSelected
 .  . �5   *   �� $ Border��61    � ��
 �����6[   5    '   5"      5$      5%      5&      .@�5'      �� $��Реактивы��6   ��5(      � 5)      .+�5*      �  � RowDefinitions 5+      �� 5,   "   $	��400 �60   �� 5-   "   .+�5/      �� -   5         ��Name$ 	listUsers��5/   5   $��0��6'   $	��Top=�6I    �� View 50   "   �� 51   &   .P�52   *   �� $��Название��69    �� DisplayMemberBinding 6L   �� *Name+�� 53   *   $��Колличество��69    6N   �� *
Quantity+�� 54   *   $��
Объем��69    6I   �� *Volume+�� 55   *   $��Чистота��69    6L   �� *Purity+�� 56   *   $��
Класс��69    6I   �� *Class+57   '   59      �� 5:      -   5         ��Name$ TextBox1��5:   &   $��1��68   $��12(�6F   $��0, 10, 0 ,0q�6U   $	��200��6j   $��Bottom=�6v   $
��Left=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$&  Поиск по названию��6�    %  !MaterialDesignFloatingHintTextBox#��[  6�   6  5;      5<      5>      �� 5?      $��Материалы��6   ��5@      � 5A      .+�5B      �  5C      �� 5D   "   $	��400 �60   �� 5E   "   .+�5G      �� -   5        $ 
listUsers1��5G   5   $��0��6'   $	��Top=�6J    5H   "   �� 5I   &   .P�5J   *   �� $��Название��69    6L   �� *Name+�� 5K   *   $��Колличество��69    6N   �� *
Quantity+�� 5L   *   $��
Объем��69    6I   �� *Volume+�� 5M   *   $��
Форма��69    6J   �� *Form+�� 5N   *   $��Тип��69    6G   �� *Type+�� 5O   *   $��Назначение��69    6N   �� *Nazn+5P   '   5R      �� 5S      -   5        $ TextBox2��5S   &   $��12(�68   $��1��6F   $��0, 10, 0 ,0q�6S   $	��200��6h   $
��Left=�6t   $��Bottom=�6�   $&  Поиск по названию��6�   #��[  6�   6  5T      5U      5W      5X      5Y      5Z      