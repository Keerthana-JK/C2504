   M S B A M L   `   `   `  ����H  DWpfCounterApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfCounterAppWpfCounterApp  5   	       WpfCounterApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfCounterApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
      �� -   5         ��Name$ 	txtNumber��5
       �� TextAlignment$ Center=�6     �� TextWrapping$
 Wrap=�68   $	��120��6p    �� Left$	 297��6|   
 �� Top$	 113��6�   $��18(�6�    �� 
IsReadOnly . {�.  $
��Left=�6�   $��Center=�6�   ��6L   �� *NewCounter.Number+6�   �� 5      -   5         ��Name$ btnPlus��5      $��+��6>   $	 222��6J   $	 197��6\   $��18(�6m   $
��Left=�6{   $��Center=�6�   $��63��6�   ��6   �� *PlusCommand+6�   �� 5      -   5        $ btnMinus��5      $��-��6A   $	 471��6M   $	 197��6_   $��18(�6p   $
��Left=�6~   $��Center=�6�   $��51��6�   ��6   �� *MinusCommand+6�   5      5      