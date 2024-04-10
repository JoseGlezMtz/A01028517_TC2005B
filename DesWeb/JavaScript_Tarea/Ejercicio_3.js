"use strict"

//Ejercicio 3

let Arreglo_Original=[1,2,3,4,5,6,7,8,9,10,11]
let Arreglo_2=[]

function SwapMismoArreglo(array){
    let i=0
    let j=array.length-1
    while (i<j){
        let temp=0
        temp=array[i]
        array[i]=array[j]
        array[j]=temp
        i++
        j--
    }
    return array 
}

function SwapNuevoArreglo(array){
    Arreglo_2=[]
    let i=0
    let j=array.length-1
    while (j>=0){
        Arreglo_2[i]=array[j]
        i++
        j--
    }
}

console.log(SwapMismoArreglo(Arreglo_Original))
console.log(Arreglo_Original)
SwapNuevoArreglo(Arreglo_Original)
console.log(Arreglo_2)

