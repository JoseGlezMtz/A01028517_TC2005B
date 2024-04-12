"use strict";

function Encontrar_duplicado(arreglo){
    let sencillos=[]
    for (let i=0; i<arreglo.length; i++){
        for(let j=0; j<sencillos.length; j++){
        if (sencillos[j]===arreglo[i]){
            i++
        }
        else if (j===sencillos.length){
        sencillos.push(arreglo[i])}
    }
}
    return sencillos
}

let arreglo_1=[1,0,1,2,0,1,0,1]
console.log(Encontrar_duplicado(arreglo_1))