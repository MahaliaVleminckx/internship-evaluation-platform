window.addEventListener("load", initialize);

let answerEl, answerRadio, answerTable;
function initialize() {
    answerEl = document.querySelectorAll(".answerdiv");
    answerRadio = document.querySelectorAll(".answer-radio");
    answerTable = document.querySelectorAll(".answer-table");

    answerEl.forEach(el => el.addEventListener("click", fillCircle));

    console.log(answerEl);
    console.log(answerRadio);
    console.log(answerTable);

    detectIfChecked();
}
