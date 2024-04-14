"use strict";


function diferente(array){
    let no_repetido=""
    for (let i=0;i<=array.length;i++) {
        let count=0
        for (let j=0;j<=array.length;j++) {
            if (array[i]==array[j] ) { 
                count++
                }
         }
        if (count==1) {
            no_repetido=array[i]
            break
            }    
    }
return no_repetido
}
console.log(`La letra que no se repite es ${diferente("abacddbec")}`)
console.log(`La letra que no se repite es ${diferente("abcdeabcd")}`)
console.log(`La letra que no se repite es ${diferente("bbccddeea")}`)
