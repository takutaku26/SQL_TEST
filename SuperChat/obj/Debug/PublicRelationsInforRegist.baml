   M S B A M L   `   `   `  ����D  @SuperChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SuperChat	SuperChat  5   	   *    $SuperChat.PublicRelationsInforRegist   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SuperChat     5   	     � Title$  追加��5   	   $	��300��6   $	��300��6!   $��1q�5	   	    � WindowStartupLocation$ CenterOwner=�5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��5 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��5 �6    � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��5 �6   .+�5%   
   � $��1��6   $��1��5&      .+�5(      �� $��	名前：��6   5*      � 5,   
   $��1��6   $��2��5-      $��4��5.      .+�50      �� -   5         ��Name$ txt_name��50      $
��Left=�6(   $	��Top=�6C   $	��100��6[   52      � 54   
   $��2��6   $��1��55      .+�57      �� $��	性別：��6   59      � 5;   
   $��2��6   $��2��5<      $��4��5=      .+�5?      �� -   5         ��Name$ 
cmb_gender��5?      $
��Left=�6+   $	��Top=�6F   $��50��6^   .@�5@      �� $	��男��6   $
��Left=�6+   $��50��6F   �� 5A      $	��女��6   $
��Left=�6+   $��50��6F   5B      5D      � 5F   
   $��3��6   $��1��5G      .+�5I      �� $��	年齢：��6   5K      � 5M   
   $��3��6   $��2��5N      $��4��5O      .+�5Q      �� -   5        $ txt_age��5Q      $
��Left=�6'   $	��Top=�6B   $��50��6Z    �� IsInputMethodEnabled .  5T      5V      � 5X   
   $��4��6   $��1��5Y      .+�5[      �� $��コース：��6   5]      � 5_   
   $��4��6   $��2��5`      $��4��5a      .+�5c      �� -   5        $ 
txt_course��5c      $
��Left=�6*   $	��Top=�6E   $	��200��6]   5e      � 5g   
   $��5��6   $��2��5h      .+�5j      �� -   5         ��Name$ 
btn_cansel��5j      $��キャンセル��6)   $��Center=�69   $	��Top=�6V   $��55��6n   6y   5l      � 5n   
   $��5��6   $��4��5o      .+�5q      �� -   5        $ btn_add��5q      $��追加��6&   $��Center=�63   $	��Top=�6P   $��55��6h   6s   5s      5u      5v      