   M S B A M L   `   `   `  ????B  >Airline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AirlineAirline  5   	       Airline.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Airline     5   	     ? Title$  Login??5   	   $	??450??6   $	??800??6$    ? WindowStartupLocation$ CenterScreen=?60    ? 
ResizeMode$ NoResize=?6U   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $	??210 ?6   ?? 5      ?? 5      $	??210 ?6    ? RowDefinitions 5   
   ?? 5      $	??150 ?6   ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??Center=?6   $??Center=?6-   $9??3pack://application:,,,/images/DS2017_TP09_color.png??6H   $??0??6?   $??0??6?   $??10q?6?   $??3??6?   ?? 5   
   $??
Username: ??6   $??0??6&   $??1??66   $??Right=?6C   $
??20px(?6_   $??Center=?6o   $??0 0 10 0q?6?   ?? 5   
   -   5        $??txtUsername??5      $??1??6%   $??1??65   $??20q?6B   
???   ?6N   ?? 5   
   $??
Password: ??6   $??0??6&   $??2??66   $??Right=?6C   $
??20px(?6_   $??Center=?6o   $??0 0 10 0q?6?   G? 5   
   -   5        $??txtPassword??5      $??1??6)   $??2??69   $??20q?6F   
???   ?6R   ?? 5   
   -   5        $??btnLogin??5      $??Login??6!   $??1??61   $??3??6A   $??50 30 200 30q?6N   6d   ?? 5   
   -   5        $??btnExit??5      $
??Exit??6    $??1??6/   $??3??6?   $??200 30 50 30q?6L   6b   5!      5"      