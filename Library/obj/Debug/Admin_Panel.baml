   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.Admin_Panel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	      MaterialDesignBody#���   5   
   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Admin_Panel��5   	   $��489.394��6   $��816.667��6.   .��5      � -   5        $��0,0,2,2q�5      ��5   
   �� 5       �� ImageSource$' !Фон регистрации.jpg��6   .+�5   
   �� $
��Name��6   $
��Left=�6   $	��Top=�6:   $��
56,163,0,0q�6R   $��99��6f   $��30(�6q   $��Bradley Hand ITC)�6   $��	ExtraBold"�6�   $��51��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgv_Sellers��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6(      
IsReadOnly .    AutoGenerateColumns .  $	��179��6�   $��Bottom=�6�   $��0q�6�   $��16(�6�   $��Bradley Hand ITC)�6�      HeadersVisibility$	 All=�6  $
��10,0q�6  ��6f   �� 	 �� Source$	 Dgv_Sellers����6�   Z� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Seller_Name+  5      $ Surname��6%    66   �� *Seller_Surname+  5      $ Email��6%    64   �� *Seller_Email+  5      $ Admin��6%    64   �� *
Is_Admin+  5      $ 	Activated��6%    68   �� *Is_Activated+  5      $ Deleted��6%    66   �� *
Is_Deleted+5      �� 5    
   -   5        $��txt_User_Name��5       $
��Left=�6'   $��38��6B   $��185,163,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��185��6�   $��30(�6�   $��Bradley Hand ITC)�6�   �� 5!   
   -   5        $��cb_Case��5!      $
��Left=�6"   $��413,173,0,0q�6=   $	��Top=�6R   $	��178��6j   $��20(�6v   $��Bradley Hand ITC)�6�   $��28��6�   �� 5"   
   $��New Sellers��6   $
��Left=�6&   $	��Top=�6A   $��
190,77,0,0q�6Y   $	��178��6m   $��30(�6y   $��Bradley Hand ITC)�6�   $��	ExtraBold"�6�   $��51��6�   �� 5#   
   -   5         ��Name$  btn_AddSellers_Admin_Panel��5#      $	��ADD��65   $
��Left=�6C   $��636,164,0,0q�6^   $	��Top=�6s   $	��135��6�   $��45��6�   $��24(�6�   $��Bradley Hand ITC)�6�   
���   �
���   �$��	ExtraBold"�6!  ��6�   Z� 6!  o� 5$   
   $
��Left=�6   $��36��6*   $��	10,10,0,0q�66   $	��Top=�6I   $	��346��6a    o� 
IsMainMenu . ��6   Z� ��6�   Z� .@�5%      m� -   5        $��Books��5%      $
��auto��6>   $��31��6K   $��20(�6W   $��Bradley Hand ITC)�6e   
���   �$��	ExtraBold"�6�   m� 5&      -   5        $��Orders��5&      $
��auto��6:   $��31��6G   $��20(�6S   $��Bradley Hand ITC)�6a   
���   �$��	ExtraBold"�6�   m� 5'      $��
Book genre��6   $
��auto��6+   $��31��68   $��20(�6D   $��Bradley Hand ITC)�6R   
���   �$��	ExtraBold"�6�   .@�5(      m� -   5        $��Create Genre��5(      ��5)      �� 5*      $' !Фон регистрации.jpg��6%   5,      m� 5-      -	   5        $��Delete Genre��5-      ��5.      �� 5/      $' !Фон регистрации.jpg��6%   51      52      53      55      56      