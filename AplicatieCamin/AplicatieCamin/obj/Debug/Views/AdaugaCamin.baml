   M S B A M L   `   `   `  ����I  EAplicatieCamin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AplicatieCamin.ViewsAplicatieCamin.Views  5   	   E'clr-namespace:AplicatieCamin.ViewModelsAplicatieCamin.ViewModels  5   	   &     AplicatieCamin.Views.AdaugaCamin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:AplicatieCamin.Views     5   	   7ctx'clr-namespace:AplicatieCamin.ViewModels     5   	     � Title$  AdaugaCamin��5	   	   $	��500��6   $	��400��6*    � WindowStartupLocation$ CenterScreen=�66    � DataContext 5
      .  (AplicatieCamin.ViewModels.AdaugaCamineVM  5   
   .��5      � 
����·� � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Adauga camin��6A   $��Center=�6X   $��Center=�6|   $��40(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��0��6   $��Center=�6-   $��Center=�6Q   
�������$
��Bold"�6�   $��15(�6�   $��Numarul caminului��6�   6�   �� 5   
   -   5         ��Name$ 
NumarCamin��5      $��1��6&   $��1��63   $��20,50,125,50q�6C   ��6�   �� *
NumarCamin+6�   �� 5   
   $��2��6   $��0��6   $��Center=�6-   $��Center=�6Q   
�������$
��Bold"�6�   $��15(�6�   $��Taxa lunara (RON)��6�   6�   �� 5   
   -   5        $ 	TaxaCamin��5      $��2��6%   $��1��62   $��20,50,125,50q�6B   ��6�   �� *Taxa+6�   �� 5   
   -   5         ��Name$ BackBtn��5     $��0��6   $��3��6!   $��Inapoi��6.   $��50,40,50,40q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   61  �� 5    
   $��1��6   $��3��6!   $��Adauga��6.   $��50,40,50,40q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   ��6  �� *AdaugaCamin+6*  5!      5"      