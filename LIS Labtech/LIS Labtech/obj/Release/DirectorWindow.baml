   M S B A M L   `   `   `  ���� F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech       LIS_Labtech.DirectorWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:LIS_Labtech     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$6  0Директор по исследованиям��$	��550��$	��900�� � Icon$ Resources/LisLogo.png�� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $��50 ��� .+�� ���#61D89F � RowDefinitions �� �� �� �� �� �� �� �� �� .+��� -   $��0������  �� 
TargetType" ��.���  �� Property � �� �� Value$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� ��  �� 
TargetType" ��.R�A� $��30��$��30��	 �� Stretch$	 UniformToFill=�
�������$��2������ 
 �� ImageSource$
 Resources/AccountLogo.png�� �� Triggers P�  P� Property � �� P� Value . . ���  � ��
 ������� $��0��$��Bottom=�
�������$��20���� -   $��3������ " ��.���  � ��$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$	 UniformToFill=�
�������$��2������ $
 Resources/AddLogo.png���� -    ��Name$ 
ButtonExit��$��8������ " ��.���  � ��$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$	 UniformToFill=�
�������$��2������ $
 Resources/CloseLogo.png���� -   $��2������ " ��.���  � ��$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$	 UniformToFill=�
�������$��2������ $!
 Resources/EducationLogo.png���� -   $��7������ " ��.���  � ��$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$	 UniformToFill=�
�������$��2������ $
 Resources/LockLogo.png���� -   $��1������ " ��.���  � ��$ 50����  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$	 UniformToFill=�
�������$��2������ $
 Resources/OtchetLogo.png�� P�  � �� . . ���  � ��
 ������ $��1�����#8AECBD.+���  �� CornerRadius$ 20��$��30q�
�������$��Stretch=� �� Padding$ 30q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 60Q�   Color$ 	LightGray��   ShadowDepth$ 1Q�._�� .+��  �� $��70 ��� $	��220 �.+��� $��0��$+��%Результаты анализов��$��22(�$
��Bold"�$��50, 30, 0 ,0q��� -    ��Name$ 	listUsers��$��1��$	��Top=� �� View �� .P��� $��Методика�� �� DisplayMemberBinding �� *	Metodic+�� $��Анализ�� �� *Name+�� $��Информация�� �� *Info+