   M S B A M L   `   `   `  ����W  SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   BaseDataGrid  �� 
TargetType&    System.Windows.Controls.DataGrid �� Property �� Value ) %DataGridColumnHeaderTextBlockTemplate �� TextAlignment ( $DataGridColumnHeaderCheckBoxTemplate d� 	IsChecked �� UpdateSourceTrigger �� Mode �� RelativeSource �� Mode	 �� AncestorType
 �� Triggers �� Binding �� Value  DataGridCheckBoxStyle " DataGridSelectionCheckBoxStyle �� BasedOn�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        &	     &	 �    &	 �    &	 q    7  �� 5      "    6!   .�5   
   ��  �@  AutoGenerateColumns$ False��60   �� 5   
    �@  CanUserAddRows$ False��6+   �� 5   
    �@  CanUserDeleteRows$ False��6.   �� 5   
    �@  CanUserReorderColumns$ False��62   �� 5	   
    �@  CanUserResizeColumns$ False��61   �� 5
   
    �@  CanUserResizeRows$ False��6.   �� 5   
    �@  CanUserSortColumns$ False��6/   �� 5   
    �@  HeadersVisibility$ Column=�6.   �� 5   
    � ��$ 26(�6%   5      �� 5      .R�5   
   �� $��19(�5      $
��Wrap=�5      $ Center=�5      ��5      �� 5      5      �� 5      .R�5   
   �� 
���   �$��2q�5       5      �� *DataContext.IsAllSelected+$ PropertyChanged=�$ TwoWay=� �� $ FindAncestor=�"	   ��5      �� *'%DataContext.ChangeAllSelectionCommand+ �� $ FindAncestor=�"	   ��5      �� 5      "  ��6   .�5      ��  � {�$
 True��62   
 5      �� 5        6&   �� *DataContext.Enrollees.Count+ �� $ FindAncestor=�"	    06�   .a�5!      ��  � {�$ False��6:   5"      5$      5&      5'      �� 5)      "  ��6*   .�5*   
   ��  � ��$ Center=�6.   �� 5+   
    � ��$ Center=�60   �� 5,   
    � ��$ 2q�6,   �� 5-   
    � ��
 �   �6(   5.      �� 50      "  ��63   8   .�51   
   ��  �@d�	IsChecked 6&   �� *
IsSelected+$ PropertyChanged=�$ TwoWay=��� 52   
    � �� 6$   �� *(&DataContext.ChangeItemSelectionCommand+ �� $ FindAncestor=�"	   �� 53   
    � �� 6-   �� 54      55      