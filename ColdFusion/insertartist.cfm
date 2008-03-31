<cfif IsDefined("form.FirstName")>
	<cfinvoke 
     component="test5.cfc.Artist"
     method="insertArtist">
        <cfinvokeargument name="formData" value="#form#"/>
    </cfinvoke>
    
	<cflocation url="index.cfm" addtoken="no"> 
</cfif>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<cfmodule template="heading.cfm" title="Insert Artist">

</head>

<body class="oneColElsCtr">
	<cfset title="Insert New Artist">
	<cfinclude template="top.cfm">


	<cfform>
    	
        <table border="0">
          <tr>
            <td>First Name:</td>
            <td><cfinput type="text" name="firstname" maxlength="20"></td>
          </tr>
          <tr>
            <td>Last Name:</td>
            <td><cfinput type="text" name="lastname" maxlength="20"></td>
          </tr>
        </table>

        
        <cfinput type="submit" name="" value="Insert Artist">
        
    </cfform>
    
	<br/>
	<br/>
	<!-- end #mainContent --></div>
<!-- end #container --></div>
	
<cfinclude template="bottom.cfm">
</body>
</html>
