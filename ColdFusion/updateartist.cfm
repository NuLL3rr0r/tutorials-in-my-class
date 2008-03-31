<cfif IsDefined("form.FirstName")>
	<cfinvoke 
     component="test5.cfc.Artist"
     method="updateArtist">
        <cfinvokeargument name="formData" value="#form#"/>
    </cfinvoke>
    
	<cflocation url="index.cfm" addtoken="no"> 
<cfelse>
	<cfinvoke 
     component="test5.cfc.Artist"
     method="getArtistQueryById"
     returnvariable="qArtist">
        <cfinvokeargument name="artistid" value="#url.artistid#"/>
    </cfinvoke>
</cfif>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>

<link href="style.css" rel="stylesheet" type="text/css" />
</head>

<body class="oneColElsCtr">
	<cfset title="Update Artist">
	<cfinclude template="top.cfm">

	
<!---     <cfdump var="#qArtist#"><cfabort> --->


	<cfform>
    	
        <table border="0">
          <tr>
            <td>First Name:</td>
            <td><cfinput type="text" name="firstname" maxlength="20" value="#qArtist.FirstName#"></td>
          </tr>
          <tr>
            <td>Last Name:</td>
            <td><cfinput type="text" name="lastname" maxlength="20" value="#qArtist.LastName#"></td>
          </tr>
        </table>

        
        <cfinput type="submit" name="" value="Update Artist">
		<cfinput type="hidden" name="artistid" value="#qArtist.ArtistID#">
    </cfform>
    
	<br/>
	<br/>
	<!-- end #mainContent --></div>
<!-- end #container --></div>
	
<cfinclude template="bottom.cfm">
</body>
</html>
