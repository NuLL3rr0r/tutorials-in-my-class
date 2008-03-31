<cfinvoke 
 component="test5.cfc.Artist"
 method="getFullArtists"
 returnvariable="qArtists">
</cfinvoke>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<cfmodule template="heading.cfm" title="Home Page">
</head>

<body class="oneColElsCtr">
	<cfset title="Please Login">
	<cfinclude template="top.cfm">
    
    <cfform>
        <table border="0">
          <tr>
            <td>Email</td>
            <td><cfinput type="text" name="email" id="email"></td>
          </tr>
          <tr>
            <td>Password</td>
            <td><cfinput type="password" name="password" id="password"></td>
          </tr>
        </table>
        <p>
          <cfinput type="submit" name="" value="Login">
    </p>
    </cfform>


	<!-- end #mainContent --></div>
<!-- end #container --></div>
	
<cfinclude template="bottom.cfm">
</body>
</html>
