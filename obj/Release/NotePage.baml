   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.NotePage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp1       N� Title$  NotePage��.���� 
���   �$��5q�._��  � RowDefinitions �� $
��auto ��� $��* ��� $��70 �.+��� 
���   �$��0��$��0 0 0 5q�._���  �� Orientation$ 
Horizontal=�$��0��
�������.+��� $��Resources/post-it.png��$��45��$��26 10 20 10q��� $��Notes��$��40(�$��Center=�$��DemiBold"�� $��1�����	#FFFFE278 �� $
��auto ��� $��* �.+�� $��0��.+��� $ 
Horizontal=�$��10 10 26 10q�$��Right=�.+��� -   $	��add��$��27��$��27��$
��10 0q���Z� ����  �� ImageSource$ Resources/plus.png�� j� Stretch$ Uniform=� j� TileMode$
 None=��� -   $	��del��$��30��$��30����Z� ���� $ Resources/del.png��$ Uniform=�$
 None=��� -    ��Name$ LV_Note�����	#FFFFE278$��Disabled=�$��Center=�$��1����Z� ���� .R��  � Orientation$ 
Horizontal=�$��Center=����� .R��� 
���   �$��0��$��10q�$��3q�._�� 
�������$	��520��.+��� $��Center=�$��18(�$��5q����� *Title+�� $
��edit��-   $��30��$��30��$��1��$��5q�$��Right=���Z� ��Z� ���� $ Resources/edit.png��$ Uniform=�$
 None=��� 
���   �$��0 5 0 0q�$��2��._�� 
�������.+��� -    ��Name$	 rep��$$��ссылка на проект��$��10q�$��5q�$��Right=�$��Center=�$��16(�
���   ����	#FFFFE278