   M S B A M L   `   `   `  ����F  BBasketStatz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BasketStatz.ViewsBasketStatz.Views  5      ,    &BasketStatz.Views.PlayerGameStats_View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:BasketStatz.Views     5      .��5
      � 
�������  � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Team: ��6-   $��Center=�6>   $��Right=�6Y   $��20(�6u   $��SemiBold"�6�   �� 5   
   $��0��6   $��1��6!   $��Center=�61   $
��Left=�6L   $��TestTeam��6g   $��20(�6w   �� 5   
   $��0��6   $��2��6   $��Name: ��6-   $��Center=�6>   $��Right=�6Y   $��20(�6u   $��SemiBold"�6�   �� 5   
   $��0��6   $��3��6!   $��Center=�61   $
��Left=�6L   $��TestName��6g   $��20(�6w   �� 5   
   $��0��6   $��4��6   $��Number: ��6-   $��Center=�6@   $��Right=�6[   $��20(�6w   $��SemiBold"�6�   �� 5   
   $��0��6   $��5��6!   $��Center=�61   $
��Left=�6L   $��20��6g   $��20(�6q   &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��6��6       Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$
 Game��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 63     5"      $	 PTS��6%   $ * 62     5#      $	 FGM��6%   $ * 62     5$      $	 FGA��6%   $ * 62     5%      $	 FG%��6%   $ * 62     5&      $	 FTM��6%   $ * 62     5'      $	 FTA��6%   $ * 62     5(      $	 FT%��6%   $ * 62     5)      $
 3FGM��6%   $ * 63     5*      $
 3FGA��6%   $ * 63     5+      $
 3FG%��6%   $ * 63     5,      $	 REB��6%   $ * 62     5-      $
 OREB��6%   $ * 63     5.      $
 DREB��6%   $ * 63     5/      $	 AST��6%   $ * 62     50      $	 STL��6%   $ * 62     51      $	 BLK��6%   $ * 62     52      $ TO��6%   $ * 61     53      $ PF��6%   $ * 61   57      58      59      