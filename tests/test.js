const { isPar } = require('../src/script');

test('verifica se 4 é par', () => {
  const isParResult = isPar(4);
  expect(isParResult).toBe(true);
});

test('verifica se 3 é ímpar', () => {
  const isParResult = isPar(3);
  expect(isParResult).toBe(false);
});