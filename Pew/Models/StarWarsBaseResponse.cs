namespace Pew.Models
{
    public abstract class StarWarsBaseResponse
    {
        public int count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
    }
}
