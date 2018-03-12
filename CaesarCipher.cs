public class CaesarCipher
{
    public string rot13(string str)
    {
        str = str.ToUpper();
        char[] buffer = str.ToCharArray();
        string newStr = "";

        for (var i = 0; i < buffer.Length; i++)
        {
            if (buffer[i] >= 65 && buffer[i] <= 90)
            {
                int tempNum = (buffer[i] + 13);

                if (tempNum > 90)
                {
                    tempNum -= 26;
                }

                newStr += (char)tempNum;
            }
            else
            {
                newStr += str[i];
            }
        }

        return newStr;
    }
}