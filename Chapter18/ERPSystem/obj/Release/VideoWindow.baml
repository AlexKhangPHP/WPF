   M S B A M L   `   `   `  ���� D  @ERPSystem, Version=5.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ERPSystem	ERPSystem      ERPSystem.VideoWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ERPSystem     -     � Title$  Video Player�� � WindowState$ Normal=� � WindowStartupLocation$ CenterScreen=�$	��530��$	��720��$	��500��$	��680�� J� 	AllowDrop . .��� -    �Name$ 	PlayMedia��$	��400��$
��Auto��$
��Auto��$	��580�� � ShowGridLines .   � RowDefinitions �� $
��300* ��� $��40 ��� $��30 ��� $��40 � � ColumnDefinitions �� $
��580* �.+�r� -    r�Name$ xMediaPlayer��$��Stretch=�$
��Auto��$
��Auto��$��0��$��0��$	��580��$	��300��	 r� Volume$		 0.5Q�
 r� LoadedBehavior$
 Manual=�$��Stretch=��� -    ��Name$ Subtitle��$��Stretch=�$
��Wrap=�$����Here is Subtitle: Windows Presentation Foundation (WPF) in Visual Studio provides developers with a unified programming model for building line-of-business desktop applications on Windows.��$	��650��$	��400��$��40��$��Center=�$��0��$��1��� -   $ PlayPosition��$��50��$
��Auto��$
��Auto��$	��580�� .  $��Stretch=�$��0��$��2�� �� $	��50* � �� $��80 ��� $
��400* ��� $��80 �.+��� -   $ 
StartValue��$��Right=�$��00:00:00��$��50��$��0��$��0���� -    ��Name$ PositionSilder��$	��540��$��20��$
��Auto��$��Stretch=�$��Center=�$	��Top=�$��1��$��0���� -   $ EndValue��$��Center=�$��00:00:00��$��50��$��2��$��0��� -	   $ PlayButtons��$
��Auto��$	��580��$��40��$
��Auto�� .  $	��Top=�$��0��$��3�� �� $��40 � �� $��35 ��� $��35 ��� $��35 ��� $
��200* ��� $��35 ��� $��35 ��� $��35 ��� $	��35* �.+��� -
    ��Name$ Shuffer��$��Center=�$��28��$��28��$	��Top=�$��Resources/shuffer.png��$��0��$��0���� -   $ ReplayVideo��$��0��$��1��$	��Top=�$
��Left=�$��28��$��28��$!��Resources/notautoreplay.png���� -   $ loudSpeaker��$	��Top=�$��Center=�$��0��$��2��$��28��$��28��$"��Resources/loudspeaker-on.png�� � ToolTip$ On���� -   $ VolumnSlider�� � Maximum$ 1Q� � Value$	 0.5Q�$��Stretch=�$
��Left=�$	��Top=�$	��150��$	��100��$��25��$��25��$��0��$��3���� -   $ 	MoveFirst��$��Center=�$��0��$��4��$��28��$��28��$	��Top=�$��Resources/first.png���� -   $ 	imagePlay��$��Center=�$��28��$��28��$��0��$��5��$	��Top=�$ Start��$��Resources/pause.png���� -   $ MoveLast��$��Center=�$��0��$��6��$��28��$��28��$	��Top=�$��Resources/last.png���� -   $ 
FullScreen��$��0��$��7��$	��Top=�$
��Left=�$��28��$��28��$��Resources/fullscreen.png��