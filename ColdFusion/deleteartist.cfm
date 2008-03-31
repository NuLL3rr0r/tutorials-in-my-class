<cfif IsDefined("form.artistid")>
	<cfinvoke 
     component="test5.cfc.Artist"
     method="deleteArtist">
        <cfinvokeargument name="artistid" value="#form.artistid#"/>
    </cfinvoke>
    
    <cflocation url="index.cfm" addtoken="no">
</cfif>


<cfinvoke 
 component="test5.cfc.Artist"
 method="getArtistById"
 returnvariable="artistName">
	<cfinvokeargument name="artistid" value="#url.artistid#"/>
</cfinvoke>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>

<link href="style.css" rel="stylesheet" type="text/css" />
</head>

<body class="oneColElsCtr">
	<cfset title="OK to delete " & variables.artistName & "?">
	<cfinclude template="top.cfm">

	<cfform>
    
    	<cfinput type="submit" name="submit" value="Delete">
        <cfinput type="button" name="cancel" value="Cancel"
        	onClick="javascript:history.back();">
    	<cfinput type="hidden" name="artistid" value="#url.artistid#">
    </cfform> 

	<br/>
	<br/>

	<!-- end #mainContent --></div>
<!-- end #container --></div>
	
<cfinclude template="bottom.cfm">
</body>
</html>
