   M S B A M L   `   `   `  ����=  9UP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:UP.Views.Windows.Main.PagesUP.Views.Windows.Main.Pages  5      -clr-namespace:UP.ViewModelsUP.ViewModels  5      0    *UP.Views.Windows.Main.Pages.LoadToFilePage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:UP.Views.Windows.Main.Pages     5      *vmclr-namespace:UP.ViewModels     5        N� Title$  LoadToFilePage��5
       � DataContext 5      '   !UP.ViewModels.LoadToFileViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $	��280 �6   .+�5   
   �� $��0��6   $��Center=�5      $$��Выгрузить в файл��5      $��2��5      $��times new roman)�5      $��30(�5       �� 5"   
   $��2��6   $��1��5$      
������ 
������ $��Center=�5'      $��Center=�5(      $��В EXCEL��5)      $��42(�5*      
�����_�$	��500��5,      $	��500��5-      ��5#      �� *LoadToExcelCommand+5/      ]� 51   
   $��1��6   $��2��52         buttonsPanel#��[  53      .+�55      �� $��
Назад��6     panelButton#��[ 57      ��56      �� *GoToWardPageCommand+57      58      59      5:      