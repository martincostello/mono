'============================================================================================
'Name:Manish Kumar Sinha 
'Email Address: manishkumarsinha@sify.com
'Test Case Name: ParamArray:
'APR-1.0.0: ParamArray can be used only on the last argument of argument list. it allows us to 'pass an arbitrary list. It allows us to pass an arbitrary number of argument to the procedure 
'=============================================================================================
Imports System
Module PA_1_0_0
   Function F(ParamArray args() As Integer,ParamArray args1() As Integer)as Boolean
      Dim a as integer
	Dim b as integer
	a = args.Length
	b = args1.Length
	if a<>b
	return true
	else 
	return false
	end if
   End Function
   Sub Main()
      Dim a As Integer() = { 1, 2, 3 }
	Dim b As Integer() = { 1, 2, 3,4 }
      Dim e as Boolean
	e= F(a,b)
	if e<>true
		Throw New System.Exception("#A1, Unexcepted Behaviour in F(a,b)")
	end if
   End Sub
End Module
'=============================================================================================