"use strict";

import express from 'express'

const app = express()

let card_list =[]

app.use(express.json())

app.get("/name", (req, res)=>{
    const salute="hellow from server"
    res.status(200).send(salute)
})

app.get("/hello/:name", (req,res)=>{
    console.log(req.params)
    const salute=`hello ${req.params.name}!!`
    res.status(200).send(salute)
})

app.post('/cards', (req,res)=>{
    console.log(req.body)
    card_list.push(req.body)
    res.status(200).send("Card added succesfully")
})

app.listen(5000, ()=>{
    console.log("running on port 5000")
})