   M S B A M L   `   `   `  ����T  PWpfAppRoutedEventGridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WpfAppRoutedEventGridViewWpfAppRoutedEventGridView  5   	   *    $WpfAppRoutedEventGridView.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:WpfAppRoutedEventGridView     5   	   -   5          � Title$  
MainWindow��5   	   $��549.497��6   $��887.94��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��gridViewData��5         AutoGenerateColumns .  $	��431��5      $
��Left=�6   $��	21,37,0,0q�5         RowDetailsVisibilityMode$ VisibleWhenSelected=�5      $	��Top=�5      $	��849��6%   
�������   RowBackground
 �����   CanUserAddRows .    CanUserDeleteRows .    Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6)      Header$ #��65   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5      �� *IsActivated+
 �� Mode$
 TwoWay=�0  *System.Windows.Controls.DataGridTextColumn  5      $ 40 6%   $ Id��61   	 5      �� *
EmployeeId+$
 OneWay=�  5      $ 80 6%   $ 	FirstName��60   	 5      �� *	FirstName+$
 TwoWay=�  5      $ 80 6%   $ LastName��60   	 5      �� *
LastName+$
 TwoWay=�4  .System.Windows.Controls.DataGridTemplateColumn  5      $ DateOfBirth��6)   $	 100 6>      CellTemplate 5      �� 5      .R�5       (  "System.Windows.Controls.DatePicker     SelectedDate 6)   ��  �� Path$ DateOfBirth�$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnExceptions . 5$      5&        5'      $	 120 6%   $ Address��61   	 5(      �� *	Address+$
 TwoWay=�  5)      $	 100 6%   $ Email��61   	 5*      �� *Email+$
 TwoWay=�  5+      $ 90 6%   $ 	Telephone��60   	 5,      �� *	Telephone+$
 TwoWay=�4	  .System.Windows.Controls.DataGridComboBoxColumn	  5-      -   5        ComboBoxState��$ State��5/      $ 70 6%    	  DisplayMemberPath$ 	StateName��50       	  SelectedValuePath$ 	StateCode��51       	  SelectedValueBinding 52      �� *	StateCode+$
 TwoWay=�  53      $ 50 6)    54      �� 55      .R�56      �� .��6&   Delete6.   57      59        5:      $ 60 6)    5;      �� 5<      .R�5=      �� .��6%   Notify6-   5>      5@       �� 
GroupStyle 5B      (
  "System.Windows.Controls.GroupStyle
  5C       
  ContainerStyle 5D      �� 5E       �� 
TargetType" ��6    .�5F      ��  �� Property � �� �� Value 5G   "   �� 5H   &    �� 
TargetType" ��66   .R�5I   *   9�  9� 
IsExpanded . ��5J   .   �� 5K   2    �� Orientation$ 
Horizontal=�6=   .+�5L   6   �� ��6@   �� *Name+�� 5M   6   $��: ��6@   �� 5N   6   ��6@   �� *	ItemCount+�� 5O   6   $�� employee(s)��6@   5P   3   .��5R   .   �� 5S   +   5T   '   5V      5W      5Z      5]      �� 5^   
   -   5         ��Name$ buttonDisplay��5^      $��Search��6(   $
��Left=�69   $��	535,5,0,0q�6T   $	��Top=�6g   $��93��6   $��25��6�    J� RenderTransformOrigin$ 	0.21,0.53&�6�   6�   �� 5_   
   $
��Left=�6   $��
302,10,0,0q�6/   $
��Wrap=�6C   $��
State Code��6W   $	��Top=�6i   $��22��6�   $��60��6�   �� 5`   
   -   5         ��Name$ comboBoxStates��5`      $
��Left=�5a   	   $��	367,6,0,0q�6$   $	��Top=�5b   	   $	��163��6!   $��24��6-    �� SelectedValuePath$ 	StateCode��5c       �� DisplayMemberPath$ 	StateName��5d      �� 5e   
   -   5          ��Name$  textBoxKeyword��5e      $
��Left=�6*   $��25��6E   $��86,7,0,0q�6Q   ! �� TextWrapping$
! Wrap=�6c   $�� ��6w   $	��Top=�6   $	��207��6�   �� 5f   
   $
��Left=�6   $��21,8,0,0q�6/   $
��Wrap=�6A   $��Keyword��6U   $	��Top=�6d   $��22��6|   $��60��6�   $ -4.283,1&�6�   �� 5g   
   -   5        $ 
buttonSave��5g      $
��Save��6%   $
��Left=�64   $��
21,477,0,0q�6O   $	��Top=�6c   $��89��6{   $��25��6�   6�   5h      5i      