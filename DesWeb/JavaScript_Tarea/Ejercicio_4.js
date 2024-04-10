"use strict"


let palabra="paraNgariCutiriMicuaRo"

function BuscarMayuscula(string){
    let Letra=""
    for (let i=0;i<string.length;i++){
        if (string[i]===string[i].toUpperCase()){
            Letra=string[i]
            break
        }
    }
    return Letra
}

console.log(`La mayuscula de ${palabra} es ${BuscarMayuscula(palabra)}`)