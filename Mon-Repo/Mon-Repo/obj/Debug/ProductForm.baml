   M S B A M L   `   `   `  ����C  ?Mon-Repo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Mon_RepoMon_Repo  5   	       Mon_Repo.ProductForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Mon_Repo     5   	     � Title$  Új termék feltöltése��5   	   $	��300��6&   $��367.5��63   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF7F6CFF��6    � Offset$ 0Q�61   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   �� -   5         ��Name$ ProductLabel��5      $��Termék megnevezése:��6&   $
��Left=�6D   $��27��6_   $��	10,66,0,0q�6k   $	��Top=�6~   $	��137��6�   �� 5   
   -   5        $ 
PriceLabel��5      $��Termék ára:��6$   $
��Left=�6:   $��27��6U   $��
10,103,0,0q�6a   $	��Top=�6u   $	��137��6�   �� 5   
   -   5         ��Name$ NameTextbox��5      $
��Left=�6'   $��32��6B   $��
147,61,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6�   $	��137��6�   ��6v   �� *Product.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ PriceTextbox��5      $
��Left=�6(   $��32��6C   $��147,135,0,0q�6O   $
 Wrap=�6d   $	��Top=�6�   $	��137��6�   ��6x   �� *Product.Price+$ PropertyChanged=�6�   �� 5   
   -   5        	 ��Name$	 SubmitButton��5      $��Termék feltöltése��6'   $
��Left=�6C   $��34��6^   $��147,183,0,0q�6j   $	��Top=�6   $	��116��6�   6�   �� 5   
   -   5        $ QuantityTextbox��5      $
��Left=�6+   $��32��6F   $��
147,98,0,0q�6R   $
 Wrap=�6f   $	��Top=�6�   $	��137��6�   ��6z   �� *Product.Quantity+$ PropertyChanged=�6�   �� 5   
   -   5        $ QuantityLabel��5      $��Termék mennyisége:��6'   $
��Left=�6D   $��27��6_   $��
10,135,0,0q�6k   $	��Top=�6   $	��137��6�   5      5      