   M S B A M L   `   `   `  ���� F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech      LIS_Labtech.MatPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:LIS_Labtech     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  MatPage��.��� ���#61D89F.+��� $��10q�
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
 �����.@��� $��Реактивы����� .+��  � RowDefinitions �� $	��400 ��� .+��� -    ��Name$ 	listUsers��$��0��$	��Top=� �� View �� .P��� $��Название�� �� DisplayMemberBinding �� *Name+�� $��Колличество�� �� *
Quantity+�� $��
Объем�� �� *Volume+�� $��Чистота�� �� *Purity+�� $��
Класс�� �� *Class+�� -    ��Name$ TextBox1��$��1��$��12(�$��0, 10, 0 ,0q�$	��200��$��Bottom=�$
��Left=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$&  Поиск по названию�� %  !MaterialDesignFloatingHintTextBox#��[  �� $��Материалы����� .+��  �� $	��400 ��� .+��� -   $ 
listUsers1��$��0��$	��Top=� �� .P��� $��Название�� �� *Name+�� $��Колличество�� �� *
Quantity+�� $��
Объем�� �� *Volume+�� $��
Форма�� �� *Form+�� $��Тип�� �� *Type+�� $��Назначение�� �� *Nazn+�� -   $ TextBox2��$��12(�$��1��$��0, 10, 0 ,0q�$	��200��$
��Left=�$��Bottom=�$&  Поиск по названию��#��[  