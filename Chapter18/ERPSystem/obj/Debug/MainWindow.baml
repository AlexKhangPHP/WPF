   M S B A M L   `   `   `  ����D  @ERPSystem, Version=5.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ERPSystem	ERPSystem  5   	       ERPSystem.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ERPSystem     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5       � Title$ 
MainWindow��5   	   $	��555��6   $	��950��6)    � 	Resources 5
         ERPSystem.ExportCommand 
  Export��%   &	          5   
   6   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Save��5      5         5   
   -   5        $ ApplicationCommands.Open��5      5         5   
   -   5        $  ApplicationCommands.Delete��5      5   "     5   
   -   5        $ ApplicationCommands.Find��5      5         5   
   -   5        $ ApplicationCommands.Print��5      5   !   .��5      � .+�5   
   ]� .+�5      o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ 	MenuMedia��5   I   $��Media��6   6I   m� 5      -   5        $ MenuDocument��5   O   $��Document��6   6O   5       5!      5"      �� 5#   
   -	   5         ��Name$ listViewData��5$      $	��910��5%      $��10,156,22,47q�6    �� View 5'      �� 5(      .P�5)      �� $��Id��6%    �� Width$ 30��61   	 �� DisplayMemberBinding	 6<   �� *
EmployeeId+�� 5*      $��	FirstName��6%   $ 80��68   	 6C   �� *	FirstName+�� 5+      $��LastName��6%   $ 80��67   	 6B   �� *
LastName+�� 5,      $��D.O.B��6%   $ 80��64   	 6?   �� *DateOfBirth+
 �� StringFormat$
 {0:dd/MM/yyyy}���� 5-      $��Address��6%   $	 150��66   	 6B   �� *	Address+�� 5.      $��	Telephone��6%   $ 85��68   	 6C   �� *	Telephone+�� 5/      $��	Cellphone��6%   $ 85��68   	 6C   �� *	Cellphone+�� 50      $��State��6%   $ 40��64   	 6?   �� *	StateCode+�� 51      $��Email��6%   $	 120��64   	 6@   �� *Email+�� 52      $��	Activated��6%   $ 65��68   	 6C   �� *IsActivated+�� 53      $��#��6%   $ 65��60    �� CellTemplate 54      �� 55      .R�56   "   ��  ��Name$ DeleteButton��6)   $��Delete��6?   $��Delete��57   $   $��50��66   $��22��6A   $��Center=�58   $   59      5;      5<       � ContextMenu 5@      �� 5A      .@�5B      m� -
   5        $ MenuEdit��5B   =   $
��Edit��6    m� Command$
 Open��6-   6=   m� 5C      -   5        $ 
MenuDelete��5C   @   $��Delete��6   $ Delete��6/   6@   5E      5G      �� 5H   
   -   5        $ buttonDisplay��5H      $
��Find��6(   $��Display��67   $
��Left=�6I   $��
10,482,0,0q�6d   $	��Top=�6x   $��75��6�   $��25��6�   �� 5I   
   $
��Left=�6   $��	10,27,0,0q�6/   $
��Wrap=�6B   $��
First Name��6V   $	��Top=�6h   $��22��6�   $��97��6�   �� 5J   
   $
��Left=�6   $��
221,27,0,0q�6/   $
��Wrap=�6C   $��	Last Name��6W   $	��Top=�6h   $��22��6�   $��68��6�   �� 5K   
   $
��Left=�6   $��
444,30,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��22��6o   $��97��6{   �� 5L      $�Date of Birth��6   6*   �� 5M   
   $
��Left=�6   $��	10,58,0,0q�6/   $
��Wrap=�6B   $��Address��6V   $	��Top=�6e   $��22��6}   $��97��6�   �� 5N   
   $
��Left=�6   $��
444,61,0,0q�6/   $
��Wrap=�6C   $��	Telephone��6W   $	��Top=�6h   $��22��6�   $��97��6�   �� 5O   
   $
��Left=�6   $��
669,64,0,0q�6/   $
��Wrap=�6C   $��	Cellphone��6W   $	��Top=�6h   $��22��6�   $��59��6�   �� 5P   
   $
��Left=�6   $��	10,90,0,0q�6/   $
��Wrap=�6B   $��Email��6V   $	��Top=�6c   $��22��6{   $��97��6�   �� 5Q   
   -   5         ��Name$ textBoxFirstName��5Q      $
��Left=�6,   $��23��5R      $��	82,25,0,0q�6    �� TextWrapping$
 Wrap=�5S      $�� ��6&    �� 	MaxLength$ 50��5T      $	��Top=�5U      $	��134��6*   �� 5V   
   -   5        $ textBoxLastName��5V      $
��Left=�6+   $��23��5W      $��
294,25,0,0q�6   $
 Wrap=�5X      $�� ��6!   $ 50��5Y      $	��Top=�5Z      $	��134��6%   �� 5[   
   -   5        $ textBoxAddress��5[      $
��Left=�6*   $��23��5\      $��	82,58,0,0q�6   $
 Wrap=�5]      $�� ��6!   $	 150��5^      $	��Top=�5_      $	��346��6%   �� 5`   
   -   5        $ textBoxTelephone��5`      $
��Left=�6,   $��23��5a      $��
526,61,0,0q�6   $
 Wrap=�5b      $�� ��6!   $ 12��5c      $	��Top=�5d      $	��120��6%   �� 5e   
   -   5        $ textBoxCellphone��5e      $
��Left=�6,   $��23��5f      $��
733,63,0,0q�6   $
 Wrap=�5g      $�� ��6!   $ 12��5h      $	��Top=�5i      $	��122��6%   �� 5j   
   -   5        $ textBoxEmail��5j      $
��Left=�6(   $��23��5k      $��	82,89,0,0q�6   $
 Wrap=�5l      $�� ��6!   $	 100��5m      $	��Top=�5n      $	��346��6%   (  "System.Windows.Controls.DatePicker  5o   
   -   5          Name$ DateOfBirth��5o      $
��Left=�6*   $��
526,27,0,0q�6E   $	��Top=�6Y   $	��120��6q   �� 5p   
   -   5        $ 
buttonSave��5p      $
��Save��6&   $
��Save��65   $
��Left=�6D   $��174,121,0,0q�6_   $	��Top=�6t   $��90��6�   $��25��6�   �� 5q   
   -   5        $ 	buttonAdd��5q      $��Add New��6$   $
��Left=�66   $��
83,121,0,0q�6Q   $	��Top=�6e   $��86��6}   $��25��6�    J� RenderTransformOrigin$ -0.337,0.717&�6�   6�   �� 5s   
   -   5        $ buttonPrint��5s      $��Print��5t      $��Print��5v      $
��Left=�6   $��273,482,0,0q�5w      $	��Top=�6"   $��76��5x      $��25��6   ��5u      ��  �� ElementName$ listViewData�� �� Path$ .�5x      �� 5y   
   -   5        $ buttonExport��5y      #��[  5z      $��Export��5|      $
��Left=�6   $��361,482,0,0q�5}      $	��Top=�6"   $��76��5~      $��25��6   ��5{      �� $ listViewData��$ .�5~      �� 5   
   -   5        $ buttonClose��5      $��Close��5�      $
��Left=�6!   $��845,482,0,0q�5�      $	��Top=�6&   $��76��5�      $��25��6   �� 5�   
   -   5        $ buttonDelete��5�      $��Delete��5�      $��Delete��5�      $
��Left=�5�      $��189,482,0,0q�5�      $	��Top=�5�      $��75��5�      $��25��6   �� 5�   
   -   5        $ 
buttonEdit��5�      $
��Open��5�      $
��Edit��5�      $
��Left=�5�      $��
99,482,0,0q�6,   $	��Top=�5�      $��75��6)   $��25��64   �� 5�   
   -   5         ��Name$ labelId��5�      $y�Visible=�6!   $�� ��66   $
��Left=�6A   $��
10,125,0,0q�6\   $	��Top=�6p   $ 1.932,0.734&�6�   �� 5�   
   $
��Left=�6   $��
444,90,0,0q�6/   $
��Wrap=�6C   $��	Stat Code��6W   $	��Top=�6h   $��22��6�   $��97��6�   �� 5�   
   -   5         ��Name$ comboBoxStates��5�      $
��Left=�5�   	   $��
526,90,0,0q�6$   $	��Top=�5�   	   $	��120��6!   $��24��6-    �� SelectedValuePath$ 	StateCode��5�       �� DisplayMemberPath$ 	StateName��5�      5�      5�      