   M S B A M L   `   `   `  ����I  EAplicatieCamin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AplicatieCamin.ViewsAplicatieCamin.Views  5   	   E'clr-namespace:AplicatieCamin.ViewModelsAplicatieCamin.ViewModels  5   	   !    AplicatieCamin.Views.Camere   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:AplicatieCamin.Views     5   	   7ctx'clr-namespace:AplicatieCamin.ViewModels     5   	     � Title$  Camere��5	   	   $	��500��6   $	��400��6%    � WindowStartupLocation$ CenterScreen=�61    � DataContext 5
      (  "AplicatieCamin.ViewModels.CamereVM  5   
   .��5      � 
����·� � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��4* �6   6*   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0��6;   $��5��6K   $��Center=�6_   $��Center=�6|   .+�5      �� $��CAMINUL��6   $��Center=�6&   $��Center=�6H   $��40(�6l   
�������$
��Bold"�6�   6�   �� 5      $��Center=�63   $��Center=�6U   $��40(�6y   
�������$
��Bold"�6�   ��6   �� *
NumarCamin+6�   5      �� 5    
   $��1��6   $��0��6   $��5��6/   $��20,20,20,20q�6C   ��6X   �� *Rooms+ �� SelectedItem 6v   �� *CameraSelectata+��5!      �� 5"      .R�5#      �� $ 
Horizontal=�6!   .+�5$      �� $��Camera��6    63   �� 5%      ��6    �� *Numar+6<   5&      5'      5)      �� 5*   
   -   5         ��Name$ BackBtn��5*     $��0��6   $��2��6!   $��Inapoi��6.   $��10,20,10,20q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   61  �� 5+   
   -   5        $ AddBtn��5+     $��1��6   $��2��6!   $��Adauga��6.   $��10,20,10,20q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   6/  �� 5,   
   -   5        $ StudentiBtn��5,   '  $��2��6   $��2��6!   $��Studenti��6.   $��10,20,10,20q�6A   
���   �
�������$��Center=�6|   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   {�6
  �� *Sterge+6X  �� 5-   
   -   5        $ 	UpdateBtn��5-   '  $��3��6   $��2��6!   $��Modifica��6.   $��10,20,10,20q�6A   
���   �
�������$��Center=�6|   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   {�6
  �� *Sterge+6T  �� 5.   
   -   5        $ 	DeleteBtn��5.     $��4��6   $��2��6!   $��Sterge��6.   $��10,20,10,20q�6?   
���   �
�������$��Center=�6z   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   {�6  �� *Sterge+��68  �� *StergereCamin+6\  5/      50      