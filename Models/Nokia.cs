namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia {Modelo}...");
        }
    }
}




// namespace DesafioPOO.Models
// {
//     // TODO: Herdar da classe "Smartphone"
//     public class Nokia
//     {
//         // TODO: Sobrescrever o método "InstalarAplicativo"
//     }
// }