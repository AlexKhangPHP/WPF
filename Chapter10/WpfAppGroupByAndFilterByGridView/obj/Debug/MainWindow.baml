   M S B A M L   `   `   `  ����[  WWpfAppGroupByAndFilterByGridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:WpfAppGroupByAndFilterByGridView WpfAppGroupByAndFilterByGridView  5   	   1    +WpfAppGroupByAndFilterByGridView.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:WpfAppGroupByAndFilterByGridView     5   	   -   5          � Title$  
MainWindow��5   	   $��549.497��6   $��887.94��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��gridViewData��5   &      AutoGenerateColumns .  $	��471��5      $
��Left=�6    $��	21,37,0,0q�5         RowDetailsVisibilityMode$ VisibleWhenSelected=�5      $	��Top=�5      $	��849��6+      Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6)      Header$ #��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *IsActivated+ �� Mode$ TwoWay=�0  *System.Windows.Controls.DataGridTextColumn  5      $ 40 6%   $ Id��61    5      �� *
EmployeeId+$ OneWay=�  5      $ 80 6%   $ 	FirstName��60    5      �� *	FirstName+$ OneWay=�  5      $ 80 6%   $ LastName��60    5      �� *
LastName+$ OneWay=�  5      $ 80 6%   $ DateOfBirth��60    5      �� *DateOfBirth+$ OneWay=� �� StringFormat$ {0:yyyy}��  5      $	 270 6%   $ Address��61    5      �� *	Address+$ OneWay=�5  /System.Windows.Controls.DataGridHyperlinkColumn  5      $	 150 6*   $ Email��66    5      �� *Email+$ OneWay=�  5       $ 90 6%   $ 	Telephone��60    5!      �� *	Telephone+$ OneWay=�	 �� 
GroupStyle	 5#      (  "System.Windows.Controls.GroupStyle  5$      
   ContainerStyle
 5%      �� 5&       �� 
TargetType" ��6    .�5'      ��  �� Property � �� �� Value 5(   "   �� 5)   &    �� 
TargetType" ��66   .R�5*   *   9�  9� 
IsExpanded . ��5+   .   �� 5,   2    �� Orientation$ 
Horizontal=�6=   .+�5-   6   �� ��6@   �� *Name+�� 5.   6   $��: ��6@   �� 5/   6   ��6@   �� *	ItemCount+�� 50   6   $�� employee(s)��6@   51   3   .��53   .   �� 54   +   55   '   57      58      5;      5>      �� 5?   
   -   5         ��Name$ buttonDisplay��5?      $��Search��6(   $
��Left=�69   $��	535,5,0,0q�6T   $	��Top=�6g   $��93��6   $��25��6�    J� RenderTransformOrigin$ 	0.21,0.53&�6�   6�   �� 5@   
   $
��Left=�6   $��
302,10,0,0q�6/   $
��Wrap=�6C   $��
State Code��6W   $	��Top=�6i   $��22��6�   $��60��6�   �� 5A   
   -   5         ��Name$ comboBoxStates��5A      $
��Left=�5B   	   $��	367,6,0,0q�6$   $	��Top=�5C   	   $	��163��6!   $��24��6-    �� SelectedValuePath$ 	StateCode��5D       �� DisplayMemberPath$ 	StateName��5E      �� 5F   
   -   5         ��Name$ textBoxKeyword��5F      $
��Left=�6*   $��25��6E   $��86,7,0,0q�6Q    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��207��6�   �� 5G   
   $
��Left=�6   $��21,8,0,0q�6/   $
��Wrap=�6A   $��Keyword��6U   $	��Top=�6d   $��22��6|   $��60��6�   $ -4.283,1&�6�   5H      5I      