   M S B A M L   `   `   `  ���� F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech      LIS_Labtech.AcountWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:LIS_Labtech     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$   ЛИС ООО Лабтех��$	��650��$	��450�� � Icon$ Resources/LisLogo.png�� � WindowStartupLocation$ CenterScreen=�.��� ���#61D89F.+��� $	��300��$	��500�� �� CornerRadius$ 20��$��30q�
�������$��Center=� �� Padding$ 30q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 60Q�   Color$ 	LightGray��   ShadowDepth$ 1Q�._��� .+��� $��Ваши данные��$��30(�$
��Bold"�$��0 0 0 30q�� $��10q�	 � ColumnDefinitions	 �� $	��100 ��� $	��150 ��� .+��� $��0��$��Ваш логин:��$
��Bold"�$
��Left=�$��Center=��� -   
 ��Name$
 Textbox1��$��1��$
��Left=��� -   $��2��$
��Left=�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 �������  �@�Cursor$
 Hand����  � �� ��  �� 
TargetType" ��.R�A� $��30��$��30�� �� Stretch$ UniformToFill=�
�������$��2������  �� ImageSource$ Resources/EditLogo.png��� $��10q�	 �� $	��100 ��� $	��150 ��� .+��� $��0��$��Ваш пароль:��$
��Bold"�$
��Left=�$��Center=�G� -    G�Name$ Textbox2��$��1��$
��Left=��� -   $��2��$
��Left=����� " ��.���  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$ UniformToFill=�
�������$��2������ $ Resources/EditLogo.png��� $��10q�	 �� $	��100 ��� $	��150 ��� .+��� $��0��$��Ваш Email:��$
��Bold"�$
��Left=�$��Center=��� -   $
 Textbox4��$��1��$
��Left=��� -   $��2��$
��Left=����� " ��.���  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$ UniformToFill=�
�������$��2������ $ Resources/EditLogo.png��� $��10q�	 �� $	��100 ��� $	��150 ��� .+��� $��0��$��Ваш телефон:��$
��Bold"�$
��Left=�$��Center=��� -   $
 Textbox5��$��1��$
��Left=��� -   $��2��$
��Left=����� " ��.���  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$ UniformToFill=�
�������$��2������ $ Resources/EditLogo.png��� $��10q�	 �� $	��100 ��� $	��150 ��� .+��� $��0��$��Ваше имя:��$
��Bold"�$
��Left=�$��Center=��� -	   $
 Textbox6��$��1��$
��Left=��� -
   $��2��$
��Left=����� " ��.���  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$ UniformToFill=�
�������$��2������ $ Resources/EditLogo.png��� $��10q�	 �� $	��100 ��� $	��150 ��� .+��� $��0��$��Ваш фамилия:��$
��Bold"�$
��Left=�$��Center=��� -   $
 Textbox7��$��1��$
��Left=��� -   $��2��$
��Left=����� " ��.���  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$ UniformToFill=�
�������$��2������ $ Resources/EditLogo.png��� $��10q�	 �� $	��100 ��� $	��150 ��� .+��� $��0��$��Ваш отчество:��$
��Bold"�$
��Left=�$��Center=��� -   $
 Textbox8��$��1��$
��Left=��� -   $��2��$
��Left=����� " ��.���  � ��
 �������  �@�Cursor$
 Hand����  � �� �� " ��.R�A� $��30��$��30��$ UniformToFill=�
�������$��2������ $ Resources/EditLogo.png��� $��	0 30 0 20q�.+��� -   $��Center=�$��
Назад��    MaterialDesignOutlinedButton#��[  