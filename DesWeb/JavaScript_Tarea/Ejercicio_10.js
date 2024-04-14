"use strict";

function Palindromo(string){
   for (let i=0; i<string.length; i++){
       if (string[i]!=string[string.length-1-i]){
           return "no es palindromo"
       }   
   }
   return "Es un palindromo"
}

console.log(Palindromo("oso"))
console.log(Palindromo("hola"))
console.log(Palindromo("reconocer"))