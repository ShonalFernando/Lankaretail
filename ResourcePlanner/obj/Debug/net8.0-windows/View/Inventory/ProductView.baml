   M S B A M L   `   `   `  ����J  FResourcePlanner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ResourcePlanner.View.InventoryResourcePlanner.View.Inventory  5      0    *ResourcePlanner.View.Inventory.ProductView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:ResourcePlanner.View.Inventory     5      S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5        N� Title$  ProductView��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   
 � Tag$ Main Content��6*   �� 5      $	��300 �6   $ Editor��6+    � RowDefinitions 5   
   �� 5      $��70 �6   $ Header��6(   �� 5      $��35 �6   $ Menu Bar��6(   �� 5      $��1* �6   $ Content��6(   �� 5      $��30 �6   $ 
Status Bar��6(   .+�5   
   �� $��2��6   ���	#FF4AB8FF �� Orientation$ 
Horizontal=�6@   .+�5      �� $*��$/Assets/Icons/icons8-products-90.png��6   $��15q�6B   �� 5      $��Products��6   $��36(�6(   
�������$��5,10,0,0q�6I   5      �� 5   
   $��1��6   $��2��6"   ���	#FF88D0FF5      �� 5!   
   $��1��6   $��2��6%   $ Vertical=�62   .+�5"      �� $��Add Product��6   $��10q�6+   $��28(�67   $��Segoe UI Semilight)�6E   �� 5%      $��Product Name��6   $��	10,10,0,0q�6,   $��14(�6?   �� 5&      $��	10,5,10,0q�6   ��6)   �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5)      $��Category��6   $��	10,10,0,0q�6(   $��14(�6;   �� 5*      $��	10,5,10,0q�6    �� DisplayMemberPath$ CategoryName��5-       �� SelectedValuePath$ 
CategoryId��5.      	 �� SelectedItem	 5+      �� *SelectedCategory+$ TwoWay=���5,      �� *CategoryList+
 �� SelectedValue
 5/      �� *
CategoryId+�� 52      $��Description��6   $��	10,10,0,0q�6+   $��14(�6>   �� 53      $��	10,5,10,0q�6    �� AcceptsReturn$
 True��55      $	��100��56       �� TextWrapping$
 Wrap=�57      ��54      �� *Description+$ TwoWay=�57      �� 5:      $��Add Product��6   $��Stretch=�5<      $��
10,30,10,0q�5=         ButtonPrimary#���   5>      ��5;      �� *AddProductCommand+5>      5?      &   System.Windows.Controls.DataGrid  5A   
   $��2��6   5B      5C      