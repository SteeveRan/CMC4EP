   M S B A M L   `   `   `  ����?  ;Ctrl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null) clr-namespace:Ctrl;assembly=CtrlCtrl  5   	   
 CMC4EP   CMC4EP.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1Ctrl clr-namespace:Ctrl;assembly=Ctrl     5   	   -   5          � Title$   ��5   	   $	��480��5   	   $	��700��5   	   $	��480��5	   	   $
��1000��5
   	    � WindowStyle$
 None=�5   	   $��0q�6    � AllowsTransparency . 
������  � 
ResizeMode$ CanResizeWithGrip=�5   ;    � WindowStartupLocation$ CenterScreen=�6Z    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ MainDictionary.xaml?�6%   %    5      .��5      � .+�5   
   �� $��0,0,0,0q�6      	Tab_style#��[  6&   .@�5      ��   Chat_TabItem_style#���  6   .��5      �   c_Tab_backround#��[ 6   .+�5      �� $��10,32,10,10q�6!     Chat_tab#��[ 66   .@�5      �� $��Global��6"     
GlobalChat#��[ 62   .��5      �   chat_Tab_backround2#��[ 6#   5      �� 5      $��Player 1��6"     
PlayerChat#��[ 64   .��5      � #��[ 6#   5       5!      5"      5#      �� 5%        Friends_TabItem_style#���  6   .��5&      � #��[ 6    � RowDefinitions 5'      �� 5(      $��40 �6(   �� 5)      .+�5+         Ctrl.FriendsList  -   5        $��
FriendList��5+   '   $��1��6:   $��10,10,10,10q�6G   5,      5-      �� 5/        Search_TabItem_style#���  6   .��50      � #��[ 6    51      �� 52      $��40 �6(   �� 53      .+�56      � $��1��6   	 � ColumnDefinitions	 57      �� 58      $	��295 �6/   �� 59      $��* �6/   .+�5;         Ctrl.Search_list  -   5        $��P_list��5;   +   $��0��69   $��0��6F   $
��Left=�6V   $��
10,10,0,10q�6q   $	��245��6�   6�   � 5<      $��1��6   5>         Ctrl.UserInform  5?      -   5        $��UInform��5?   *   $��1��69   $��	10,10,0,0q�6I   5@         Ctrl.Search_box  5B      $��0��6&   $��0��63   $
��Left=�6C   $��32��6^   $��10,8,0,0q�6j   $	��Top=�6|   $	��266��6�      Ctrl.Filter_popup  5C      $
��Left=�6(   $��	285,8,0,0q�6C   $	��Top=�6V   5D      5E      �� 5G       	 Map_TabItem_style#��[	 6   5I      �� 5K       
 Options_TabItem_style#��� 
 6   .��5L      � #��[ 6   5M      5N         Ctrl.Exit_button  5O   
   $��0��6   $��0,5,5,0q�6(   $	��Top=�69   $��Right=�6Q   5Q      5R      