   M S B A M L   `   `   `  ����F  BLIS Labtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LIS_LabtechLIS_Labtech  5   	   #    LIS_Labtech.MaterialAddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LIS_Labtech     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$,  &Менеджер по закупкам��5	   	   $	��560��6&   $	��500��63    � Icon$ Resources/LisLogo.png��6?    � WindowStartupLocation$ CenterScreen=�6\   .��5
      � ���#61D89F.+�5   
   �� $	��400��6   $	��500��6     �� CornerRadius$ 20��6/   $��30q�6A   
�������$��Center=�6`    �� Padding$ 30q�6{    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 60Q�6#      Color$ 	LightGray��63      ShadowDepth$ 1Q�6E   ._�5      �� .+�5      �� $2��,Добавьте новый материал��6   $��22(�6;   $
��Bold"�6I   $��0 0 0 30q�6[   $��Center=�6m   �� 5      -   5        	 ��Name$	 Textbox1��5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$8
 2Введите название материала��6,   $��0 0 0 15q�6h    %  !MaterialDesignFloatingHintTextBox#��[  6z   �� 5      -   5        $	 Textbox2��5      $+
 %Введите колличество��6,   $��0 0 0 15q�6a   #��[  6s   �� 5      -   5        $	 Textbox3��5      $
 Введите форму��6,   $��0 0 0 15q�6[   #��[  6m   �� 5      -   5        $	 Textbox4��5      $
 Введите объем��6,   $��0 0 0 15q�6[   #��[  6m   �� 5      -   5        $	 Textbox5��5      $
 Введите тип��6,   $��0 0 0 15q�6Y   #��[  6k   �� 5      -   5        $	 Textbox6��5      $)
 #Введите назначение��6,   $��0 0 0 15q�6`   #��[  6r   � 5      $��0 0 0 20q�6   .+�5      �� -   5        $
��Left=�5      $��Добавить��68   $
��Auto��6K   6Y   �� 5      -   5        $��Right=�5      $��
Назад��69      MaterialDesignOutlinedButton#��[ 6I   6   5      5      5      5      5      