   M S B A M L   `   `   `  ����B  >WPF_SQL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_SQLWPF_SQL  5          WPF_SQL.CelebrationTable   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WPF_SQL     5        N� Title$  CelebrationTable��5	       N� 
Background 5      �� 5   
    �� Opacity$ 0Q�6   .��5      � .+�5   
   �� .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $
��Left=�6   $ 
Horizontal=�68   .+�5      �� $��15(�6    $��Center=�6.   $��5,12,5,0q�6K   Фильтры6f   �� 5      $��Выбирите цвет��6   .��5      �� -   5        $��CBColors��5   #   6c   5      �� 5      $%��Введите значение��6   .��5      �� -   5        $��
TBOXSearch��5   "   $	��150��64   6i   5      �� 5      $��Галочка��6   .��5      �� -   5        $��CheckBAllPhoto��5   #   .��6�   Только джинсы6�   5      5      �� 5      $
��Left=�6   $ 
Horizontal=�68   .+�5       �� $��15(�6    $��Center=�6.   $��5,12,5,0q�6K   Сортировка6i   �� 5!      $#��Выбирите способ��6   .��5"      �� -   5        $��CBSort��5"   #   .@�5#      �� $��По цвету��6+   �� 5$      $��По дате��6+   �� 5%      $��По имени��6+   5&      5'      �� 5(      -   5        $	��BUp��5(      $��25��6(   $��25��64   $��0,10,5,0q�6?   $	��↑��6Q   6]   �� 5)      -   5        $��BDown��5)      $��25��6*   $��25��66   $��0,10,0,0q�6A   $	��↓��6S   6_   5*      5+      �� 5,      -   5        $��LVCelebration��5,      $��Disabled=�6-   $	��250��6c   $
��Auto=�6p   ��5-      �� 55       �� Color$
 Gray��6&   $ 0Q�63   ��57      �� 58      .R�59      � 5:      ��5<      �� 5=      .R�5>      �� 
�������$��2q�65   ��6I   �� *	ColorDate+._�5?      �� $	��360��6)   .+�5@   "   �� $ 
Horizontal=�6-   .+�5A   &   ��    Stblockorder#��[  6E   ��60   �� *FIO+6E   5B   #   �� 5C   "   #��[  6g   ��6,   �� *
party_date+ �� StringFormat$ {0:dd.MMM.yyyy}��6g   �� 5E   "   $ 
Horizontal=�6-   .+�5F   &   �� #��[  6N   ��60   �� *Parties.name+6N   �� 5G   &   $�� ��60   �� 5H   &   #��[  6E   ��60   �� *AGE+6E   �� 5I   &   $�� ��60   5J   #   �� 5K   "   $ 
Horizontal=�6-   .+�5L   &   �� -   5        $��Удалить��5L   b   $
��Left=�6t   
 J� Uid 6-   �� *id+��6@   �� *	ColorCell+6�   �� 5M   &   -	   5        $ ��Редактировать��5M   a   $
��Left=�6y   $��10,0,0,0q�6�    6-   �� *id+��6@   �� *	ColorCell+6�   5N   #   5O      5P      5Q      5S      �� 5T      -
   5        $
��Ladd��5T        
Slableback#��[ 6    $#��Добавить запись��6D   6^   �� 5U      -   5        $��Lback��5U      #��[ 6!   $��
Назад��6E   6U   �� 5V      $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5W      �� -   5        $��PginPrev��5W      $
 prev��6,   $�� Пред. ��67   6F   �� 5X      -   5        $��Pagin1��5X      $ 1��6*   ��62   ��  �� Path$ NPage[0]�$ {0,3}��y�6j   �� *
Visible[0]+��6�   �� *	Bold[0]+6�   �� 5Y      -   5        $��Pagin2��5Y      $ 2��6*   ��62   �� $ NPage[1]�$ {0,3}��y�6j   �� *
Visible[1]+��6�   �� *	Bold[1]+6�   �� 5Z      -   5        $��Pagin3��5Z      $ 3��6*   ��62   �� $ NPage[2]�$ {0,3}��y�6j   �� *
Visible[2]+��6�   �� *	Bold[2]+6�   �� 5[      -   5        $��Pagin4��5[      $ 4��6*   ��62   �� $ NPage[3]�$ {0,3}��y�6j   �� *
Visible[3]+��6�   �� *	Bold[3]+6�   �� 5\      -   5        $��Pagin5��5\      $ 5��6*   ��62   �� $ NPage[4]�$ {0,3}��y�6j   �� *
Visible[4]+��6�   �� *	Bold[4]+6�   �� 5]      -   5        $��	PaginNext��5]      $
 next��6-   $��
 След.��68   6F   �� 5_      -   5        $��PaginCountAllOrders��5_      $��5,0,0,0q�6d   $��40��6v   6�   5`      5a      5b      5c      