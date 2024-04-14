"use strict";

function mediana_moda(arreglo){
    //mediana
    arreglo.sort()
    let mediana=0
    if (arreglo.length%2==0){
        mediana=(arreglo[arreglo.length/2]+arreglo[arreglo.length/2-1])/2}
    else{
        mediana=arreglo[(Math.floor(arreglo.length/2))-1]
    }
    //moda
    let moda=0
    let contador=0
    let contador2=0
    
    for (let i=0; i<arreglo.length; i++){
        for (let j=0; j<arreglo.length; j++){
            if (arreglo[i]==arreglo[j]){
                contador++
            }
        }
        if (contador>contador2){
            moda=arreglo[i]
            contador2=contador
        }
        contador=0
    }
    return [mediana, moda]
}

console.log(mediana_moda([1,2,3,4,5,6,7,8,9,10]))
console.log(mediana_moda([1,2,3,2,2,3,4,5,6]))
console.log(mediana_moda([1,2,3,4,5,6,7,8,9,10,10,10,10,10,10,10,10,10,10,10]))