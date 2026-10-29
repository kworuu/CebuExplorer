namespace MidtermProj.Models;

public static class PlaceImages
{
    public const string Hero =
        "https://images.unsplash.com/photo-1495162048225-6b3b37b8a69e?auto=format&fit=crop&w=1800&q=88";

    public static string ForCategory(string category) => category switch
    {
        "Heritage" => "images/places/magellans-cross.jpg",
        "Nature"   => "images/places/tops-lookout.jpg",
        "Food"     => "images/places/lechon-cebu.jpg",
        _          => "images/places/colon-street.jpg",
    };
}