   M S B A M L   `   `   `  ����F  BWpfAppAudio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfAppAudioWpfAppAudio  5   	       WpfAppAudio.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfAppAudio     5   	   -   5          � Title$  
MainWindow��5   	   $	��280��6   $	��500��6)    � WindowStartupLocation$ CenterScreen=�6L    � WindowState$ Normal=�6q    � 
ResizeMode$ NoResize=�6�   .��5
      � $	��280��6   $
��Auto��6   $
��Auto��5      $	��480��6    � ShowGridLines .  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��70* �6    � ColumnDefinitions 5   
   �� 5      $
��480* �6   .+�5   
   �� -   5         ��Name$	 Adv��5      $	��400��6   $	��200��6,   $��0��69   $��0��6I   $��Stretch=�6V   �� 5   
   $	��400��6   $��60��6$   $
��Auto��60   $��0��6=   $��1��6M    �� Orientation$ 
Horizontal=�6Z   $��Stretch=�6s   .+�5      �� -   5        $��
clickSound��5      $	��100��6'   $��30��63   $	��Top=�6X   .��6p   
Play Sound	 � Triggers	 5      :� 5      
 :� RoutedEvent$
 Button.Click��6#   [�5      �� 5      -   5        SoundPlayer1��5   0   5      5      �� 5      $	��   ��6   6%   �� 5       -   5        $	��100��5       $��30��6!   $
��Left=�6-   $	��Top=�6`   .��6x   Ringing Sound!	 5"      :� 5#      $
 Button.Click��6#   [�5$      �� 5%      -   5        SoundPlayer2��5%   0   5'      5)      5*      5+      5,      