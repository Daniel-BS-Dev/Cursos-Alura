let tdwieght = document.querySelector(".info-peso");
let tdheigth = document.querySelector(".info-altura");
let tdimc = document.querySelector(".info-imc");

let wieghtValid = true;
let heightValid = true;



const tr = document.querySelectorAll(".paciente").forEach((trs) => {
  console.log(trs);

  let tdwieght = trs.querySelector(".info-peso");
  let tdheigth = trs.querySelector(".info-altura");
  let tdimc = trs.querySelector(".info-imc");
  let wieght = tdwieght.textContent;
  let height = tdheigth.textContent;

  if (wieght <= 0 || wieght >= 500) {
    console.log("peso ivalido");
    wieghtValid = false;
    tdimc.textContent = "Peso invalido";
    trs.classList.add("pacient-invalid")
  }
  if (height <= 0 || height >= 10) {
    console.log("altura invalida");
    heightValid = false;
    tdimc.textContent = "Altura invalido";
    trs.classList.add("pacient-invalid")
  }
  if (!heightValid && !wieghtValid) {
    tdimc.textContent = "Altura é Peso invalido";
    trs.classList.add("pacient-invalid")
  }
  
  if (wieghtValid && heightValid) {
    let imc = wieght / (height * height);
    tdimc.textContent = imc.toFixed(2);
  }

});
