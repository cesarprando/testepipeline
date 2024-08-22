# CI/CD Pipeline

Este projeto utiliza GitHub Actions para CI/CD.

## Estrutura

- `src/`: Código fonte da aplicação.
- `tests/`: Testes automatizados com NUnit.
- `.github/workflows/ci.yml`: Pipeline de CI/CD.

## Como Funciona

1. O pipeline é acionado em cada push e pull request para a branch `main`.
2. Executa o build e os testes automatizados.
3. Em caso de sucesso, realiza o deploy para o serviço de hospedagem configurado.
4. Envia notificações em caso de sucesso ou falha.

## Contribuindo

Para contribuir, siga as etapas abaixo:

1. Faça um fork deste repositório.
2. Crie uma branch para a sua funcionalidade (`git checkout -b feature/nome-da-feature`).
3. Faça commit das suas alterações (`git commit -m 'Adiciona nova funcionalidade'`).
4. Faça push para a branch (`git push origin feature/nome-da-feature`).
5. Abra um Pull Request. 
