#!/usr/bin/perl
use strict;
use CGI ':standard';
use CGI::Carp 'fatalsToBrowser';
use utf8;
use encoding "utf-8";

my $n1 = param('n1');
my $n2 = param('n2');
my $sum = $n1 + $n2;

print "Content-type: text/html; charset=utf-8\n\n";
print "Sum is $sum";