<cfcomponent>
	<cfset this.name="artGallery">

	<cffunction name="onRequestStart" access="public" returntype="void">
    	<!--- <h1>Hello, Application Framework</h1> --->
        
        <cfif NOT IsDefined("application.datasource")>
        	<cfset application.datasource="artgallery">
		</cfif>
        
        
        <cflogin>
<!---         	<h1>You ar not login</h1>
            <cfloginuser name="David" password="123" roles="administrator"> --->
            
            <cfif IsDefined("form.email")>
            	<cfquery datasource="#application.datasource#" name="qUser">
                	SELECT * FROM galleryadmin
                    WHERE Email = '#form.email#' AND
                    		Password = '#form.password#'
                </cfquery>
                <cfif qUser.RecordCount IS 1>
                	<cfloginuser name="#qUser.FirstName# #qUser.LastName#" password="qUser.Password" roles="qUser.Roles">
                <cfelse>
                	<h3 style="color: #FFFFFF;">Invalid username or password</h3>
    		        <cfinclude template="login.cfm">
		            <cfabort>
                </cfif>
            <cfelse>
    	        <cfinclude template="login.cfm">
	            <cfabort>
            </cfif>
            
        </cflogin>
        
	</cffunction>
    
</cfcomponent>