# Music Store Generator

> Deterministic music store with 1,000 AI-generated songs, browser-based audio synthesis, and multi-language support.

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Live Demo](https://img.shields.io/badge/demo-live-success)](https://music-store-generator-0bt0.onrender.com)

**[Live Demo](https://music-store-generator-0bt0.onrender.com/)** 

---

## ✨ Features

- 🎲 **Deterministic Generation** - Same seed always produces identical results
- 🌍 **Multi-Language** - English, German, Ukrainian with native names
- 🎵 **Audio Synthesis** - Real-time music generation in browser (Web Audio API)
- 📦 **Export to ZIP** - Download all 1,000 songs as WAV files
- 🎤 **Synced Lyrics** - Auto-scrolling lyrics during playback
- 🎨 **Dual Views** - Table with pagination + Gallery with infinite scroll
- 🖼️ **Dynamic Art** - Procedurally generated album covers

---
## 📚 API Endpoints

- `GET /api/songs`
  - **Query Parameters:**
    - `seed` (long): Deterministic seed for song generation
    - `page` (int): Page number
    - `pageSize` (int): Songs per page
    - `likesValue` (double): Filter by likes
    - `locale` (string): Language (`en-US`, `de-DE`, `uk-UA`)
  - **Response:**
    {
  "page": 1,
  "pageSize": 10,
  "totalCount": 1000,
  "totalPages": 100,
  "data": [ ... ]
}

## 📁 Project Structure

- `Services/SongGenerator.cs` - Core deterministic song generator
- `Locales/LocaleProvider.cs` - Multi-language data provider
- `Controllers/SongsController.cs` - API endpoint logic
- `wwwroot/index.html` - Interactive frontend (Table/Gallery, audio, export)
- `.gitignore` - Clean build artifacts

## 🚀 Quick Start
```bash
git clone https://github.com/yourusername/music-store-generator.git
cd music-store-generator
dotnet run
# Open https://localhost:5001
```

---

## 🛠️ Tech Stack

**Backend:** ASP.NET Core 8.0, Bogus (Faker), C# 12  
**Frontend:** Vanilla JS, Web Audio API, Canvas API, JSZip  
**Architecture:** RESTful API, Stateless, Deterministic RNG

---
## 🙏 Acknowledgements

- [Bogus](https://github.com/bchavez/Bogus) for fake data generation
- [JSZip](https://stuk.github.io/jszip/) for ZIP export
- [Web Audio API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Audio_API)

