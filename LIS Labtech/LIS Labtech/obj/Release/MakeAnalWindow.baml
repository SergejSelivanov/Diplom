   M S B A M L   `   `   `  ���� F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech       LIS_Labtech.MakeAnalWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:LIS_Labtech     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Лаборант��$	��600��$	��500�� � Icon$ Resources/LisLogo.png�� � WindowStartupLocation$ CenterScreen=�.��� ���#61D89F.+��� $	��400��$	��500�� �� CornerRadius$ 20��$��30q�
�������$��Center=� �� Padding$ 30q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 60Q�   Color$ 	LightGray��   ShadowDepth$ 1Q�._��� .+��� $)��#Проведение анализа��$��22(�$
��Bold"�$��0 0 0 30q�$��Center=��� -   	 ��Name$	 
TextBlock1��$��Первый шаг��$��14(�$
��Bold"�$��0 0 0 0q�$
��Left=��� -   
 ��Name$
 Textbox1��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$' !Введите результат��$��0 0 0 15q� %  !MaterialDesignFloatingHintTextBox#��[  �� -   $	 
TextBlock2��$��Второй шаг��$��14(�$
��Bold"�$��0 0 0 0q�$
��Left=��� -   $
 Textbox2��$' !Введите результат��$��0 0 0 15q�#��[  �� -   $	 
TextBlock3��$��Третий шаг��$��14(�$
��Bold"�$��0 0 0 0q�$
��Left=��� -   $
 Textbox3��$' !Введите результат��$��0 0 0 15q�#��[  �� -   $	 
TextBlock4��$��Четвертый шаг��$��14(�$
��Bold"�$��0 0 0 0q�$
��Left=��� -   $
 Textbox4��$' !Введите результат��$��0 0 0 15q�#��[  � $��	0 40 0 20q�.+��� -	   $
��Left=�$%��Завершить анализ��$��29��$	��Top=��� -
   $��Right=�$��
Назад��   MaterialDesignOutlinedButton#��[ $��29��$��Bottom=�