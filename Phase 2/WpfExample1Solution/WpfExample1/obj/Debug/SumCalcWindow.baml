   M S B A M L   `   `   `  ����F  BWpfExample1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfExample1WpfExample1  5   	       WpfExample1.SumCalcWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfExample1     5   	     � Title$  SumCalcWindow��5   	   $	��450��6   $	��800��6,   .��5	      �� .+�5
      �� -   5         ��Name$ 
lblNumber1��5
      $��23��6"    �� Left$	 143��6.   $
��Wrap=�6@   $��Number 1��6T    �� TextAlignment$ Center=�6d   
 �� Top$ 64��6{   $��98��6�   $��Center=�6�   $	��Top=�6�   $
��Bold"�6�   �� 5      -   5        $ 
lblNumber2��5      $��23��6"   $	 143��6.   $
��Wrap=�6@   $��Number 2��6T   $ Center=�6d   $	 121��6{   $��98��6�   $��Center=�6�   $	��Top=�6�   $
��Bold"�6�   �� 5      -   5        $ lblSum��5      $��23��6   $	 143��6*   $
��Wrap=�6<   $	��Sum��6P   $ Center=�6[   $	 176��6r   $��98��6�   $��Center=�6�   $	��Top=�6�   $
��Bold"�6�   �� 5      -   5         ��Name$ 
txtNumber1��5      $��23��6    $	 282��6,    �� TextWrapping$
 Wrap=�6>   $ 62��6R   $	��133��6b   $��Center=�6n   $	��Top=�6�   �� 5      -   5        $ 
txtNumber2��5      $��23��6    $	 282��6,   $
 Wrap=�6>   $	 119��6R   $	��133��6c   $��Center=�6o   $	��Top=�6�   �� 5      -   5        $ txtSum��5      $��23��6   $	 282��6(   $
 Wrap=�6:   $	 174��6N   $	��133��6_   $��Center=�6k   $	��Top=�6�   {�.  6�   �� 5      -   5         ��Name$ 
btnFindSum��5      $��Find Sum��6   $��34��62   $	 282��6>   $	 241��6P   $��88��6a   $
��Bold"�6l   6~   5      5      