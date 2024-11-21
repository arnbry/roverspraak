namespace roverspraak.Server
{
    public class RoverSpraakText
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string? Alias { get; set; }
        public string? OriginalText { get; set; }
        public string? RoverText { get; set; }
    }
}
