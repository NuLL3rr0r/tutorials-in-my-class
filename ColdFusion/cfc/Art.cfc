<cfcomponent>
<cffunction name="getQArt" output="false" access="public" returntype="query">
  <cfargument name="ArtistID" default="1" hint="Argument for ArtistID.">
  <cfset var qArt = "" >
  <cfquery name="qArt" datasource="artgallery">
SELECT ArtName, "Description", Price
FROM art
WHERE ArtistID = <cfqueryparam value="#Arguments.ArtistID#" cfsqltype="cf_sql_numeric">
ORDER BY ArtistID ASC 
  </cfquery>
  <cfreturn qArt>
</cffunction>


<cffunction name="getFilteredArt" output="false" access="public" returntype="query">
  <cfargument name="formData" required="yes" type="struct">
  <cfset var qArt = "" >
  <cfquery name="qArt" datasource="artgallery">
SELECT ArtName, "Description", Price
FROM art
WHERE 0=0

<cfif Len(formData.artname) GT 0>
<!--- 	AND ArtName = '#formData.artname#' --->
	AND ArtName LIKE '#formData.artname#%'
</cfif>

<cfif IsNumeric(formData.artistid)>
	AND ArtistID = #formData.artistid#
</cfif>

<cfif IsNumeric(formData.price)>
	AND Price <= #formData.price#
</cfif>

<cfif formData.isSold IS NOT "All">
	AND IsSold = #formData.issold#
</cfif>

ORDER BY ArtistID ASC 
  </cfquery>
  <cfreturn qArt>
</cffunction>

</cfcomponent>