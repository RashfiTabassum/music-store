namespace MusicStoreApi.Locales;

public static class LocaleProvider
{
    public static LocaleData GetLocale(string locale)
    {
        return locale switch
        {
            "de-DE" => GetGerman(),
            "uk-UA" => GetUkrainian(),
            _ => GetEnglish()
        };
    }

    private static LocaleData GetEnglish()
    {
        return new LocaleData
        {
            FirstNames = new[]
            {
                "James", "Emma", "Michael", "Olivia", "William", "Ava", "Alexander", "Sophia",
                "Benjamin", "Isabella", "Lucas", "Mia", "Henry", "Charlotte", "Theodore", "Amelia",
                "Jack", "Harper", "Leo", "Evelyn", "Oliver", "Abigail", "Daniel", "Emily",
                "Matthew", "Elizabeth", "Samuel", "Sofia", "David", "Avery", "Joseph", "Ella",
                "Carter", "Madison", "Owen", "Scarlett", "Wyatt", "Victoria", "John", "Aria",
                "Sebastian", "Grace", "Jackson", "Chloe", "Levi", "Camila", "Mason", "Luna"
            },
            LastNames = new[]
            {
                "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis",
                "Rodriguez", "Martinez", "Hernandez", "Lopez", "Wilson", "Anderson", "Thomas", "Taylor",
                "Moore", "Jackson", "Martin", "Lee", "Thompson", "White", "Harris", "Clark",
                "Lewis", "Robinson", "Walker", "Young", "Allen", "King", "Wright", "Scott",
                "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams", "Nelson", "Baker",
                "Hall", "Rivera", "Campbell", "Mitchell", "Carter", "Roberts", "Phillips", "Evans"
            },
            AlbumWords = new[]
            {
                "Midnight", "Echo", "Dream", "Shadow", "Fire", "Thunder", "Crystal", "Silver",
                "Golden", "Electric", "Cosmic", "Velvet", "Diamond", "Neon", "Twilight", "Storm",
                "Ocean", "Phoenix", "Aurora", "Mystic", "Eternal", "Celestial", "Radiant", "Infinite",
                "Horizon", "Paradise", "Enigma", "Symphony", "Harmony", "Whisper", "Serenity", "Destiny",
                "Journey", "Legacy", "Odyssey", "Revolution", "Genesis", "Sanctuary", "Utopia", "Eclipse"
            },
            Genres = new[]
            {
                "Rock", "Pop", "Jazz", "Electronic", "Hip-Hop", "R&B", "Country", "Blues",
                "Classical", "Metal", "Indie", "Folk", "Reggae", "Soul", "Funk", "Disco",
                "Techno", "House", "Ambient", "Punk"
            },
            Adjectives = new[]
            {
                "emotional", "energetic", "melancholic", "vibrant", "atmospheric", "powerful",
                "haunting", "uplifting", "nostalgic", "captivating", "mesmerizing", "dynamic",
                "introspective", "euphoric", "somber", "jubilant", "ethereal", "raw", "polished", "experimental"
            },
            Qualities = new[]
            {
                "composition", "rhythm", "melody", "production", "arrangement", "vocals",
                "instrumentation", "lyrics", "harmony", "groove", "soundscape", "performance",
                "mixing", "energy", "progression", "texture", "dynamics", "atmosphere"
            }
        };
    }

    private static LocaleData GetGerman()
    {
        return new LocaleData
        {
            FirstNames = new[]
            {
                "Lukas", "Anna", "Felix", "Mia", "Leon", "Emma", "Paul", "Hannah",
                "Ben", "Sophia", "Jonas", "Emilia", "Noah", "Lina", "Elias", "Marie",
                "Finn", "Ella", "Louis", "Clara", "Henry", "Lea", "Max", "Sophie",
                "Oscar", "Johanna", "Theo", "Charlotte", "Anton", "Amelie", "Karl", "Laura",
                "Fritz", "Greta", "Otto", "Frieda", "Gustav", "Ida", "Wilhelm", "Martha"
            },
            LastNames = new[]
            {
                "Müller", "Schmidt", "Schneider", "Fischer", "Weber", "Meyer", "Wagner", "Becker",
                "Schulz", "Hoffmann", "Schäfer", "Koch", "Bauer", "Richter", "Klein", "Wolf",
                "Schröder", "Neumann", "Schwarz", "Zimmermann", "Braun", "Krüger", "Hofmann", "Hartmann",
                "Lange", "Schmitt", "Werner", "Schmitz", "Krause", "Meier", "Lehmann", "Schmid",
                "Schulze", "Maier", "Köhler", "Herrmann", "Walter", "König", "Huber", "Kaiser"
            },
            AlbumWords = new[]
            {
                "Mitternacht", "Klang", "Traum", "Schatten", "Feuer", "Donner", "Kristall", "Silber",
                "Gold", "Elektrisch", "Kosmisch", "Samt", "Diamant", "Neon", "Dämmerung", "Sturm",
                "Ozean", "Phönix", "Nordlicht", "Mystisch", "Ewig", "Himmlisch", "Strahlend", "Unendlich",
                "Horizont", "Paradies", "Rätsel", "Symphonie", "Harmonie", "Flüstern", "Gelassenheit", "Schicksal",
                "Reise", "Vermächtnis", "Odyssee", "Revolution", "Genesis", "Heiligtum", "Utopie", "Finsternis"
            },
            Genres = new[]
            {
                "Rock", "Pop", "Jazz", "Elektronisch", "Hip-Hop", "R&B", "Schlager", "Blues",
                "Klassik", "Metal", "Indie", "Folk", "Reggae", "Soul", "Funk", "Disco",
                "Techno", "House", "Ambient", "Punk"
            },
            Adjectives = new[]
            {
                "emotional", "energetisch", "melancholisch", "lebhaft", "atmosphärisch", "kraftvoll",
                "eindringlich", "erhebend", "nostalgisch", "fesselnd", "hypnotisierend", "dynamisch",
                "introspektiv", "euphorisch", "düster", "freudig", "ätherisch", "roh", "poliert", "experimentell"
            },
            Qualities = new[]
            {
                "Komposition", "Rhythmus", "Melodie", "Produktion", "Arrangement", "Gesang",
                "Instrumentierung", "Text", "Harmonie", "Groove", "Klanglandschaft", "Performance",
                "Abmischung", "Energie", "Progression", "Textur", "Dynamik", "Atmosphäre"
            }
        };
    }

    private static LocaleData GetUkrainian()
    {
        return new LocaleData
        {
            FirstNames = new[]
            {
                "Олександр", "Анна", "Дмитро", "Марія", "Іван", "Катерина", "Максим", "Ольга",
                "Андрій", "Наталія", "Микола", "Ірина", "Сергій", "Юлія", "Володимир", "Тетяна",
                "Петро", "Людмила", "Віктор", "Світлана", "Богдан", "Оксана", "Ярослав", "Вікторія",
                "Олег", "Дарія", "Роман", "Софія", "Тарас", "Галина", "Михайло", "Валентина",
                "Василь", "Лариса", "Юрій", "Олена", "Степан", "Надія", "Григорій", "Любов"
            },
            LastNames = new[]
            {
                "Мельник", "Шевченко", "Бойко", "Коваленко", "Ткаченко", "Кравченко", "Ковальчук", "Бондаренко",
                "Олійник", "Шевчук", "Лисенко", "Павленко", "Савченко", "Козак", "Руденко", "Марченко",
                "Гончар", "Кравчук", "Поліщук", "Гриценко", "Мороз", "Литвин", "Романенко", "Захарченко",
                "Білий", "Сидоренко", "Петренко", "Іваненко", "Волошин", "Семенченко", "Клименко", "Коваль",
                "Павлюк", "Данилюк", "Сергієнко", "Мельничук", "Васильченко", "Тимошенко", "Лисенко", "Гордієнко"
            },
            AlbumWords = new[]
            {
                "Північ", "Відлуння", "Мрія", "Тінь", "Вогонь", "Грім", "Кришталь", "Срібло",
                "Золото", "Електрика", "Космос", "Оксамит", "Діамант", "Неон", "Сутінки", "Буря",
                "Океан", "Фенікс", "Сяйво", "Містика", "Вічність", "Небесна", "Сяючий", "Безкінечність",
                "Горизонт", "Рай", "Загадка", "Симфонія", "Гармонія", "Шепіт", "Спокій", "Доля",
                "Подорож", "Спадщина", "Одіссея", "Революція", "Генезис", "Святиня", "Утопія", "Затемнення"
            },
            Genres = new[]
            {
                "Рок", "Поп", "Джаз", "Електронна", "Хіп-Хоп", "R&B", "Народна", "Блюз",
                "Класична", "Метал", "Інді", "Фолк", "Реґі", "Соул", "Фанк", "Диско",
                "Техно", "Хаус", "Ембієнт", "Панк"
            },
            Adjectives = new[]
            {
                "емоційний", "енергійний", "меланхолійний", "яскравий", "атмосферний", "потужний",
                "гіпнотичний", "піднесений", "ностальгічний", "захоплюючий", "чарівний", "динамічний",
                "інтроспективний", "ейфорійний", "похмурий", "радісний", "ефірний", "сирий", "відшліфований", "експериментальний"
            },
            Qualities = new[]
            {
                "композиція", "ритм", "мелодія", "продакшн", "аранжування", "вокал",
                "інструментовка", "текст", "гармонія", "groove", "звуковий ландшафт", "виконання",
                "мікшування", "енергія", "прогресія", "текстура", "динаміка", "атмосфера"
            }
        };
    }
}