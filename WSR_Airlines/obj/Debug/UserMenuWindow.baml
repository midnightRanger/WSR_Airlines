   M S B A M L   `   `   `  ????G  CWSR_Airlines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WSR_AirlinesWSR_Airlines  5   	   !    WSR_Airlines.UserMenuWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WSR_Airlines     5   	   -   5          ? Title$  UserMenuWindow??5   	   $	??720??6    $
??1280??6-   .??5	      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $	??51* ?6   ?? 5      $	??57* ?6   ?? 5      $	??28* ?6   ?? 5      $
??439* ?6   ?? 5      $	??30* ?6   ?? 5      $	??58* ?6   ?? 5      $	??28* ?6   .+?5   
   o? $??25??6   $	??Top=?6   $??1q?63   
???   ?$??3??6[   $??
0,0,-0.4,0q?6o   .@?5      m? -   5        $
??Exit??5      $??25??6%   $??59??61   6<   5      ?? 5   
   -   5         ??Name$ 	welcomeLB??5   I   $
??Left=?6   $??40??6+   $??Welcome??67   $??0??6\   $??1??6l   ?? 5   
   -   5        $ timeSpentLB??5   J   $
??Left=?6   $??40??6+   $??00:00:00??67   $??1??6_   $??1??6o   ?? 5   
   -   5        $ crashLB??5   I   $
??Left=?6   $??40??6+   $??Crashes??67   $??3??6Z   $??1??6j   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ ActivityDataGrid??5!      $??3??6-   $??0??6:   $??3??6K   $??10q?6_      	CellStyle 5"      ?? 5#       ?? 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .?5$      ??  ?? Property ? ?? ?? Value
 ?  ??63   	 ?? Triggers	 5%      ?? 5&      
 ?? Binding
 6&   ?? *UnsuccessfulLogoutReason+ ?? Value  6S   .a?5'      ??  ? ??
 ?????6;   5(      5*      5-      5/      50      