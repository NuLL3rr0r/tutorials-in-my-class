<cfcomponent>
	<cffunction name="getFullArtists" access="public" returntype="query">
    	<cfquery name="qArtists" datasource="#application.datasource#">
        SELECT ArtistID, FirstName, LastName,
        	CONCAT( FirstName, ' ', LastName ) AS FullName
        FROM artists
        ORDER BY LastName ASC 
        </cfquery>
		<cfreturn qArtists>
	</cffunction>
    
    
    <cffunction name="getArtistById" access="public" returntype="string">
    	<cfargument name="artistid" type="numeric" required="yes">

    	<cfquery name="qArtists" datasource="#application.datasource#">
        SELECT *
        FROM artists
        WHERE ArtistID = #arguments.artistid#
        </cfquery>
        
        <cfreturn qArtists.FirstName & " " & qArtists.LastName>
    </cffunction>
    

    <cffunction name="getArtistQueryById" access="public" returntype="query">
    	<cfargument name="artistid" type="numeric" required="yes">

    	<cfquery name="qArtists" datasource="#application.datasource#">
        SELECT *
        FROM artists
        WHERE ArtistID = #arguments.artistid#
        </cfquery>
        
        <cfreturn qArtists>
    </cffunction>
    
    <cffunction name="insertArtist" access="public" returntype="void">
    	<cfargument name="formData" type="struct" required="yes">
        
        <cfquery datasource="#application.datasource#">
        INSERT INTO artists
        	(FirstName, LastName)
        VALUES
        	('#formData.firstname#', '#formData.lastname#')
        </cfquery>
    </cffunction>
 
    <cffunction name="updateArtist" access="public" returntype="void">
    	<cfargument name="formData" type="struct" required="yes">
        
        <cfquery datasource="#application.datasource#">
        UPDATE artists
        SET FirstName = '#formData.FirstName#',
	        LastName = '#formData.LastName#'
        WHERE ArtistID = #formData.ArtistID#
        </cfquery>
    </cffunction>       

    <cffunction name="deleteArtist" access="public" returntype="void">
    	<cfargument name="artistid" type="numeric" required="yes">
        
        <cfquery datasource="#application.datasource#">
        DELETE FROM artists
        WHERE ArtistID = #arguments.artistid#
        </cfquery>
    </cffunction>       
</cfcomponent>