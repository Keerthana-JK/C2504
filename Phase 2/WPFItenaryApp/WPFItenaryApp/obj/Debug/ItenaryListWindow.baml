   M S B A M L   `   `   `  ����H  DWPFItenaryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFItenaryAppWPFItenaryApp  5   	   %    WPFItenaryApp.ItenaryListWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFItenaryApp     5   	   -   5          � Title$  Itenary App��5   	   $	��450��6   $	��800��6*   .��5	      �� .+�5
      �� -   5         ��Name$ btnNew��5
      $��New Itenary��6   $
��Left=�61   $��36��6L   $��	42,84,0,0q�6X   $	��Top=�6k   $	��143��6�   $��16(�6�   6�   �� 5      -   5         ��Name$ lblListItenary��5   
   $��List Itenary��6"   $��Center=�69   $��88��6V   $	��Top=�6b   $	��312��6z   $��48(�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ datagrid��5      
�������   
IsReadOnly .    SelectionMode$ Single=�5   s      AreRowDetailsFrozen . $��Center=�5      $	��Top=�6%   $	��210��5      $��	0,144,0,0q�6   $	��780��6'      AutoGenerateColumns .  ��5      �� *	Itenaries+ �� SelectedItem 6*   �� *SelectedItenary+	 �� Mode$	 TwoWay=�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID+  5      $
 Time��6    6'   �� *Time+  5      $ Itenary��6    6*   �� *ItenaryName+  5      $ Description��6    6.   �� *Description+  5      $ Price��6    6(   �� *Price+5      �� 5      -   5        $ btnEdit��5      $
��Edit��6   $
��Left=�6+   $��34��6F   $��
54,372,0,0q�6R   $	��Top=�6f   $��85��6~   $��16(�6�   6�   �� 5      -   5        $ 	btnDelete��5      $��Delete��6   $
��Left=�6/   $��34��6J   $��202,372,0,0q�6V   $	��Top=�6k   $��84��6�   $��16(�6�   5      5      