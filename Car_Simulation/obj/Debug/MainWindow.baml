   M S B A M L   `   `   `  ����I  ECar_Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Car_SimulationCar_Simulation  5   	       Car_Simulation.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Car_Simulation     5   	   -   5          � Title$  Ignition Controls��5   	   $	��350��6#   $	��550��60   
����İ� � 
ResizeMode$ NoResize=�6X   .��5	      � .+�5
   
   �� -   5         ��Name$
 lbl1��5
      $��Car Simulation��6   $��Center=�67   $��0,10,0,0q�6T   $	��Top=�6f   $��Center=�6~   $��Center=�6�   $��18(�6�   
�������
���  ��$��2q�6�   �� 5   
   -   5         ��Name$ 
lbIgnition��5      $��210,129,205,107q�6&   
������
��� � �$��2q�6k   .@�5      	� -   5         	�Name$ rdnEngineOff��5      $	��Off��60   6>   	� 5      -   5        $ rdnEngineIgnition��5      $��Ignition��65   6H   	� 5      -   5        $ rdnEngineOn��5      $��On��6/   6<   5      �� 5   
   -   5        $ 
lbKeyInOut��5      $��39,129,376,107q�6&   
������
��� � �$��2q�6j   .@�5      	� -   5        $ 	rdnKeyOut��5      $��Key Out��6-   6?   	� 5      -	   5        $ rdnKeyIn��5      $��Key In��6,   6=   5      �� 5   
   -
   5        $ lbDomeLight��5      $��373,129,42,107q�6'   
������
��� � �$��2q�6k   .@�5      	� -   5        $ 
rdnDomeOff��5      $	��Off��6.   6<   	� 5      -   5        $ rdnDomeAuto��5      $
��Auto��6/   6>   	� 5      -   5        $ 	rdnDomeOn��5      $��On��6-   6:   5      �� 5   
   -   5        $
 lbl2��5      $��Key In / Out��6   $
��Left=�65   $��
64,101,0,0q�6P   $	��Top=�6d   $��85��6|   $��14(�6�   $��Center=�6�   �� 5   
   -   5        $
 lbl3��5      $��Ignition��6   $
��Left=�61   $��235,101,0,0q�6L   $	��Top=�6a   $��85��6y   $��14(�6�   $��Center=�6�   �� 5   
   -   5        $
 lbl4��5      $��Dome Lights��6   $
��Left=�64   $��395,101,0,0q�6O   $	��Top=�6d   $��91��6|   $��Center=�6�   $��14(�6�   �� 5   
   -   5         ��Name$ btnCarControls��5      $��Car Controls��6)   $
��Left=�6@   $��144,247,0,0q�6[   $	��Top=�6p   $��30��6�   $��98��6�   
���z���
���  ��$��2q�6�    � ToolTip 5      �� 5      .+�5       �� $
��Bold"�6    ;9Click this button to enter control the actions in the car6m   5!      5#      �� 5%   
   -   5        $ 
btnTurnOff��5%      $��Turn Off��6%   $
��Left=�68   $��311,247,0,0q�6S   $	��Top=�6h   $��30��5&      $��98��6   
���z���
���  ��$��2q�6S   6g   5'      5(      