using Bogus;
using MusicStoreApi.Models;
using MusicStoreApi.Rng;
using MusicStoreApi.Locales;

namespace MusicStoreApi.Services;

public class SongGenerator
{
    private const int TOTAL_SONGS = 1000;

    public PagedResult<Song> GenerateSongs(
        long seed,
        int page = 1,
        int pageSize = 5,
        double likesValue = 0.0,
        string locale = "en-US")
    {
        var songs = new List<Song>();
        int startIndex = (page - 1) * pageSize;
        var localeData = LocaleProvider.GetLocale(locale);

        // Map unsupported locales to supported ones for Bogus
        string bogusLocale = locale switch
        {
            "en-US" => "en",
            // Add more mappings if needed
            _ => locale
        };

        for (int i = 0; i < pageSize; i++)
        {
            int absoluteIndex = startIndex + i;

            // Stop if we exceed total songs
            if (absoluteIndex >= TOTAL_SONGS)
                break;

            // METADATA GENERATION USING BOGUS 
            // Set seed for Bogus to ensure reproducibility
            Randomizer.Seed = new Random((int)(seed + absoluteIndex));

            // Create Faker instance with specific locale
            var faker = new Faker(bogusLocale);

            // Use our custom RNG for some specific logic
            var metadataRandom = new DeterministicRandom((ulong)(seed + absoluteIndex));

            // GENERATE SONG TITLE 
            string title;
            int titleVariant = metadataRandom.NextInt(0, 4);
            switch (titleVariant)
            {
                case 0:
                    // Use album word + number
                    title = localeData.AlbumWords[metadataRandom.NextInt(0, localeData.AlbumWords.Length)]
                            + " " + faker.Random.Number(1, 100);
                    break;
                case 1:
                    // Use two random words from Bogus
                    title = faker.Commerce.ProductAdjective() + " " + faker.Commerce.ProductMaterial();
                    break;
                case 2:
                    // Use album word + suffix
                    title = localeData.AlbumWords[metadataRandom.NextInt(0, localeData.AlbumWords.Length)]
                            + " Dreams";
                    break;
                default:
                    // Use "The" + album word
                    title = "The " + localeData.AlbumWords[metadataRandom.NextInt(0, localeData.AlbumWords.Length)];
                    break;
            }

            // GENERATE ARTIST NAME
            string artist;
            bool isBandName = faker.Random.Bool(); // 50% chance of band vs personal name

            if (isBandName)
            {
                // Generate band name
                int bandVariant = metadataRandom.NextInt(0, 3);
                switch (bandVariant)
                {
                    case 0:
                        // "The [Adjective] [Nouns]"
                        artist = "The " + faker.Commerce.ProductAdjective() + " " + faker.Commerce.Department();
                        break;
                    case 1:
                        // "[Name]'s [Word]"
                        artist = localeData.LastNames[metadataRandom.NextInt(0, localeData.LastNames.Length)]
                                + "'s " + localeData.AlbumWords[metadataRandom.NextInt(0, localeData.AlbumWords.Length)];
                        break;
                    default:
                        // "[Word] [Word]"
                        artist = localeData.AlbumWords[metadataRandom.NextInt(0, localeData.AlbumWords.Length)]
                                + " " + faker.Commerce.Department();
                        break;
                }
            }
            else
            {
                // Generate personal name using Faker
                artist = faker.Name.FullName();
            }

            // GENERATE ALBUM 
            string album;
            if (faker.Random.Double() > 0.3)
            {
                // Album collection
                int albumVariant = metadataRandom.NextInt(0, 3);
                switch (albumVariant)
                {
                    case 0:
                        album = localeData.AlbumWords[metadataRandom.NextInt(0, localeData.AlbumWords.Length)] + " Collection";
                        break;
                    case 1:
                        album = faker.Commerce.ProductName() + " Album";
                        break;
                    default:
                        album = localeData.AlbumWords[metadataRandom.NextInt(0, localeData.AlbumWords.Length)]
                                + " " + faker.Random.Number(1, 5);
                        break;
                }
            }
            else
            {
                album = "Single";
            }

            // GENERATE GENRE
            string genre = localeData.Genres[metadataRandom.NextInt(0, localeData.Genres.Length)];

            // GENERATE REVIEW 
            string adjective = localeData.Adjectives[metadataRandom.NextInt(0, localeData.Adjectives.Length)];
            string quality = localeData.Qualities[metadataRandom.NextInt(0, localeData.Qualities.Length)];

            string reviewTemplate = metadataRandom.NextInt(0, 3) switch
            {
                0 => $"A {adjective} track with outstanding {quality}.",
                1 => $"Features {adjective} {quality} that captivates listeners.",
                _ => $"The {adjective} {quality} makes this track unforgettable."
            };

            // CALCULATE LIKES (INDEPENDENT RNG)
            // Separate RNG for likes to ensure parameter independence
            var likesRandom = new DeterministicRandom((ulong)(seed + absoluteIndex + 999999));

            int baseLikes = (int)Math.Floor(likesValue);
            double fraction = likesValue - baseLikes;
            int calculatedLikes = baseLikes;

            if (likesRandom.NextDouble() < fraction)
            {
                calculatedLikes += 1;
            }

            // ===== CREATE SONG OBJECT =====
            songs.Add(new Song
            {
                Index = absoluteIndex + 1,
                Title = title,
                Artist = artist,
                Album = album,
                Genre = genre,
                Likes = calculatedLikes,
                Review = reviewTemplate
            });
        }

        int totalPages = (int)Math.Ceiling((double)TOTAL_SONGS / pageSize);

        return new PagedResult<Song>
        {
            Page = page,
            PageSize = pageSize,
            TotalCount = TOTAL_SONGS,
            TotalPages = totalPages,
            Data = songs
        };
    }
}