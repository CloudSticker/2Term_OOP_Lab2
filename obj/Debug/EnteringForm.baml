   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Title$L  FToxicCode: ООП Лабораторная работа №2 ToxicCode��5   	   $��669.378��6A   $��515.403��6R    � Icon$ logo.png��6b    � 
ResizeMode$ CanMinimize=�6r   
 J� Uid$
 0002��6�    � WindowStartupLocation$ CenterScreen=�6�    � AllowsTransparency .  � WindowStyle$
 None=�6�    � TaskbarItemInfo 5	      *  $System.Windows.Shell.TaskbarItemInfo  5
   
      Overlay$ logo.png��6   .��5      � $��0,-2,-11.094,18.283q�6   	 � ColumnDefinitions	 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5        
 ��Name$
 
Tardisback��5      $
��Left=�6$   $	��672��6?   $	��Top=�6L   $	��526��6d    J� RenderTransformOrigin$ 0.501,0.702&�6p   $��	0,0,0,-19q�6�   $��tardisback.jpg��6�    J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FF0744C5��6#   $ 1Q�65   5      5      �� 5   
   -   5        $
 Door1��5      $
��Left=�6   $	��575��6:   $��261,97,0,-19q�6G   $	��Top=�6]   $	��255��6u   $��RightDoor.jpg��6�   $y�Hidden=�6�   �� 5   
   -   5        $
 Door2��5      $
��Left=�6   $	��575��6:   $��69,97,0,-19q�6G   $	��Top=�6\   $	��212��6t   $��LeftDoor.jpg��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ DKDBtn��5      ���	#00000000$��1q�6:   $
��Left=�6N   $	��562��6i   $��	62,91,0,0q�6v   $	��Top=�6�   $	��197��6�   ���	#00A894946  �� 5   
   -   5        $ DKABtn��5      ���	#00000000$��1q�6:   $
��Left=�6N   $	��581��6i   $��264,91,0,-19q�6v   $	��Top=�6�   $	��197��6�   ���	#00A894946  �� 5   
   -   5        $ exitbtn��5      ���	#00000000$��1q�6:   $
��Left=�6N   $��48��6i   $��	31,10,0,0q�6u   $	��Top=�6�   $	��460��6�   ���	#005916166  5!      5"      