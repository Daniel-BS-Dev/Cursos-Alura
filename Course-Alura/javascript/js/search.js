let buttonSearch = document.querySelector(".buttonSearch");
buttonSearch.addEventListener("click", function(){
    
    let xhr = new XMLHttpRequest();  // objeto responsavel de fazer requisições HTTP

    xhr.open("GET", "https://api-pacientes.herokuapp.com/pacientes"); // abre minha conexão, local onde eu coloco o verbo e a url 

    xhr.addEventListener("load", function(){
       
        if(xhr.status == 200){
            let response = xhr.responseText;

            let pacient = JSON.parse(response); // transformando minga string em JSON
        
            pacient.forEach(element => {
                addPacientInTable(element)

    
        });
    }else{
        console.log("error");
    }
    
    })

    
    xhr.send(); // envia minha conexão
})
