<div class="header">
	<ul class="topMenu">
    	<li><a href="index.cfm">Home</a></li>
    	<li><a href="gallery.cfm">Gallery</a></li>
    	<li><a href="buy.cfm">Buy</a></li>
    	<li><a href="contact.cfm">Contact</a></li>
    	<li><a href="about.cfm">About</a></li>
    </ul>
	<cfoutput>
    	#title#
	</cfoutput>
</div>
<div id="container">
  <div id="mainContent">
    <h2> <cfoutput>#title#</cfoutput> </h2>
    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent aliquam,  justo convallis luctus rutrum, erat nulla fermentum diam, at nonummy quam  ante ac quam. Maecenas urna purus, fermentum id, molestie in, commodo  porttitor, felis. Nam blandit quam ut lacus. Quisque ornare risus quis  ligula. Phasellus tristique purus a augue condimentum adipiscing. Aenean  sagittis. Etiam leo pede, rhoncus venenatis, tristique in, vulputate at,  odio. Donec et ipsum et sapien vehicula nonummy. Suspendisse potenti. Fusce  varius urna id quam. Sed neque mi, varius eget, tincidunt nec, suscipit id,  libero. In eget purus. Vestibulum ut nisl. Donec eu mi sed turpis feugiat  feugiat. Integer turpis arcu, pellentesque eget, cursus et, fermentum ut,  sapien. Fusce metus mi, eleifend sollicitudin, molestie id, varius et, nibh.  Donec nec libero.</p>
    <h2>H2 level heading </h2>
    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent aliquam,  justo convallis luctus rutrum, erat nulla fermentum diam, at nonummy quam  ante ac quam. Maecenas urna purus, fermentum id, molestie in, commodo  porttitor, felis. Nam blandit quam ut lacus. Quisque ornare risus quis  ligula. Phasellus tristique purus a augue condimentum adipiscing. Aenean  sagittis. Etiam leo pede, rhoncus venenatis, tristique in, vulputate at, odio.</p>
	<!-- end #mainContent --></div>
<!-- end #container --></div>
<div class="footer">Today is <cfoutput>#DateFormat(Now())#</cfoutput></div>
