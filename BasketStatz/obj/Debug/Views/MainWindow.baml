   M S B A M L   `   `   `  ����F  BBasketStatz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BasketStatzBasketStatz  5   	   ?$clr-namespace:BasketStatz.ViewModelsBasketStatz.ViewModels  5   	   5clr-namespace:BasketStatz.ViewsBasketStatz.Views  5   	       BasketStatz.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BasketStatz     5   	   ;
viewmodels$clr-namespace:BasketStatz.ViewModels     5   	   1viewsclr-namespace:BasketStatz.Views     5   	     � 
ResizeMode$  CanResizeWithGrip=�5
   	   $	��250��5   	   $	��300��6    � Title$ BasketStatz��5   	   $	��750��6   $
��1100��6*    � DataContext 5      *  $BasketStatz.ViewModels.MainViewModel  5   
    � 	Resources 5         
MenuButton �� 
TargetType �� Property �� Value �� DataType$  BasketStatz.ViewModels.Menu_VM!   BasketStatz.Views.Menu_View1  +BasketStatz.ViewModels.PlayerCareerStats_VM,   &BasketStatz.Views.PlayerGameStats_View/  )BasketStatz.ViewModels.PlayerStatInput_VM,   &BasketStatz.Views.PlayerStatInput_View-  'BasketStatz.ViewModels.TeamGameStats_VM*	   $BasketStatz.Views.TeamGameStats_View/
  )BasketStatz.ViewModels.TeamSeasonStats_VM,   &BasketStatz.Views.TeamSeasonStats_View��%d  &	        (�� �     5      *, +)(��     5      *, +)(�� G    5!      *, +)(�� y    5$      *, +)(�� �    5'      *,
 +)�� 5   
   " ��6#   .�5      ��  � ��$ 50��6'   �� 5       � ��$ 50��6&   �� 5       � ��$ 10,0,0,0q�6'   �� 5       � ��$ Center=�64   �� 5       � ��$	 Top=�62   5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5       �� 5!   
   "  6   .R�5"        5#      �� 5$   
   "  6   .R�5%      	  5&      �� 5'   
   " 
 6   .R�5(        5)      5+      .��5-      �  � RowDefinitions 5.   
   �� 5/      $��75 �6   �� 50      $��* �6   	 � ColumnDefinitions	 52   
   �� 53      $	��200 �6   �� 54      $��* �6   .+�58   
   � $��0��6   $��2��6   	 59      �� 5:      $	��200 �6#   �� 5;      $��* �6#   �� 5<      $	��200 �6#   �� 5=      $��80 �6#   �� 5>      $��80 �6#   �� 5?      $��80 �6#   �� 5@      $	��200 �6#   �� 5A      $��* �6#   .+�5E      �� $��0��6   $��2��6(   $��10,10,10,10q�6<   $��BasketStatz��6Q   $��36(�6d   $��Black"�6r   �� 5G      $��2��6   $��	Home Team��6(   $��26(�69   $��Center=�6G   $��Center=�6d   �� 5J      $��3��6   $��60��6%   $��55��60   
�������$��20(�6O   ��6]   �� *	HomeScore+��6{   �� *AddToHomeScore+�� 5M      $��5��6   $��60��6%   $��55��60   
�������$��20(�6O   ��6]   �� *	AwayScore+��6{   �� *AddToAwayScore+�� 5O      $��6��6   $��	Away Team��6(   $��26(�69   $��Center=�6G   $��Center=�6d   5P      � 5S   
   $��1��6   $��0��6    5T      �� 5U      $��50 �6    �� 5V      $��* �6    .+�5Y      �� $��0��6   $��30��6#   $	��180��6/   
�������$��	10,0,10,0q�6U   $��Center=�6h   $
��Left=�6�   $��	Search...��5Z      $��20(�6'   �� 5\      -   5        
 ��Name$
 PlayerListBox��5\      $��1��6-   $
��Auto��6:   $
��Auto��6G   
����ح���6l   �� *GamePlayers+ �� SelectedItem 6�   �� *SelectedPlayer+��5]      �� 5^      .R�5_      ��  �� CornerRadius$ 5��6!   $��2q�62   
�������
�������$	��190��6t   $��24��6�   ._�5`      � $	��190��6#   $��Center=�6/   	 5a   "   �� 5b   &   $��* �67   �� 5c   &   $��30 �67   .+�5e   "   �� $��0��6,   $��5,0,0,0q�6R   $
��Left=�6c   $��Center=�6~   ��6<   �� *Name+6~   �� 5f   "   $��1��6,   $��0,0,5,0q�6T   $��Center=�6e   $��Center=�6�   ��6<   �� *Number+6�   5g      5h      5i      5k      5m      � 5o   
   $��1��6   $��1��6    5p      �� 5q      $��40 �6    �� 5r      $��* �6    .+�5v      � $��0��6   	 5w      �� 5x      $	��200 �6'   �� 5y      $	��200 �6'   .+�5      �� $��0��6   
����ح�$
��Menu��6@   $��20(�6O   $��SemiBold"�6]   ��6s   �� *ChangeToMenu+�� 5�      $��1��6   
����ح�$��	Set Stats��6@   $��20(�6T   $��SemiBold"�6b   ��6x   �� *ChangeToPlayerStat+5�      � 5�      -   5         �Name$ DisplayGrid��5�      $��1��6(   
�������.+�5�      �� -   5         ��Name$ displayContent��5�   !   ��69   �� *CurrentViewModel+5�      5�      5�      5�      