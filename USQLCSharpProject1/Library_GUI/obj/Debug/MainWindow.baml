   M S B A M L   `   `   `  ����F  BLibrary_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Library_GUILibrary_GUI  5   	       Library_GUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Library_GUI     5   	     � Title$  Library��5   	   $��594.5��6   $	��771��6(    � WindowStartupLocation$ CenterScreen=�64   .��5	      � .+�5
   
   �� -   5         ��Name$ insert_authors��5
      $��Insert��6)   $
��Left=�6:   $	��Top=�6U   $	��148��6m   $��218,300,0,0q�6y   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5         ��Name$ listBox1��5      $
��Left=�6$   $	��180��6?   $	��Top=�6L   $	��763��6d   ���	#FFFBF292$��22(�6�   $��Palatino Linotype)�6�   �� 5   
   $��Books:��6   $
��Left=�6!   $��336,185,0,0q�6<   $	��Top=�6Q   $��22(�6i   $
��Bold"�6w   $��Times New Roman)�6�   �� 5   
   -   5        $ edit_authors��5      $��Update��6'   $
��Left=�68   $	��Top=�6S   $	��148��6k   $��394,300,0,0q�6w   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   $��Authors:��6   $
��Left=�6#   $��332,261,0,0q�6>   $	��Top=�6S   $��22(�6k   $
��Bold"�6y   $��Times New Roman)�6�   �� 5   
   -   5        $ delete_authors��5      $��Delete��6)   $
��Left=�6:   $	��Top=�6U   $	��148��6m   $��570,300,0,0q�6y   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   $��Genres:��6   $
��Left=�6"   $��338,330,0,0q�6=   $	��Top=�6R   $��22(�6j   $
��Bold"�6x   $��Times New Roman)�6�   �� 5   
   -   5        $ insert_books��5      $��Insert��6'   $
��Left=�68   $	��Top=�6S   $	��148��6k   $��218,228,0,0q�6w   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $ 
edit_books��5      $��Update��6%   $
��Left=�66   $	��Top=�6Q   $	��148��6i   $��394,228,0,0q�6u   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $ delete_books��5      $��Delete��6'   $
��Left=�68   $	��Top=�6S   $	��148��6k   $��570,228,0,0q�6w   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $ insert_genres��5      $��Insert��6(   $
��Left=�69   $	��Top=�6T   $	��148��6l   $��218,368,0,0q�6x   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -	   5        $ edit_genres��5      $��Update��6&   $
��Left=�67   $	��Top=�6R   $	��148��6j   $��394,368,0,0q�6v   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -
   5        $ delete_genres��5      $��Delete��6(   $
��Left=�69   $	��Top=�6T   $	��148��6l   $��570,368,0,0q�6x   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $ show_authors��5      $
��Show��6'   $
��Left=�66   $	��Top=�6Q   $	��148��6i   $��
44,300,0,0q�6u   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $ 
show_books��5      $
��Show��6%   $
��Left=�64   $	��Top=�6O   $	��148��6g   $��
44,228,0,0q�6s   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $ show_genres��5      $
��Show��6&   $
��Left=�65   $	��Top=�6P   $	��148��6h   $��
44,368,0,0q�6t   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   $��Call WCF Service:��6   $
��Left=�6,   $��296,480,0,0q�6G   $	��Top=�6\   $��22(�6t   $
��Bold"�6�   $��Times New Roman)�6�   �� 5   
   -   5        $ wcf_btn��5      $��WCF Service��6"   $
��Left=�68   $	��Top=�6S   $	��148��6k   $��312,524,0,0q�6w   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $ linq_queries��5      $��LINQ Queries��6'   $
��Left=�6>   $	��Top=�6Y   $	��164��6q   $��304,425,0,0q�6}   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   $��36��6�   6�   �� 5   
   -   5        $ serialize_btn��5      $��	Serialize��6(   $
��Left=�6<   $	��Top=�6W   $	��148��6o   $��
44,524,0,0q�6{   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $ msmq_btn��5      $��MS MQ��6#   $
��Left=�63   $	��Top=�6N   $	��148��6f   $��557,524,0,0q�6r   $��22(�6�   $
��Bold"�6�   $��Times New Roman)�6�   6�   5       5!      