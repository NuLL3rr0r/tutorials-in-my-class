<cfcomponent>
	<cffunction name="myFunction" access="public" returntype="string">
		<cfargument name="myArgument" type="string" required="yes">
		<cfset myResult=#myArgument#>
		<cfreturn myResult>
	</cffunction>
</cfcomponent>