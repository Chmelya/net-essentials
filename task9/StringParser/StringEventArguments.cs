namespace StringParserLibarary
{ 
    public class StringEventArguments
    {
        public char Letter { get; set; }
        public int Count { get; set; }

        public StringEventArguments(char letter, int count)
        {
            Letter = letter;
            Count = count;
        }
    }
}
