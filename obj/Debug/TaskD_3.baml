   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window7   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   -   5          � Title$  
ЖИЗНЬ��5	   	   $��560.15��6   $��744.848��6'   ���	#FF1A2916 � 
ResizeMode$ CanMinimize=�6g    � Icon$ logo.png��6�    � WindowStartupLocation$ CenterScreen=�6�   .��5
      � $��
0,0,4.17,0q�6   $	��571��6   $	��Top=�6,   .+�5   
   �� -   5         ��Name$ Canvas1��5      $
��Left=�6"   $	��500��6=   $��	10,10,0,0q�6J   $	��Top=�6]   $	��500��6u   ���	#FF769653 J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   	 � Offset$	 0Q�61   � 5      $ White��6#   $
	 0.45Q�61   5      5      �� 5   
   -   5        
 ��Name$
 TurnBtn��5      $��Генерация��6"   $
��Left=�66   $��524,118,0,0q�6Q   $	��Top=�6f   $	��180��6~   $��71��6�   ���	#FF7696536�   �� 5   
   -   5         ��Name$ 	GenNumLbl��5      $0��*Количество генераций: 0��6#   $
��Left=�6E   $��
510,10,0,0q�6`   $	��Top=�6t   $��16(�6�   ���	#FF7696536�   �� 5   
   -   5        $ DeathNumLbl��5      $,��&Количество смертей: 0��6%   $
��Left=�6E   $��
510,46,0,0q�6`   $	��Top=�6t   $��16(�6�   $	��194��6�   ���	#FF7696536�   �� 5   
   -   5        $ AliveNumLbl��5      $.��(Количество выживших: 0��6%   $
��Left=�6F   $��
510,82,0,0q�6a   $	��Top=�6u   $��16(�6�   ���	#FF7696536�   �� 5   
   -   5        $
 
RestartBtn��5      $��Перезапуск��6%   $
��Left=�6:   $��524,217,0,0q�6U   $	��Top=�6j   $	��180��6�   $��71��6�    J� RenderTransformOrigin$ 1.081,1.402&�6�   ���	#FF7696536�   �� 5   
   -   5        $
��Fura��5      "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ fura.gif��6      RepeatBehavior$ 1x��6H   $
��Left=�6n   $	��168��6�   $��530,340,0,0q�6�   $	��Top=�6�   $	��176��6�      	AutoStart .  6�   5      5      