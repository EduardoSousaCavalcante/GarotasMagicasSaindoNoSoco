namespace GMSNS.personagem
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int VidaMaxima { get; set; }
        public int VidaAtual { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }

        public string GolpeFraco { get; set; }
        public string GolpeForte { get; set; }
        public string ComboEspecial { get; set; }

        public Personagem(string nome, int vida, int forca, int defesa, string golpeFraco, string golpeForte, string comboEspecial)
        {
            Nome = nome;
            VidaMaxima = vida;
            VidaAtual = vida;
            Forca = forca;
            Defesa = defesa;
            GolpeFraco = golpeFraco;
            GolpeForte = golpeForte;
            ComboEspecial = comboEspecial;
        }

        public int Atacar(string tipoAtaque)
        {
            return tipoAtaque switch
            {
                "fraco" => Forca,
                "forte" => Forca * 2,
                "especial" => Forca * 3,
                _ => 0
            };
        }

        public void ReceberDano(int dano)
        {
            int danoRecebido = dano - Defesa;
            VidaAtual -= danoRecebido > 0 ? danoRecebido : 0;
            if (VidaAtual < 0) VidaAtual = 0;
        }

        public bool EstaVivo()
        {
            return VidaAtual > 0;
        }
    }
}
