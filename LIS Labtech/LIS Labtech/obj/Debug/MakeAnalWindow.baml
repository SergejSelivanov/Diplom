   M S B A M L   `   `   `  ����F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  5   	        LIS_Labtech.MakeAnalWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LIS_Labtech     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  Лаборант��5	   	   $	��600��6   $	��500��6'    � Icon$ Resources/LisLogo.png��63    � WindowStartupLocation$ CenterScreen=�6P   .��5
      � ���#61D89F.+�5   
   �� $	��400��6   $	��500��6     �� CornerRadius$ 20��6/   $��30q�6A   
�������$��Center=�6`    �� Padding$ 30q�6{    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 60Q�6#      Color$ 	LightGray��63      ShadowDepth$ 1Q�6E   ._�5      �� .+�5      �� $)��#Проведение анализа��6   $��22(�66   $
��Bold"�6D   $��0 0 0 30q�6V   $��Center=�6h   �� 5      -   5        	 ��Name$	 
TextBlock1��5      $��Первый шаг��60   $��14(�6B   $
��Bold"�6P   $��0 0 0 0q�6b   $
��Left=�6s   �� 5      -   5        
 ��Name$
 Textbox1��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$' !Введите результат��6,   $��0 0 0 15q�6_    %  !MaterialDesignFloatingHintTextBox#��[  6q   �� 5      -   5        $	 
TextBlock2��5      $��Второй шаг��60   $��14(�6B   $
��Bold"�6P   $��0 0 0 0q�6b   $
��Left=�6s   �� 5      -   5        $
 Textbox2��5      $' !Введите результат��6,   $��0 0 0 15q�6_   #��[  6q   �� 5      -   5        $	 
TextBlock3��5      $��Третий шаг��60   $��14(�6B   $
��Bold"�6P   $��0 0 0 0q�6b   $
��Left=�6s   �� 5      -   5        $
 Textbox3��5      $' !Введите результат��6,   $��0 0 0 15q�6_   #��[  6q   �� 5      -   5        $	 
TextBlock4��5      $��Четвертый шаг��60   $��14(�6E   $
��Bold"�6S   $��0 0 0 0q�6e   $
��Left=�6v   �� 5      -   5        $
 Textbox4��5      $' !Введите результат��6,   $��0 0 0 15q�6_   #��[  6q   � 5      $��	0 40 0 20q�6   .+�5      �� -	   5        $
��Left=�5      $%��Завершить анализ��68   $��29��6S   $	��Top=�6v   �� 5      -
   5        $��Right=�5      $��
Назад��69      MaterialDesignOutlinedButton#��[ 6I   $��29��6�   $��Bottom=�6�   5      5      5      5      5       