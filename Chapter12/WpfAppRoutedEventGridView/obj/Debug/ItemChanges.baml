   M S B A M L   `   `   `  ����T  PWpfAppRoutedEventGridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WpfAppRoutedEventGridViewWpfAppRoutedEventGridView  5   	   +    %WpfAppRoutedEventGridView.ItemChanges   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:WpfAppRoutedEventGridView     5   	     � Title$  ItemChanges��5   	   $	��460��6   $��887.94��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGridChanges��5   &      AutoGenerateColumns .  $	��122��5      $
��Left=�6    $��	10,10,0,0q�5         RowDetailsVisibilityMode$ VisibleWhenSelected=�5      $	��Top=�5      $	��849��6+      CanUserAddRows .     CanUserDeleteRows .  
�������   RowBackground
 �����   Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6)      Header$ #��65   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5      �� *IsActivated+
 �� Mode$
 OneWay=�0  *System.Windows.Controls.DataGridTextColumn  5      $ 40 6%   $ Id��61   	 5      �� *
EmployeeId+$
 OneWay=�  5      $ 80 6%   $ 	FirstName��60   	 5      �� *	FirstName+$
 OneWay=�  5      $ 80 6%   $ LastName��60   	 5      �� *
LastName+$
 OneWay=�  5      $ DateOfBirth��6%   $	 100 6:   	 5      �� *DateOfBirth+$
 OneWay=� �� StringFormat$ {0:dd/MM/yyyy}��  5      $	 200 6%   $ Address��61   	 5      �� *	Address+$
 OneWay=�  5      $	 120 6%   $ Email��61   	 5      �� *Email+$
 OneWay=�  5       $ 90 6%   $ 	Telephone��60   	 5!      �� *	Telephone+$
 OneWay=�  5"      -   5        ComboBoxState��$ State��5$      $ 80 6%   	 5%      �� *	StateCode+$
 OneWay=� �� 
GroupStyle 5'      (  "System.Windows.Controls.GroupStyle  5(         ContainerStyle 5)      �� 5*       �� 
TargetType" ��6    .�5+      ��  �� Property � �� �� Value 5,   "   �� 5-   &    �� 
TargetType" ��66   .R�5.   *   9�  9� 
IsExpanded . ��5/   .   �� 50   2    �� Orientation$ 
Horizontal=�6=   .+�51   6   �� ��6@   �� *Name+�� 52   6   $��: ��6@   �� 53   6   ��6@   �� *	ItemCount+�� 54   6   $�� employee(s)��6@   55   3   .��57   .   �� 58   +   59   '   5;      5<      5?      5B      �� 5C   
   -   5         ��Name$ 
buttonSave��5C      $��Accept��6%   $
��Left=�66   $��
10,399,0,0q�6Q   $	��Top=�6e   $��74��6}    J� RenderTransformOrigin$ -0.25,0.475&�6�   6�   �� 5D   
   -   5        $ buttonCancel��5D      $��Cancel��6'   $
��Left=�68   $��
89,398,0,0q�6S   $	��Top=�6g   $��76��6   $��21��6�   6�     5E   
   -   5          Name$ dataGridChangesDelete��5G   !    .  $	��122��5F      $
��Left=�6   $��
10,137,0,0q�5G      $ VisibleWhenSelected=�5H      $	��Top=�5I      $	��849��6%    .   .  
�������
 ����� 5L        5M      $ 30 6)   $ #��65   	 5N      �� *IsActivated+$
 OneWay=�  5O      $ 40 6%   $ Id��61   	 5P      �� *
EmployeeId+$
 OneWay=�  5Q      $ 80 6%   $ 	FirstName��60   	 5R      �� *	FirstName+$
 OneWay=�  5S      $ 80 6%   $ LastName��60   	 5T      �� *
LastName+$
 OneWay=�  5U      $ DateOfBirth��6%   $	 100 6:   	 5V      �� *DateOfBirth+$
 OneWay=�$ {0:dd/MM/yyyy}��  5W      $	 200 6%   $ Address��61   	 5X      �� *	Address+$
 OneWay=�  5Y      $	 120 6%   $ Email��61   	 5Z      �� *Email+$
 OneWay=�  5[      $ 90 6%   $ 	Telephone��60   	 5\      �� *	Telephone+$
 OneWay=�  5]      -   5        ComboBoxState1��$ State��5_      $ 80 6%   	 5`      �� *	StateCode+$
 OneWay=� 5b        5c       5d      �� 5e      " ��6    .�5f      ��  � �� 5g   "   �� 5h   &   " ��66   .R�5i   *   9�  . ��5j   .   �� 5k   2   $ 
Horizontal=�6=   .+�5l   6   �� ��6@   �� *Name+�� 5m   6   $��: ��6@   �� 5n   6   ��6@   �� *	ItemCount+�� 5o   6   $�� employee(s)��6@   5p   3   .��5r   .   �� 5s   +   5t   '   5v      5w      5z      5}        5~   
   -   5        $ dataGridChangesNew��5�   !    .  $	��122��5      $
��Left=�6   $��
10,264,0,0q�5�      $ VisibleWhenSelected=�5�      $	��Top=�5�      $	��849��6%    .   .  
�������
 ����� 5�        5�      $ 30 6)   $ #��65   	 5�      �� *IsActivated+$
 OneWay=�  5�      $ 40 6%   $ Id��61   	 5�      �� *
EmployeeId+$
 OneWay=�  5�      $ 80 6%   $ 	FirstName��60   	 5�      �� *	FirstName+$
 OneWay=�  5�      $ 80 6%   $ LastName��60   	 5�      �� *
LastName+$
 OneWay=�  5�      $ DateOfBirth��6%   $	 100 6:   	 5�      �� *DateOfBirth+$
 OneWay=�$ {0:dd/MM/yyyy}��  5�      $	 200 6%   $ Address��61   	 5�      �� *	Address+$
 OneWay=�  5�      $	 120 6%   $ Email��61   	 5�      �� *Email+$
 OneWay=�  5�      $ 90 6%   $ 	Telephone��60   	 5�      �� *	Telephone+$
 OneWay=�  5�      -   5        ComboBoxState2��$ State��5�      $ 80 6%   	 5�      �� *	StateCode+$
 OneWay=� 5�        5�       5�      �� 5�      " ��6    .�5�      ��  � �� 5�   "   �� 5�   &   " ��66   .R�5�   *   9�  . ��5�   .   �� 5�   2   $ 
Horizontal=�6=   .+�5�   6   �� ��6@   �� *Name+�� 5�   6   $��: ��6@   �� 5�   6   ��6@   �� *	ItemCount+�� 5�   6   $�� employee(s)��6@   5�   3   .��5�   .   �� 5�   +   5�   '   5�      5�      5�      5�      5�      5�      