   M S B A M L   `   `   `  ����J  FBookstoreNMCNPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BookstoreNMCNPM.ViewBookstoreNMCNPM.View  5      #    BookstoreNMCNPM.View.HomeMenu   5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:BookstoreNMCNPM.View     5      -   5        .��5      � .+�5   
   �   � RowDefinitions  5      �� 5      $��50 �6    �� 5      $��50 �6    �� 5      .+�5      � $��0��6   $��0��6     � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��1��6   $��0��6$   .+�5      �� -   5        $��tbThang��5       $��Center=�6/   $��Center=�6L   $
��Bold"�6g   $��25(�6y   
���   �	Tháng:6�   5      � 5      $��1��6   $��1��6$   .+�5      �� -   5        $��tbNam��5       $��Center=�6-   $��Center=�6J   $
��Bold"�6e   $��25(�6w   
���   �Năm:6�   5      5      � 5      $��1��6   $��0��6    .+�5       �� $��Center=�6   $��Center=�69   $
��Bold"�6T   $��25(�6f   
���   �Top sản phẩm bán chạy6�   5!      � 5"      $��2��6   $��0��6    $��
10,10,10,5q�60   .+�5#      &   System.Windows.Controls.DataGrid  -   5          Name$ dataSachBanChay��5#         AutoGenerateColumns .     
IsReadOnly . ��65   ��    Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã Sách��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *MaSach+ �� NotifyOnTargetUpdated . 	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�     5'      $ 
Tên Sách��6�    6-   �� *	TenSach+ . $	 TwoWay=�$
 PropertyChanged=�6�     5(      $ 
Tác Giả��6�    6-   �� *TacGia+ . $	 TwoWay=�$
 PropertyChanged=�6�     5)      $ Giá ��6�    6-   �� *GiaBan+ . $	 TwoWay=�$
 PropertyChanged=�6�   5+      5,      5.      5/      50      