// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
* @name: S15.5.4.16_A2;
* @section: 15.5.4.16;
* @assertion: The characters in SpecialCasings.txt are converted by multi-character results;
* @description: Complex test;
*/

//CHECK
LowerSpecialCase = [["\u0130", "\u0069\u0307"], ["\u1F88", "\u1F80"], ["\u1F89", "\u1F81"], ["\u1F8A", "\u1F82"], ["\u1F8B", "\u1F83"], ["\u1F8C", "\u1F84"], ["\u1F8D", "\u1F85"], ["\u1F8E", "\u1F86"], ["\u1F8F", "\u1F87"], ["\u1F98", "\u1F90"], ["\u1F99", "\u1F91"], ["\u1F9A", "\u1F92"], ["\u1F9B", "\u1F93"], ["\u1F9C", "\u1F94"], ["\u1F9D", "\u1F95"], ["\u1F9E", "\u1F96"], ["\u1F9F", "\u1F97"], ["\u1FA8", "\u1FA0"], ["\u1FA9", "\u1FA1"], ["\u1FAA", "\u1FA2"], ["\u1FAB", "\u1FA3"], ["\u1FAC", "\u1FA4"], ["\u1FAD", "\u1FA5"], ["\u1FAE", "\u1FA6"], ["\u1FAF", "\u1FA7"], ["\u1FBC", "\u1FB3"], ["\u1FCC", "\u1FC3"], ["\u1FFC", "\u1FF3"], ["\u03A3", "\u03C2"], ["\u0049", "\u0069\u0307"], ["\u004A", "\u006A\u0307"], ["\u012E", "\u012F\u0307"], ["\u00CC", "\u0069\u0307\u0300"], ["\u00CD", "\u0069\u0307\u0301"], ["\u0128", "\u0069\u0307\u0303"]];

errorCount = 0;
count = 0;

for (index = 0; index < LowerSpecialCase.length; index++) {
  var capitalI = LowerSpecialCase[index][0];
  var capitalS = String.fromCharCode(capitalI);
  var smallI = LowerSpecialCase[index][1];  
  var smallS = String.fromCharCode(smallI);
  if (capitalS.toLowerCase() !== smallS) {
    var hexC = decimalToHexString(capitalI);
    var hexS = decimalToHexString(smallI);
    $ERROR('#' + hexC + '->' + hexS + ' ');
    errorCount++;
  }  
  count++;
}  

if (errorCount > 0) {    
  $ERROR('Total error: ' + errorCount + ' bad Unicode character in ' + count);
}

function decimalToHexString(n) {
  n = Number(n);
  var h = "";
  for (var i = 3; i >= 0; i--) {
    if (n >= Math.pow(16, i)) {
      var t = Math.floor(n / Math.pow(16, i));
      n -= t * Math.pow(16, i);
      if ( t >= 10 ) {
        if ( t == 10 ) { h += "A"; }
        if ( t == 11 ) { h += "B"; }
        if ( t == 12 ) { h += "C"; }
        if ( t == 13 ) { h += "D"; }
        if ( t == 14 ) { h += "E"; }
        if ( t == 15 ) { h += "F"; }
      } else {
        h += String(t);
      }
    } else {
      h += "0";
    }
  }
  return h;
}
