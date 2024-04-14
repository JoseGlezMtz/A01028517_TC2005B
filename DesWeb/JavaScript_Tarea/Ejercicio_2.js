
"use strict";


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

console.log(BubbleSort([2,6,8,4,5,9,1,3,7])) 
console.log(BubbleSort([5,6,7,8,9,4,3,2,1]))
console.log(BubbleSort([1,2,3,10,5,8,7,6]))

