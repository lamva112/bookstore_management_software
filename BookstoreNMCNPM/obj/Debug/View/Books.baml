   M S B A M L   `   `   `  ����J  FBookstoreNMCNPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BookstoreNMCNPM.ViewBookstoreNMCNPM.View  5   	        BookstoreNMCNPM.View.Books   5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:BookstoreNMCNPM.View     5   	   -   5        $	��800��5	   	   $
��1100��6   .��5      �   � RowDefinitions  5   
   �� 5      $��0 �6   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��1��6     5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      �� 5      $��20 �6#   �� 5      �� 5      $
��Auto �6#   .+�5       �� -   5         ��Name$ tbMaSach��5       $��0��6(   $��0��65    %  !MaterialDesignFloatingHintTextBox#��[  6E   $
��10,4q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Mã Sách��5!      {�.  ��5"      �� *SelectedItem.MaSach+ �� ElementName$ 	dataBooks���� 5#      -   5        $ 	tbTenSach��5#      $��1��6)   $��0��66   #��[  6F   $
��10,4q�6�   $ 
Tên Sách��5$      {�.  ��5%      �� *SelectedItem.TenSach+$ 	dataBooks���� 5&      -   5        $ tbTacGia��5&      $��2��6(   $��0��65   #��[  6E   $
��10,4q�6�   $ 
Tác Giả��5'      {�.  ��5(      �� *SelectedItem.TacGia+$ 	dataBooks���� 5)      -   5         ��Name$ 	cbTheLoai��5)      $��0��6*   $��2��67    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 6Z   $
��10,4q�6�   $ Thể Loại��5*      {�.   �� 
IsReadOnly . ��5+      ��  �� Text 5-      �� *!SelectedItem.THELOAI.TenTheLoai+$ 	dataBooks��	 �� SelectedValue	 5.      �� *SelectedItem.THELOAI+$ 	dataBooks���� 5/      -   5        $ cbNhaXuatBan��5/      $��1��6-   $��2��6:    . #��[ 6]   $
��10,4q�6�   $ Nhà Xuất Bản��50      {�.   . ��51      ��  53      �� *'%SelectedItem.NHAXUATBAN.TenNhaXuatBan+$ 	dataBooks��	 54      �� *SelectedItem.NHAXUATBAN+$ 	dataBooks���� 56      -   5        $��btnAdd��56   2   $��3��6   $��0��6%    * &MaterialDesignFloatingActionMiniButton#��[ 6@   $��8 4 8 0q�57      $
��Left=�6&   
 � ToolTip$
 Thêm sách��58      .��5:      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Plus=�6*   $��24��66   $��24��6B   5;      �� 5<      -   5        $��btnSave��5<   2   $��3��6   $��1��6%   #��[ 6A   $��8 4 8 0q�5=      $
��Left=�6&   $
 
Lưu sách��5>      {�.  .��5A        $ ContentSave=�6*   $��24��6=   $��24��6I   5B      �� 5C      -	   5        $��btnEdit��5C   2   $��3��6   $��2��6%   #��[ 6A   $��8 4 8 0q�5D      $
��Left=�6&   $
 Chỉnh sửa��5E      .��5G        $ 
LeadPencil=�6*   $��24��6<   $��24��6H   5H      5I      � 5K   
   $��2��6   $��	0,20,5,10q�6   .+�5L      &   System.Windows.Controls.DataGrid  -
   5          Name$ 	dataBooks��5L         AutoGenerateColumns .     
IsReadOnly . ��6*   ��    Columns 5M      4  .System.Windows.Controls.DataGridTemplateColumn  5N         CellTemplate 5O      �� 5P      .R�5Q   "   �� -   5        #��[ 5Q   )   $
 
Xóa sách��5R   )   $��25��6X   $��25��6d   .��5S   &     $ DeleteForever=�6>   $��20��6S   $��20��6_   5T   #   5U      5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$	 Mã��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *MaSach+ �� NotifyOnTargetUpdated .  �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�     5Y      $ 
Tên Sách��6�    6)   �� *	TenSach+ . $ TwoWay=�$ PropertyChanged=�6�     5Z      $ 
Tác Giả��6�    6)   �� *TacGia+ . $ TwoWay=�$ PropertyChanged=�6�     5[      $ Thể Loại��6�    6)   �� *THELOAI.TenTheLoai+ . $ TwoWay=�$ PropertyChanged=�6�     5\      $ Nhà Xuất Bản��6�    6)   �� *NHAXUATBAN.TenNhaXuatBan+ . $ TwoWay=�$ PropertyChanged=�6�     5]      $ 
Đơn Giá��6�    6)   �� *GiaBan+ . $ TwoWay=�$ PropertyChanged=�6�     5^      $ Số lượng tồn��6�    6)   �� *
SoLuongTon+ . $ TwoWay=�$ PropertyChanged=�6�   5`      5a      5b      5c      