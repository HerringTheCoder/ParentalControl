   M S B A M L   `   `   `  ����J  FParentalControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ParentalControlParentalControl  5   	   !    ParentalControl.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ParentalControl     5   	     � Title$  ParentalControl��5   	   $	��160��6!   $	��320��6.    � WindowStyle$
 None=�6:    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ NoResize=�6r   .��5	      �� .+�5   
   �� -   5         ��Name$ 
LoginPanel��5      .+�5   
   �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��20,0,0,0q�6$   Login:6>   5      �� 5   
   -   5         ��Name$ loginBox��5      $��20��6;   $	��280��6G   $��20,0,0,0q�6S   $
��Left=�6f   ��6$   �� *Login+6�   �� 5   
   $��0��6   $��20,0,0,0q�6$   	Password:6A   G� 5      -   5         G�Name$ passwordBox��5      $��20��6S   $	��280��6_   $��20,0,0,0q�6k   $
��Left=�6~   � 5       5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ LoginButton��5      $��Login��6D   {�.  $��0��6f   $	��120��6v   $��30��6�   $
��Left=�6�   $��	20,20,0,0q�6�   �� 5      -   5        $ 
BackButton��5      $
��Back��6B   $��1��6Q   $	��120��6a   $��30��6m   $
��Left=�6y   $��	30,20,0,0q�6�   5      5      5!      5"      