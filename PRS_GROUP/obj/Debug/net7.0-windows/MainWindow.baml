   M S B A M L   `   `   `  ����D  @PRS_GROUP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PRS_GROUP.ViewModelsPRS_GROUP.ViewModels  5   	   %clr-namespace:PRS_GROUP	PRS_GROUP  5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137akOclr-namespace:MahApps.Metro.IconPacks;assembly=MahApps.Metro.IconPacks.MaterialMahApps.Metro.IconPacks 5   	       PRS_GROUP.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PRS_GROUP.ViewModels     5   	   *local1clr-namespace:PRS_GROUP     5   	   e	iconPacksOclr-namespace:MahApps.Metro.IconPacks;assembly=MahApps.Metro.IconPacks.Material     5   	   -   5          � Title$  
MainWindow��5
   	   $	��550��6   $	��800��6)    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      '   !PRS_GROUP.ViewModels.MainWindowVM  5   
   .��5      ��  �� CornerRadius$ 20��6   ��5   
   �� 5       �� ImageSource$ /Images/download.jpg��6   ._�5   
   �� $ 20��6   $��6q�5       J� Opacity$	 0.8Q�5      ��5      �� 5       	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5!      �  � Color$ #FFF176��6#    � Offset$ 0Q�63   � 5"      $ #0A34AE��6#   $	 0.5Q�63   � 5#      $ #FFF176��6#   $ 1Q�63   5%      ��5(      �� 5)      $		 0,0&�6&   $	
 1,1&�67   .��5*      � $ #81D4FA��6#   $ 0Q�63   � 5+      $ #0D47A1��6#   $
 0.75Q�63   5.      ._�51      �  � RowDefinitions 52      �� 53      $��40 �6$   �� 54      .+�58      �  � ColumnDefinitions 59      �� 5:      �� 5;      $��50 �6+   �� 5<      $��50 �6+   �� 5=      $��5 �6+   .+�5B      �� -   5         ��Name$ minimize��5B      
����  �$��-��5D      $��1��5E         Minimize_close#��[  5G      5I      �� 5K      -   5        $ close��5K      
����  �$��2��5M      #��[  5O      .��5P      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Close=�65   $��Center=�5Q   5   $��Center=�5R   5   
�������5S   5   5T      5U      �� 5W      $	��300��6   $��2��5X       �� Orientation$ Vertical=�5Y      $��0,25,0,0q�5Z      .+�5\      �� $��/Images/medicare logo.png��6   $	��300��5]      $��80��6(   �� 5_      $!��Patient Registration System��6    
����  �$��15(�5a       $��Medium"�5b       $��
Montserrat)�5c       $��Center=�5d       $��10q�5e       �� 5h      $����Effortlessly streamline your patient registration process with our secure login system, empowering you to efficiently manage and maintain comprehensive records in just a few clicks.��6    $��Italic$�5i       
�������$��10(�5k       $��Medium"�5l       $��
Montserrat)�5m       $
��Wrap=�5n        �� TextAlignment$ Center=�5o       $��0,15,0,0q�5p       �� 5s      $��Username��6    
�������$��15(�5u       $
��Bold"�5v       $��
Montserrat)�5w       $��0,35,0,0q�5x       �� 5z      $ 
Horizontal=�6!   .+�5{        $ Account=�65   $��Center=�5|   5   $��Center=�5}   5   
�������5~   5   �� 5      -   5         ��Name$ usename��5   "   $��13(�5�   "   $��Medium"�5�   "   
������ $��
Montserrat)�5�   "   
������� �� 
CaretBrush
 �����
�������$��0,0,0,3q�5�   "   $��28��5�   "   $	��280��5�   "   $��Center=�5�   "   $��5,0,0,0q�5�   "   ��5�   "   �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=�5�      �� 5�      $��Password��6    
�������$��15(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,40,0,0q�5�       �� 5�      $ 
Horizontal=�6!   .+�5�        $ FormTextboxPassword=�65   $��Center=�5�   5   $��Center=�5�   5   
�������5�   5   �� 5�      -   5        $	 pwb��5�   "   $��13(�5�   "   $��Medium"�5�   "   
������ $+��%ms-appx:///Assets/PassDot.ttf#PassDot)�5�   "   
�������
 �����
�������$��0,0,0,3q�5�   "   $��28��5�   "   $	��280��5�   "   $��Center=�5�   "   $��5,0,0,0q�5�   "   ��63   �� *
Password+5�      �� 5�      -   5        $ signup��5�      
���  ��$��Continue��5�        Loginbutton#��[ 5�      ��5�      �� *AccessCommand+$ PropertyChanged=�6f   5�      5�      5�      5�      5�      