

using examen_pratique_poo;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ResistanceCordeVrai()
        {
            Corde corde1 = new Corde();
            Corde corde2 = new Corde();

            bool resultatAttendu = true;
            bool resultatObtenu = corde1 < corde2;

            Assert.Equal(resultatAttendu, resultatObtenu);
        }

        [Fact]
        public void ResistanceCordeFaux()
        {
            Corde corde1 = new Corde();
            Corde corde2 = new Corde();

            bool resultatAttendu = false;
            bool resultatObtenu = corde1 > corde2;

            Assert.Equal(resultatAttendu, resultatObtenu);
        }
    }
}
