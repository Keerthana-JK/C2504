   M S B A M L   `   `   `  ����H  DWPFItenaryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFItenaryAppWPFItenaryApp  5   	   %    WPFItenaryApp.EditItenaryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFItenaryApp     5   	   -   5          � Title$  Edit Itenary Window��5   	   $	��450��6%   $	��800��62   .��5	      �� $	��300��6   $	��378��6   
�������$��Center=�6;   $��Center=�6X   .+�5
      �� -   5         ��Name$ lblID��5
      $��24��6    �� Left$ 25��6)   $
��Wrap=�6:   $��ID��6N   
 �� Top$ 20��6X   $��83��6h   $��Center=�6s   $	��Top=�6�    J� RenderTransformOrigin$ -0.527,1.051&�6�   �� 5      -   5         ��Name$ txtID��5      $��24��6   $	 134��6'    �� TextWrapping$
 Wrap=�69   $ 20��6q   $��99��6�   $��Center=�6�   $	��Top=�6�   ��6M   �� *SelectedItenary.ID+6�   �� 5      -   5        $ lblTime��5      $��24��6   $ 25��6+   $
��Wrap=�6<   $
��Time��6P   $ 71��6\   $��83��6l   $��Center=�6w   $	��Top=�6�   $ -0.527,1.051&�6�   �� 5      -   5        $ txtTime��5      $��24��6   $	 134��6)   $
 Wrap=�6;   $ 71��6u   $��99��6�   $��Center=�6�   $	��Top=�6�   ��6O   �� *SelectedItenary.Time+6�   �� 5      -   5        $ 
lblItenary��5      $��24��6"   $ 25��6.   $
��Wrap=�6?   $��Itenary��6S   $	 122��6b   $��83��6s   $ -0.527,1.051&�6~   $��Center=�6�   $	��Top=�6�   �� 5      -   5        $ 
txtItenary��5      $��24��6    $	 134��6,   $
 Wrap=�6>   $	 122��6{   $��99��6�   $��Center=�6�   $	��Top=�6�   ��6R   �� *SelectedItenary.Itenary+6�   �� 5      -   5        $ lblDescription��5      $��24��6&   $ 25��62   $
��Wrap=�6C   $��Description��6W   $	 175��6j   $��83��6{   $ -0.527,1.051&�6�   $��Center=�6�   $	��Top=�6�   �� 5      -	   5        $ txtDescription��5      $��52��6$   $	 134��60   $
 Wrap=�6B   $	 175��6�   $��99��6�   $��Center=�6�   $	��Top=�6�   ��6V   �� *SelectedItenary.Description+6�   �� 5      -
   5        $ lblPrice��5      $��24��6    $ 25��6,   $
��Wrap=�6=   $��Price��6Q   $	 265��6^   $��83��6o   $ -0.527,1.051&�6z   $��Center=�6�   $	��Top=�6�   �� 5      -   5        $ txtPrice��5      $��24��6   $	 134��6*   $
 Wrap=�6<   $	 265��6w   $��99��6�   $��Center=�6�   $	��Top=�6�   ��6P   �� *SelectedItenary.Price+6�   �� 5      -   5         ��Name$ 	btnCreate��5      $��Update��6@   $��37��6Q   $ 14��6]   $	 319��6n   $	��166��6   $
��Left=�6�   $��Center=�6�   ��6   �� *UpdateCommand+6�   5      5      