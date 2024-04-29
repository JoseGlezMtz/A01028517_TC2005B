"use strict";

import express from 'express'

const app = express()

let card_list =[{
    "ID_Carta": 1,
    "Name": "Wendy",
    "Description": "Campist",
    "habilidad":{
        "ID_Habilidad": 1,
        "Name": "Bugs",
        "Efect": "rest",
        "Direction":"enemy",
        "cost": 10,
        "health": 100,
        "speed":0,
        "Resistance":0,
        "Attack":0
    },
    "Health": 100

}]

app.use(express.json())

app.get("/Cards_on_list", (req, res)=>{
    if(card_list.length>0){
        res.status(200).json(card_list)}
    else{
    const Error="No cards on list"
    res.status(200).send(Error)}
})

app.get("/Card_ID/:ID", (req,res)=>{
    let Card_Exist= card_list.find((Cards)=> Cards.ID_Carta==req.params.ID)
    if (Card_Exist){
        res.status(200).json(Card_Exist)
    }
    else{
        res.status(200).send("carta no existe")
    }
    
})

app.post('/New_Card', (req,res)=>{
    let count=0
    for (let i in req.body){
        count++
    }
    if (count==5){
        let Card_Exist= card_list.find((Cards)=> Cards.ID_Carta==req.body.ID_Carta)
        if (Card_Exist){
            res.status(200).send("Carta ya existe")
        }
        else{
        card_list.push(req.body)
        res.status(200).json("agregado correctamente")}
    }
    else{
        res.status(200).json("No Tiene todos los parametros")
    }
})

app.delete('/Delete_card/:ID', (req,res)=>{
    let Card_Exist= card_list.find((Cards)=> Cards.ID_Carta==req.params.ID)
    let Index= Card_Exist.findIndex
    if (Card_Exist){
        card_list.pop(card_list[Index])
        res.status(200).send("Carta borrada con exito")
    }
    else{
        res.status(200).send("carta no existe")
    }
    
    
})

app.put('/Update_Card/:ID', (req, res) => {
    
    let card_index = card_list.findIndex((Cards) => Cards.ID_Carta == req.params.ID)
    if (card_index != -1) {
      let cardToUpdate = card_list[card_index]
      for (let i in req.body) {
        if (cardToUpdate.hasOwnProperty(i)) { 
          cardToUpdate[i] = req.body[i]
        }
      }
      console.log("Carta cambiada");
      res.status(200).send("Carta actualizada con exito")
    } else {
      res.status(200).send("Carta no existe");
    }
  })
  



app.listen(5000, ()=>{
    console.log("running on port 5000")
})