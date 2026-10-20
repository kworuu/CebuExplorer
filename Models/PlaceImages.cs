namespace MidtermProj.Models;

public static class PlaceImages
{
    public const string Hero =
        "https://images.unsplash.com/photo-1495162048225-6b3b37b8a69e?auto=format&fit=crop&w=1800&q=88";

    public static string ForCategory(string category) => category switch
    {
        "Heritage" => "https://images.unsplash.com/photo-1751814584947-cf00331c8183?auto=format&fit=crop&w=1000&q=82",
        "Nature"   => "https://images.unsplash.com/photo-1588439977971-1c3a00ee8bc7?auto=format&fit=crop&w=1000&q=82",
        "Food"     => "https://images.unsplash.com/photo-1583637120022-259646969b6a?auto=format&fit=crop&w=1000&q=82",
        _          => "https://images.unsplash.com/photo-1751814584924-48c8feb87345?auto=format&fit=crop&w=1000&q=82",
    };
}