   M S B A M L   `   `   `  ����G  C03_Inlamning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:_03_Inlamning_03_Inlamning  5   	   Q-clr-namespace:_03_Inlamning.Models.ViewModels_03_Inlamning.Models.ViewModels  5   	       _03_Inlamning.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:_03_Inlamning     5   	   C	viewModel-clr-namespace:_03_Inlamning.Models.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1000��6)    � DataContext 5      9  3_03_Inlamning.Models.ViewModels.MainWindowViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �� 
������ $��8q�6.   $��Ny Kund��6:   ��6L   �� *CreateCustomerViewCommand+�� 5      
������ $��8q�6.   $
��Kund��6:   ��6I   �� *CustomersViewCommand+�� 5      
������ $��8q�6.   $��Nytt Ärende��6:   ��6P   �� *CreateErrandViewCommand+�� 5      
������ $��8q�6.   $��Ärenden��6:   ��6L   �� *ErrandsViewCommand+5      �� 5   
   $��1��6   ��6)   �� *CurrentView+5      5!      