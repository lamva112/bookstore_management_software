   M S B A M L   `   `   `  ����J  FBookstoreNMCNPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BookstoreNMCNPM.ViewBookstoreNMCNPM.View  5      %    BookstoreNMCNPM.View.ImportBook   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:BookstoreNMCNPM.View     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��3* �6   �� 5      $��2* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      $��10 �6#   �� 5      $��2* �6#   .+�5      � $��0��6     5      �� 5      �� 5      $
��Auto �6$   .+�5      �� $��1��6    �� Orientation$ 
Horizontal=�6*   $��Center=�6C   .+�5       �� -   5        $��btnAdd��5#       *  &MaterialDesignFloatingActionMiniButton#��[  5       $��0 4 8 4q�5!      $
��Left=�6.    � ToolTip$  Tạo phiếu nhập mới��5"      .��5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Plus=�62   $��24��6>   $��24��6J   5&      �� 5'      -   5        $��	btnUpdate��5*      #��[  5'      $��0 4 8 4q�5(      $
��Left=�6.   $ Nhập sách��5)      {�.  .��5-        $ Import=�62   $��24��6@   $��24��6L   5.      �� 5/      -   5        $��btnSave��52      #��[  5/      $��0 4 0 4q�50      $
��Left=�6.   $ Lưu phiếu nhập��51      {�.  .��55        $ ContentSave=�62   $��24��6E   $��24��6Q   56      58      &   System.Windows.Controls.DataGrid  5:      -   5          Name$ dataPhieuNhap��5:         AutoGenerateColumns .  {�. ��62   ��    Columns 5<      4  .System.Windows.Controls.DataGridTemplateColumn  5=         CellTemplate 5>      �� 5?   "   .R�5@   &   �� -   5        #��[  5@   -   $ Xóa sách nhập��5A   )   $��25��6Y   $��25��6e   .��5B   *     $ DeleteForever=�6B   $��20��6W   $��20��6c   5C   '   5D   #   5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn	   Header$		 Mã��6�   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6-   �� *SoPNS+ �� NotifyOnTargetUpdated .  �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�     5H      $	 Ngày nhập��6�      
IsReadOnly . 
 6-   �� *
NgayNhap+ . $ TwoWay=�$ PropertyChanged=�6�     5I      $	 Tổng tiền��6�    . 
 6-   �� *
TongTien+ . $ TwoWay=�$ PropertyChanged=�6�   5K      5L      � 5N      -   5         �Name$ pnlBooks��5N      $��2��6%   {�.  .+�5O        -   5        $ 	dataBooks��5O       .     
IsReadOnly . $��
0,0,0,44.6q�6t   ��6.   ��  5P        5Q      $		 Mã��6�   
 6-   �� *MaSach+ . $ TwoWay=�$ PropertyChanged=�6�     5R      $	 
Tên Sách��6�   
 6-   �� *	TenSach+ . $ TwoWay=�$ PropertyChanged=�6�     5S      $	 
Tác Giả��6�   
 6-   �� *TacGia+ . $ TwoWay=�$ PropertyChanged=�6�     5T      $	 Số Lượng Tồn��6�   
 6-   �� *
SoLuongTon+ . $ TwoWay=�$ PropertyChanged=�6�   5V      5W      5Y      � 5[   
   -	   5        $ pnlPhieuNhap��5[      $��2��6%   {�.   5\      �� 5]      �� 5^      $
��Auto �6#   .+�5a      �� -
   5        $��pnlThemSach��5a   )   $��1��6   .+�5b      �� -   5         ��Name$ 	tbSoLuong��5b      $��0��6-   $��0��6:    % !MaterialDesignFloatingHintTextBox#��[ 6J   $��
10,4,9.6,4q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Số lượng nhập��5c      $��48��6   {�6E   �� *SelectedItem+ �� ElementName$ 	dataBooks��5d      �� 5e      -   5        $ tbDonGia��5e      $��0��6,   $��0��69   #��[ 6I   $��
10,4,9.6,4q�6�   $ Giá nhập��5f      $��52��6z   {�6@   �� *SelectedItem+$ 	dataBooks��5g      �� 5h      -   5        $��Thêm Sách��5h      $��0,30,-0.4,0q�6F   5i        5j      -   5        $ dataCT��5j      $��0��6'   $��0,0,10,0q�67    .   . ��6I   ��  5k        5l       5m      �� 5n      .R�5o   "   �� -   5        #��[  5o   )   $ Xóa sách nhập��5p   )   $��25��6]   $��25��6i   .��5q   &     $ DeleteForever=�6>   $��20��6S   $��20��6_   5r   #   5s      5u        5v      $		 Mã��6�   
 6)   �� *MaSach+ . $ TwoWay=�$ PropertyChanged=�6�     5w      $	 
Tên Sách��6�   
 6)   �� *SACH.TenSach+ . $ TwoWay=�$ PropertyChanged=�6�     5x      $	 Số lượng��6�   
 6)   �� *SoLuongNhap+ . $ TwoWay=�$ PropertyChanged=�6�     5y      $	 
Đơn giá��6�   
 6)   �� *
DonGiaNhap+ . $ TwoWay=�$ PropertyChanged=�6�     5z      $	 Thành tiền��6�   
 6)   �� *	ThanhTien+ . $ TwoWay=�$ PropertyChanged=�6�   5|      5}      5      5�      