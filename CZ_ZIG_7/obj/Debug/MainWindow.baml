   M S B A M L   `   `   `  ����C  ?CZ_ZIG_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CZ_ZIG_7CZ_ZIG_7  5   	       CZ_ZIG_7.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CZ_ZIG_7     5   	     � Title$)  #CZ_ZIG_7 - Gra 'Galaktyczny Biznes'��5   	   $	��600��65   $	��800��6B    � 
ResizeMode$ NoResize=�6N    � Icon$! /no-copyright-star-icon.png��6d   ��5	      �� 5
   
    �� ImageSource$ /no-copyright-sky-pic.jpg��6   .��5      �  � ShowGridLines .  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ Label_0_0_0��5      $	��Gra��6%   $��Center=�63   $��0,10,0,0q�6P   $	��Top=�6b   $��20(�6z   
�������$
��Bold"�6�   �� 5   
   -   5         ��Name$ ComboBox_0_0_0��5      $��Center=�6+   $��0,55,0,0q�6H   $	��Top=�6Z   $	��126��6r   	 �� SelectedIndex$	 0��6~   .@�5      �� $��Gracz (1) vs Gracz (2)��6   �� 5      $��Gracz (1) vs Komputer (2)��6   5      �� 5   
   -   5        
 ��Name$
 Button_0_0_0��5      $��Nowa gra��6'   $��Center=�6:   $��0,90,0,0q�6W   $	��Top=�6i    J� RenderTransformOrigin$ 1.641,0.763&�6�   $	��125��6�   $��25��6�   $��16(�6�   ���	#FF7F78C7 � UseLayoutRounding .  6�   � 5   
   $��1��6    5      �� 5      $
��1.5* �6    �� 5       $��* �6    �� 5!      $��* �6    �� 5"      $��* �6     5$      �� 5%      $��* �6#   �� 5&      $��* �6#   �� 5'      $��* �6#   .+�5)      �� -   5        $ Label_0_1_0��5)      $��0��6)   $��1��66   $��
Statystyki��6F   $��Center=�6[   $��0,10,0,0q�6x   $	��Top=�6�   $��20(�6�   
�������$
��Bold"�6�   �� 5*      -   5        $ Label_0_1_1��5*      $��Gracz 1��6)   $��0��6;   $��0��6H   $��Center=�6X   $��0,18,0,0q�6u   $	��Top=�6�   $��16(�6�   ���#C77D78$��Italic$�6�   �� 5+      -   5        $ Label_0_1_3��5+      $��Gracz 2��6)   $��0��6;   $��2��6H   $��Center=�6X   $��0,18,0,0q�6u   $	��Top=�6�   $��16(�6�   ���#C2C778$��Italic$�6�   �� 5,      -   5        $ Label_0_1_2��5,      $
��- KG��6)   $��1��68   $��0��6E   $��Center=�6U   $��0,0,0,0q�6r   $	��Top=�6�   $��16(�6�   
�������6�   �� 5-      -   5        $ Label_0_1_4��5-      $
��- KG��6)   $��1��68   $��2��6E   $��Center=�6U   $��0,0,0,0q�6r   $	��Top=�6�   $��16(�6�   
�������6�   �� 5.      -	   5        $ Label_0_1_5��5.      $��
Stan konta��6)   $��1��6>   $��1��6K   $��Center=�6[   $��0,0,0,0q�6x   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   �� 5/      -
   5        $ Label_0_1_6��5/      $��Lista budowli��6)   $��2��6A   $��1��6N   $��Center=�6^   $��0,-3,0,0q�6{   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   �� 50      -   5        $ Label_0_1_7��50      $��
Lista kart��6)   $��3��6>   $��1��6K   $��Center=�6[   $��0,-5,0,0q�6x   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   �� 51      -   5        $ ComboBox_0_1_0��51      {�.  $��2��6A   $��0��6N   $��Center=�6^   $��0,0,0,0q�6{   $	��Top=�6�   $	��126��6�   $	 0��6�   �� 52      -   5        $ ComboBox_0_1_2��52      {�.  $��2��6A   $��2��6N   $��Center=�6^   $��0,0,0,0q�6{   $	��Top=�6�   $	��126��6�   $	 0��6�   �� 53      -   5        $ ComboBox_0_1_1��53      {�.  $��3��6A   $��0��6N   $��Center=�6^   $��0,0,0,0q�6{   $	��Top=�6�   $	��126��6�   $	 0��6�   �� 54      -   5        $ ComboBox_0_1_3��54      {�.  $��3��6A   $��2��6N   $��Center=�6^   $��0,0,0,0q�6{   $	��Top=�6�   $	��126��6�   $	 0��6�   55      �� 56   
   -   5        $ Label_0_2_0��56      $��2��6%   $
��Tura��65   $��Center=�6D   $��0,10,0,0q�6a   $	��Top=�6s   $��20(�6�   
�������$
��Bold"�6�   �� 57   
   -   5        $ Label_0_2_1��57      $��0��6%   $��2��62   $��-��6B   $��Center=�6N   $��0,45,0,0q�6k   $	��Top=�6}   $��20(�6�   
�������6�   �� 58   
   -   5        $
 Button_0_2_0��58      $��2��6'   $��Dalej��67   {�.  $��Center=�6Y   $��0,90,0,0q�6v   $	��Top=�6�   $ 1.641,0.763&�6�   $	��125��6�   $��25��6�   $��16(�6�   ���	#FF7F78C7 .  6  �� 59   
   -   5        $ Label_1_0_0��59      $��1��6%   $��0��62   $
��Ruch��6B   $��Center=�6Q   $��0,80,0,0q�6n   $	��Top=�6�   $��20(�6�   
�������$
��Bold"�6�   �� 5:   
   -   5        $ Label_1_0_1��5:      $��1��6%   $��0��62   $��-��6B   $��Center=�6N   $��	0,120,0,0q�6k   $	��Top=�6~   $��16(�6�   
�������$��Italic$�6�   �� 5<   
   -   5        $ Label_1_1_0��5<      $��1��6%   $��1��62   $��Gra nierozpoczęta��6B   $��Center=�6^   $��0,10,0,0q�6{   $	��Top=�6�   $��24(�6�   
���  ��$
��Bold"�6�   �� 5=   
   -   5        $ Label_1_1_1��5=      $y�Hidden=�6%   $��1��69   $��1��6F   $��-��6V   $��Center=�6b   $��0,35,0,0q�6   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   �� 5>   
   -   5        $ Label_1_1_2��5>      $y�Hidden=�6%   $��1��69   $��1��6F   $��-��6V   $��Center=�6b   $��	0,125,0,0q�6   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   �� 5?   
   -   5        $
 Button_1_1_0��5?      $y�Hidden=�6'   $��1��6;   $��1��6H   $��-��6X   {�.  $��Center=�6v   $��0,70,0,0q�6�   $	��Top=�6�   $ 1.641,0.763&�6�   $	��252��6�   $��25��6�   $��16(�6�   ���	#FF7F78C7 .  68  �� 5@   
   -   5        $
 Button_1_1_1��5@      $y�Hidden=�6'   $��1��6;   $��1��6H   $��-��6X   {�.  $��Center=�6v   $��	0,135,0,0q�6�   $	��Top=�6�   $ 1.641,0.763&�6�   $	��252��6�   $��25��6�   $��16(�6�   ���	#FF7F78C7 .  69  �� 5A   
   -   5        $
 Button_1_1_2��5A      $y�Hidden=�6'   $��1��6;   $��1��6H   $��-��6X   {�.  $��Center=�6v   $��	0,200,0,0q�6�   $	��Top=�6�   $ 1.641,0.763&�6�   $	��252��6�   $��25��6�   $��16(�6�   ���	#FF7F78C7 .  69  �� 5B   
   -   5        $ ComboBox_1_1_0��5B      $y�Hidden=�6+   {�.  $��1��6Q   $��1��6^   $��Center=�6n   $��0,98,0,0q�6�   $	��Top=�6�   $	��252��6�   $	 0��6�   �� 5C   
   -   5        $ ComboBox_1_1_1��5C      $y�Hidden=�6+   {�.  $��1��6Q   $��1��6^   $��Center=�6n   $��	0,163,0,0q�6�   $	��Top=�6�   $	��252��6�   $	 0��6�   �� 5E   
   -   5        $ Label_1_2_0��5E      $��1��6%   $��2��62   $��
Informacje��6B   $��Center=�6W   $��0,80,0,0q�6t   $	��Top=�6�   $��20(�6�   
�������$
��Bold"�6�   �� 5F   
   -   5        $ Label_1_2_1��5F      $��1��6%   $��2��62   $��-��6B   $��Center=�6N   $��	0,120,0,0q�6k   $	��Top=�6~   $��16(�6�   
�������$��Italic$�6�   �� 5G   
   -   5        $ Label_2_0_0��5G      $��2��6%   $��0��62   $��Rozkład układu��6B   $��Center=�6[   $��0,10,0,0q�6x   $	��Top=�6�   $��20(�6�   
�������$
��Bold"�6�   �� 5H   
   -    5        $ Label_2_0_1��5H      $��2��6%   $��0��62   $
��1. -��6B   $��Center=�6Q   $��0,65,0,0q�6n   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   �� 5I   
   -!   5        $ Label_2_0_2��5I      $��2��6%   $��0��62   $
��2. -��6B   $��Center=�6Q   $��0,90,0,0q�6n   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   � 5J   
   $��2��6   $��1��6    .  5K      �� 5L      $��2* �6    �� 5M      $��3* �6    .+�5O      �� -"   5        $ Label_2_1_0��5O      $��Plansza��6)   $��Center=�6;   $��0,10,0,0q�6X   $	��Top=�6j   $��20(�6�   
�������$
��Bold"�6�   � 5P      $��2��6   $��1��6     .  5Q      �� 5R      $��2* �6$   �� 5S      $��* �6$    5U      �� 5V      $��* �6'   �� 5W      $��* �6'   �� 5X      $��* �6'   �� 5Y      $��* �6'   �� 5Z      $��* �6'   �� 5[      $��* �6'   �� 5\      $��* �6'   �� 5]      $��* �6'   �� 5^      $��* �6'   .+�5`      �� -#   5        $ Label_2_1_1��5`      $y�Hidden=�6-   $��G1��6A   $��2��6N   $
��Left=�6[   $��5,5,0,0q�6v   $	��Top=�6�   $��12(�6�   ���#C77D786�   �� 5a      -$   5        $ Label_2_1_2��5a      $y�Hidden=�6-   $��G2��6A   $��2��6N   $��Right=�6[   $��0,5,5,0q�6w   $	��Top=�6�   $��12(�6�   ���#C2C7786�   �� 5b      -%   5        $ Label_2_1_3��5b      $��0��6-   $��Center=�6=   $��0,0,0,0q�6Z   $��Center=�6k   $��12(�6�   
�������$��Italic$�6�   .��5c      �� $��WrapWithOverflow=�6     �� TextAlignment$ Center=�6@   Układ Słone- czny5e      5f      �� 5g      -&   5        $ Label_2_1_4��5g      $��1��6-   $��Center=�6=   $��-3,0,0,0q�6Z   $��Center=�6l   $��12(�6�   
����ح�$��Italic$�6�   .��5h      �� $��WrapWithOverflow=�6    $ Center=�6@   Dworzec Orbita lny5j      5k      �� 5l      -'   5        $ Label_2_1_5��5l      $��2��6-   $��Center=�6=   $��0,0,0,0q�6Z   $��Center=�6k   $��12(�6�   
�������$��Italic$�6�   .��5m      �� $��WrapWithOverflow=�6    $ Center=�6@   Układ Księży- cowy5o      5p      �� 5q      -(   5        $ Label_2_1_6��5q      $��3��6-   $��Center=�6=   $��0,0,0,0q�6Z   $��Center=�6k   $��12(�6�   
������$��Italic$�6�   .��5r      �� $��WrapWithOverflow=�6    $ Center=�6@   Szansa5t      5u      �� 5v      -)   5        $ Label_2_1_7��5v      $��4��6-   $��Center=�6=   $��0,0,0,0q�6Z   $��Center=�6k   $��12(�6�   
�������$��Italic$�6�   .��5w      �� $��WrapWithOverflow=�6    $ Center=�6@   Układ Gwie- zdny5y      5z      �� 5{      -*   5        $ Label_2_1_8��5{      $��5��6-   $��Center=�6=   $��-3,0,0,0q�6Z   $��Center=�6l   $��12(�6�   
����ح�$��Italic$�6�   .��5|      �� $��WrapWithOverflow=�6    $ Center=�6@   Dworzec Świe- tlny5~      5      �� 5�      -+   5        $ Label_2_1_9��5�      $��6��6-   $��Center=�6=   $��0,0,0,0q�6Z   $��Center=�6k   $��12(�6�   
�������$��Italic$�6�   .��5�      �� $��WrapWithOverflow=�6    $ Center=�6@   Układ Głębi- nowy5�      5�      �� 5�      -,   5        $ Label_2_1_10��5�      $��7��6.   $��Center=�6>   $��0,0,0,0q�6[   $��Center=�6l   $��12(�6�   
�������$��Italic$�6�   .��5�      �� $��WrapWithOverflow=�6    $ Center=�6@   Piraci5�      5�      �� 5�      --   5        $ Label_2_1_11��5�      $��8��6.   $��Center=�6>   $��0,0,0,0q�6[   $��Center=�6l   $��12(�6�   
�������$��Italic$�6�   .��5�      �� $��WrapWithOverflow=�6    $ Center=�6@   Układ Mglisty5�      5�      5�      5�      �� 5�   
   -.   5        $ Label_2_2_0��5�      $��2��6%   $��2��62   $��Kostki��6B   $��Center=�6S   $��0,10,0,0q�6p   $	��Top=�6�   $��20(�6�   
�������$
��Bold"�6�   �� 5�   
   -/   5        $ Label_2_2_1��5�      $��2��6%   $��2��62   $
��1. -��6B   $��Center=�6Q   $��0,65,0,0q�6n   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   �� 5�   
   -0   5        $ Label_2_2_2��5�      $��2��6%   $��2��62   $
��2. -��6B   $��Center=�6Q   $��0,90,0,0q�6n   $	��Top=�6�   $��16(�6�   
�������$��Italic$�6�   5�      5�      