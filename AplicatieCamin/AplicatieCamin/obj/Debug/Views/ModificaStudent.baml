   M S B A M L   `   `   `  ����I  EAplicatieCamin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AplicatieCamin.ViewModelsAplicatieCamin.ViewModels  5   	   ;"clr-namespace:AplicatieCamin.ViewsAplicatieCamin.Views  5   	   *    $AplicatieCamin.Views.ModificaStudent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7ctx'clr-namespace:AplicatieCamin.ViewModels     5   	   4local"clr-namespace:AplicatieCamin.Views     5   	     � Title$  ModificaStudent��5	   	   $	��500��6!   $	��400��6.    � WindowStartupLocation$ CenterScreen=�6:    � DataContext 5
      1  +AplicatieCamin.ViewModels.AdaugareStudentVM  5   
   6"   .��5      � 
����·� � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Modifica student��6A   $��Center=�6\   $��Center=�6�   $��40(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��0��6   $
��Nume��6-   $��Center=�6<   $��Center=�6`   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5    
   $��1��6   $��1��6   $��20,20,20,20q�6/   ��6D   �� *Nume+6\   �� 5!   
   $��2��6   $��0��6   $��Prenume��6-   $��Center=�6?   $��Center=�6c   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5"   
   $��2��6   $��1��6    $��20,20,20,20q�60   ��6E   �� *	Prenume+6`   �� 5#   
   $��3��6   $��0��6   $	��Cnp��6-   $��Center=�6;   $��Center=�6_   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5$   
   $��3��6   $��1��6   $��20,20,20,20q�6/   ��6D   �� *CNP+6[   �� 5%   
   $��4��6   $��0��6   $��	Facultate��6-   $��Center=�6A   $��Center=�6e   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5&   
   $��4��6   $��1��6    $��20,20,20,20q�60    �� DisplayMemberPath$
 Nume��6�   ��6E   �� *	Facultati+ �� SelectedItem 6g   �� *	Facultate+6�   �� 5'   
   $��5��6   $��0��6   $��Tip taxa��6-   $��Center=�6@   $��Center=�6d   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5(   
   $��5��6   $��1��6    $��20,20,20,20q�60   $
 Nume��6�   ��6E   �� *TipuriDeTaxa+ 6j   �� *	TipTaxa+6�   �� 5)   
   -   5         ��Name$ BackBtn��5)     $��0��6   $��6��6!   $��Inapoi��6.   $��50,20,50,20q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   61  �� 5*   
   $��1��6   $��6��6!   $��Salveaza��6.   $��50,20,50,20q�6A   
���   �
�������$��Center=�6|   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   ��6
  �� *
Modifica+6)  5+      5,      