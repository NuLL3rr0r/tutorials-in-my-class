<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>

<body>

<cfinvoke component="test5.cfc.test"
			method="myFunction"
            returnvariable="myResult"
            myArgument="Hello"/>
            
            <cfoutput>
            	The Returned Value is: #myResult#
            </cfoutput>
<br/>            

<cfinvoke component="test5.cfc.test"
			method="myFunction"
            returnvariable="myResult"
            myArgument="Ali Hasani"/>
            
            
            <cfoutput>
            	The Returned Value is: #myResult#
            </cfoutput>
<br/>            

<cfinvoke component="test5.cfc.test"
			method="myFunction"
            returnvariable="myResult"
            myArgument="123456789"/>
            
            
            <cfoutput>
            	The Returned Value is: #myResult#
            </cfoutput>

<br/>            

</body>
</html>
