

document.getElementById('nome').addEventListener('keyup', login);
document.getElementById('sobrenome').addEventListener('keyup', login);

function login() {
    const nome = document.getElementById('nome').value;
    const sobrenome = document.getElementById('sobrenome').value;
    const login = nome + '.' + sobrenome;
    document.getElementById('Login').value = login.toLowerCase();
}
function updateTable() {
    document.getElementById('Login').disabled = false;
    let queryString = $('#form').serializeArray();

    queryString.forEach(element => {
        if (element.nome == "agreeTerms") {
            $('#gridCheck').prop('checked', false);
        }
        else if (element.nome != 'radios') {
            let inputId = 'input' + capitalizeFirstLetter(element.nome);

            document.getElementById(element.nome).innerHTML = element.value;
            document.getElementById(inputId).value = "";
        }
    });
    document.getElementById('Login').disabled = true;
    document.getElementById('radios').checked = true;
}

function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}



function limpa_formulario_cep() {
    //Limpa valores do formulário de cep.
    document.getElementById('endereco').value=("");
    document.getElementById('bairro').value=("");
    document.getElementById('cidade').value=("");
    document.getElementById('estado').value=("");
    
}

function meu_callback(conteudo) {
if (!("erro" in conteudo)) {
    //Atualiza os campos com os valores.
    document.getElementById('endereco').value=(conteudo.logradouro);
    document.getElementById('bairro').value=(conteudo.bairro);
    document.getElementById('cidade').value=(conteudo.localidade);
    document.getElementById('estado').value=(conteudo.uf);
} //end if.
else {
    //CEP não Encontrado.
    limpa_formulario_cep();
    alert("CEP não encontrado.");
    document.getElementById('cep').value=("");
}
}

function pesquisacep(valor) {

//Nova variável "cep" somente com dígitos.
var cep = valor.replace(/\D/g, '');

//Verifica se campo cep possui valor informado.
if (cep !== "") {

    //Expressão regular para validar o CEP.
    var validacep = /^[0-9]{8}$/;

    //Valida o formato do CEP.
    if(validacep.test(cep)) {

        //Preenche os campos com "..." enquanto consulta webservice.
        document.getElementById('endereco').value="...";
        document.getElementById('bairro').value="...";
        document.getElementById('cidade').value="...";
        document.getElementById('estado').value="...";

        //Cria um elemento javascript.
        var script = document.createElement('script');

        //Sincroniza com o callback.
        script.src = '//viacep.com.br/ws/'+ cep + '/json/?callback=meu_callback';

        //Insere script no documento e carrega o conteúdo.
        document.body.appendChild(script);

    } //end if.
    else {
        //cep é inválido.
        limpa_formulario_cep();
        alert("Formato de CEP inválido.");
    }
} //end if.
else {
    //cep sem valor, limpa formulário.
    limpa_formulario_cep();
}
}


var capturar = "";

function Salvar(){

    capturar = document.getElementById('nome').value;
    document.getElementById('valordigitado-nome').innerHTML = capturar;

    capturar = document.getElementById('sobrenome').value;
    document.getElementById('valordigitado-sobrenome').innerHTML = capturar;

    capturar = document.getElementById('email').value;
    document.getElementById('valordigitado-email').innerHTML = capturar;

    capturar = document.getElementById('login').value;
    document.getElementById('valordigitado-login').innerHTML = capturar;

    capturar = document.getElementById('senha').value;
    document.getElementById('valordigitado-senha').innerHTML = capturar;

    capturar = document.getElementById('endereco').value;
    document.getElementById('valordigitado-rua').innerHTML = capturar;

    capturar = document.getElementById('numero').value;
    document.getElementById('valordigitado-numero').innerHTML = capturar;

    capturar = document.getElementById('bairro').value;
    document.getElementById('valordigitado-bairro').innerHTML = capturar;

    capturar = document.getElementById('estado').value;
    document.getElementById('valordigitado-estado').innerHTML = capturar;

    capturar = document.getElementById('cidade').value;
    document.getElementById('valordigitado-cidade').innerHTML = capturar;

    capturar = document.getElementById('github').value;
    document.getElementById('valordigitado-github').innerHTML = capturar;

    capturar = document.getElementById('academia').value;
    document.getElementById('valordigitado-academia').innerHTML = capturar;


    capturar = document.getElementById('professor').value;
    document.getElementById('valordigitado-professor').innerHTML = capturar;
    

}


document.getElementById('form-horizontal').addEventListener('submit', function (e){
    e.preventDefault();
    document.getElementById('tabela-dados')
    alert('Submetido');
 });


 





documentgetElementById('.nome').addEventListener('keyup', gerarLogin);
document.getElementById('.sobrenome').addEventListener('keyup', gerarLogin);

function gerarLogin(){
    const nome = document.getElementById('.nome').value;
    const sobrenome = document.getElementById('.sobrenome').value;
    const login = nome + "." + sobrenome;

    document.getElementById('.login').value = login.toLowerCase();
}