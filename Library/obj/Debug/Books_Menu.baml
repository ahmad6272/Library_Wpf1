   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.Books_Menu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
Books_Menu��5   	   $��545.985��6   $��1136.681��6-   .��5      � $��0,0,2,0q�6   ��5   
   �� 5       �� ImageSource$' !Фон регистрации.jpg��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgv_Books��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6&   $	��505��67   $��Bottom=�6D   $��0q�6u   $��16(�6�   $��Bradley Hand ITC)�6�      HeadersVisibility$	 All=�6�   $��
620,0,10,0q�6�   ��6_   Z� 6�   �� 5   
   -   5         ��Name$ cb_Book_Genres��5      $��20(�6+   $��Bradley Hand ITC)�69   $
��Left=�6W   $��
52,240,0,0q�6r   $	��Top=�6�   $	��137��6�    �� DisplayMemberPath$ 
Genre_Name��5      	 �� SelectedValuePath$	 ID��5      ��5      �� *Book_Genres+
 �� SelectedValue
 5      �� *Book_Genres+�� 5   
   $��Create Books��6   $��30(�6'   $��Bradley Hand ITC)�65   $
��Left=�6S   $��	52,36,0,0q�6n   $	��Top=�6�   $	��179��6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txt_Book_Name��5      $��20(�6)   $��Bradley Hand ITC)�67   $
��Left=�6U   $��39��6p   $��
52,128,0,0q�6|    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��306��6�   �� 5   
   -   5         ��Name$ btn_Add_Book��5      $��Add Book��6'   $
��Left=�6:   $��425,407,0,0q�6U   $	��Top=�6j   $	��190��6�   $��46��6�   $��20(�6�   $��Bradley Hand ITC)�6�   
���   �
���   ���6�   Z� 6  �� 5   
   $��Book Author��6   $��30(�6&   $��Bradley Hand ITC)�64   $
��Left=�6R   $��
425,36,0,0q�6m   $	��Top=�6�   $	��190��6�   $
��Bold"�6�   �� 5    
   $��	Book Name��6   $��20(�6$   $��Bradley Hand ITC)�62   $
��Left=�6P   $��	52,95,0,0q�6k   $	��Top=�6~   �� 5!   
   -   5        $ txt_Author_Name��5!      $��20(�6+   $��Bradley Hand ITC)�69   $
��Left=�6W   $��39��6r   $��425,128,0,0q�6~   $
 Wrap=�6�   $	��Top=�6�   $	��190��6�   �� 5"   
   $��Author Name��6   $��20(�6&   $��Bradley Hand ITC)�64   $
��Left=�6R   $��
425,95,0,0q�6m   $	��Top=�6�   �� 5#   
   -   5        $ txt_Author_Surname��5#      $��20(�6.   $��Bradley Hand ITC)�6<   $
��Left=�6Z   $��39��6u   $��425,238,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��190��6�   �� 5$   
   $��Author Surname��6   $��20(�6)   $��Bradley Hand ITC)�67   $
��Left=�6U   $��425,202,0,0q�6p   $	��Top=�6�   $	��161��6�   �� 5%   
   -   5        $ txt_Author_Patronymic��5%      $��20(�61   $��Bradley Hand ITC)�6?   $
��Left=�6]   $��39��6x   $��425,342,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��190��6�   �� 5&   
   $��Author Patronymic��6   $��20(�6,   $��Bradley Hand ITC)�6:   $
��Left=�6X   $��425,306,0,0q�6s   $	��Top=�6�   $	��190��6�   �� 5'   
   $��
Book Genre��6   $��20(�6%   $��Bradley Hand ITC)�63   $
��Left=�6Q   $��
52,202,0,0q�6l   $	��Top=�6�   $	��119��6�   �� 5(   
   $��Book Amount��6   $��20(�6&   $��Bradley Hand ITC)�64   $
��Left=�6R   $��239,202,0,0q�6m   $	��Top=�6�   $	��146��6�   �� 5)   
   $��Book Deposit��6   $��20(�6'   $��Bradley Hand ITC)�65   $
��Left=�6S   $��
52,306,0,0q�6n   $	��Top=�6�   $	��119��6�   �� 5*   
   $��Book Rent Price��6   $��20(�6*   $��Bradley Hand ITC)�68   $
��Left=�6V   $��239,306,0,0q�6q   $	��Top=�6�   $	��146��6�   5,      5-      