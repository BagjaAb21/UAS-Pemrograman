   M S B A M L   `   `   `  ����M  ISistem Pendaftaran, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Sistem_PendaftaranSistem_Pendaftaran  5   	   (    "Sistem_Pendaftaran.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Sistem_Pendaftaran     5   	     � Title$  
MainWindow��5   	   $	��700��5	   	   $
��1300��5
   	    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	    � 	Resources 5       �� 
TargetType   menu �� Triggers P� Property P� Value �� Property	 �� Value
 �� ImageSource  btnClose��%�  &	        &	 �     �� 5   
   " ��6    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��	 5      �� 5      $!
 /Images/menu background.png��6)   5      �� 5       �@�Cursor$
	 Hand��6/   5      5      �� 5   
   " ��6    5      P� 5       �@J�IsMouseOver . . �5       ��  �@�Cursor$
	 Hand��6/   5!      5#      5$      .��5'      �  � ColumnDefinitions 5)   
   �� 5*      $	��280 �6   �� 5+      $��* �6   .+�5/   
   � ���#642DCA � RowDefinitions 50      �� 51      $	��100 �6    �� 52      $��5 �6    �� 53      $��30 �6    �� 54      $��60 �6    �� 55      $��60 �6    �� 56      $��* �6    .+�5:      � $��0��6   .+�5;      �� $��/Images/Group 120 v2.png��6   $��23��5<      $��Center=�5=      5>      �� 5?      $��1��6   $��/Images/garis.png��5@      �� 5C      -   5         ��Name$ btnPendaftaran��5F      $��3��5C      #��[  5D      $
��3, 0q�5E      ._�5H      �� $��60,0,0,0q�6   $��Center=�5I       �� Orientation$ 
Horizontal=�5J      .+�5K      �� $��/Images/people_alt.png��6   $��25��5L      �� 5M      $��Pendaftaran��6   $��25,0,0,0q�5N      $��Center=�5O      $��SemiBold"�5P      
�������$��14(�5R      5S      5T      �� 5W      -   5        $ btnJadwalDokter��5Z      $��4��5W      #��[  5X      $
��3, 0q�5Y      ._�5\      �� $��60,0,0,0q�6   $��Center=�5]      $ 
Horizontal=�5^      .+�5_      �� $��/Images/event_note.png��6   $��25��5`      �� 5a      $��Jadwal Dokter��6   $��25,0,0,0q�5b      $��Center=�5c      $��SemiBold"�5d      
�������$��14(�5f      5g      5h      5i      �� 5l   
   $��1��6   .+�5m      �� -   5         ��Name$ btnClose��5m      $��Right=�5n      $��48��5o      $��45��5p      ���	#FF6C3AC8$��X��5r      $��0q�5t      
�������$��16(�5v      #��[ 5x      ��5s      Z� 5x       � 5z      -   5          �Name$
 Main��5z        � NavigationUIVisibility$ Hidden=�5{      5|      5}      5~      5      