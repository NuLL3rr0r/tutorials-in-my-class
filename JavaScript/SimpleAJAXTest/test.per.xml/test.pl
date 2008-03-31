#!/usr/bin/perl
use strict;
use CGI ':standard';
use CGI::Carp 'fatalsToBrowser';


print "Content-Type: text/xml; charset=utf-8\n\n";


print qq(<?xml version="1.0" encoding="utf-8" standalone="yes"?>\n\n);
print qq(<school>\n);
print qq(\t<class>\n);
print qq(\t\t<teacher name="A" />\n);
print qq(\t\t<students>\n);
print qq(\t\t\t<student name="B" />\n);
print qq(\t\t\t<student name="C" />\n);
print qq(\t\t\t<student name="D" />\n);
print qq(\t\t</students>\n);
print qq(\t</class>\n);
print qq(</school>\n);
