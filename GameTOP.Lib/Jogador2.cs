using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas Pateando";
        }

        public string Corre()
        {
            return "Maradona estas Corriendo";
        }

        public string Passe()
        {
            return "Maradona estas pasando";
        }
    }
}