   M S B A M L   `   `   `  ����I  EAplicatieCamin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AplicatieCaminAplicatieCamin  5   	       AplicatieCamin.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AplicatieCamin     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��4* �6   6*    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��4��6    $��0��64   $��5��6A   $��../Images/camin.png��6S   $	��800��6p   $	��450��6|   $��Center=�6�   $��Center=�6�   $
��Fill=�6�   6�   �� 5   
   $��0��6   $��0��6   $��4��6-   $��Camin UNITBV��6A   $��Center=�6X   $	��Top=�6u   $��40(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��2��6   $��Nume utilizator��6.   $��Right=�6H   $��Center=�6d   $��20(�6   
�������$
��Bold"�6�   6�   �� 5   
   $��2��6   $��0��6   $	��CNP��6-   $��Right=�6;   $��Center=�6W   $��20(�6r   
�������$
��Bold"�6�   6�   �� 5   
   $��2��6   $��2��6   $��Parola��6-   $��Right=�6>   $��Center=�6Z   $��20(�6u   
�������$
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ UsernameTxt��5      $��1��6'   $��3��64   $��50,15,50,15q�6D   6\   G� 5   
   -   5         G�Name$ PasswordTxt��5      $��2��6+   $��3��68   $��50,15,50,15q�6H   6`   �� 5   
   -   5        $ CNPTxt��5      $��2��6"   $��1��6/   $��30,10,30,10q�6?   6W   �� 5    
   -   5         ��Name$ TaxeBtn��5    �   $��1��6   $��3��6!   $��Verificare taxe��6.   $��Center=�6H   $��Center=�6l   
���   �$��30,10,30,10q�6�   
�������$��2q�6�   
�������$��15(�6  $
��Bold"�6'  6;  �� 5!   
   -   5        $ LoginBtn��5!   �   $��3��6   $��3��6!   $��Login��6.   $��Center=�6>   $��Center=�6b   
���   �$��50,10,50,10q�6�   
�������$��2q�6�   
�������$��15(�6  $
��Bold"�6  62  5"      5#      