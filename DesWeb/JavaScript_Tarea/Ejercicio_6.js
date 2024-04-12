"use strict";


function hackerSpeak(frase){
    frase=frase.replace(/a/g, "4");
    frase=frase.replace(/e/g, "3");
    frase=frase.replace(/i/g, "1");
    frase=frase.replace(/o/g, "0");
    frase=frase.replace(/s/g, "5");
    return frase;
}

console.log(hackerSpeak("Hola, soy un robot"));
console.log(hackerSpeak("me gustan las manzanas"));
console.log(hackerSpeak("Yo soy tu padre"));
