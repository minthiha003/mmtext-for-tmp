
using mmfont.Net;

public static class FontHelper 
{
    public static string Uni2Zg(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return "";
        
        return MmFont.Uni2Zg(str);
    }
}
