   M S B A M L   `   `   `  ����K  GPremiumWebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PremiumWebServerPremiumWebServer  5   	   I)clr-namespace:PremiumWebServer.ViewModelsPremiumWebServer.ViewModels  5   	   "    PremiumWebServer.WinDbConfig   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PremiumWebServer     5   	   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   2vm)clr-namespace:PremiumWebServer.ViewModels  5   	     � Title$  Cofiguración de Conexion��5
   	   $	��238��6*   $	��396��67    � DataContext 5      1  +PremiumWebServer.ViewModels.ConfigViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��122* �6   �� 5      $��7* �6   .+�5   
   �� -   5         ��Name$ label��5      $��Nombre del servidor:��6   $	��Top=�6>   $��0,36,0,0q�6V   $��Right=�6h   �� 5   
   -   5         ��Name$ txtservername��5      $��26��6)   $��2,36,1,0q�65    �� TextWrapping$
 Wrap=�6G   $	��Top=�6\   $��1��6�   ��6t   �� *txtMyServer+.��6�    � 	Resources 5       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 3��65   5      5      .��6!   *  $MahApps.Metro.Controls.TextBoxHelper
   	Watermark$!
 Ejem. localhost,192.168.0.1��5   m   .��5      �� 5    
   -   5        $ 
label_Copy��5       $��Nombre de Usuario:��6$   $	��Top=�6A   $��0,67,0,0q�6Y   $��Right=�6k   �� 5!   
   -   5        $ txtusername��5!      $��26��6'   $��2,67,1,0q�63   $
 Wrap=�6E   $	��Top=�6Z   $��1��6�   ��6r   �� *	txtMyuser+.��6�    5#      ��%^   '��       �� 5$      " ��6   .�5%      ��  �@��CornerRadius$	 3��65   5&      5(      .��6!   $
 Ejem. root.��5)   ]   .��5+      �� 5,   
   -   5        $ label_Copy1��5,      $��Clave de Usuario:��6%   $	��Top=�6A   $��0,98,0,0q�6Y   $��Right=�6k   G� 5-   
   -   5         G�Name$
 pass��5-      $��26��6$   $��2,98,1,0q�60   $	��Top=�6D   $��1��6]    5/      ��%^   '��       �� 50      " ��6   .�51      ��  �@��CornerRadius$	 3��65   52      54      $
 Clave del usuario Msql.��55   i   57      �� 58   
   -   5        $ label_Copy2��58      $��Puerto:��6%   $	��Top=�67   $��	1,129,0,0q�6O   $��Right=�6b   �� 59   
   -   5        $ txtservername_Copy2��59      $��26��6/   $��	2,129,1,0q�6;   $
 Wrap=�6N   $	��Top=�6c   $��1��6�   ��6{   �� *	txtMyPort+.��6�    5;      ��%^   '��       �� 5<      " ��6   .�5=      ��  �@��CornerRadius$	 3��65   5>      5@      .��6!   $
 
Ejem. 3306��5A   \   .��5C      �� 5D   
   -	   5         ��Name$ button��5D      $��Iniciar Conexión��6!   $��1��6<   $
��Left=�6L   $��132,160,0,0q�6g   $	��Top=�6|   $	��109��6�   ��6�   �� *DbConnectCommand+��6�   ��  �� ElementName$
 pass���� 5E   
   -
   5        $ label_Copy3��5E      $��Datos de conexión Mysql��6%   $
��Left=�6G   $��Microsoft Sans Serif)�6i   $��19(�6�   $��	ExtraBold"�6�   ���#5bc0de$��2��6�   $��
10,3,1,174q�6�    J� Effect 5F      3  -System.Windows.Media.Effects.DropShadowEffect  5G         ShadowDepth$ 1Q�6#   5I      �� 5J   
   -   5        $ label1��5J      $��Estatus:��6    $��1��63   $
��Left=�6C   $��	3,159,0,0q�6^   $	��Top=�6q   $��25��6�   �� 5K   
   -   5        $ label1_Copy��5K      $��1��6B   $
��Left=�6R   $��
44,159,0,0q�6m   $	��Top=�6�   $��25��6�    J� RenderTransformOrigin$ 	1.46,0.68&�6�   $
��Left=�6�   $��83��6�   ��6%   �� *
ValidTxt+6�   5L      5M      