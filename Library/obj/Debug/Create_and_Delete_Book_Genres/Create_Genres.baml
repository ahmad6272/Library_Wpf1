   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Library.Create_and_Delete_Book_Genres%Library.Create_and_Delete_Book_Genres  5   	   9    3Library.Create_and_Delete_Book_Genres.Create_Genres   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:Library.Create_and_Delete_Book_Genres     5   	   -   5           MaterialDesignBody#���   5   
   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Create_and_Update_Genres��5   	   $��374.242��6*   $��645.454��6;   .��5      � ��5   
   �� 5       �� ImageSource$: 4/Library;component/Фон регистрации.jpg��6   .+�5   
   �� -   5         ��Name$ txt_Create_Genre��5      $
��Left=�6,   $��34��6G   $��
39,117,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��229��6�   $��20(�6�   $��Bradley Hand ITC)�6�   �� 5   
   $��Create Genres ��6   $
��Left=�6)   $	��Top=�6D   $��	39,58,0,0q�6\   $	��229��6o   $��20(�6{   $��Bradley Hand ITC)�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgv_Book_Genres��5         AutoGenerateColumns .     
IsReadOnly . 	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6Z   $	��333��6�   $��Bottom=�6�   $��0q�6�   $��16(�6�   $��Bradley Hand ITC)�6�   
   HeadersVisibility$	
 All=�6  $��357,0,10,10q�6'  ��6j   ��  �� Source$ Dgv_Book_Genres����6�   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Genres��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
Genre_Name+5      �� 5   
   -   5         ��Name$ 
btn_Create��5      $��Create Genres��6%   $
��Left=�6=   $��
39,193,0,0q�6X   $	��Top=�6l   $	��229��6�   $��45��6�   $��20(�6�   $��Bradley Hand ITC)�6�   
���   �
���   ���6�   Z� 6  5      5      