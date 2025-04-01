namespace GMSNS.personagem.sahiku
{
    public class Sahiku : Personagem
    {
        public Sahiku() : base("Sahiku", 120, 15, 8, "Golpe Sutil", "Chute Devastador", "Fúria das Sombras")
        {
        }

        // Exemplo de habilidade especial
        public int ExecutarComboEspecial()
        {
            return Forca * 3;
        }
    }
}
