buttoncreate.addEventListener("click", function(e){
    e.preventDefault();
    
    let form = document.querySelector("#form-add");
    let table = document.querySelector("#tabela-pacientes");
  
    let pacient = dataPacient(form);

    
    console.log(!invalidPacient(pacient));
    
    
    

    let pacientTr = createPacientTr(pacient);

    table.appendChild(pacientTr);

    addPacientInTable(pacient)

    form.reset();

});

function dataPacient(form){
    let pacient = {
     name: form.name.value,
     wieght: form.wieght.value,
     height: form.height.value,
     fat: form.fat.value,
     imc: sumImc(form.height.value, form.wieght.value)
    }

    return pacient;
}

function createPacientTr(pacient){
    const tr = document.createElement("tr");
    tr.classList.add("paciente");

    tr.appendChild(createPacientTd(pacient.name, "info-nome"));
    tr.appendChild(createPacientTd(pacient.wieght, "info-peso"));
    tr.appendChild(createPacientTd(pacient.height, "info-altura"));
    tr.appendChild(createPacientTd(pacient.fat, "info-gordura"));
    tr.appendChild(createPacientTd(pacient.imc, "info-imc"));

   return tr;
}

function createPacientTd(dado, classe){
    let td = document.createElement("td");
    td.textContent = dado;
    td.classList.add(classe);

    return td;
}

function addPacientInTable(pacient){
    let pacientTr = createPacientTr(pacient)
    let table = document.querySelector("#tabela-pacientes");
    table.appendChild(pacientTr)
}

// retornando um array de errors
function invalidPacient(pacient){

    let erros = []

    if(invalidHieght(pacient.height)){
       erros.push("Peso é invalido") ;
    }

    if(invalidWieght(pacient.wieght)){
        erros.push("Altura é invalida")
    }

    return erros;
    

}

