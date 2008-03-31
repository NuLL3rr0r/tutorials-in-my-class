<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>

<body>

<cfset myValue=URLEncodedFormat("Ahmadi & Sons")>

<cfoutput>
<a href="recieving.cfm?firstName=David&age=12&company=#variables.myValue#">Click ME, I'm David</a><br/>
<a href="recieving.cfm?firstName=Hasan&age=19">Click ME, I'm Hasan</a><br/>
<a href="recieving.cfm?firstName=Alexander&age=15">Click ME, I'm Alexander</a><br/>
</cfoutput>
</body>
</html>
