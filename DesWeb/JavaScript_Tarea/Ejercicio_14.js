"use strict"

function Potencia(num){
    if(num==1){
        return true
    }
    else if(num%2!=0){
        return false
    }
    else{
        return Potencia(num/2)
    }

}

console.log(Potencia(64))
console.log(Potencia(1024))
console.log(Potencia(1000))