function getXMLHTTPRequest() {
	try {
		req = new XMLHttpRequest();
	}
	catch(e) {
		try {
			req = new ActiveXObject("Msxml2.XMLHTTP");
		}
		catch (e) {
			try {
				req = new ActiveXObject("Microsoft.XMLHTTP");
			}
			catch (E) {
				req = false;
			}
		}
	}
	return req;
}
function ResultOnTalkingServer(msg, whereShown) {
	var obj = document.getElementById(whereShown);
	obj.innerHTML = msg;
}
function TalkingServer(url, whereShown) {
	var obj = document.getElementById(whereShown);
	obj.innerHTML = 'Please Wait...<br /><img src="loading.gif" />';
	var http = getXMLHTTPRequest();
	http.open('GET', url, true);
	http.onreadystatechange = function() {
		if (http.readyState == 4 && (http.status == 200 || window.location.href.indexOf("http") == -1))
			ResultOnTalkingServer(http.responseText, whereShown);
		return;
	};
	http.send(null);
}