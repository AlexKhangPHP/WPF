   M S B A M L   `   `   `  ����[  WWpfAppGroupByAndFilterByListView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:WpfAppGroupByAndFilterByListView WpfAppGroupByAndFilterByListView  5   	   1    +WpfAppGroupByAndFilterByListView.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:WpfAppGroupByAndFilterByListView     5   	   -   5          � Title$  
MainWindow��5   	   $��549.497��6   $��887.94��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ listViewData��5      $��10,41,21,10q�6$    �� ItemBindingGroup 5
      �� *	StateCode+ �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$ 40��61    �� DisplayMemberBinding 6<   �� *
EmployeeId+�� 5      $��	FirstName��6%   $ 80��68    6C   �� *	FirstName+�� 5      $��LastName��6%   $ 80��67    6B   �� *
LastName+�� 5      $��D.O.B��6%   $ 80��64    6?   �� *DateOfBirth+ �� StringFormat$ {0:dd/MM/yyyy}���� 5      $��Address��6%   $	 280��66    6B   �� *	Address+�� 5      $��Email��6%   $	 150��64    6@   �� *Email+�� 5      $��	Telephone��6%   $	 100��68    6D   �� *	Telephone+5       �� 
GroupStyle 5      (  "System.Windows.Controls.GroupStyle  5         ContainerStyle 5      �� 5      	 �� 
TargetType"	 ��6    .�5      �� 
 �� Property
 � �� �� Value 5   "   �� 5   &   .R�5   *   9�  9� 
IsExpanded . ��5    .   �� 5!   2    �� Orientation$ 
Horizontal=�6=   .+�5"   6   �� ��6@   ��  �� Path$
 Name��� 5#   6   $��: ��6@   �� 5$   6   ��6@   �� *	ItemCount+�� 5%   6   $�� employee(s)��6@   5&   3   .��5(   .   �� 5)   +   5*   '   5,      5-      50      53      �� 54   
   -   5         ��Name$ buttonDisplay��54      $��Search��6(   $
��Left=�69   $��	535,5,0,0q�6T   $	��Top=�6g   $��93��6   $��25��6�    J� RenderTransformOrigin$ 	0.21,0.53&�6�   6�   �� 55   
   $
��Left=�6   $��
302,10,0,0q�6/   $
��Wrap=�6C   $��
State Code��6W   $	��Top=�6i   $��22��6�   $��60��6�   �� 56   
   -   5         ��Name$ comboBoxStates��56      $
��Left=�57   	   $��	367,6,0,0q�6$   $	��Top=�58   	   $	��163��6!   $��24��6-    �� SelectedValuePath$ 	StateCode��59       �� DisplayMemberPath$ 	StateName��5:      �� 5;   
   -   5         ��Name$ textBoxKeyword��5;      $
��Left=�6*   $��25��6E   $��86,7,0,0q�6Q    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��207��6�   �� 5<   
   $
��Left=�6   $��21,8,0,0q�6/   $
��Wrap=�6A   $��Keyword��6U   $	��Top=�6d   $��22��6|   $��60��6�   $ -4.283,1&�6�   5=      5>      