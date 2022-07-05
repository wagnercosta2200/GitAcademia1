
document.getElementById('form').addEventListener('submit', function (e) {
    e.preventDefault();
    alert('Registration finished');
    updateTable();
    document.getElementById('table').classList.remove('d-none');
});

document.getElementById('inputnome').addEventListener('keyup', login);
document.getElementById('inputsobrenome').addEventListener('keyup', login);

try {
    document.getElementById('inputcep').addEventListener('focusout', async function (e) {
        let data = await fetch(`https://viacep.com.br/ws/${inputcep.value}/json/`);
        let cep = await data.json();

        document.getElementById('inputEndereço').value = cep.logradouro;
        document.getElementById('inputComplemento').value = cep.complemento;
        document.getElementById('inputBairro').value = cep.bairro;
        document.getElementById('inputCidade').value = cep.localidade;
        document.getElementById('inputEstado').value = cep.uf;
    });
}
catch (err) { }

function login() {
    const nome = document.getElementById('inputnome').value;
    const sobrenome = document.getElementById('inputsobrenome').value;
    const login = nome + '.' + sobrenome;
    document.getElementById('inputLogin').value = login.toLowerCase();
}

function updateTable() {
    document.getElementById('inputLogin').disabled = false;
    let queryString = $('#form').serializeArray();

    queryString.forEach(element => {
        if (element.name == "agreeTerms") {
            $('#gridCheck').prop('checked', false);
        }
        else if (element.name != 'radios') {
            let inputId = 'input' + capitalizeFirstLetter(element.name);

            document.getElementById(element.name).innerHTML = element.value;
            document.getElementById(inputId).value = "";
        }
    });
    document.getElementById('inputLogin').disabled = true;
    document.getElementById('radios').checked = true;
}

function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}


var capturar = "";

function Salvar(){

    capturar = document.getElementById('nome').value;
    document.getElementById('nome').innerHTML = capturar;

    capturar = document.getElementById('sobrenome').value;
    document.getElementById('sobrenome').innerHTML = capturar;

    capturar = document.getElementById('email').value;
    document.getElementById('email').innerHTML = capturar;

    capturar = document.getElementById('login').value;
    document.getElementById('login').innerHTML = capturar;

    capturar = document.getElementById('passaword').value;
    document.getElementById('passaword').innerHTML = capturar;

    capturar = document.getElementById('endereco').value;
    document.getElementById('rua').innerHTML = capturar;

    capturar = document.getElementById('complemento').value;
    document.getElementById('complemento').innerHTML = capturar;

    capturar = document.getElementById('bairro').value;
    document.getElementById('bairro').innerHTML = capturar;

    capturar = document.getElementById('estado').value;
    document.getElementById('estado').innerHTML = capturar;

    capturar = document.getElementById('cidade').value;
    document.getElementById('cidade').innerHTML = capturar;

    capturar = document.getElementById('github').value;
    document.getElementById('vgithub').innerHTML = capturar;

    capturar = document.getElementById('academia').value;
    document.getElementById('academia').innerHTML = capturar;


    capturar = document.getElementById('professor').value;
    document.getElementById('professor').innerHTML = capturar;
    

}

document.getElementById('container').addEventListener('submit', function (e){
    e.preventDefault();
    document.getElementById('tabela-dados')
    alert('Submetido');
 });