   M S B A M L   `   `   `  ����H  DWPFItenaryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFItenaryAppWPFItenaryApp  5   	   $    WPFItenaryApp.NewItenaryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFItenaryApp     5   	   -   5          � Title$  New Iternary Window��5   	   $	��450��6%   $	��800��62   .��5	      �� $	��300��6   $	��378��6   
�������$��Center=�6;   $��Center=�6X   .+�5
      �� $
��Wrap=�6   $��ID��6"   
 �� Top$ 9��6,   $
��Left=�6;   $��Center=�6V    �� Left$ 7��6q   �� 5      -   5         ��Name$ txtID��5      $	 158��6;    �� TextWrapping$
 Wrap=�6N   $ 6��6c   $	��120��6r   $
��Left=�6~   $��Center=�6�    �� 
IsReadOnly . ��6   �� *NewItenary.ID+6�   �� 5      $ 10��6   $
��Wrap=�6    $��Itenary��64   $ 69��6C   $
��Left=�6S   $��Center=�6n   �� 5      -   5        $ 
txtItenary��5      $	 160��6    $
 Wrap=�62   $ 66��6n   $	��120��6~   $
��Left=�6�   $	��Top=�6�   ��6F   �� *NewItenary.ItenaryName+6�   �� 5      $ 10��6   $
��Wrap=�6   $	 127��64   $
��Left=�6E   $��Center=�6`   $��About��6{   �� 5      -   5        $ txtAbout��5      $	 160��6   $
 Wrap=�60   $	 124��6l   $	��125��6}   $��Center=�6�   $	��Top=�6�   $��65��6�   ��6D   �� *NewItenary.Description+6�   �� 5      $ 13��6   $
��Wrap=�6   $��Price��63   $	 229��6@   $
��Left=�6Q   $��Center=�6l   �� 5      -   5        $ txtPrice��5      $	 160��6   $
 Wrap=�60   $	 226��6f   $	��120��6w   $��Center=�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.417,3.621&�6�   ��6D   �� *NewItenary.Price+6�   �� 5      -   5         ��Name$ 	btnCreate��5      $��Create Itenary��6@   $	 274��6Y   $��Center=�6j   $	��Top=�6�   $	��160��6�   ��6   �� *CreateCommand+6�   �� 5      $
��Wrap=�6   $
��Time��6"   $ 37��6.   $
��Left=�6>   $��Center=�6Y   $ 7��6t   �� 5      -   5        $ txtTime��5      $	 158��6   $
 Wrap=�6/   $ 34��6d   $	��120��6t   $��Center=�6�   $	��Top=�6�   ��6C   �� *NewItenary.Time+6�   5      5      