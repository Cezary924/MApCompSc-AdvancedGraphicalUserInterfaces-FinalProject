   M S B A M L   `   `   `  ���� C  ?CZ_ZIG_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CZ_ZIG_7CZ_ZIG_7      CZ_ZIG_7.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:CZ_ZIG_7       � Title$)  #CZ_ZIG_7 - Gra 'Galaktyczny Biznes'��$	��600��$	��800�� � 
ResizeMode$ NoResize=� � Icon$! /no-copyright-star-icon.png������  �� ImageSource$ /no-copyright-sky-pic.jpg��.���  � ShowGridLines .  � RowDefinitions �� $��* ��� $
��1.5* ��� $��* � � ColumnDefinitions �� $��* ��� $��3* ��� $��* �.+��� -    ��Name$ Label_0_0_0��$	��Gra��$��Center=�$��0,10,0,0q�$	��Top=�$��20(�
�������$
��Bold"��� -    ��Name$ ComboBox_0_0_0��$��Center=�$��0,55,0,0q�$	��Top=�$	��126��	 �� SelectedIndex$	 0��.@��� $��Gracz (1) vs Gracz (2)���� $��Gracz (1) vs Komputer (2)���� -   
 ��Name$
 Button_0_0_0��$��Nowa gra��$��Center=�$��0,90,0,0q�$	��Top=� J� RenderTransformOrigin$ 1.641,0.763&�$	��125��$��25��$��16(����	#FF7F78C7 � UseLayoutRounding .  � $��1�� �� $
��1.5* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* �.+��� -   $ Label_0_1_0��$��0��$��1��$��
Statystyki��$��Center=�$��0,10,0,0q�$	��Top=�$��20(�
�������$
��Bold"��� -   $ Label_0_1_1��$��Gracz 1��$��0��$��0��$��Center=�$��0,18,0,0q�$	��Top=�$��16(����#C77D78$��Italic$��� -   $ Label_0_1_3��$��Gracz 2��$��0��$��2��$��Center=�$��0,18,0,0q�$	��Top=�$��16(����#C2C778$��Italic$��� -   $ Label_0_1_2��$
��- KG��$��1��$��0��$��Center=�$��0,0,0,0q�$	��Top=�$��16(�
��������� -   $ Label_0_1_4��$
��- KG��$��1��$��2��$��Center=�$��0,0,0,0q�$	��Top=�$��16(�
��������� -	   $ Label_0_1_5��$��
Stan konta��$��1��$��1��$��Center=�$��0,0,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -
   $ Label_0_1_6��$��Lista budowli��$��2��$��1��$��Center=�$��0,-3,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -   $ Label_0_1_7��$��
Lista kart��$��3��$��1��$��Center=�$��0,-5,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -   $ ComboBox_0_1_0��{�.  $��2��$��0��$��Center=�$��0,0,0,0q�$	��Top=�$	��126��$	 0���� -   $ ComboBox_0_1_2��{�.  $��2��$��2��$��Center=�$��0,0,0,0q�$	��Top=�$	��126��$	 0���� -   $ ComboBox_0_1_1��{�.  $��3��$��0��$��Center=�$��0,0,0,0q�$	��Top=�$	��126��$	 0���� -   $ ComboBox_0_1_3��{�.  $��3��$��2��$��Center=�$��0,0,0,0q�$	��Top=�$	��126��$	 0���� -   $ Label_0_2_0��$��2��$
��Tura��$��Center=�$��0,10,0,0q�$	��Top=�$��20(�
�������$
��Bold"��� -   $ Label_0_2_1��$��0��$��2��$��-��$��Center=�$��0,45,0,0q�$	��Top=�$��20(�
��������� -   $
 Button_0_2_0��$��2��$��Dalej��{�.  $��Center=�$��0,90,0,0q�$	��Top=�$ 1.641,0.763&�$	��125��$��25��$��16(����	#FF7F78C7 .  �� -   $ Label_1_0_0��$��1��$��0��$
��Ruch��$��Center=�$��0,80,0,0q�$	��Top=�$��20(�
�������$
��Bold"��� -   $ Label_1_0_1��$��1��$��0��$��-��$��Center=�$��	0,120,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -   $ Label_1_1_0��$��1��$��1��$��Gra nierozpoczęta��$��Center=�$��0,10,0,0q�$	��Top=�$��24(�
���  ��$
��Bold"��� -   $ Label_1_1_1��$y�Hidden=�$��1��$��1��$��-��$��Center=�$��0,35,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -   $ Label_1_1_2��$y�Hidden=�$��1��$��1��$��-��$��Center=�$��	0,125,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -   $
 Button_1_1_0��$y�Hidden=�$��1��$��1��$��-��{�.  $��Center=�$��0,70,0,0q�$	��Top=�$ 1.641,0.763&�$	��252��$��25��$��16(����	#FF7F78C7 .  �� -   $
 Button_1_1_1��$y�Hidden=�$��1��$��1��$��-��{�.  $��Center=�$��	0,135,0,0q�$	��Top=�$ 1.641,0.763&�$	��252��$��25��$��16(����	#FF7F78C7 .  �� -   $
 Button_1_1_2��$y�Hidden=�$��1��$��1��$��-��{�.  $��Center=�$��	0,200,0,0q�$	��Top=�$ 1.641,0.763&�$	��252��$��25��$��16(����	#FF7F78C7 .  �� -   $ ComboBox_1_1_0��$y�Hidden=�{�.  $��1��$��1��$��Center=�$��0,98,0,0q�$	��Top=�$	��252��$	 0���� -   $ ComboBox_1_1_1��$y�Hidden=�{�.  $��1��$��1��$��Center=�$��	0,163,0,0q�$	��Top=�$	��252��$	 0���� -   $ Label_1_2_0��$��1��$��2��$��
Informacje��$��Center=�$��0,80,0,0q�$	��Top=�$��20(�
�������$
��Bold"��� -   $ Label_1_2_1��$��1��$��2��$��-��$��Center=�$��	0,120,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -   $ Label_2_0_0��$��2��$��0��$��Rozkład układu��$��Center=�$��0,10,0,0q�$	��Top=�$��20(�
�������$
��Bold"��� -    $ Label_2_0_1��$��2��$��0��$
��1. -��$��Center=�$��0,65,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -!   $ Label_2_0_2��$��2��$��0��$
��2. -��$��Center=�$��0,90,0,0q�$	��Top=�$��16(�
�������$��Italic$�� $��2��$��1�� .  �� $��2* ��� $��3* �.+��� -"   $ Label_2_1_0��$��Plansza��$��Center=�$��0,10,0,0q�$	��Top=�$��20(�
�������$
��Bold"�� $��2��$��1�� .  �� $��2* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -#   $ Label_2_1_1��$y�Hidden=�$��G1��$��2��$
��Left=�$��5,5,0,0q�$	��Top=�$��12(����#C77D78�� -$   $ Label_2_1_2��$y�Hidden=�$��G2��$��2��$��Right=�$��0,5,5,0q�$	��Top=�$��12(����#C2C778�� -%   $ Label_2_1_3��$��0��$��Center=�$��0,0,0,0q�$��Center=�$��12(�
�������$��Italic$�.���� $��WrapWithOverflow=� �� TextAlignment$ Center=�Układ Słone- czny�� -&   $ Label_2_1_4��$��1��$��Center=�$��-3,0,0,0q�$��Center=�$��12(�
����ح�$��Italic$�.���� $��WrapWithOverflow=�$ Center=�Dworzec Orbita lny�� -'   $ Label_2_1_5��$��2��$��Center=�$��0,0,0,0q�$��Center=�$��12(�
�������$��Italic$�.���� $��WrapWithOverflow=�$ Center=�Układ Księży- cowy�� -(   $ Label_2_1_6��$��3��$��Center=�$��0,0,0,0q�$��Center=�$��12(�
������$��Italic$�.���� $��WrapWithOverflow=�$ Center=�Szansa�� -)   $ Label_2_1_7��$��4��$��Center=�$��0,0,0,0q�$��Center=�$��12(�
�������$��Italic$�.���� $��WrapWithOverflow=�$ Center=�Układ Gwie- zdny�� -*   $ Label_2_1_8��$��5��$��Center=�$��-3,0,0,0q�$��Center=�$��12(�
����ح�$��Italic$�.���� $��WrapWithOverflow=�$ Center=�Dworzec Świe- tlny�� -+   $ Label_2_1_9��$��6��$��Center=�$��0,0,0,0q�$��Center=�$��12(�
�������$��Italic$�.���� $��WrapWithOverflow=�$ Center=�Układ Głębi- nowy�� -,   $ Label_2_1_10��$��7��$��Center=�$��0,0,0,0q�$��Center=�$��12(�
�������$��Italic$�.���� $��WrapWithOverflow=�$ Center=�Piraci�� --   $ Label_2_1_11��$��8��$��Center=�$��0,0,0,0q�$��Center=�$��12(�
�������$��Italic$�.���� $��WrapWithOverflow=�$ Center=�Układ Mglisty�� -.   $ Label_2_2_0��$��2��$��2��$��Kostki��$��Center=�$��0,10,0,0q�$	��Top=�$��20(�
�������$
��Bold"��� -/   $ Label_2_2_1��$��2��$��2��$
��1. -��$��Center=�$��0,65,0,0q�$	��Top=�$��16(�
�������$��Italic$��� -0   $ Label_2_2_2��$��2��$��2��$
��2. -��$��Center=�$��0,90,0,0q�$	��Top=�$��16(�
�������$��Italic$�