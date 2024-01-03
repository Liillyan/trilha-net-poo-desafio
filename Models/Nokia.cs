namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string Numero, string Modelo, string Imei, int Memoria) : base(Numero, Modelo, Imei, Memoria)  
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado com sucesso no seu Nokia!");
        }
        
    }
}