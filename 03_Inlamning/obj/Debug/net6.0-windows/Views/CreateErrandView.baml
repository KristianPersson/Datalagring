   M S B A M L   `   `   `  ����G  C03_Inlamning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:_03_Inlamning.Views_03_Inlamning.Views  5      *    $_03_Inlamning.Views.CreateErrandView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:_03_Inlamning.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��1��6!   $��Skapa nytt ärende��61   $��Center=�6J   $��18(�6g    �� Padding$ 5 5 5 10q�6v   �� 5   
   $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $
��Left=�6K   $�� 5q�6f   .+�5      �� $��Ärende��6   $��0 0 20 0q�6%   �� 5      -   5         ��Name$ tbErrand��5      $��5q�6(   $	��200��64   �� 5      $��Kund Id��6   $��	10 0 12 0q�6&   �� 5      -   5        $ tbCustomerId��5      $��5q�6,   $	��200��68   5      �� 5    
   $��2��6   $��1��6#   $ 
Horizontal=�64   $��Stretch=�6M   $�� 5q�6k   .+�5!      �� $��Beskrivning av ärendet��6   $��0 0 12 0q�65   $��Center=�6G   �� 5"      -   5        $ tbDescription��5"      $��5q�6-   $	��400��69   $��80��6E   5#      �� 5$   
   $��3��6   $��1��6#   $ 
Horizontal=�64   $��Center=�6M   $�� 5q�6j   .+�5%      �� $��Datum vid skapning��6   $��0 0 13 0q�61   �� 5&      -   5        $ tbCreateDate��5&      $��5q�6,   $	��300��68   5'      �� 5(   
   $��4��6   $��1��6#   $ 
Horizontal=�64   $��Center=�6M   $�� 5q�6j   .+�5)      �� $��Datum vid ändring��6   $��0 0 20 0q�60   �� 5*      -   5        $ tbChangeDate��5*      $��5q�6,   $	��300��68   5+      �� 5-   
   $��5��6   $��1��6#   $ 
Horizontal=�64   $��Center=�6M   $�� 5q�6j   .+�5.      �� $��Status på ärendet��6   $��0 0 26 0q�60   �� 5/      -   5        $ tbErrandState��5/      $��5q�6-   $	��300��69   50      53      54      