namespace CalculaJurosAPI.Business
{
    public interface ICalculoJurosBusiness
    {
        decimal ObterJurosComposto(decimal valorInicial, int meses);
    }
}
