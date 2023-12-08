namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        
        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {

        }
public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo: {nomeApp}" );
        }
    }
}