   M S B A M L   `   `   `  ����B  >WpfEDSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfEDSS.PagesWpfEDSS.Pages  5          WpfEDSS.Pages.ClientEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfEDSS.Pages     5        N� Title$  
ClientEdit��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��ID клиента��6   $��0��5      $��0��5      $��28(�5      �� 5   
   -   5         ��Name$ idClientIdBox��5      $��1��5      $��0��5       $��28(�5!       �� 
IsReadOnly . 6    �� 5#   
   $��ФИО клиента��6   $��0��5$      $��1��5%      $��28(�5&      �� 5'   
   -   5        $ ClientFIOBox��5'      $��1��5(      $��1��5)      $��28(�5*      �� 5,   
   $��Телефон��6   $��0��5-      $��3��5.      $��28(�5/      �� 50   
   -   5        $ idTelBox��50      $��1��51      $��3��52      $��28(�53      �� 55   
   $��6��6   $��2��56       �� Orientation$ 
Horizontal=�57      $��Center=�58      .+�5:      �� -   5         ��Name$ BtnClientAdd��5:      $��Добавить��5<      $��28(�6(   $	��200��5=      �� 5>      -   5        $ BtnClientEdit��5>      $��Обновить��5@      $��28(�6(   $	��200��5A      �� 5B      $��20��6   �� 5C      -   5        $ BtnClientDel��5C      $��Удалить��5E      $��28(�6'   $	��200��5F       � Cursor$  ��6!   5G      5H      5I      