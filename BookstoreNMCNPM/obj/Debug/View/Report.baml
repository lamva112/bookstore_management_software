   M S B A M L   `   `   `  ����J  FBookstoreNMCNPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BookstoreNMCNPM.ViewBookstoreNMCNPM.View  5      !    BookstoreNMCNPM.View.Report   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:BookstoreNMCNPM.View     5      -   5        .��5      � .+�5   
   �   � RowDefinitions  5      �� 5      $��50 �6    �� 5      $��50 �6    �� 5       � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��0��6   $��0��6     5      �� 5      �� 5      .+�5      �� -   5         ��Name$ cbThang��5      $��0��6,   $��0��69    �� 
IsEditable .  &  "MaterialDesignFloatingHintComboBox#��[  6\   $
��10,4q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tháng��5      {�.  �� 
IsReadOnly . ��5      �� 5      �� 5!      -   5        $ cbNam��5!      $��0��6*   $��1��67    . #��[  6Z   $
��10,4q�6�   $
 Năm��5"      {�.  . ��5#      �� 5%      5'      � 5(      $��1��6   $��0��6    .+�5)      �� $��Center=�6   $��Center=�69   $
��Bold"�6T   $��25(�6f   
���   �Bảng sách tồn kho6�   5*      � 5+      $��2��6   $��0��6    $��
10,10,10,5q�60   .+�5,      &   System.Windows.Controls.DataGrid  -   5          Name$ dataSachTon��5,         AutoGenerateColumns .     
IsReadOnly . ��61   �� 	   Columns	 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Mã Sách��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *MaSach+ �� NotifyOnTargetUpdated .  �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�     50      $
 Tồn đầu��6�    6-   �� *TonDau+ . $ TwoWay=�$ PropertyChanged=�6�     51      $
 
Phát sinh��6�    6-   �� *
PhatSinh+ . $ TwoWay=�$ PropertyChanged=�6�     52      $
 Tồn cuối��6�    6-   �� *	TonCuoi+ . $ TwoWay=�$ PropertyChanged=�6�   54      55      � 56      $��1��6   $��2��6    .+�57      �� $��Center=�6   $��Center=�69   $
��Bold"�6T   $��25(�6f   
���   �Bảng công nợ6�   58      � 5:      $��2��6   $��2��6    $��
10,10,10,5q�60   .+�5;        -   5        $ 
dataCongNo��5;       .   . ��6/   �� 	 5<        5=      $
 Mã Khách Hàng��6�    6-   �� *MaKhachHang+ . $ TwoWay=�$ PropertyChanged=�6�     5>      $
 Nợ đầu��6�    6-   �� *NoDau+ . $ TwoWay=�$ PropertyChanged=�6�     5?      $
 
Phát sinh��6�    6-   �� *
PhatSinh+ . $ TwoWay=�$ PropertyChanged=�6�     5@      $
 Nợ cuối��6�    6-   �� *NoCuoi+ . $ TwoWay=�$ PropertyChanged=�6�   5B      5C      5D      5E      5F      