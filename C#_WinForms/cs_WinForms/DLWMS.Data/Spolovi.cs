namespace DLWMS.Data
{
    public class Spolovi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return $"{Naziv}";
        }
        // public bool Aktivan { get; set; }
    }
}