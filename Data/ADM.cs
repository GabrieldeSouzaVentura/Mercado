namespace Mercado.Data;
class Moderador
{
    private string ADM = "gsventura";
    private string SenhaADM = "12345678Gs.";
    
    public bool Validacao(string usuario, string senha)
    {
        return usuario == ADM || senha == SenhaADM;
    }
}
