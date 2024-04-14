"use strict"

function BubbleSort(array){
    for (let i=array.length;i>=0;i--){

        for( let j=array.length-1; j>=0;j--){

            if (array[j]<array[j-1]){

                let temp=0
                temp=array[j]
                array[j]=array[j-1]
                array[j-1]=temp

            }
        }
    }
    return array
}   


function Descendiente(arreglo){
    let arreglo2=[]
    let arreglo1=BubbleSort(arreglo)
    for(let i=arreglo1.length-1;i>=0;i--){
        arreglo2.push(arreglo1[i])
    }
    return arreglo2
}

console.log(Descendiente([1,2,3,4,5,6,7,8,9,10]))