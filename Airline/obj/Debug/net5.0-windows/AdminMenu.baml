   M S B A M L   `   `   `  ????B  >Airline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AirlineAirline  5   	       Airline.AdminMenu   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Airline     5   	   -   5          ? Title$'  !AMONIC Airlines Automation System??5   	   $	??450??63   $
??800 ??6@    ? WindowStartupLocation$ CenterScreen=?6M    ? 
ResizeMode$ NoResize=?6r   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??50 ?6   ?? 5      ?? 5      $??50 ?6   .+?5   
   ]? 
???????$??0??6&   $??3??66   .+?5      ?  5      ?? 5      $	??150 ?6'   ?? 5      $	??150 ?6'   .+?5      ?? -   5         ??Name$ 
btnAddUser??5      $??10q?6-   $??Add user??6:   
???   ?$??0??6a   6q   ?? 5      -   5        $ btnExit??5      $??10q?6+   $
??Exit??67   
???   ?$??1??6Z   6j   5      5       ?? 5!   
   $"??Отсортировать: ??6   $??0??6+   $??1??6;   $??Center=?6H   $
??Left=?6c   $??55 0 0 0q?6~   ?? 5"   
   -   5        $??cbFilter??5"      $??0??6#   $??1??63   
???   ?$??Center=?6T   $??Right=?6o   $	??120??6?   6?   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ dataGrid??5$      $??2??6&   $??3??63   $??50 10 50 10q?6G   ?? 5&   
   -   5        $ btnChangeRole??5&      $??50 10 10 10q?6(   $	??100??6=   $??Change Role??6J   
???   ?$??0??6t   $??3??6?   $
??Left=?6?   ?? 5'   
   -   5        $ btnEnableDisable??5'      $??
0 10 10 10q?6+   $	??130??6?   $??Enable/Disable Login??6L   
???   ?$??1??6   $??3??6?   $
??Left=?6?   5(      5)      