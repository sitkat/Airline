   M S B A M L   `   `   `  ????B  >Airline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AirlineAirline  5   	       Airline.LogoutDetected   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Airline     5   	     ? Title$  No logout detected??5   	   $	??450??6$   $	??800??61    ? WindowStartupLocation$ CenterScreen=?6=    ? 
ResizeMode$ NoResize=?6b   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $??60 ?6   ?? 5      $??60 ?6   ?? 5      ?? 5      $??80 ?6   .+?5   
   ?? -   5        $??txtNoLogout??5      $C??=No logout detected for your last login on 06/07/2017 at 08:22??6'   $??0??6l   $??0??6|   $??2??6?   $??Center=?6?   $
??Left=?6?   $??80 0 0 0q?6?   ?? 5   
   $??Reason:??6   $??0??6#   $??1??63   $??Center=?6@   $
??Left=?6[   $??80 0 0 0q?6v   ?? 5   
   -   5        $??	txtReason??5      $??0??6#   $??2??63   $??3??6@   $??
80 0 80 20q?6T   
???   ?6h   	? 5   
   -   5        $??rbFirst??5      $??0??6%   $??3??65   $??
80 20 0 20q?6B   
???   ?$??Center=?6j   $??Software Crash??6?   	? 5   
   -   5        $??rbSecond??5      $??1??6&   $??3??66   $??0 20 140 20q?6C   
???   ?$??Center=?6l   $??System Crash??6?   ?? 5    
   -   5        $??
btnConfirm??5       $??Confirm??6#   $??3??65   $??3??6E   $??2??6R   $??20 20 80 20q?6f   6{   5!      5"      