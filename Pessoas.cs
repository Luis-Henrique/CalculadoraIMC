public class Pessoas
{
    public string nome { get; set; }
    public float altura { get; set; }
    public float peso { get; set; }

    public Pessoas(string Nome, float Altura, float Peso)
    {
        nome = Nome;
        altura = Altura;
        peso = Peso;
    }
}