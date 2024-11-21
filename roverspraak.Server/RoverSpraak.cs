using System.Text;

namespace roverspraak.Server
{
    public class RoverSpraak
    {
        public required string Id { get; set; }
        public DateOnly Created { get; set; }
        public string? Alias { get; set; }
        public string? OriginalText { get; set; }
        public string? RoverText => ConvertToRoverSpraak(OriginalText);

        private string ConvertToRoverSpraak(string? OriginalText)
        {
            if (string.IsNullOrEmpty(OriginalText))
            {
                return string.Empty;
            }
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            var result = new StringBuilder();

            foreach (var character in OriginalText)
            {
                if (char.IsLetter(character) && !vowels.Contains(character))
                {
                    result.Append(character).Append('o').Append(character);
                }
                else result.Append(character);
            }
            return result.ToString();
        }
    }
}
