   M S B A M L   `   `   `  ����B  >WpfEDSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfEDSSWpfEDSS  5   	       WpfEDSS.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfEDSS     5   	     � Title$
  EDSS��5   	   $
��1000��6   $
��1920��6$    � 
ResizeMode$ CanResizeWithGrip=�61    � WindowStartupLocation$ CenterScreen=�6P    � WindowState$ 	Maximized=�6u   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 10��6    � 5   
   -   5          �Name$ FrameMainWindow��5        � NavigationUIVisibility$ Hidden=�5      $��1��5      $��4��6   �� 5   
   -   5        	 ��Name$	 
lblAccount��5      $��3��5      $��0��5      $	��250��5      $
��Left=�5      5      �� 5!   
   -   5        
 ��Name$
 ButtonProcesses��5$      $��0��5"      $��0��5#      $%��Журнал процессов��5%      5&      �� 5(   
   -   5        $
 ButtonClients��5+      $��1��5)      $��0��5*      $#��Журнал клиентов��5,      5-      �� 5/   
   -   5        $
 ButtonWorkers��52      $��2��50      $��0��51      $)��#Журнал сотрудников��53      54      �� 56   
   -   5        $
 ButtonLogOut��5;      $��3��57      $��0��58      $��Right=�59      $	��220��5:      $��
Выйти��5<      5=      5@      5A      