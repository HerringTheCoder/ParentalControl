   M S B A M L   `   `   `  ����J  FParentalControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ParentalControlParentalControl  5   	        ParentalControl.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ParentalControl     5   	     � Title$  Parental Control��5   	   $	��300��6"   $	��600��6/   
������� � WindowStartupLocation$ CenterScreen=�6N    � 
ResizeMode$ NoResize=�6s   .��5	      �� .+�5
   
   �� $��Control Panel��6   $
��Bold"�6'   $��Center=�69   $��15(�6V   �� 5   
   � 5   
    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��5 �6#   �� 5      $��* �6#   .+�5      �� $��0��6   .+�5      �� $��Center=�6U   $��0,10,0,0q�6r   ��6   �� *Login+ �� StringFormat$ Logged in as: {0}��6r   �� 5      -   5         ��Name$ 	ShowLogin��5      $��Login��6J   $��20��6Z   $	��150��6f   $��10q�6r   5      �� 5      $��1��6    �� Orientation$ 
Horizontal=�6)   .+�5      �� #��["�6   5      �� 5      $��2��6   .+�5      �� $��Set a lock timer: ��6   $��0,10,0,0q�66   $��Center=�6H   �� 5       -   5         ��Name$ LockTimerBox��5        �� 
IsEditable .  $	��150��6�   {�61   �� *AccessGranted+	 �� Text	 6U   �� *
TimeLeft+.@�5!      �� 
 �� 
IsSelected
 . .��65   568   �� 5"      .��6#   156'   �� 5#      .��6#   306'   �� 5$      .��6#   606'   �� 5%      .��6#   906'   �� 5&      .��6#   1206(   5'      �� 5(      -   5        $ LockActivationButton��5(      $��Activate Lock��6Z   $��20��5)   =   $	��150��6I   $��10q�6U   {�6   �� *AccessGranted+6U   5*      5+      �� 5-   
   #��["�6   �� 5.   
   
������$��WARNING��61   $��Center=�6@   $��15(�6]   $��Heavy"�6k   �� 5/   
   $��15(�6   $
��Wrap=�6"   $����Letting your child play video games over 60 minutes a day will make him an addict...                    and possibly an upcoming terrorist.��66   $��10q�50   9   $��Center=�6E    �� TextAlignment$ Justify=�6`   51      52      