   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.Window3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Window3��5   	   $��465.532��6   $��809.235��6*   .��5	      �  � ShowGridLines .  � RowDefinitions 5
   
   �� 5      $��39 �6   �� 5      $��29 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   `�  `� 
Background
 �����$��30��6)   $��3��65   $��0��6I   $	��Top=�5      $	��Top=�5       `� Orientation$ 
Horizontal=�6/   .�5      c� -   5         c�Name$ toolBar��5      $
��Left=�6'   $	��Top=�6B   .@�5      �� .��5      �� $��Images\cut.png��6   $��20��64    � ToolTip$	 Cut��6?   5      �� 5      .��5      �� $��Images\copy.png��6   $��20��65   $
 Copy��6@   5      �� 5      .��5      �� $��Images\paste.png��6   $��20��66   $ Paste��6A   5      5       5!      R� 5"   
   -   5         R�Name$ treeViewCountry��5"      $	��150��5#      $
��Auto��6   $��0��5$      $��2��6#   $��2��5%      .@�5'      Q� $��United States��6   .@�5(      Q� $��New York��6   Q� 5)      $��Los Angeles��6   Q� 5*      $��Chicago��6   5+      Q� 5,      $��French��6   .@�5-      Q� $��Paris��6   Q� 5.      $��	Marseille��6   Q� 5/      $
��Lyon��6   Q� 50      $��Toulouse��6   51      Q� 52      $��United Kingdom��6   .@�53      Q� $��London��6   Q� 54      $��
Birmingham��6   Q� 55      $��	Cambridge��6   Q� 56      $��
Manchester��6   57      58      �� 59   
   -   5        $��textBlockTitle��5;      $��1��59      $��1��6%   $��3��62   $��23��5:      $
��Left=�6    $��12,6,0,0q�6;   $��Sale Orders��5;   *   $
��Bold"�5<      $��14(�6&   ]� 5=   
   $��1��6   $��2��6$   .+�5>      �� -   5        	 ��Name$	 listView��5>      $	��325��6)   $	��Top=�5?      $	��650��5@      $	��Top=�6#   
 �� View
 5B      �� 5C      .P�5D      �� $��Order No��6)    �� Width$ 80��6;    �� DisplayMemberBinding 6F   �� *	OrderNo+�� 5E      $��
Order Date��6)   $	 100��6=    6I   �� *	OrderDate+�� 5F      $��Client Name��6)   $	 150��6>    6J   �� *
ClientName+�� 5G      $��Address��6)   $	 200��6:    6F   �� *	Address+�� 5H      $��Amount��6)   $ 90��69    6D   �� *Amount+5I      5M      �� 5N       �� Orientation$ 
Horizontal=�6   $��Bottom=�62   $��36��6J   .+�5O      �� $��  ��6   �� 5P      -   5         ��Name$ 
buttonLoad��5P      $��60��6-   $��26��68   $��Display��6D   6V   �� 5Q      $��  ��6   �� 5R      -   5        $ buttonDetails��5R      $��60��60   $��26��6;   $��Details��6G   6Y   5S      5T      5U      5V      