   M S B A M L   `   `   `  ����F  BBasketStatz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BasketStatz.ViewsBasketStatz.Views  5      G(clr-namespace:BasketStatz.CustomControlsBasketStatz.CustomControls  5      ,    &BasketStatz.Views.PlayerStatInput_View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:BasketStatz.Views     5      =controls(clr-namespace:BasketStatz.CustomControls     5      .��5
      � 
�������  � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��	Team Name��6-   $��Bottom=�6A   $��Center=�6\   $��20(�6y   $
��Bold"�6�   �� 5   
   -   5         ��Name$ teamName_TextBlock��5      $��1��60   $��0��6=   $	��Top=�6r   $��Center=�6�   $��20(�6�   ��6M   �� *SelectedPlayer.Team+6�   �� 5   
   $��0��6   $��1��6   $
��Name��6-   $��Bottom=�6<   $��Center=�6W   $��20(�6t   $
��Bold"�6�   �� 5   
   -   5        $ name_TextBlock��5      $��1��6,   $��1��69   $	��Top=�6n   $��Center=�6�   $��20(�6�   ��6I   �� *SelectedPlayer.Name+6�   �� 5    
   $��0��6   $��3��6   $	��Age��6-   $��Bottom=�6;   $��Center=�6V   $��20(�6s   $
��Bold"�6�   �� 5!   
   -   5        $ age_TextBlock��5!      $��1��6+   $��3��68   $	��Top=�6l   $��Center=�6�   $��20(�6�   ��6H   �� *SelectedPlayer.Age+6�   �� 5#   
   $��0��6   $��4��6   $��Height��6-   $��Bottom=�6>   $��Center=�6Y   $��20(�6v   $
��Bold"�6�   �� 5$   
   -   5        $ height_TextBlock��5$      $��1��6.   $��4��6;   $	��Top=�6r   $��Center=�6�   $��20(�6�   ��6K   �� *SelectedPlayer.Height+6�   1   +BasketStatz.CustomControls.StatInputControl  5&   
   -   5          Name$ pts_Stat��5&   $      Title$	 PTS��66   $��2��6k   $��0��6x   $��10,20,10,20q�6�      	StatValue 6B   �� *SelectedPlayer.PTS+6�     5'   
   -   5        $ fgm_Stat��5'   $   $	 FGM��66   $��2��6k   $��1��6x   $��10,20,10,20q�6�    6B   �� *SelectedPlayer.FGM+6�     5(   
   -   5        $ fga_Stat��5(   $   $	 FGA��66   $��2��6k   $��2��6x   $��10,20,10,20q�6�    6B   �� *SelectedPlayer.FGA+6�     5)   
   -   5        $ ftm_Stat��5)   $   $	 FTM��66   $��2��6k   $��3��6x   $��10,20,10,20q�6�    6B   �� *SelectedPlayer.FTM+6�     5*   
   -	   5        $ fta_Stat��5*   $   $	 FTA��66   $��2��6k   $��4��6x   $��10,20,10,20q�6�    6B   �� *SelectedPlayer.FTA+6�     5,   
   -
   5        $ threeFGM_Stat��5,   $   $
 3FGM��6;   $��3��6v   $��0��6�   $��10,20,10,20q�6�    6H   �� *SelectedPlayer.ThreeFGM+6�     5-   
   -   5        $ threeFGA_Stat��5-   $   $
 3FGA��6;   $��3��6v   $��1��6�   $��10,20,10,20q�6�    6H   �� *SelectedPlayer.ThreeFGA+6�     5.   
   -   5        $ reb_Stat��5.   $   $	 REB��66   $��3��6k   $��2��6x   $��10,20,10,20q�6�    6B   �� *SelectedPlayer.REB+6�     5/   
   -   5        $ 	oreb_Stat��5/   $   $
 OREB��67   $��3��6n   $��3��6{   $��10,20,10,20q�6�    6D   �� *SelectedPlayer.OREB+6�     50   
   -   5        $ 	dreb_Stat��50   $   $
 DREB��67   $��3��6n   $��4��6{   $��10,20,10,20q�6�    6D   �� *SelectedPlayer.DREB+6�     52   
   -   5        $ ast_Stat��52   $   $	 AST��66   $��4��6k   $��0��6x   $��10,20,10,20q�6�    6B   �� *SelectedPlayer.AST+6�     53   
   -   5        $ stl_Stat��53   $   $	 STL��66   $��4��6k   $��1��6x   $��10,20,10,20q�6�    6B   �� *SelectedPlayer.STL+6�     54   
   -   5        $ blk_Stat��54   $   $	 BLK��66   $��4��6k   $��2��6x   $��10,20,10,20q�6�    6B   �� *SelectedPlayer.BLK+6�     55   
   -   5        $ to_Stat��55   $   $ TO��65   $��4��6h   $��3��6u   $��10,20,10,20q�6�    6@   �� *SelectedPlayer.TO+6�     56   
   -   5        $ pf_Stat��56   $   $ PF��65   $��4��6h   $��4��6u   $��10,20,10,20q�6�    6@   �� *SelectedPlayer.PF+6�   59      5:      