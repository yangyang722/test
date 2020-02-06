;#DropDB DXApplication1EasyTest

#Application DXApplication1Win
#Application DXApplication1Web
#IfDef DXApplication1Win

*Action About...
 
*Action OK

#EndIf

#IfDef DXApplication1Web
!Action Navigation(My Details)
#EndIf
