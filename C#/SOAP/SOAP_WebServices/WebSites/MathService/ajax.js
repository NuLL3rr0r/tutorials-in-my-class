var srv = 'http://localhost:49180/MathService/MyMath.asmx';
//var srv = (window.location.href.indexOf('http://www.') != -1) ? 'http://www.test.com/MyMath.asmx' : 'http://test.com/MyMath.asmx';

var loadingText = "Loading....";
var errServer = "Internal server error.";

function getXMLHTTPRequest() {
	try {
		req = new XMLHttpRequest();
	}
	catch(e1) {
		try {
			req = new ActiveXObject('Msxml2.XMLHTTP');
		}
		catch(e2) {
			try {
				req = new ActiveXObject('Microsoft.XMLHTTP');
			}
			catch(e3) {
				req = false;
			}
		}
	}
	return req;
}

function parseXML(text, tag) {
	if (!window.ActiveXObject) {
		var parser = new DOMParser();
		var doc = parser.parseFromString(text, "text/xml");
	}
	else
	{
		var doc = new ActiveXObject("Microsoft.XMLDOM");
		doc.async = 'false';
		doc.loadXML(text);
	}
	var x = doc.documentElement;
	return x.getElementsByTagName(tag)[0].childNodes[0].nodeValue;
}

/****************** My way instead of parseXML */
function detectChar(ch) {
	switch (ch) {
		case "&lt;":
			return '<';
			break;
		case "&gt;":
			return '>';
			break;
		case "&amp;nbsp;":
			return '&nbsp;';
			break;
		case "&amp;hellip;":
			return '&hellip;';
			break;
		default:
			break;
	}
}

function correctTags(str, ch) {
	parts = str.split(ch);
	var clnd = parts.join(detectChar(ch));
	return clnd;
}

function filterTalking(msg, tag) {
	if (msg != 'Internal Server Error')	{
		var pos1 = msg.indexOf('<' + tag + '>');
		var pos2 = msg.indexOf('</' + tag + '>');
		var tagLen = tag.length + 2;
		return msg.substr(pos1 + tagLen, pos2 - pos1 - tagLen);
	}
	else
		return errServer;
}

function correctPageTags(str, tag) {
	str = filterTalking(str, tag);
	str = correctTags(str, '&lt;');
	str = correctTags(str, '&gt;');
	str = correctTags(str, '&amp;nbsp;');
	str = correctTags(str, '&amp;hellip;');
	return str;
}
/******************/

function talkingServer(op, param, target) {
	var obj = document.getElementById(target);

    obj.innerHTML = loadingText;
	
	var http = getXMLHTTPRequest();
	
	http.open('POST', srv, true);
	http.onreadystatechange = function() {
		if (http.readyState == 4) {
			if (http.status == 200) {
				resultOnTalkingServer(0, http.responseText, op, target);
			}
			else
				resultOnTalkingServer(1, http.statusText, op, target);
			return;
		}
	};
	
	http.setRequestHeader("Content-Type", "text/xml; charset=utf-8");
               
	var sendSOAP = '<?xml version="1.0" encoding="utf-8"?><soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/"><soap:Body><' + op + ' xmlns="' + 'http://tempuri.org/' + '">' + param + '</' + op + '></soap:Body></soap:Envelope>';
	
	http.send(sendSOAP);
}

function resultOnTalkingServer(code, msg, op, target) {
	var obj = document.getElementById(target);
	
	if (code == 1) {
		obj.innerHTML = errServer;
		return;
	}

    window.alert(msg);
    window.alert(parseXML(msg, op + 'Result'));
    window.alert(correctPageTags(msg, op + 'Result'));
	
	switch (op) {
		case 'Add':
	    	obj.innerHTML = "Add result: " + parseXML(msg, op + 'Result');
			break;
		case 'Dec':
	    	obj.innerHTML = "Dec result: " + parseXML(msg, op + 'Result');
			break;
		default:
			break;
	}	
}

function add(text1, text2) {
    var num1 = document.getElementById(text1).value;
    var num2 = document.getElementById(text2).value;
    
    talkingServer('Add', '<n1>' + num1 + '</n1><n2>' + num2 + '</n2>', 'divResult');
}

function dec(text1, text2) {
    var num1 = document.getElementById(text1).value;
    var num2 = document.getElementById(text2).value;
    
    talkingServer('Dec', '<n1>' + num1 + '</n1><n2>' + num2 + '</n2>', 'divResult');
}
