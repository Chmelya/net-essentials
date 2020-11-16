namespace StringParserLibarary
{
    public class StringParser: IStringParser
    {
        public event StringEventHandler OnStringContainsBLetter;
        public event StringEventHandler OnStringContainsZLetter;
        public void Parse(string str)
        {
            var buffer = str.ToLower().ToCharArray();

            int bCount = 0;
            int zCount = 0;

            foreach(var letter in buffer)
            {
                if(letter.CompareTo('b') == 0)
                {
                    bCount++;
                    continue;
                }
                if (letter.CompareTo('z') == 0)
                {
                    zCount++;
                    continue;
                }
            }

            OnStringContainsBLetter(this, new StringEventArguments('B', bCount));
            OnStringContainsZLetter(this, new StringEventArguments('Z', zCount));
        }
    }
}
