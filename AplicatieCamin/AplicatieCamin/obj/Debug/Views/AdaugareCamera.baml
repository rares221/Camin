   M S B A M L   `   `   `  ����I  EAplicatieCamin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AplicatieCamin.ViewModelsAplicatieCamin.ViewModels  5   	   ;"clr-namespace:AplicatieCamin.ViewsAplicatieCamin.Views  5   	   )    #AplicatieCamin.Views.AdaugareCamera   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7ctx'clr-namespace:AplicatieCamin.ViewModels     5   	   4local"clr-namespace:AplicatieCamin.Views     5   	     � Title$  AdaugareCamera��5	   	   $	��500��6    $	��400��6-    � WindowStartupLocation$ CenterScreen=�6:    � DataContext 5
      0  *AplicatieCamin.ViewModels.AdaugareCameraVM  5   
   .��5      � 
����·� � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Adauga camera��6A   $��Center=�6Y   $��Center=�6}   $��40(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��0��6   $��Center=�6-   $��Center=�6Q   
�������$
��Bold"�6�   $��20(�6�   $��Numarul camerei��6�   6�   �� 5   
   -   5         ��Name$ NumarCamera��5      $��1��6'   $��1��64   $��20,65,125,65q�6D   ��6�   �� *NumarCamera+6�   �� 5   
   -   5         ��Name$ BackBtn��5     $��0��6   $��2��6!   $��Inapoi��6.   $��50,60,50,60q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   61  �� 5   
   $��1��6   $��2��6!   $��Adauga��6.   $��50,60,50,60q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   ��6  �� *AdaugaCamera+6+  5      5      