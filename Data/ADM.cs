namespace Mercado.Data;
class Moderador
{
    private string ADM = "qwer";
    private string SenhaADM = "1234";
    
    public bool Validacao(string usuario, string senha)
    {
        return usuario == ADM && senha == SenhaADM;
    }
}
