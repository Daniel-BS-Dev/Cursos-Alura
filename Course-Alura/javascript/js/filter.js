let filter = document.querySelector(".input-filter");

filter.addEventListener("input", function(){

    let paciente = document.querySelectorAll(".paciente");

    if(this.value.length > 0){
        for(let i=0; i< paciente.length ; i++){
            let pacient = paciente[i];
    
            let nameTd = pacient.querySelector(".info-nome");
            let name = nameTd.textContent;

            let expressionRegular = new RegExp(this.value, "i"); // essa expressão vai buscar por nome a partir das letras primeiro valos eu coloco o que eu quero comparar, segundo se é sensitive
    
            if(!expressionRegular.test(name)){
                pacient.classList.add("invisible");
            }else{
                pacient.classList.remove("invisible")
            }
        }
    }else{
        for(let i=0; i< paciente.length ; i++){
            let pacient = paciente[i];
        pacient.classList.remove("invisible");
        }
    }
})