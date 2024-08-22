namespace ParOuImpar.Test
{
    public class CalculadoraDeParOuImparTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, false)]
        [TestCase(4, true)]
        public void Deve_Testar_Numero(int numero, bool esperado)
        {
            var result = CalculadoraDeParOuImpar.IsPar(numero);

            Assert.That(result, Is.EqualTo(esperado));
        }
    }
}