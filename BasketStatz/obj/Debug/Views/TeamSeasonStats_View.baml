   M S B A M L   `   `   `  ����F  BBasketStatz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BasketStatz.ViewsBasketStatz.Views  5      ,    &BasketStatz.Views.TeamSeasonStats_View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:BasketStatz.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Team Name: ��6-   $��Center=�6C   $��Right=�6^   $��20(�6z   $
��Bold"�6�   �� 5   
   $��0��6   $��1��6!   $��SeasonTestTeam��61   $��Center=�6G   $
��Left=�6b   $��20(�6}   &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��2��6       Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Player��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 65     5      $	 PTS��6%   $ * 62     5      $	 FGM��6%   $ * 62     5      $	 FGA��6%   $ * 62     5      $	 FG%��6%   $ * 62     5      $	 FTM��6%   $ * 62     5      $	 FTA��6%   $ * 62     5      $	 FT%��6%   $ * 62     5       $
 3FGM��6%   $ * 63     5!      $
 3FGA��6%   $ * 63     5"      $
 3FG%��6%   $ * 63     5#      $	 REB��6%   $ * 62     5$      $
 OREB��6%   $ * 63     5%      $
 DREB��6%   $ * 63     5&      $	 AST��6%   $ * 62     5'      $	 STL��6%   $ * 62     5(      $	 BLK��6%   $ * 62     5)      $ TO��6%   $ * 61     5*      $ PF��6%   $ * 61   5,      5-      5.      