   M S B A M L   `   `   `  ����F  BTrabalhoLP2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrabalhoLP2.ViewsTrabalhoLP2.Views  5      '    !TrabalhoLP2.Views.CriarTarefaPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TrabalhoLP2.Views     5        N� Title$  CriarTarefaPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.4* �6   6,   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��2��6   $��3��61   $1��+/TrabalhoLP2;component/Images/Back_wood.jpg��6B   $
��Fill=�6w   6�   �� 5   
   -   5        $��
TituloGrid��5      $��0��6"   
�������$��2��6B   $��Center=�6V   $��36(�6t   $��DemiBold"�6�   $��Criar Tarefa Page��6�   
������ 6�   �� 5   
   -   5        $��InfoTarefaStack��5      $��1��6,   $��3��69   $��2��6J   $��Center=�6^   $��Center=�6{    �� Orientation$ Vertical=�6�   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Nome Tarefa��6   $��15(�6.   
�������6Q   �� 5       -   5        $��
NomeTarefa��5       $��21��6,   $��0,0,0,3q�68   $��80��6I   6V   �� 5!      $��Descrição��6   $��15(�6,   $��35,0,0,0q�6:   
�������6a   �� 5"      -   5        $��DescricaoTarefa��5"      $��21��61   $��0,0,0,3q�6=   $��80��6N   6[   5#      �� 5%      -   5        $��ProgramadoresStack��5%   +   $��0,40,0,0q�6   $��0��6E   $��2��6U   $	��Top=�6b   $
��Left=�6z   $ Vertical=�6�   .+�5&      �� $��Programadores:��6   $��14(�61   
�������$��
120,0,0,20q�6R   6h   5'      �� 5)      -   5        $��DesignersStack��5)      $��1��6/   $��2��6?   $	��Top=�6L   $
��Left=�6d   $ Vertical=�6   .+�5*      �� $��
Designers:��6   $��14(�6-   
�������$��
120,0,0,20q�6N   6d   5+      �� 5,      -   5        $��Criar Tarefa��5,   7    J� Opacity$	 0.9Q�6N   $��25��6\   $	��150��6h   $��15(�6t   $��0,65,0,0q�6�   
�������6�   5-      �� 5/   
   -   5        $��EditarTarefa��5/   )   $y�Hidden=�6   $��1��6=   $��3��6J   $��2��6[   $��Center=�6o   $��Center=�6�   $ Vertical=�6�   .+�50      �� -	   5        $��NomeTarefaDefinitivo��50      $��18(�61   
�������$��Nome Tarefa: ��6R   6l   �� 51      -
   5        $��DescricaoDefinitiva��51      $��18(�60   
�������$��Descrição: ��6Q   6i   �� 52      -   5        $��UserNome��52      $��18(�6%   
�������$��User Tarefa: ��6F   6`   �� 53      -   5        $��CriarSubtarefasButton��53      $��1��62   $��0��6?   $	��100��6O   
������ 
�������$	��220��6�   $��Criar Nova SubTarefa��6�   
������ $��Stretch=�6�   $��20(�6  $��Italic$�6  $��0,30,0,0q�61  $��Stretch=�6C   J� OpacityMask 54      !� 55       !� Visual 56      � 57      ��6#   ��  �� Path$ ActualWidth� �� RelativeSource �� *FindAncestor+	 �� AncestorType$	 ButtonL�
 �� AncestorLevel$
 1����6�   �� $ ActualHeight� �� *FindAncestor+$	 ButtonL�$
 1��.+�58   "   A� 
���   �6*   59      5;      5=      5>      5?      5@      