   M S B A M L   `   `   `  ����I  EAplicatieCamin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AplicatieCamin.ViewModelsAplicatieCamin.ViewModels  5   	   ;"clr-namespace:AplicatieCamin.ViewsAplicatieCamin.Views  5   	   #    AplicatieCamin.Views.Studenti   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7ctx'clr-namespace:AplicatieCamin.ViewModels     5   	   4local"clr-namespace:AplicatieCamin.Views     5   	     � Title$  Studenti��5	   	   $	��500��6   $	��400��6'    � WindowStartupLocation$ CenterScreen=�63    � DataContext 5
      *  $AplicatieCamin.ViewModels.StudentiVM  5   
   .��5      � 
����·� � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��5* �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $��4��6-   $��STUDENTI��6A   $��Center=�6T   $��Center=�6v   $��40(�6�   
�������$
��Bold"�6�   6�   &   System.Windows.Controls.DataGrid  51   
   $��1��6^   $��0��6l   $��4��6|   $��20,20,20,20q�6�   ��6   �� *
Students+ �� SelectedItem 64   �� *StudentSelectat+6�   �� 52   
   -   5         ��Name$ BackBtn��52     $��0��6   $��2��6!   $��Inapoi��6.   $��20,20,20,20q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   61  �� 53   
   -   5        $ AddBtn��53     $��1��6   $��2��6!   $��Adauga��6.   $��20,20,20,20q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   60  �� 54   
   -   5        $ 	UpdateBtn��54   
  $��2��6   $��2��6!   $��Modifica��6.   $��20,20,20,20q�6A   
���   �
�������$��Center=�6|   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   {�6  �� *Sterge+6T  �� 55   
   -   5        $ 	DeleteBtn��55     $��3��6   $��2��6!   $��Sterge��6.   $��20,20,20,20q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   {�6  �� *Sterge+��68  �� *StergereStudent+6_  56      57      