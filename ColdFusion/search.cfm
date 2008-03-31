<cfinvoke 
 component="test5.cfc.Artist"
 method="getFullArtists"
 returnvariable="qArtists">
</cfinvoke>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>

<link href="style.css" rel="stylesheet" type="text/css" />
</head>

<body class="oneColElsCtr">
	<cfset title="Available Arts Search">
	<cfinclude template="top.cfm">

    <cfform preservedata="yes">
        <table border="0" id="radiobutton1" name="radiobutton1">
          <tr>
            <td nowrap="nowrap">Art Name:</td>
            <td><cfinput type="text" name="artname" id="artname"></td>
          </tr>
          <tr>
            <td nowrap="nowrap">Artist:</td>
            <td><cfselect name="artistid" id="artist"
            	 query="qArtists" value="ArtistID" display="FullName" queryPosition="below">
                 	<option value="all">All Artists</option>
            </cfselect></td>
          </tr>
          <tr>
            <td nowrap="nowrap">Maximum Price:</td>
            <td><cfinput type="text" name="price" message="Price must be numeric" validateat="onSubmit" validate="integer" required="yes" id="price"></td>
          </tr>
          <tr>
            <td nowrap="nowrap">Sold?</td>
            <td><cfinput type="radio" name="issold" checked="true" id="issoldall" value="all">
            All Art 
              <cfinput type="radio" name="issold" value="1" id="issoldyes">
            Sold
            <cfinput type="radio" name="issold" value="0" id="issoldno">
            Not Sold</td>
          </tr>
        </table>
        <p>
          <cfinput type="submit" name="Submit" id="Submit" value="Search For Art">
    </p>
    </cfform>
    
    
    <cfif ISDefined("form.artname")>
    	<!---The form was submitted! --->
        
        
        <cfif Len(form.price) GT 0 AND
			NOT ISNUMERIC(form.price)>
        	<p>The Price Must Be Numeric</p>
        <cfelse>
        
            <cfinvoke 
             component="test5.cfc.Art"
             method="getFilteredArt"
             returnvariable="qArt">
                <cfinvokeargument name="formData" value="#form#"/>
            </cfinvoke>
    
            
            
            <!--- <cfdump var="#form#" label="Form Scope"> --->
            <cfdump var="#qArt#" label="Art Data">
        </cfif>
    </cfif>

    <br/><br/>
    <!-- end #mainContent --></div>
<!-- end #container --></div>
	
<cfinclude template="bottom.cfm">
</body>
</html>
