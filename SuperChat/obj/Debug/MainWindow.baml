   M S B A M L   `   `   `  ����D  @SuperChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SuperChat	SuperChat  5   	   9!clr-namespace:SuperChat.ViewModelSuperChat.ViewModel  5   	       SuperChat.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SuperChat     5   	   0vm!clr-namespace:SuperChat.ViewModel     5   	   -   5          �Name$  DashBoardWindow��5   	    � Title$ 
MainWindow��5	   	   $	��580��5
   	   $	��930��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      -  'SuperChat.ViewModel.NavigationViweModel  5   
   .��5      � .+�5   
   �� ���#ECF0F1 �� CornerRadius$ 10��5      �� 5!   
   ���#5C5C5C$	��Top=�5"      $
��Left=�5#      $ 
10,0,100,0��5$      $��80��5%      $	��850��5&      ._�5(      �� $��広報情報��6      HeaderStyle#��[  5)      5+      �� 5/   
   ���#5C5C5C$��Bottom=�50      $��Right=�51      $ 
100,0,10,0��52      $��80��53      $	��850��54      56      �� 5:   
   ���#303030���#FFFFFF$��0,5,0,5q�5<      $	��480��5=      $��0,10,0,0q�5>      $ 25��5?      � 5C   
    � ColumnDefinitions 5E      �� 5G      $��25 �6#   �� 5H      $	��180 �6#   �� 5I      $��40 �6#   �� 5J      $	��660 �6#   �� 5K      $��25 �6#   	 � RowDefinitions	 5O      �� 5Q      $��0 �6    �� 5R      $��80 �6    �� 5S      $��55 �6    �� 5T      $	��370 �6    �� 5U      $��0 �6    .+�5[      � $��2��6   $��1��5\      .+�5^      �� -   5        
 ��Name$
 	SearchBox��5^        SearchBoxStyle#��[ 5`      ��5_      �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�5`      �� 5b      $��Search��6     SearchTextStyle#��[ 5c      5e      � 5i      $��3��6   $��1��5j      $��0,10,0,0q�5k      .+�5m      �� ��6   �� *SourceCollection+��5n      �� 5o      .R�5p      �� .+�5q   "   	�   MenuButtonStyle#��[ 5u   .    	� 	GroupName$ 	MenuGroup��5v   .   ��5q   .   �� *
MenuName+
 � Tag 5r   .   �� *	MenuImage+��5s   .   �� *
MenuName+��5t   .   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$ DataContext.MenuCommand�5v   .   5w      5x      5z      5|      � 5�      $��2��6   $��3��5�      $��2��5�      
������ .+�5�      �� -   5         ��Name$ Pages��5�   !   ��5�   !   �� *SelectedViewModel+5�      5�      �� 5�   
   -   5        $��50��5�      $��50��5�      $��Right=�5�      $	��Top=�5�      $��0,5,20,0q�5�        CloseBtn_Style#��[ 5�      69   5�      5�      