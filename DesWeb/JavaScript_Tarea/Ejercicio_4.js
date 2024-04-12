"use strict"


let frase="hola mundo"
let frase_2="saquenme de latinoamerica"
let frase_3="comida rapida"

function convertir_mayusculas(string){
    string=string[0].toUpperCase()+string.substring(1)
    for (let i=0; i<string.length; i++){
        if (string[i]==" "){
            string=string.substring(0,i+1)+string[i+1].toUpperCase()+string.substring(i+2)
        }
    }
    return string

}



console.log(convertir_mayusculas(frase))
console.log(convertir_mayusculas(frase_2))
console.log(convertir_mayusculas(frase_3))