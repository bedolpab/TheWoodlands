   M S B A M L   `   `   `  ����  TheWoodlands    TheWoodlands.GameHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  GameHome��5      .��5      � -   5         �Name$ GameHomePageGrid��5   	   ���#111111 � ColumnDefinitions 5      �� 5      $
��0.8* �6   �� 5      $
��0.2* �6   .+�5      �� $��0��6   ���#1111116    �� 5      $��1��6   ���#A2BDA46    �� 5      -   5         ��Name$ SpriteImage��5      $��1��63   $	��121��6C   $	��229��6O   $��17, 24, 15, 271q�6\   ��6!   Z� 6\   �� 5      -   5         ��Name$ UserName��5      $��1��6"   ���#000000$
��Bold"�6G   $��Arial)�6Y   $��17(�6l   $��10,290,10,234q�6z    �� TextAlignment$ Center=�6�   $
��Wrap=�6�   ��6�   Z� 6�   �� 5      -   5         ��Name$ LocationsBtn��5      $��1��6=   ���#111111���#FAFAFA$��Arial)�6w   $��17(�6�   $	��109��6�   $��39��6�   $��21, 329, 23, 159q�6�   $��	Locations��6�    � 	Resources 5        �� 
TargetType	 �� Property
 �� Value �� Triggers P� Property P� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color   Opacity   
BlurRadius��%  '��       �� 5!   
   " ��6   .�5"      �� 	 �@��CornerRadius$
 15��6+    5$      P� 5%       �@J�IsMouseOver . . �5&      �� 	 �@J�Effect
 5'        5(      $ 0Q�6%   $ Black��65   $ 10Q�6C   $ 8Q�6P   5*      5+      5-      5.   	   5/      �� 53      -   5        $ InventoryBtn��53      $��1��6>   ���#111111���#FAFAFA$��Arial)�6x   $��17(�6�   $	��109��6�   $��39��6�   $��21, 371, 23, 114q�6�   $��	Inventory��6�    54      ��%  '��       �� 55   
   " ��6   .�56      �� 	 �@��CornerRadius$
 15��6+    58      P� 59       �@J�IsMouseOver . . �5:      �� 	 �@J�Effect
 5;        5<      $ 0Q�6%   $ Black��65   $ 10Q�6C   $ 8Q�6P   5>      5?      5A      5B   	   5C      �� 5F      -   5        $ SettingsBtn��5F      $��1��6<   ���#111111���#FAFAFA$��Arial)�6v   $��17(�6�   $	��109��6�   $��39��6�   $��21, 416, 23, 69q�6�   $��Settings��6�    5G      ��%  '��       �� 5H   
   " ��6   .�5I      �� 	 �@��CornerRadius$
 15��6+    5K      P� 5L       �@J�IsMouseOver . . �5M      �� 	 �@J�Effect
 5N        5O      $ 0Q�6%   $ Black��65   $ 10Q�6C   $ 8Q�6P   5Q      5R      5T      5U   	   5V      �� 5Y      -   5        $ MapBtn��5Y      $��1��62   ���#111111���#FFFFFF$��Arial)�6l   $��17(�6   $	��109��6�   $��39��6�   $��21, 461, 23, 24q�6�   $	��Map��6�    5Z      ��%  '��       �� 5[   
   " ��6   .�5\      �� 	 �@��CornerRadius$
 15��6+    5^      P� 5_       �@J�IsMouseOver . . �5`      �� 	 �@J�Effect
 5a        5b      $ 0Q�6%   $ Black��65   $ 10Q�6C   $ 8Q�6P   5d      5e      5g      5h   	   5i      �� 5m      -   5        $ LocationName��5m      $��0��6&   ���#FAFAFA$��Arial)�6K   $��25(�6^   $��30��6l   $��43,115,70,424q�6x   ��6�   Z� �� 5n      -	   5        $ LocationDescription��5n      $��0��6-   ���#FAFAFA$��Arial)�6R   $��17(�6e   $��84��6s   $��43,153,42,332q�6   $
��Wrap=�6�   ��6�   Z� 6�   �� 5o      -
   5        $ LocationImage��5o      $	��239��65   $��43,247,199,83q�6B   ��6#   Z� 6B   �� 5r      -   5         ��Name$ TaskListRectangleBoxBody��5r      ���#FAFAFA$	��156��6E   $	��239��6Q   $��438, 247, 26, 83q�6^   �� 5s      -   5        $ TaskListRectangleBoxHead��5s      ���#A2BDA4$	��156��6B   $��34��6N   $��438, 245, 26, 292q�6Z   �� 5v      -   5        $ TaskListTitle��5v      ���#111111$��Arial)�6<   $��17(�6O   $��20��6]   $��444,252,31,297q�6i   $��	Task List��6�   $ Center=�6�   �� 5w      -   5        $ Task0��5w      ���#FAFAFA$��Arial)�65   $��13(�6H   $	��154��6V   $��444,284,22,249q�6b   $
��Wrap=�6�   ��6z   Z� 6�   �� 5x      -   5        $ Task1��5x      ���#FAFAFA$��Arial)�65   $��13(�6H   $	��154��6V   $��444,308,22,246q�6b   $
��Wrap=�6�   ��6z   Z� 6�   �� 5y      -   5        $ Task2��5y      ���#FAFAFA$��Arial)�65   $��13(�6H   $	��154��6V   $��444,337,22,214q�6b   $
��Wrap=�6�   ��6z   Z� 6�   �� 5z      -   5        $ Task3��5z      ���#FAFAFA$��Arial)�65   $��13(�6H   $	��154��6V   $��444,364,22,189q�6b   $
��Wrap=�6�   ��6z   Z� 6�   �� 5{      -   5        $ Task4��5{      ���#FAFAFA$��Arial)�66   $��13(�6I   $	��154��6W   $��444,394,22,153q�6c   $
��Wrap=�6�   ��6{   Z� 6�   �� 5|      -   5        $ Task5��5|      ���#FAFAFA$��Arial)�66   $��13(�6I   $	��154��6W   $��444,421,22,116q�6c   $
��Wrap=�6�   ��6{   Z� 6�   �� 5      -   5        $ ViewItemsBtn��5      $��0��6>   $y�	Collapsed=�6N   ���#A2BDA4���#111111$��Arial)�6�   $��17(�6�   $	��183��6�   $��39��6�   $��43,491,394,39q�6�   .��6�   
View Items 5�      ��%  '��       �� 5�   
   " ��6   .�5�      �� 	 �@��CornerRadius$
 10��6+    5�      P� 5�       �@J�IsMouseOver . . �5�      �� 	 �@J�Effect
 5�        5�      $ 0Q�6%   $ White��65   $ 10Q�6C   $ 20Q�6P   5�      5�      5�      5�   	   5�      �� 5�      -   5        $ 
ViewNPCBtn��5�      $��0��6:   $y�	Collapsed=�6J   ���#A2BDA4���#111111$��Arial)�6�   $��17(�6�   $	��183��6�   $��39��6�   $��238,491,199,39q�6�   .��6�   Interact With Local 5�      ��%  '��       �� 5�   
   " ��6   .�5�      �� 	 �@��CornerRadius$
 10��6+    5�      P� 5�       �@J�IsMouseOver . . �5�      �� 	 �@J�Effect
 5�        5�      $ 0Q�6%   $ White��65   $ 10Q�6C   $ 20Q�6P   5�      5�      5�      5�   	   5�      5�      5�      