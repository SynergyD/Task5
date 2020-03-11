using System.Text;

namespace Task5ConvertNumberToText
{
    public class MyStringBuilder
    {
        public MyStringBuilder(StringBuilder stringBuilder)
        {
            this.stringBuilder = stringBuilder;
        }

        public void Append (string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return;
            }
            
            if (this.inserSpace)
            {
                this.stringBuilder.Append(' ');
            }
            
            else
            {
                this.inserSpace = true;
            }
 
            this.stringBuilder.Append (s);
        }
 
        public override string ToString ()
        {
            return stringBuilder.ToString ();
        }
        
        private readonly StringBuilder stringBuilder;

        private bool inserSpace = false;
    }
}