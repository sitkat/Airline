   M S B A M L   `   `   `  ????B  >Airline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AirlineAirline  5   	       Airline.UserMenu   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Airline     5   	   -   5          ? Title$'  !AMONIC Airlines Automation System??5   	   $	??450??63   $
??800 ??6@    ? WindowStartupLocation$ CenterScreen=?6M    ? 
ResizeMode$ NoResize=?6r   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??50 ?6   ?? 5      $??50 ?6   ?? 5      ?? 5      $??10 ?6   .+?5   
   ]? 
???????$??0??6&   $??3??66   .+?5      ?  5      ?? 5      $	??150 ?6'   .+?5      ?? -   5         ??Name$ btnExit??5      $??10q?6+   $
??Exit??67   
???   ?$??0??6Z   6j   5      5      ?? 5    
   -   5        $??txtName??5       $-??'Hi SomeOne, Welcome to AMONIC Airlines.??6#   $??0??6R   $??1??6b   $??2??6o   $??Center=?6?   $
??Left=?6?   $??55 0 0 0q?6?   ?? 5!   
   -   5        $??txtTime??5!      $$??Time spent on system: 00:00:00??6#   $??1??6I   $??2??6Y   $??2??6f   $??Center=?6z   $
??Left=?6?   $??0 0 0 0q?6?   ?? 5"   
   -   5        $??
txtCrashes??5"      $??Number of craches: 0??6&   $??2??6B   $??2??6R   $??2??6_   $??Center=?6s   $
??Left=?6?   $??0 0 0 0q?6?   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ dataGrid??5$      $??3??6&   $??3??63   $??50 10 50 10q?6G   5&      5'      