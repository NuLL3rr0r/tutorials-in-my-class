function getXMLHTTPRequest() {
	try {
		req = new XMLHttpRequest();
	}
	catch(e1) {
		try {
			req = new ActiveXObject("Msxml2.XMLHTTP");
		}
		catch (e2) {
			try {
				req = new ActiveXObject("Microsoft.XMLHTTP");
			}
			catch (e3) {
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
	obj.innerHTML = '<img src="loading.gif" /> Please Wait...';
	var http = getXMLHTTPRequest();
	http.open('GET', url, true);
	http.onreadystatechange = function() {
		if (http.readyState == 4 && (http.status == 200 || window.location.href.indexOf("http") == -1))
			ResultOnTalkingServer(http.responseText, whereShown);
		return;
	};
	http.send(null);
}