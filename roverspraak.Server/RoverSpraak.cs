namespace roverspraak.Server
{
    public class RoverSpraak
    {
        public int Id { get; set; }
        public DateOnly Created { get; set; }
        public string? Alias { get; set; }
        public string? OriginalText { get; set; }
        public string? RoverText { get; set; }
    }
}
