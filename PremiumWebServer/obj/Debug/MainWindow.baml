   M S B A M L   `   `   `  ����K  GPremiumWebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PremiumWebServerPremiumWebServer  5   	   I)clr-namespace:PremiumWebServer.ViewModelsPremiumWebServer.ViewModels  5   	   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fD2clr-namespace:MahApps.Metro;assembly=MahApps.MetroMahApps.Metro 5
   	   !    PremiumWebServer.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PremiumWebServer     5   	   ;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   
   2vm)clr-namespace:PremiumWebServer.ViewModels  5   	   ;
Converters*http://metro.mahapps.com/winfx/xaml/shared  5	   
   >metro2clr-namespace:MahApps.Metro;assembly=MahApps.Metro  5
   	   J FWpfAnimatedGif, Version=1.4.14.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	   \ XHardcodet.Wpf.TaskbarNotification, Version=1.0.5.0, Culture=neutral, PublicKeyToken=null)tb http://www.hardcodet.net/taskbar  5   	   -   5        $��Loging��5   $   $��1q�5   
     � Title$  Premium Web Server��5   	   $��381.276��62   $��242.448��6C    � WindowStartupLocation$ CenterScreen=�6S    J� SnapsToDevicePixels .  � Icon$ Contents/PwsIcon.ico��6�    � DataContext 5      1  +PremiumWebServer.ViewModels.LogingViewModel  5   
   -   5        
LoginModel��5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Resources/Icons.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5       $	��81* �6   �� 5!      $	��78* �6   �� 5"      $	��81* �6   	 � RowDefinitions	 5%   
   �� 5&      $	��34* �6   �� 5'      $	��45* �6   �� 5(      $	��39* �6   �� 5)      $	��86* �6   �� 5*      $	��42* �6   �� 5+      $
��103* �6   .+�5-   
   �� -   5        
 ��Name$
 	Validator��5-      $��3��6@   
���  ��$��Center=�6^   $��0,67,0,0q�6�   $��31��6�   $	��Top=�6�   $��2��6�   $��3��6�   ��6#   �� *
ValidTxt+6�   �� 5.   
   -   5        $
 label��5.      $��Premium Web Server��6   $��Center=�6<   $��Microsoft Sans Serif)�6`   $��19(�6�   $��	ExtraBold"�6�   ���#5bc0de$��1��6�   $��3��6�    J� Effect 5/      3  -System.Windows.Media.Effects.DropShadowEffect  50         ShadowDepth$ 1Q�6#   52      �� 53   
   -   5         ��Name$ CommandConfig��53      $��
18,74,0,10q�6(      MetroCircleButtonStyle#���   6^    � ToolTip$ 
Configurar��6�   $��3��6�   ���#66cff6$y�Hidden=�6�   $��2��6�   $
��Left=�6�   $��44��6  $��1��6  ��6<   �� *ConfigCommand+.��54      �� $��25��6   $��25��55      
������� J� OpacityMask 57      !� 58       j� Stretch$
 Fill=�6"     
appbar_cog !� Visual# �  59      5;      5<      �� 5=   
   -   5         ��Name$ txtuser��5=      $��26��6#   $��
42,10,29,0q�6/   $��3��6C    �� TextWrapping$
 Wrap=�6P   $	��Top=�6e   $��3��6�   ��6}   �� *	UserTxt+.��6�    5?       �� 
TargetType �� Property �� Value��%^   '��       �� 5@      " ��6   .�5A      ��  �@��CornerRadius$ 3��65   5B      5D      .��6!   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Nombre de Usuario��5E   c   .��5G      G� 5H   
   -   5         G�Name$ password��5H      $��26��6(   $��
42,41,29,0q�64   $��3��6H   $	��Top=�6V   $��3��6n    5I      ��%^   '��       �� 5J      " ��6   .�5K      ��  �@��CornerRadius$ 3��65   5L      5N      $ Clave��5O   W   5P      �� 5Q   
   -   5        $ button��5Q      $��Right=�6!   $��0,4,29,0q�6=   $��4��6O   $	��Top=�6\   $��75��6t   $��25��6    �� 	IsDefault . $��Ingresar��6�   $��1��6  $��2��6  ��6�   �� *IngresarCommand+��6�   ��  �� ElementName$ password��6  �� 5R   
   -	   5         ��Name$ t1��5R      $��0,0,29,0q�6    $��5��62   $��18��6?   $	��Top=�6K   $��Right=�6c   $��60��6   $��1��6�   $��2��6�   �� 6�   -
   5        $��http://www.google.com?�5R   �   .�6
  �� $�Registrarse��6  6$  60  �� 5S   
   -   5        $ t2��5S      $��	0,20,29,0q�6    $��5��63    J� RenderTransformOrigin$ -0.035,0.55&�6@   $��15��6d   $	��Top=�6p   $��Right=�6�   $��87��6�   $��1��6�   $��2��6�   �� 6�   -   5        $��http://www.google.com?�5S   �   .�6/  �� $�Olvido Su clave?��63  6N  6Z  3  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon  5T   
   -   5          Name$ MyTask��5T         MenuActivation$ 
RightClick=�5U         
IconSource$ ./Contents/PwsIcon.ico��5V          ToolTipText$  Premium Web Server��5W      $��3��5Z   B   !   DoubleClickCommand! 5Y      �� *ShowWindowCommand+""   DoubleClickCommandParameter" 5Z      �� $ Loging��# � ContextMenu# 5\      �� 5]      
�������.@�5_      m� $��
Configurar��6   $ m� Command$ 63   �� *ShowWindowCommand+% m� CommandParameter% 6Y   �� *principalwindow+m� 5`      $��Salir��6   $ 6/   �� *LogOutCommand+% 6Q   �� *principalwindow+5a      5d      �� 5e   
   -   5        & ��Name$& image��5e      $��1��6   $��2��6,   $��Contents/Logo copia.png��6=   $��
32,35,31,0q�6^   $��3��6r   �� 5f   
   -   5        $& 	imgLoader��5f      $
��Left=�6#   $��18��6>   $��	42,67,0,0q�6J   $��3��6]   $	��Top=�6j   $	��159��6�   "  WpfAnimatedGif.ImageBehavior'   AnimatedSource$' Contents/30.gif��6�   $
��Fill=�6�   $y�Hidden=�6�   $��3��6�   �� 5g   
   -   5        $
 Welcome��5g      $��
Bienvenido��6!   $��Center=�66   $��Microsoft Sans Serif)�6Z   $��19(�6|   $��	ExtraBold"�6�   ���#5bc0de$��3��6�   $��	0,13,0,45q�6�   $y�Hidden=�6�   $��3��6�    5h        5i      $ 1Q�6#   5k      �� 5l   
   -   5        $
 username��5l      $��3��6U   $��Center=�6b   $y�Hidden=�6�   $��	0,41,0,19q�6�   $��3��6�   ��6"   �� *UserLoged.username+( �� Mode$( OneWay=�6�   �� 5m   
   -   5        $ 	textBlock��5m      $
��Wrap=�6'   $��10(�6;   $��ExtraCondensed&�6I   ) �� TextAlignment$) Center=�6f   
����������	#FF424242$��0,43,0,0q�6�   $��5��6�   $��3��6�   �� 6�   $/�)Este Sistema esta protegido por las Leyes��6�   �� 6  $	� de��6  �� 6#  $� Autor��6'  �� 67  $� ��6;  �� 6F  $�I��6J  �� 6U  $�
nternacion��6Y  �� 6m  $�a��6q  �� 6|  $	�les��6�  �� 6�  $�.��6�  �� 6�  �� 6�  $�Ilogic Softwares��6�  �� 6�  $��Arial)�6�  $�©��6�  �� 6�  $��Arial)�6�  $� 2016��6�  �� 6  �� 6  �� 6   �� 6,  63  5p      5q      