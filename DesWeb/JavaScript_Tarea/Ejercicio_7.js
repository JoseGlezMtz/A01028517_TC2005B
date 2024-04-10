"use strict"

function factorizar(n){
    let factores=[]
    let i=0
    let j=1
    while (j<=n){
        if (n%j===0){
            factores[i]=j
            i++
        }
        j++
    }
    return factores
}

console.log(factorizar(27))