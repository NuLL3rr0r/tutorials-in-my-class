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
	<cfset title="Home Page">
	<cfinclude template="top.cfm">
    
    <cfdump var="#application#" label="Application Scope">
    
    <cfset count="There are " & qArtists.RecordCount & " Artists">
    <cfoutput>
    	<h4>#count#</h4>
    </cfoutput>
    
    <cfif qArtists.RecordCount IS 0>
		<h4>This query cannot returning results.</h4>    	
    <cfelse>
    <table border="1">
      <tr>
        <th nowrap="nowrap" bgcolor="#FF99CC">Artist #</th>
        <th nowrap="nowrap" bgcolor="#FF99CC">FirstName</th>
        <th nowrap="nowrap" bgcolor="#FF99CC">LastName</th>
        <th nowrap="nowrap" bgcolor="#FF99CC"></th>
        <th nowrap="nowrap" bgcolor="#FF99CC"></th>
        <th nowrap="nowrap" bgcolor="#FF99CC"></th>
      </tr>
      
      <cfoutput query="qArtists">
	      <cfif qArtists.CurrentRow mod 2 IS 1>
	      	<cfset variables.bgcolor="white">
	      <cfelse>
    	  	<cfset variables.bgcolor="silver">
	      </cfif>
      
        <tr bgcolor="#variables.bgcolor#">
          <td>#qArtists.CurrentRow#</td>
          <td>#qArtists.FirstName#</td>
          <td>#qArtists.LastName#</td>
          <td><a href="updateartist.cfm?artistid=#qArtists.ArtistID#">Edit</a></td>
          <td><a href="deleteartist.cfm?artistid=#qArtists.ArtistID#">Delete</a></td>
          <td><a href="art.cfm?artistid=#qArtists.ArtistID#">View Art</a></td>
        </tr>
      </cfoutput>
    </table>
    </cfif>
    
    <p>
    	<a href="insertartist.cfm">Insert New Artist</a>
    </p>
    
    <BR/>
    <!--- <cfdump var="#qArtists#" format="html"> --->

	<!-- end #mainContent --></div>
<!-- end #container --></div>
	
<cfinclude template="bottom.cfm">
</body>
</html>
