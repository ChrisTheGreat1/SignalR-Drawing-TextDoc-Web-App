"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/textDocHub").withAutomaticReconnect().build();

connection.on("updateText", (textContents) => {
    textDoc.value = textContents;
})

connection.start().catch(err => console.error(err.toString()));

const textDoc = document.getElementById("textDocument");

textDoc.addEventListener("input", () => {
    let textContents = textDoc.value;
    connection.invoke("UpdateText", textContents);
})