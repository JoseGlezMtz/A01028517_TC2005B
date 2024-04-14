 "use strict"
function moda(arreglo){
    let moda=""
    let contador=0
    let contador2=0
    
    for (let i=0; i<arreglo.length; i++){
        for (let j=0; j<arreglo.length; j++){
            if (arreglo[i]==arreglo[j]){
                contador++
            }
        }
        if (contador>contador2 && arreglo[i]!=moda){
            moda=arreglo[i]
            contador2=contador
        }
        contador=0
    }
    return moda
}

console.log(moda(["hola", "adios", "hola", "hola", "adios", "adios", "hola", "hola"]))
console.log(moda(["hola", "adios", "hola", "hola", "adios", "adios", "hola", "adios"]))
console.log(moda(["hola", "adios", "hola", "hola", "adios", "adios", "adios", "adios"]))