   M S B A M L   `   `   `  ����I  ELankaretailERP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LankaretailERP.ViewLankaretailERP.View  5   	   (    "LankaretailERP.View.AuthMasterView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   \ XPrism.Unity.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59V RPrism.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   6P   /local!clr-namespace:LankaretailERP.View   5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True69    � Title$ AuthMasterView��5   	   $	��450��6    $	��800��6-    � WindowStyle$
 None=�69    � 
ResizeMode$ NoResize=�6L    � Topmost$
 True��6b    � WindowStartupLocation$ CenterScreen=�6q    � AllowsTransparency$
 True��6�   ��6�   Z� .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��7* �6   �� 5      $��6* �6   .+�5   
   ��  �� CornerRadius$ 	15,0,0,15��6   ��5      �� 5      	 �� ImageSource$)	 #/Assets/img/Defaults/Carrousel1.png��6   
 j� Stretch$

 Fill=�6O   5      �� 5   
   $ 	0,15,15,0��6   $��1��6*   ��5      
� 5       
� Center$ 0.5,0.5&�6&    
� GradientOrigin$	 0,1&�67   .��5      �  � Color$ 	#FF113653��6#   � 5      $ 	#FF0C2A40��6#    � Offset$ 1Q�65   5      ._�5      �  5      �� 5      $��1* �6'   �� 5      $��1* �6'    � RowDefinitions 5!      �� 5"      $	��30* �6$   �� 5#      $	��75* �6$   �� 5$      $	��40* �6$   .+�5'      �� $��Sign In��6   ���	#FFEDEDED$��Segoe UI Semilight)�6o   $��94��6�   $	��184��6�   $��16(�6�   ��6+   Z� ��6A   Z� 6�   �� 5(      $��Sign Up��6   $��1��6+   ���	#FF989898$��Segoe UI Semilight)�6   $��16(�6�   $��90��6�   $	��184��6�   ��6;   Z� ��6Q   Z� 6�   �� 5+      ,  &Prism.Navigation.Regions.RegionManager   
RegionName$ 
AuthRegion��6!   $��1��6M   $��2��6Z   �� 5-      $��2��6   $��2��6*   $��Center=�6>   $��Center=�6Y   .+�5.      �� $��Lankaretail��6    $��18(�63   ���	#FF8ABCFF$��Eras ITC)�6X   $��Center=�6n   �� 5/      $!��Your Premium Retail Partner��6    $��12(�6C   ���	#FF8ABCFF$��Eras ITC)�6h   $��Center=�6~   �� 50       �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��0,25,0,0q�6X   .+�51      �� $��Privacy | About | Terms��6!   ���	#FF68A3F1��6C   Z� ��6Y   Z� 6p   �� 52      $
��Exit��6!   $��10,0,0,0q�60   ���	#FF68A3F1��6B   Z� ��6X   Z� ��6�   �� *ExitCommand+53      54      55      56      57      58      