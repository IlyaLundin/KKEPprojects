   M S B A M L   `   `   `  ????H  DCalendarNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CalendarNotesCalendarNotes  5   	       CalendarNotes.WindowWork   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CalendarNotes     5   	     ? Title$  Рабочее окно??5   	   $	??450??6   $	??800??6+    ? Icon$ /Resources/feather1.ico??67    ? 
ResizeMode$ NoResize=?6V   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??70 ?6   6*   ?? 5      6   ?? 5      $	??100 ?6   6+    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      $	??300 ?6   6-   ?? 5      6!   .+?5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ 
PickedDate??5      $??30??6*   $	??180??66   $??0??6B   $??1??6O      SelectedDateFormat$
 Long=?6_   6{   ?? 5   
   -   5         ??Name$ 
ButtonHelp??5         
ButtonMain#??[  6%   $??0??6I   $??2??6V   .??6   Справка6?   ?? 5   
   $	??200??6   $??1??6$   $??1??61   .??5   
   ?? -   5         ??Name$ TextBoxNote??5      $
??Auto??6'   $	??300??65   	 ?? TextWrapping$
	 Wrap=?6B   6X   5      ?? 5   
   -   5        $ ButtonOpenNotes??5      #??[  6*   $??3??6N   $??0??6[   .??6?   Открыть заметки6?   ?? 5   
   -   5        $ ButtonMakeNote??5      #??[  6)   $??3??6M   $??1??6Z   .??6?   Создать заметку6?   ?? 5   
   -   5        $ 
ButtonExit??5      #??[  6%   $??3??6I   $??2??6V   .??6   
Выйти6?   5      5      