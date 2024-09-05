function isPar(numero){
    return numero % 2 == 0;
}

function verificar() {
    const numero = document.getElementById('numero').value;
    const resultado = document.getElementById('resultado');

    if (numero === '') {
        resultado.textContent = 'Por favor, insira um número.';
        return;
    }

    if (isPar(numero)) {
        resultado.textContent = `O número ${numero} é Par.`;
        return true;
    } else {
        resultado.textContent = `O número ${numero} é Ímpar.`;
        return false;
    }
}

module.exports = { isPar };