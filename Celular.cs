namespace AulaPOOCelular_C_
{
    public class Celular
    {
        public string cor = "Black";
        public string modelo = "Iphone";
        public string Tamanho = "6.53 Polegadas";
        public string Espaço = "256GB";
        public string Sistema = "iOS 11.3";
        public string camera = "12 MP";
        public string resolução = "1125 x 2436px";
        private bool ligado = false;

        public bool Ligar()
        {
            ligado = true;
            return (true);
        }
        public bool Desligar()
        {
            ligado = false;
            return (false);
        }
        public void Ligacao()
        {
        }
        public void EnviarMensagem()
        {
        }
    }
}