   M S B A M L   `   `   `  ���� D  @ERPSystem, Version=5.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ERPSystem	ERPSystem      ERPSystem.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ERPSystem     -     � WindowStartupLocation$  CenterScreen=� � Title$ 
MainWindow��$	��555��$	��950�� � 	Resources    ERPSystem.ExportCommand 
  Export��%   &	           J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$ ApplicationCommands.Save��  -   $ ApplicationCommands.Open��  -   $  ApplicationCommands.Delete��  -   $ ApplicationCommands.Find��  -   $ ApplicationCommands.Print��.��� .+�]� .+�o� $	��Top=�.@�m� $
��File��.@�m� -    m�Name$ 	MenuMedia��$��Media��m� -   $ MenuDocument��$��Document���� -	    ��Name$ listViewData��$	��910��$��10,156,22,47q� �� View �� .P��� $��Id�� �� Width$ 30��	 �� DisplayMemberBinding	 �� *
EmployeeId+�� $��	FirstName��$ 80��	 �� *	FirstName+�� $��LastName��$ 80��	 �� *
LastName+�� $��D.O.B��$ 80��	 �� *DateOfBirth+
 �� StringFormat$
 {0:dd/MM/yyyy}���� $��Address��$	 150��	 �� *	Address+�� $��	Telephone��$ 85��	 �� *	Telephone+�� $��	Cellphone��$ 85��	 �� *	Cellphone+�� $��State��$ 40��	 �� *	StateCode+�� $��Email��$	 120��	 �� *Email+�� $��	Activated��$ 65��	 �� *IsActivated+�� $��#��$ 65�� �� CellTemplate �� .R���  ��Name$ DeleteButton��$��Delete��$��Delete��$��50��$��22��$��Center=� � ContextMenu �� .@�m� -
   $ MenuEdit��$
��Edit�� m� Command$
 Open��m� -   $ 
MenuDelete��$��Delete��$ Delete���� -   $ buttonDisplay��$
��Find��$��Display��$
��Left=�$��
10,482,0,0q�$	��Top=�$��75��$��25���� $
��Left=�$��	10,27,0,0q�$
��Wrap=�$��
First Name��$	��Top=�$��22��$��97���� $
��Left=�$��
221,27,0,0q�$
��Wrap=�$��	Last Name��$	��Top=�$��22��$��68���� $
��Left=�$��
444,30,0,0q�$
��Wrap=�$	��Top=�$��22��$��97���� $�Date of Birth���� $
��Left=�$��	10,58,0,0q�$
��Wrap=�$��Address��$	��Top=�$��22��$��97���� $
��Left=�$��
444,61,0,0q�$
��Wrap=�$��	Telephone��$	��Top=�$��22��$��97���� $
��Left=�$��
669,64,0,0q�$
��Wrap=�$��	Cellphone��$	��Top=�$��22��$��59���� $
��Left=�$��	10,90,0,0q�$
��Wrap=�$��Email��$	��Top=�$��22��$��97���� -    ��Name$ textBoxFirstName��$
��Left=�$��23��$��	82,25,0,0q� �� TextWrapping$
 Wrap=�$�� �� �� 	MaxLength$ 50��$	��Top=�$	��134���� -   $ textBoxLastName��$
��Left=�$��23��$��
294,25,0,0q�$
 Wrap=�$�� ��$ 50��$	��Top=�$	��134���� -   $ textBoxAddress��$
��Left=�$��23��$��	82,58,0,0q�$
 Wrap=�$�� ��$	 150��$	��Top=�$	��346���� -   $ textBoxTelephone��$
��Left=�$��23��$��
526,61,0,0q�$
 Wrap=�$�� ��$ 12��$	��Top=�$	��120���� -   $ textBoxCellphone��$
��Left=�$��23��$��
733,63,0,0q�$
 Wrap=�$�� ��$ 12��$	��Top=�$	��122���� -   $ textBoxEmail��$
��Left=�$��23��$��	82,89,0,0q�$
 Wrap=�$�� ��$	 100��$	��Top=�$	��346��(  "System.Windows.Controls.DatePicker  -     Name$ DateOfBirth��$
��Left=�$��
526,27,0,0q�$	��Top=�$	��120���� -   $ 
buttonSave��$
��Save��$
��Save��$
��Left=�$��174,121,0,0q�$	��Top=�$��90��$��25���� -   $ 	buttonAdd��$��Add New��$
��Left=�$��
83,121,0,0q�$	��Top=�$��86��$��25�� J� RenderTransformOrigin$ -0.337,0.717&��� -   $ buttonPrint��$��Print��$��Print��$
��Left=�$��273,482,0,0q�$	��Top=�$��76��$��25������  �� ElementName$ listViewData�� �� Path$ .��� -   $ buttonExport��#��[  $��Export��$
��Left=�$��361,482,0,0q�$	��Top=�$��76��$��25������ $ listViewData��$ .��� -   $ buttonClose��$��Close��$
��Left=�$��845,482,0,0q�$	��Top=�$��76��$��25���� -   $ buttonDelete��$��Delete��$��Delete��$
��Left=�$��189,482,0,0q�$	��Top=�$��75��$��25���� -   $ 
buttonEdit��$
��Open��$
��Edit��$
��Left=�$��
99,482,0,0q�$	��Top=�$��75��$��25���� -    ��Name$ labelId��$y�Visible=�$�� ��$
��Left=�$��
10,125,0,0q�$	��Top=�$ 1.932,0.734&��� $
��Left=�$��
444,90,0,0q�$
��Wrap=�$��	Stat Code��$	��Top=�$��22��$��97���� -    ��Name$ comboBoxStates��$
��Left=�$��
526,90,0,0q�$	��Top=�$	��120��$��24�� �� SelectedValuePath$ 	StateCode�� �� DisplayMemberPath$ 	StateName��