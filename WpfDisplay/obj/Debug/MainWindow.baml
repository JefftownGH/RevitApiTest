   M S B A M L   `   `   `  ����E  AWpfDisplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfDisplay
WpfDisplay  5   	       WpfDisplay.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfDisplay     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Title$  Information��5   	   $	��560��6   $	��810��6*      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5       5      �� 5      $E ?pack://application:,,,/WpfDisplay;component/MaterialDesign.xaml?�6   %    5      .��5      �  � RowDefinitions 5      �� 5      $
��487* �6   �� 5      $	��34* �6   .+�5       �� -   5         ��Name$ textBox��5       
����İ�$��5q�6:   $��	30,47,0,0q�6N   $��38��6a   $	��Top=�6m   $
��Left=�6�   $	��262��6�   .��6�   Input name or guid6�   �� 5!      -   5         ��Name$ filterButton��5!      $��filter��6!   $��
83,104,0,0q�62   $
��Left=�6\   $	��137��6w   $��27��6�   $	��Top=�6�   �� 5"      -   5        $ showAllButton��5"      $��show all elements��6"   $��
83,158,0,0q�6U   $
��Left=�6i   $	��137��6�   $��27��6�   $	��Top=�6�   �� 5#      
�������
�������$��1q�6:   $��320,0,-0.4,0q�6N   $
��Left=�6d   $	��474��6   $	��487��6�   $	��Top=�6�   ._�5$      �� $��10q�6   .+�5%      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dataGrid��5%      
   AutoGenerateColumns
 .  $	��465��6=      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$
 Name�  5(      $
 GUID��6    6)   �� $ Id�5*      5+      5,      #  MaterialDesignThemes.Wpf.Card  5.      $��0��6   $��
30,237,0,0q�6%   $
��Left=�69   $	��262��6T   $	��151��6`   $	��Top=�6m   
�������.��5/      �� $��Images/RevitBuilding.png��6   60   50      51      52      