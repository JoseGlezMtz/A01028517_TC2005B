"use strict";

function cadena_corta(arreglo){
    let tamaño=arreglo[0].length
    for (let i=0; i<arreglo.length; i++){
        if (arreglo[i].length<tamaño){
            tamaño=arreglo[i].length
        }
        }
    return tamaño
    }


console.log(cadena_corta([ "adios", "buenos dias", "buenas noches"]))
console.log(cadena_corta([ "jesus", "vive", "en", "mi", "corazon"]))
console.log(cadena_corta([ "Viva", "Cristo", "Rey"]))