   M S B A M L   `   `   `  ����F  BTrabalhoLP2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrabalhoLP2.ViewsTrabalhoLP2.Views  5      !    TrabalhoLP2.Views.AdminPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TrabalhoLP2.Views     5        N� Title$  	AdminPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��3��6   $1��+/TrabalhoLP2;component/Images/Back_wood.jpg��6.   $
��Fill=�6c   6t   �� 5   
   $��0��6   
�������$��Center=�60   $��36(�6N   $��DemiBold"�6\   $��
Admin Page��6r   
������ 6�   �� 5   
   -   5        $��Stack��5   )   $y�Hidden=�6    �� Orientation$ 
Horizontal=�66   $��0��6O   $��0,30,0,0q�6\   $��Center=�6n   $��Center=�6�   .+�5      �� -   5         J� Opacity$	 0.9Q�5   5   $��25��6C   $	��100��6O   $��14(�6[   $��Center=�6i   $��Criar utilizador��6�   6�   �� 5      
�������$��15,0,0,0q�6'   $��Center=�69   $��13(�6V   $
��Nome��6d   6u   �� 5      -   5        $��NomeNovoUtilizador��5   g   
�������$	 0.7Q�6)   $	��100��67    �� TextAlignment$ Justify=�6C   $��25��6[   
������ 6�   �� 5      -   5        $��ProgramadorButton��5      $	 0.9Q�6P   $��15,0,0,0q�6^   $��25��6p   $��85��6|   $��14(�6�   $��Programador��6�   6�   �� 5      -   5        $��DesignerButton��5      $	 0.9Q�6J   $��5,0,0,0q�6X   $��25��6i   $��85��6u   $��14(�6�   $��Designer��6�   6�   �� 5      -   5        $��ScrumMasterButton��5      $	 0.9Q�6P   $��5,0,0,0q�6^   $��25��6o   $��90��6{   $��14(�6�   $��Scrum Master��6�   6�   �� 5      -   5        $��ProjectOwnerButton��5      $	 0.9Q�6R   $��5,0,0,0q�6`   $��25��6q   $��93��6}   $��14(�6�   $��Project Owner��6�   6�   �� 5       -   5        $��ProjectManagerButton��5       $	 0.9Q�6V   $��5,0,0,0q�6d   $��25��6u   $	��106��6�   $��14(�6�   $��Project Manager��6�   6�   5!      �� 5"   
   -	   5        $��
OpcaoCriar��5"   $   
�������$��5��66   $��0��6b   $��Center=�6o   $	��170��6�   $��40��6�   $��17(�6�   $��0q�6�   
������ $��0,10,0,0q�6�   $��Criar Novo Utilizador��6�   6  �� 5$   
   -
   5        $��VerUtilizadores��5$   $   
�������$��5��6;   $��0��6s   $��Bottom=�6�   $	��170��6�   $��40��6�   $��17(�6�   $��0q�6�   
������ $��0,0,0,15q�6�   $��Ver Utilizadores��6   6  �� 5&   
   $ 
Horizontal=�6   $��1��6.   $��Center=�6;   $��Center=�6V   .+�5'   
   �� -   5        $��CriarProjetoButton��5'      $��1��6+   $	��100��68   
������ 
�������$	��220��6�   $��Criar Novo Projeto��6�   
������ $��Stretch=�6�   $��20(�6�   $��Italic$�6  $��0,0,10,0q�6  $��Stretch=�6&   J� OpacityMask 5(      !� 5)       !� Visual 5*      � 5+      ��6   ��  �� Path$ ActualWidth� �� RelativeSource �� *FindAncestor+	 �� AncestorType$	 ButtonL�
 �� AncestorLevel$
 1����6�   �� $ ActualHeight� �� *FindAncestor+$	 ButtonL�$
 1��.+�5,      A� 
���   �6&   5-      5/      51      �� 53      -   5        $��VerProjetosButton��53      $	��100��6.   
������ 
�������$	��220��6�   $��2��6�   $��Ver Projetos��6�   
������ $��Stretch=�6�   $��20(�6�   $��Italic$�6�   $��Stretch=�6   54      !� 55       56      � 57      ��6#   �� $ ActualWidth� �� *FindAncestor+$	 ButtonL�$
 1����6�   �� $ ActualHeight� �� *FindAncestor+$	 ButtonL�$
 1��.+�58   "   A� 
���   �6*   59      5;      5=      5>      5A      5B      