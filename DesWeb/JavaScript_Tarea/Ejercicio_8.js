"use strict";

function Limpiar_arreglo(arreglo){
    let sencillos=[]
    for(let i=0;i<arreglo.length;i++){
        if(sencillos.includes(arreglo[i])==false){
            sencillos.push(arreglo[i])
        }
    }
    return sencillos

}


console.log(Limpiar_arreglo([1,0,1,2,0,1,0,1]))
console.log(Limpiar_arreglo([5,7,3,4,5,4,2,3,4,1]))
console.log(Limpiar_arreglo([10,100,10,100,1,0,10]))