   M S B A M L   `   `   `  ����G  C03_Inlamning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:_03_Inlamning.Views_03_Inlamning.Views  5      ,    &_03_Inlamning.Views.CreateCustomerView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:_03_Inlamning.Views     5      .��5	      � 
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
   �� $��0��6   $��1��6!   $��Registrera ny kund��61   $��Center=�6K   $��18(�6h    �� Padding$ 5 5 5 10q�6w   �� 5   
   $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $
��Left=�6K   $�� 5q�6f   .+�5      �� $��Förnamn��6   $��0 0 20 0q�6&   �� 5      -   5         ��Name$ tbFirstName��5      $��5q�6+   $	��200��67   �� 5      $��	Efternamn��6   $��0 0 22 0q�6(   �� 5      -   5        $ 
tbLastName��5      $��5q�6*   $	��200��66   5      �� 5    
   $��2��6   $��1��6#   $ 
Horizontal=�64   $
��Left=�6M   $�� 5q�6h   .+�5!      �� $��E-mejl��6   $��0 0 34 0q�6%   �� 5"      -   5        $ tbEmail��5"      $��5q�6'   $	��200��63   �� 5#      $��Mobilnummer��6   �� 5$      -   5        $ tbPhone��5$      $��5q�6'   $	��200��63   5%      �� 5&   
   $��3��6   $��1��6#   $ 
Horizontal=�64   $
��Left=�6M   $�� 5q�6h   .+�5'      �� $��Gatunamn��6   $��0 0 12 0q�6'   �� 5(      -   5        $ tbStreetName��5(      $��5q�6,   $	��200��68   �� 5)      $��
Gatunummer��6   $��0 0 6 0q�6)   �� 5*      -   5        $ tbStreetNumber��5*      $��5q�6.   $	��200��6:   5+      �� 5,   
   $��4��6   $��1��6#   $ 
Horizontal=�64   $
��Left=�6M   $�� 5q�6h   .+�5-      �� $��
Postnummer��6   �� 5.      -   5        $ tbPostalCode��5.      $��5q�6,   $	��200��68   �� 5/      $
��Stad��6   $��0 0 53 0q�6#   �� 50      -   5        $ tbCity��50      $��5q�6&   $	��200��62   51      �� 53   
   $��5��6   $��1��6   $��Center=�6.   $��Lägg till Kund��6K   $��10q�6d   57      58      