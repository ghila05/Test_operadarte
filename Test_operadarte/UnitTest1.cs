using quadro.libreria;
namespace Test_operadarte

{
    public class UnitTest1
    {
        Quadro q1 = new Quadro("Monet", 190, 160, 650, 100);
        Quadro q2 = new Quadro("ghila", 200, 100, 250, 50);

        [Fact]
        public void Test1()
        {
            Assert.False(q1.Equals(q2));
        }

        [Fact]
        public void Test2()
        {
            q1.ModDati(100, 100, 700, 150);
            Assert.True(q1.Altezza == 100);
            

        }

        [Fact]
        public void Test3()
        {
            Assert.True(q1.Confronta(q1, q2) == "il quadro " + q1 + " ha prezzo maggiore");

        }
        [Fact]
        public void Test4()
        {
            q1.Prezzofin();
            float a = q1.PrezzoOff + q1.PrezzoTras;
            Assert.True(q1.Prezzofin() == Convert.ToString(a));
        }
        [Fact]
        public void Test5()
        {
            Assert.True(q2.Ultimaoff() == Convert.ToString(q2.PrezzoOff));
            q2.Offerta(450);
            Assert.True(q2.Ultimaoff() == Convert.ToString(q2.PrezzoOff));
        }

        [Fact]
        public void Test6()
        {
            q2.Trasporto();
            Assert.True(q2.RichiediTras);
        }

        [Fact]
        public void Test7()
        {
            q2.ModDati(10, 20, 585, 3);
            float a = q2.PrezzoTras;

            Assert.True(q2.PrezzoTras == a);
        }

        [Fact]
        public void Test8()
        {
            q2.ModDati(10, 20, 585, 3);
            float a = q2.PrezzoTras;

            Assert.True(q2.PrezzoTras == a);
        }

    }
}