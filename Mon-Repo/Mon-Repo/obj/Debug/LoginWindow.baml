   M S B A M L   `   `   `  ����C  ?Mon-Repo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Mon_RepoMon_Repo  5   	       Mon_Repo.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Mon_Repo     5   	   -   5          � Title$  LoginWindow��5   	   $	��300��6   $	��300��6*    � 
ResizeMode$ NoResize=�6S    � AllowsTransparency . 
������  � WindowStyle$
 None=�6�   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� 
���   �$��1q�6%    �� CornerRadius$ 25��69   $
��Left=�6K   $	��300��6f   $	��Top=�6s   $	��300��6�   $��2��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF7F6CFF��6#   	 � Offset$	 0.005Q�65   � 5      $ White��6#   $	 1Q�61   5      5      �� 5   
   $
��Left=�6   $��53��6+   $��
124,56,0,0q�67   $	��Top=�6K   $��54��6c   $��Resources/signin.png��6n   $��2��6�   �� 5   
   -   5        $
��Left=�5      $��22��6+   $��
117,10,0,0q�67   $	��Top=�6K   $��23��6c   $��Resources/admin.png��6n   
 � Cursor$

 Hand��6�   $��1��6�   $y�Hidden=�6�   �� 5   
   -   5        $��Bejelentkezés��5       �� 	IsDefault . $
��Left=�6:   $��25��6U   $��
54,187,0,0q�6a   $	��Top=�6u   $��86��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5!   
   -   5         ��Name$ OpenSignUpWindow��5!      $��Új felhasználó��6+   $
��Left=�6D   $��25��6_   $��
10,187,0,0q�6k   $	��Top=�6   $��86��6�   $��1��6�   �� 5"   
   -   5        $ 
ExitButton��5"      $��	Kilépés��6%   $
��Left=�67   $��107,217,0,0q�6R   $	��Top=�6g   $��87��6   $��23��6�   $��2��6�   $ 
0.497,0.53&�6�   5*      �� 5.   
   $
��Left=�6   $��27��6-   $��
85,114,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��130��6y   $��Felhasználónév��6�   $��Italic$�5/      
�������|�.  $��2��51   "   .��66   52      �� 53   
   -   5         ��Name$ UserTextBox��53      $
��Left=�6f   $��27��6�   $��
85,114,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��130��6�   |�. $��2��54   !   ��53   '   �� *
username+ �� UpdateSourceTrigger$ PropertyChanged=�.��54   5   ��55      �� 56       �� 
TargetType" ��6   .�57      ��  �� Property �@J�Opacity �� Value$ 1Q�58       �� Triggers 59      ]� 5:       ]� 
Conditions 5;      �� 5<   "    �� Property �@J�	IsFocused �� Value .  5=   *   �� 5>   "    � ��$  ��5?   *   ./�5A      ��  �@J�Opacity$ 0Q�5B   #   5C      5E      .��5F      5G      G� 5J   
   -   5         G�Name$ PasswordTextBox��5J      $
��Left=�6/   $��27��6J   $��
85,146,0,0q�6V   $	��Top=�6j   $	��130��6�    G� Password$ jelszó��6�   $��Italic$�5K      
�������|�. $��2��5M   f   5N      5Q      5R      