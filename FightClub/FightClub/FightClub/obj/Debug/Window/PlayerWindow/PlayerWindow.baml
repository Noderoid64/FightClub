   M S B A M L   `   `   `  ����D  @FightClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FightClub	FightClub  5   	       FightClub.PlayerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:FightClub     5   	     � Title$  PlayerWindow��5   	   $	��400��6   $	��400��6+    � 
ResizeMode$ NoResize=�67    � 	Resources 5	         BodyPart �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " ��6!   .�5      ��  � ��$ 80��6'   64   �� 5       � ��$ 10q�6'   64   5      5      .��5      ��   	darkColor#���  6   .+�5   
   � $��70��6    � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��70 �6#   60   .+�5      �� .+�5      �� -   5         ��Name$ TextBoxName��5      $��Center=�61   $��20(�6N     defaultTextColor#���  6\   Empty6�   � 5      .+�5      � -   5         �Name$ ProgressBarHp��5   "   
��� d �	 � Value$		 100Q�6P   $��10q�6\   $��30��6h   6v   �� 5      -   5        $ TextBlockHP��5         superTextColor#���  65   $��20(�6c   $��Center=�6q   $��Center=�6�   0/06�   5      5      �� 5      $��1��6   
 �� CornerRadius$
 50��6%   
�������._�5       �� $��15q�6     ComputerImage#���  6$   6O   5!      5"      �� 5#   
   -   5         ��Name$ 
HeadButton��5#      
������ $��0q�6?   .��5$      �� #���   6     HeadDefImage#���  67   5%      �� 5&   
   -   5        $ 
BodyButton��5&      
������ $��0q�6?   .��5'      �� #���   6     BodyDefImage#���  67   5(      �� 5)   
   -   5        $ 
LegsButton��5)      
������ $��0q�6?   .��5*      �� #���   6     LegsDefImage#���  67   5+      5.      5/      