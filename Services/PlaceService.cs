using MidtermProj.Models;

namespace MidtermProj.Services;

public class PlaceService
{
    public static readonly string[] Categories = { "Heritage", "Nature", "Food", "Shopping" };

    private readonly List<Place> _places = new()
    {
        new("magellans-cross", "Magellan's Cross", "Heritage", "Downtown",
            "A landmark marking the arrival of Christianity in the Philippines.",
            "Step inside the octagonal pavilion beside the Basilica and discover one of Cebu's most enduring symbols. The painted ceiling tells the story of Magellan's arrival and the baptism of Cebu's first Christians.",
            "Early morning", "Free",
            new[] { "Dress respectfully when visiting.", "Pair your visit with the nearby Basilica.", "Look up to see the historic ceiling mural." },
            "history church landmark downtown",
            Image: "images/places/magellans-cross.jpg"),

        new("basilica-santo-nino", "Basilica del Santo Niño", "Heritage", "Downtown",
            "The Philippines' oldest Roman Catholic church and a beloved pilgrimage site.",
            "Home to the revered image of the Santo Niño, this centuries-old basilica is the spiritual heart of Cebu. Its peaceful courtyard, stone façade, and candle-lit prayer area welcome visitors all day.",
            "Weekday morning", "Free",
            new[] { "Keep voices low inside the basilica.", "Light a candle in the outdoor prayer area.", "Expect crowds during Sinulog season." },
            "church religion history santo nino",
            Image: "images/places/basilica-santo-nino.jpg"),

        new("fort-san-pedro", "Fort San Pedro", "Heritage", "Plaza Independencia",
            "A compact Spanish-era fort with gardens and stories of old Cebu.",
            "Wander through stone ramparts, small galleries, and a leafy central garden at the oldest triangular bastion fort in the country. It is a relaxed window into Cebu's colonial past.",
            "Late afternoon", "₱30",
            new[] { "Walk the ramparts for city views.", "Bring water on sunny days.", "Visit Plaza Independencia afterward." },
            "fort spanish museum history",
            Image: "images/places/fort-san-pedro.jpg"),

        new("taoist-temple", "Taoist Temple", "Heritage", "Beverly Hills",
            "A colorful hilltop sanctuary with ornate architecture and city views.",
            "Built by Cebu's Chinese community, this serene complex rewards the climb with vivid dragons, peaceful prayer halls, and sweeping views toward the city and Mactan.",
            "Early morning", "Free",
            new[] { "Observe silence in prayer areas.", "Photography rules vary by building.", "Prepare for plenty of steps." },
            "temple chinese views hills",
            Image: "images/places/taoist-temple.jpg"),

        new("temple-of-leah", "Temple of Leah", "Heritage", "Busay",
            "A grand Roman-inspired tribute perched high above Cebu City.",
            "This dramatic monument to enduring love features marble halls, towering columns, statues, and a broad terrace overlooking Cebu. It is especially atmospheric in the soft late-afternoon light.",
            "Late afternoon", "₱100",
            new[] { "Arrive before sunset for golden light.", "Bring a light layer, since the hills can be breezy.", "Combine with Tops Lookout nearby." },
            "roman monument views busay",
            Image: "images/places/temple-of-leah.jpg"),

        new("sirao-flower-garden", "Sirao Flower Garden", "Nature", "Sirao",
            "A colorful hillside garden often called Cebu's Little Amsterdam.",
            "Rows of brilliant celosia flowers, playful installations, and mountain air make Sirao an easy escape from the city. The gardens are designed for slow strolls and bright holiday photos.",
            "Morning", "₱100",
            new[] { "Visit on a clear weekday.", "Wear comfortable walking shoes.", "Do not step into flower beds." },
            "flowers garden mountain photos",
            Image: "images/places/sirao-flower-garden.jpg"),

        new("tops-lookout", "Tops Lookout", "Nature", "Busay",
            "Panoramic skyline and sea views from Cebu's cool highlands.",
            "A favorite highland viewpoint where the whole city seems to sparkle below. Stay for sunset, settle in with a snack, and watch Cebu transition from golden hour to city lights.",
            "Sunset", "₱100",
            new[] { "Check the weather before going.", "Bring a light jacket after dark.", "Allow extra travel time at sunset." },
            "viewpoint sunset skyline hills",
            Image: "images/places/tops-lookout.jpg"),

        new("lechon-cebu", "Lechon Cebu", "Food", "Citywide",
            "Cebu's famously crisp, herb-filled roast pig, a true island essential.",
            "Cebu lechon is prized for crackling skin and deeply seasoned meat, traditionally stuffed with lemongrass and local aromatics. Find it at institutions across the city and order by weight.",
            "Lunch", "From ₱250",
            new[] { "Ask for a mix of skin and meat.", "Try it without sauce first.", "Arrive early for the best cuts." },
            "roast pig local cuisine restaurant",
            Image: "images/places/lechon-cebu.jpg"),

        new("larsian-bbq", "Larsian BBQ", "Food", "Fuente Osmeña",
            "A lively open-air barbecue market packed with smoky local favorites.",
            "Choose skewers of pork, chicken, seafood, and vegetables, then watch them hit the grill. Larsian is casual, energetic, and best enjoyed with hanging rice and a cold drink.",
            "Evening", "From ₱20",
            new[] { "Confirm prices before ordering.", "Try puso, Cebu's hanging rice.", "Bring cash in small bills." },
            "barbecue street food night market",
            Image: "images/places/larsian-bbq.jpg"),

        new("colon-street", "Colon Street", "Shopping", "Downtown",
            "The country's oldest street, buzzing with shops and everyday city life.",
            "Historic Colon Street remains a vivid slice of urban Cebu, lined with budget shops, old façades, cinemas, and busy sidewalks. Come for people-watching and affordable finds.",
            "Daytime", "Free",
            new[] { "Keep valuables secure.", "Explore during daylight.", "Walk toward the Heritage of Cebu Monument." },
            "shops history downtown bargains",
            Image: "images/places/colon-street.jpg"),

        new("carbon-market", "Carbon Market", "Shopping", "Downtown",
            "Cebu's largest public market for produce, flowers, food, and local goods.",
            "A sensory feast of tropical fruit, native delicacies, flowers, woven goods, and energetic vendors. The redeveloped market offers a more comfortable way to sample everyday Cebu.",
            "Early morning", "Free",
            new[] { "Bring cash and a reusable bag.", "Try seasonal local fruit.", "Ask before photographing vendors." },
            "market fruit souvenirs local goods",
            Image: "images/places/carbon-market.jpg"),

        new("casa-gorordo", "Casa Gorordo Museum", "Heritage", "Parian",
            "An elegant ancestral home revealing 19th-century Cebuano life.",
            "Beautifully restored rooms, period furniture, and thoughtful exhibits bring the story of a prominent Cebuano family to life. Guided interpretation makes the house especially rewarding.",
            "Mid-morning", "₱120",
            new[] { "Allow about an hour.", "Join a guided tour when available.", "Explore the Parian district afterward." },
            "museum ancestral house culture parian",
            Image: "images/places/casa-gorordo.jpg"),
    };

    public IReadOnlyList<Place> All => _places;
    public Place? GetById(string id) => _places.FirstOrDefault(p => p.Id == id);
    public IEnumerable<Place> Featured() =>
        _places.Where(p => p.Id is "magellans-cross" or "temple-of-leah" or "lechon-cebu");
}