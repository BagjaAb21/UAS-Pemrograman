   M S B A M L   `   `   `  ����N  JSistem Administrasi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Sistem_Administrasi.ViewSistem_Administrasi.View  5      *    $Sistem_Administrasi.View.LoginWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Sistem_Administrasi.View     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Sistem Antrean��5      $
��1300��5	      $	��700��5
       � WindowStartupLocation$ CenterScreen=�5       � WindowState$ 	Maximized=�5       � WindowStyle$
 None=�5       � 	Resources 5         btnClose �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value��%�   &	        �� 5   
   " ��6!    5      P� 5       �@J�IsMouseOver . . �5      �� 	 �@�Cursor$

 Hand��6/   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��1.7* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���	#FF6C3AC8.+�5       �� $	��561��5!      $	��331��5"      $��	0,130,0,0q�5#      $��Center=�5$      $(��"/Images/Person On a WheelChair.png��5%      �� 5'      $	��258��5(      $��0,50,0,0q�5)      $��Sistem Antrean Pasien��5*      $��Segoe UI Semibold)�5+      $��24(�5,      $
��Bold"�5-      
�������5.      �� 50      $	��600��51      $��0,5,0,0q�52      $��Center=�53      $��14(�54      
������� �� 
LineHeight$ 20��56       J� Opacity$	 0.5Q�57      $����Sistem ini berfungsi memudahkan pasien ketika ingin periksa dengan dokter maupun membuat jadwal agar tidak harus mengantri lama jika tidak menggunakan sistem ini. Semangat dan tetap jaga kesehatan.��58       �� TextAlignment$ Center=�59      $
��Wrap=�5:      5<      �� 5>   
   $��1��6   ���#ffffff.+�5?      �� -   5         ��Name$ btnClose��5@      $��48��5A      $��40��5B      $��Right=�5C      ���	#FF6C3AC8$��0q�5F      $��X��5H      $��16(�5I      
�������#��[  5K      ��5E      Z� 5K      �� 5M      $	��143��5N      $��42��5O      $��	70,50,0,0q�5P      $
��Left=�5Q      $��Center=�5R      $��/Images/Group 152.png��5S       J� OpacityMask 5T      �� 5U       �� ImageSource$ /Images/Group 152.png��6!   5W      �� 5X      $��	70,40,0,0q�5Y      $��0q�5Z      $��Login��5[      $
��30px(�5\      $
��Bold"�5]      �� 5_      $��70,5,0,0q�5`      $��0q�5a      $)��#Login sebagai pegawai ataupun admin��5b      $
��12px(�5c      ���#0a0a0a$	 0.7Q�5e      �� 5g      $��	70,25,0,0q�5h      $��0q�5i      $��Username��5j      $
��12px(�5k      $��SemiBold"�5l      �� 5n      -   5         ��Name$ txtUsername��5o      $��40��5p      $��	70,5,70,0q�5q      $��8q�5r      
�������$��14(�5t      .��5u   =   ��5v      �� 5w      $ /Images/textbox.png��6!   .��5x   &   5y      �� 5{      $��	70,20,0,0q�5|      $��0q�5}      $��Password��5~      $
��12px(�5      $��SemiBold"�5�      G� 5�      -   5         G�Name$ txtPassword��5�      $��40��5�      $��	70,5,70,0q�5�      $��8q�5�      $��14(�5�      ��5�      Z� ��5�      �� 5�      $ /Images/textbox.png��6!   5�      �� 5�      -   5         ��Name$ forgotPassword��5�      $	��100��5�      $��0,8,70,0q�5�      $��0q�5�      $��Right=�5�      $��Forgot Password?��5�      $
��12px(�5�      $��SemiBold"�5�      ���#1858f55�      �� 5�      -   5        $ btnLogin��5�      $��40��5�      $��
70,25,70,0q�5�      $��Log In��5�      $
��14px(�5�      $��SemiBold"�5�      
���������5�      Z� ��5�      �� 5�      $ /Images/btn login.png��6!   5�      5�      5�      5�      