namespace Behnammby.Common.Services
{
    public interface IHashService
    {
        string Encode(int id);
        int Decode(string hash);
    }
}