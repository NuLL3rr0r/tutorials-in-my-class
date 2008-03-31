/**********************************
//   Simple Ajax Library Build -Dec 23, 2K7-
//   For Ajax in 10 Minutes Book
//   (C) M.S. Babaei
//   This notice MUST stay intact for legal use
//
//   Visit official websites at
//   http://www.babaei.net/
//   for full source code and more information
**********************************/



String.prototype.trim = function () {
    return this.replace(/^\s*/, '').replace(/\s*$/, '');
};

String.prototype.lTrim = function () {
	return this.replace(/\s*((\S+\s*)*)/, '$1');
};

String.prototype.rTrim = function () {
	return this.replace(/((\s*\S+)*)\s*/, '$1');
};

if (typeof String.prototype.substrCount == "undefined") {
    String.prototype.substrCount = function (s) {
        return this.split(s).length - 1;
    }
}

String.prototype.isAlpha = function () {
    return (this >= 'a' && this <= 'z\uffff') || (this >= 'A' && this <= 'Z\uffff');
}

String.prototype.isDigit = function () {
    return (this  >= '0' && this  <= '9');
}

String.prototype.isEmail = function () {
	return verifyRegExp('\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*', this);
};

String.prototype.isURL = function () {
	return verifyRegExp('http(s)?://([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?', this);
};

var loadingText = 'Please wait while loading...';
var http = new Array();
var useCache = false;
var ajaxTargets;
var ajaxTargetsLen;
var browser = new detectBrowser();

function getBrowserInfo(br) {
	var result = '';
	for (i in navigator)
		result += i + ': ' + navigator[i] + br;
	return result;
}

function detectBrowser() {
	this.getInfoRaw = function () {
		return getBrowserInfo('');
	};
	this.getInfoText = function () {
		return getBrowserInfo('\n');
	};
	this.getInfoHTML = function () {
		return getBrowserInfo('<br />');
	};
	
	this.isKHTML = false;
	this.isGecko = false;
	this.isMSIE = false;
	this.isOpera = false;
	this.ver = null;
	this.platform = navigator.platform;
	this.engine = null;
	
	var browser = navigator.userAgent;
	
	if (browser.indexOf('KHTML') > -1) {
		this.isKHTML = true;
		this.engine = 'KHTML';
		return;
	}
	if (browser.indexOf('Gecko') > -1) {
		this.isGecko = true;
		this.engine = 'Gecko';
		return;
	}
	if (browser.indexOf('MSIE') > -1) {
		this.isMSIE = true;
		var pos1 = browser.indexOf('MSIE') + 5;
		var pos2 = browser.indexOf(';', pos1);
		this.ver = Number(browser.substring(pos1, pos2));
		this.engine = 'MSIE';
		return;
	}
	if (browser.indexOf('Opera') > -1) {
		this.isOpera = true;
		this.engine = 'Opera';
		return;
	}
}

function verifyRegExp(regExp, value) {
    var rx = new RegExp(regExp);
    var matches = rx.exec(value);
	return (matches != null && value == matches[0]);
};

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

function resultOnTalkingServer(msg, target) {
	target.innerHTML = msg;
}

function talkingServer(url, target) {
	var obj = document.getElementById(target);
	obj.innerHTML = loadingText;
	var index = -1;
	while (index < ajaxTargetsLen) {
		if (target == ajaxTargets[++index])
			break;
	}
	http[index].abort();
	http[index] = getXMLHTTPRequest();
	if (!useCache)
		url = url + (url.indexOf('?') == -1 ? '?' : '&') + 'rndnocache=' + new Date().getTime();
	http[index].open('GET', url, true);
	http[index].onreadystatechange = function () {
		if (http[index].readyState == 4 && (http[index].status == 200 || window.location.href.indexOf('http://') == -1))
			resultOnTalkingServer(http[index].responseText, obj);
		return;
	};
	http[index].send(null);
}

function initAjaxTargets() {
	for (var i = 0; i < arguments.length; i++)
		http[i] = getXMLHTTPRequest();
	ajaxTargets = arguments;
	ajaxTargetsLen = ajaxTargets.length;
}

function initAjaxLinks() {
	if (!document.getElementsByTagName) 
		return;
	var anchors = document.getElementsByTagName('a');
	for (var i = 0; i < anchors.length; i++) {
		var anchor = anchors[i];
		if (anchor.getAttribute('href'))
			for (var j = 0; j < ajaxTargetsLen; j++)
				if (anchor.getAttribute("rel") == ajaxTargets[j]) {
					anchor.onclick = function () {
						talkingServer(this.href, this.rel);
						return false;
					};
				}
	}
}

function addLoadEvent(func) {	
	var oldonload = window.onload;
	if (typeof window.onload != 'function') {
    	window.onload = func;
	}
	else {
		window.onload = function(){
			oldonload();
			func();
		};
	}
}


addLoadEvent(initAjaxLinks);