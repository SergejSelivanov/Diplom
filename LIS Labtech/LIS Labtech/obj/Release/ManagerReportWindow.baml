   M S B A M L   `   `   `  ���� F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  %    LIS_Labtech.ManagerReportWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:LIS_Labtech     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$,  &Менеджер по закупкам��$	��550��$	��900�� � Icon$ Resources/LisLogo.png�� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $��50 ��� .+�� ���#61D89F � RowDefinitions �� �� �� �� �� �� �� �� �� .+��� -   $��0������  �� 
TargetType" ��.���  �� Property � �� �� Value$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� ��  �� 
TargetType" ��.R�A� $��30��$��30��	 �� Stretch$	 UniformToFill=�
�������$��2������ 
 �� ImageSource$
 Resources/AccountLogo.png�� �� Triggers P�  P� Property � �� P� Value . . ���  � ��
 ������� $��0��$��Bottom=�
�������$��20���� -    ��Name$ 
ButtonExit��$��8������ " ��.���  � ��$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$	 UniformToFill=�
�������$��2������ $
 Resources/CloseLogo.png��� $��1�����#8AECBD.+��� $��10q�
������� � 	Resources  �� CornerRadius ��Name �� 
TargetName��%V  '��       �� " ��.���  � �� �� " ��.R��� $��Border��$��1,1,1,0q�
�������$ 4,4,0,0��$	��2,0q�._��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected . . ��� $ Border�� � ��
 ��·�P�  �@��
IsSelected .  . ��� $ Border�� � ��
 �����.@��� $��Реактивы����� .+��  �� $	��400 ��� .+��� -    ��Name$ 	listUsers��$��0��$	��Top=� �� View �� .P��� $��Название�� �� DisplayMemberBinding �� *Name+�� $��Колличество�� �� *
Quantity+�� $��
Объем�� �� *Volume+�� $��Чистота�� �� *Purity+�� $��
Класс�� �� *Class+�� -    ��Name$ TextBox1��$��1��$��12(�$��0, 10, 0 ,0q�$	��200��$
��Left=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$&  Поиск по названию�� %  !MaterialDesignFloatingHintTextBox#��[  �� -   $��1��$��Bottom=�$��Right=����� " ��.���  � ��$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��50��$��50��$	 UniformToFill=�
�������$��2������ $
 Resources/AddLogo.png�� P�  � �� . . ���  � ��
 ������� $��Материалы����� .+��  �� $	��400 ��� .+��� -   $ 
listUsers1��$��0��$	��Top=� �� .P��� $��Название�� �� *Name+�� $��Колличество�� �� *
Quantity+�� $��
Объем�� �� *Volume+�� $��
Форма�� �� *Form+�� $��Тип�� �� *Type+�� $��Назначение�� �� *Nazn+�� -   $ TextBox2��$��1��$��12(�$��0, 10, 0 ,0q�$	��200��$
��Left=�$&  Поиск по названию��#��[  �� -   $��1��$��Bottom=�$��Right=����� " ��.���  � ��$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��50��$��50��$	 UniformToFill=�
�������$��2������ $
 Resources/AddLogo.png�� P�  � �� . . ���  � ��
 �����