let tdwieght = document.querySelector(".info-peso");
let tdheigth = document.querySelector(".info-altura");
let tdimc = document.querySelector(".info-imc");
let buttoncreate = document.querySelector(".button-create");

const tr = document.querySelectorAll(".paciente").forEach((trs) => {

  let tdwieght = trs.querySelector(".info-peso");
  let tdheigth = trs.querySelector(".info-altura");
  let tdimc = trs.querySelector(".info-imc");
  let wieght = tdwieght.textContent;
  let height = tdheigth.textContent;

  let validWieght = invalidWieght(wieght);
  let validHeight = invalidHieght(height);

  if (validWieght) {
    console.log("peso ivalido");
    validWieght = false;
    tdimc.textContent = "Peso invalido";
    trs.classList.add("pacient-invalid")
    
  }
  if (validHeight) {
    console.log("altura invalida");
    validHeight = false;
    tdimc.textContent = "Altura invalido";
    trs.classList.add("pacient-invalid")
  }
  if (validHeight && validWieght) {
    tdimc.textContent = "Altura é Peso invalido";
    trs.classList.add("pacient-invalid")
  }
  
  if (!validWieght && !validHeight) {
    let imc = sumImc(height,wieght)
    tdimc.textContent = imc;
  }

 
  });

  function sumImc(height, wieght){
     let imc = wieght / (height * height)
     return imc.toFixed(2);
  }

  function invalidWieght(wieght){
    if(wieght <= 0 || wieght >= 500){
       return true;
    }else{
      return false
    }
  }

  function invalidHieght(height){
    if(height <= 0 || height >= 10){
      return true;
    }else{
      return false;
    }
  }