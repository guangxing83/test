   M S B A M L   `   `   `  ����  WPFTest    WPFTest.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$
  demo��5   	   $	��600��6   $	��960��6#    � WindowStartupLocation$ CenterScreen=�6F    � WindowState$ Normal=�6k   .��5      � -   5        $
��grid��5      $��0q�6    � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5	      $	��10* �6   6+    � ColumnDefinitions 5   
   �� 5      $	��160 �6   6-   �� 5      $��* �6   6+   .+�5   
    � -   5          �Name$ 	headFrame��5   *   
�������$��0��6=   $��2��6J   $��0,0,0,0q�6^     � NavigationUIVisibility$ Hidden=�6o   $
��head��6�   $��Stretch=�6�   $��Stretch=�6�    � 5   
   -   5        $ mainMenuFrame��5   '   
�������$��1��6>   $��2��6K   $��0,0,0,0q�6_   $ Hidden=�6p   $��top menu��6�   $��Stretch=�6�   $��Stretch=�6�    � 5   
   -   5        $ leftMenuFrame��5   #   
�������$��2��6:   $��0��6G   $��0,0,0,0q�6W   $ Hidden=�6h   $��	left menu��6�   $��Stretch=�6�   $��Stretch=�6�    � 5   
   -   5        $ contentFrame��5      $��2��6&   $��1��63   $��0,0,0,0q�6C   $ Hidden=�6T   $�� ��6t   $��Stretch=�6   $��Stretch=�6�   5      5      