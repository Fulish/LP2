   M S B A M L   `   `   `  ����F  BTrabalhoLP2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrabalhoLP2.ViewsTrabalhoLP2.Views  5      (    "TrabalhoLP2.Views.CriarProjetoPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TrabalhoLP2.Views     5        N� Title$  CriarProjetoPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.4* �6   6,   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��2��6   $��3��61   $1��+/TrabalhoLP2;component/Images/Back_wood.jpg��6B   $
��Fill=�6w   6�   �� 5   
   -   5        $��
TituloGrid��5      $��0��6"   
�������$��2��6B   $��Center=�6V   $��36(�6t   $��DemiBold"�6�   $��Criar Projeto Page��6�   
������ 6�   �� 5   
   -   5        $��InfoProjetoStack��5      $��1��6-   $��2��6:   $��Center=�6N   $��Center=�6k    �� Orientation$ Vertical=�6�   .+�5      �� $ 
Horizontal=�6   .+�5       �� $��Nome Projeto��6   $��15(�6/   
�������6R   �� 5!      -   5        $��NomeProjeto��5!      $��21��6-   $��0,0,0,3q�69   $��80��6J   6W   �� 5"      $��Descrição��6   $��15(�6,   $��35,0,0,0q�6:   
�������6a   �� 5#      -   5        $��DescricaoProjeto��5#      $��21��62   $��0,0,0,3q�6>   $��80��6O   6\   �� 5$      $��Nome Comprador��6   $��15(�61   $��35,0,0,0q�6?   
�������6f   �� 5%      -   5        $��	OwnerName��5%      $��21��6+   $��0,0,0,3q�67   $��80��6H   6U   5&      �� 5'      -   5        $��Criar Projeto��5'   5    J� Opacity$	 0.9Q�6M   $��25��6[   $	��150��6g   $��15(�6s   $��0,65,0,0q�6�   
�������6�   5(      �� 5+   
   -   5        $��CriarTarefaButton��5+   %   $y�Hidden=�6   $��1��6>   $��0��6K   $	��100��6[   
������ 
�������$	��220��6�   $��Criar Nova Tarefa��6�   
������ $��Stretch=�6�   $��20(�6  $��Italic$�6$  $��0,0,10,0q�67  $��Stretch=�6I   J� OpacityMask 5,      !� 5-       !� Visual 5.      � 5/      ��6   ��  �� Path$ ActualWidth� �� RelativeSource �� *FindAncestor+	 �� AncestorType$	 ButtonL�
 �� AncestorLevel$
 1����6�   �� $ ActualHeight� �� *FindAncestor+$	 ButtonL�$
 1��.+�50      A� 
���   �6&   51      53      55      �� 57   
   -   5        $��RelatarBuggButton��57   %   $y�Hidden=�6   $	��100��6>   
������ 
�������$	��220��6�   $��1��6�   $��1��6�   $��Relatar Bugg��6�   
������ $��Stretch=�6�   $��20(�6  $��Italic$�6  $��Stretch=�60   58      !� 59       5:      � 5;      ��6   �� $ ActualWidth� �� *FindAncestor+$	 ButtonL�$
 1����6�   �� $ ActualHeight� �� *FindAncestor+$	 ButtonL�$
 1��.+�5<      A� 
���   �6&   5=      5?      5A      �� 5C   
   -	   5        $��CriarSprintButton��5C   %   $y�Hidden=�6   $��2��6>   $��0��6K   $	��100��6[   
������ 
�������$	��220��6�   $��Criar Novo Sprint��6�   
������ $��Stretch=�6�   $��20(�6  $��Italic$�6$  $��0,0,10,0q�67  $��Stretch=�6I   5D      !� 5E       5F      � 5G      ��6   �� $ ActualWidth� �� *FindAncestor+$	 ButtonL�$
 1����6�   �� $ ActualHeight� �� *FindAncestor+$	 ButtonL�$
 1��.+�5H      A� 
���   �6&   5I      5K      5M      �� 5O   
   -
   5        $��FazerEquipaButton��5O   %   $y�Hidden=�6   $��2��6>   $��1��6K   $	��100��6[   
������ 
�������$	��220��6�   $��Fazer Equipa��6�   
������ $��Stretch=�6�   $��20(�6  $��Italic$�6  $��0,0,10,0q�62  $��Stretch=�6D   5P      !� 5Q       5R      � 5S      ��6   �� $ ActualWidth� �� *FindAncestor+$	 ButtonL�$
 1����6�   �� $ ActualHeight� �� *FindAncestor+$	 ButtonL�$
 1��.+�5T      A� 
���   �6&   5U      5W      5Y      �� 5[   
   -   5        $��GravarProjetoButton��5[   %   $y�Hidden=�6   $��2��6@   $	��100��6T   
������ 
�������$	��220��6�   $��2��6�   $��Gravar Projeto��6�   
������ $��Center=�6�   $��20(�6  $��Italic$�6(  $��Bottom=�6;   5\      !� 5]       5^      � 5_      ��6   �� $ ActualWidth� �� *FindAncestor+$	 ButtonL�$
 1����6�   �� $ ActualHeight� �� *FindAncestor+$	 ButtonL�$
 1��.+�5`      A� 
���   �6&   5a      5c      5e      5f      5g      