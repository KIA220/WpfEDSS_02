   M S B A M L   `   `   `  ����B  >WpfEDSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfEDSS.PagesWpfEDSS.Pages  5          WpfEDSS.Pages.WorkersPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfEDSS.Pages     5        N� Title$  WorkersPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $)��#Список сотрудников��6   �� 5   
   -   5         ��Name$ textBlockSearch��5   )   $��20 10 10 10q�6   $��0��6B   $��0��6O   $��5��6_   $��
Поиск��6s    �� TextAlignment$
 Left=�6�   $��Bottom=�6�   �� 5   
   -   5         ��Name$ 	SearchBox��5   -   $��Bottom=�6   $��0��6@   $��0��6M   $��5��6]   $	��600��6q   $��40��6}   $
��Left=�6�   $�� ��6�   $��28(�6�   
���   �$��10q�6�   ��6�   Z� 6�   �� 5!   
   -   5         ��Name$ btnUserAddNew��5!   8   $<��6Добавить нового пользователя��6   $��1��6k   $��5��6x   � 5"   
   $��2��6   $��5��6    5#      �� 5$      $��60 �6#   �� 5%      $	��775 �6#   �� 5&      $	��775 �6#   �� 5'      $��* �6#   .+�5)      �� $��0��6   $
��  ID��6(   �� 5*      $��1��6   $��  Логин��6(   �� 5+      $��2��6   $��  Телефон��6(   �� 5,      $��4��6   $��  ��6(   5-      � 5/   
   $��3��6   $��0��6   $��5��6,   $��5��6=    50      �� 51      $
��Auto �6    �� 52      $��* �6    .+�54      �� -   5         ��Name$ listOfWorkers��54      $��10q�6.   $��1��6:   ��55      �� 56       �� 
TargetType" ��6&   .R�57      �� $��1q�6!   
�������._�58      �� $
��Auto=�6+   $
��Auto=�6N   .��59   "   �� 5:      5;      5<      ��5>      �� 5?      .R�5@      �  5A      �� 5B   "   $��60 �63   �� 5C   "   $	��775 �63   �� 5D   "   $	��775 �63   �� 5E   "   $��* �63   .+�5G      �� $��0��6A   ��6(   �� *	id_user+6A   �� 5H      $��1��6E   ��6(   �� *id_jobtitle+6E   �� 5I      $��2��6B   ��6(   �� *
tel_user+6B   �� 5J      $��btnEditWorker��6=   -   5        $ ��Редактировать��5J   %   $��3��6n   5K      5L      5N      5O      5P      5Q      