   M S B A M L   `   `   `  ����I  EAplicatieCamin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AplicatieCamin.ViewModelsAplicatieCamin.ViewModels  5   	   ;"clr-namespace:AplicatieCamin.ViewsAplicatieCamin.Views  5   	   &     AplicatieCamin.Views.TaxeStudent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7ctx'clr-namespace:AplicatieCamin.ViewModels     5   	   4local"clr-namespace:AplicatieCamin.Views     5   	     � Title$  TaxeStudent��5	   	   $	��500��6   $	��400��6*    � WindowStartupLocation$ CenterScreen=�66    � DataContext 5
      .  (AplicatieCamin.ViewModels.PlataStudentVM  5   
   .��5      � 
����·� � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $	��.5* �6   6+   �� 5      $��2* �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��0��6   $��Center=�6F   $��Right=�6h   $��40(�6�   
�������$
��Bold"�6�   ��6-   �� *Nume+6�   �� 5   
   $��0��6   $��1��6   $��Center=�6I   $
��Left=�6k   $��40(�6�   
�������$
��Bold"�6�   ��6-   �� *	Prenume+6�   �� 5   
   $��1��6   $��0��6   $��Taxe platite��6-   $��Center=�6D   $��Center=�6f   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��1��6   $��Taxe neplatite��6-   $��Center=�6F   $��Center=�6h   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��2��6   $��0��6   $��10,10,10,10q�6/   ��6D   �� *TaxePlatite+��5      �� 5      .R�5       ��  �� Orientation$ 
Horizontal=�6!   .+�5!      �� $
��Luna��6    61   �� 5"      ��6    �� *Luna+6;   �� 5#      $
��Suma��6    61   �� 5$      ��6    �� *Suma+6;   5%      5&      5(      �� 5)   
   $��2��6   $��1��6   $��10,10,10,10q�6/   ��6D   �� *TaxeNeplatite+ �� SelectedItem 6j   �� *TaxaSelectata+��5*      �� 5+      .R�5,      �� $ 
Horizontal=�6!   .+�5-      �� $
��Luna��6    61   �� 5.      ��6    �� *Luna+6;   �� 5/      $
��Suma��6    61   �� 50      ��6    �� *Suma+6;   51      52      54      �� 55   
   -   5         ��Name$ BackBtn��55     $��0��6   $��3��6!   $��Inapoi��6.   $��50,30,50,30q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   61  �� 56   
   -   5        $ PlatesteBtn��56   
  $��1��6   $��3��6!   $��Plateste��6.   $��50,30,50,30q�6A   
���   �
�������$��Center=�6|   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   {�6   �� *PlataSelectata+��6E  �� *
Plateste+6d  57      58      