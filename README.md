# Cebu Explorer

A tourism guide for Cebu City, "The Queen City of the South". Browse heritage sites, highland viewpoints, food stops and markets, then save your favorites to a personal trip list.

Built with **Blazor WebAssembly** (.NET 10) and **Tailwind CSS v4**.

## Features

- **Home:** full-width hero with search, quick city facts, about section, category tiles, tourist areas, featured places, best time to visit, Sinulog festival highlight and travel essentials.
- **Explore:** live search by name, area or keyword, with category filters (Heritage, Nature, Food, Shopping).
- **Place detail:** description, best time to visit, entrance fee, local tips, related places and an Add to my trip button.
- **My Trip:** list of saved stops with remove and clear-all actions. The trip count shows as a badge in the navigation.
- **Not found pages:** friendly fallbacks for unknown routes and unknown places.
- Responsive layout, from phone to desktop.

## Routes

| Route | Page |
|---|---|
| `/` | Home |
| `/explore` | Explore (supports `?q=` and `?category=`) |
| `/explore/{id}` | Place detail |
| `/trip` | My Trip |

## Getting started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (for the Tailwind CLI)

### Run locally

```powershell
# 1. Install dependencies
npm install

# 2. Build the CSS once
npm run css:build

# 3. In one terminal, watch the CSS
npm run css:watch

# 4. In a second terminal, run the app
dotnet watch
```

The app runs at `http://localhost:5184`.

If you change data in `PlaceService.cs`, stop and restart `dotnet watch`. The service is a singleton, so hot reload does not refresh its data.

## Project structure

```
MidtermProj/
├── Components/        Reusable UI (PlaceCard, Icon)
├── Layout/            MainLayout and NavMenu
├── Models/            Place record and image helpers
├── Pages/             Home, Explore, PlaceDetail, MyTrip, NotFound
├── Services/          PlaceService (place data) and TripService (saved trip state)
├── Styles/            tailwind.css (source)
└── wwwroot/
    ├── css/app.css    Compiled Tailwind output
    └── images/places/ Place photos
```

## How it works

- **PlaceService** holds all place data and lookups. Pages never contain raw data.
- **TripService** is a shared singleton that stores saved place ids and raises an `OnChange` event, so the nav badge and pages update together.
- **Icons** are inline SVGs in `Icon.razor`, so there are no emojis or icon libraries.
- **Styling** uses Tailwind utility classes. `Styles/tailwind.css` compiles to `wwwroot/css/app.css`.

## Adding a place

1. Put a photo in `wwwroot/images/places/`.
2. Add a new entry to the list in `Services/PlaceService.cs`, with `Image: "images/places/your-photo.jpg"` as the last argument.
3. Restart `dotnet watch`.

## Notes

- Your trip is stored in memory only, so a page refresh clears it.
- City facts and prices are approximate and may change.

## Credits

Photos: add your photo credits here.