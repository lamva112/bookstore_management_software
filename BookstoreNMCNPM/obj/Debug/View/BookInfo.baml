   M S B A M L   `   `   `  ����J  FBookstoreNMCNPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BookstoreNMCNPM.ViewBookstoreNMCNPM.View  5      #    BookstoreNMCNPM.View.BookInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:BookstoreNMCNPM.View     5      .��5      �   � RowDefinitions  5   
   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � $��0��6   $��0��6   .+�5      �� $��Center=�6   $��Center=�65   $
��Bold"�6P   $��16(�6b   Thể Loại6z   5      � 5   
   $��1��6   $��0��6   $��
10,10,10,5q�6,   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataTheLoai��5         AutoGenerateColumns .     CanUserDeleteRows . $��Center=�5   =   ��5   ,   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Mã��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *	MaTheLoai+ �� NotifyOnTargetUpdated . 	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�     5       $ Tên thể loại��6�      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�    6)   �� *
TenTheLoai+ . $	 TwoWay=�$
 PropertyChanged=�6�   4  .System.Windows.Controls.DataGridTemplateColumn  5!         CellTemplate 5"      �� 5#      .R�5$   "   �� -   5         *  &MaterialDesignFloatingActionMiniButton#��[  5$   )    � ToolTip$ Xóa thể loại��5%   )   $��25��6V   $��25��6b   .��5&   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ DeleteForever=�6>   $
��Auto��6S   $
��Auto��6a   5'   #   5(      5*      5,      5-      � 5.   
   $��0��6   $��2��6   .+�5/      �� $��Center=�6   $��Center=�65   $
��Bold"�6P   $��16(�6b   Nhà Xuất Bản6~   50      � 52   
   $��1��6   $��2��6   $��
10,10,10,5q�6,   .+�53        -   5        $ dataNhaXuatBan��53       .   . $��Center=�57   @   ��53   /   ��  58        59      $	 Mã��6�    6)   �� *MaNhaXuatBan+ . $	 TwoWay=�$
 PropertyChanged=�6�     5:      $ Tên nhà xuất bản��6�   $ * 6�    6)   �� *TenNhaXuatBan+ . $	 TwoWay=�$
 PropertyChanged=�6�     5;       5<      �� 5=      .R�5>   "   �� -   5        #��[  5>   )   $ Xóa nhà xuất bản��5?   )   $��25��6]   $��25��6i   .��5@   &     $ DeleteForever=�6>   $
��Auto��6S   $
��Auto��6a   5A   #   5B      5D      5F      5G      5H      5I      