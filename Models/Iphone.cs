namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone {Modelo} via App Store...");
        }
    }
}





// namespace DesafioPOO.Models
// {
//     // TODO: Herdar da classe "Smartphone"
//     public class Iphone
//     {
//         // TODO: Sobrescrever o método "InstalarAplicativo"
//     }
// }