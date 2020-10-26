namespace StringParserLibarary
{
    public interface IStringParser
    {
        public event StringEventHandler OnStringContainsBLetter;
        public event StringEventHandler OnStringContainsZLetter;

        public void Parse(string str);
    }
}
