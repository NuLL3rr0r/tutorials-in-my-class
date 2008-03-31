<cfparam name="url.artistid" default="1">

<cfinvoke
  component="test5.cfc.Art"
  method="getQArt"
  returnvariable="qArt">
<!--- CFC Query --->
<cfinvokeargument name="ArtistID" value="#url.artistid#">
</cfinvoke>
<cfinvoke 
 component="test5.cfc.Artist"
 method="getArtistById"
 returnvariable="artistName"
 artistid=#url.artistid#></cfinvoke>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>

<link href="style.css" rel="stylesheet" type="text/css" />
</head>

<body class="oneColElsCtr">
	<cfset title="Home Page">
	<cfinclude template="top.cfm">
    
	<cfoutput>
    	<h4>Art by #artistName#
        </h4>
	</cfoutput>
    <table border="1">
      <tr>
        <td>ArtName</td>
        <td>Description</td>
        <td>Price</td>
      </tr>
      <cfoutput query="qArt">
        <tr>
          <td>#qArt.ArtName#</td>
          <td>#qArt.Description#</td>
          <td>#DollarFormat(qArt.Price)#</td>
        </tr>
      </cfoutput>
    </table>
    <br/>
    <!-- end #mainContent --></div>
<!-- end #container --></div>
	
<cfinclude template="bottom.cfm">
</body>
</html>
