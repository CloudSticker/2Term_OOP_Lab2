   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window9   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   -   5          � Title$  БАШЕ��5	   	   $��210.094��6   $��463.297��6'    � Icon$ logo.png��6m    � WindowStartupLocation$ CenterScreen=�6}    � 
ResizeMode$ CanMinimize=�6�    � TaskbarItemInfo 5
      *  $System.Windows.Shell.TaskbarItemInfo  5   
      ProgressState$
 None=�6   .��5      � $��1,10,2.887,4.491q�6    � RowDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ TurnBtn��5      $
��Turn��6"   $
��Left=�61   $��
38,112,0,0q�6L   $	��Top=�6`   $	��142��6x   $��28��6�   6�   �� 5   
   -   5         ��Name$ 
GiveSlider��5      $
��Left=�6%   $	��Top=�6@   $	��142��6X   	 � SmallChange$	 1Q�6�   
 �� Interval$
 1��6�    �� TickPlacement$ BottomRight=�6�    �� IsSnapToTickEnabled . $��	38,51,0,0q�6�   $��24��6�   �� 5   
   -   5         ��Name$ ValueLbl��5      $��0��6"   $
��Left=�6.   $	��Top=�6I   $��
185,51,0,0q�6a   $��24��6u   $��26��6�   �� 5   
   -   5        $ 	BolderLbl��5      $��0��6#   $
��Left=�6/   $��
189,10,0,0q�6J   $	��Top=�6^    J� RenderTransformOrigin$ 2,1.231&�6v   $��24��6�   $��34��6�   �� 5   
   $D��>Оставшееся кол-во камней:                ��6   $
��Left=�6D   $��24��6_   $��	37,10,0,0q�6k   $	��Top=�6~   $	��152��6�   �� 5   
   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ ogre.gif��6   $
��Left=�6<   $	��130��6W   $��
300,10,0,0q�6d   $	��Top=�6x   $	��123��6�   5      5      