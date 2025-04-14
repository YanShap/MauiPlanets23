using Models;


namespace Services
{
    internal class PlanetsService
    {

        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. Mercury is classified as a terrestrial planet, with roughly the same surface gravity as Mars. The surface of Mercury is heavily cratered, as a result of countless impact events that have accumulated over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. Venus has by far the densest atmosphere of the terrestrial planets, composed mostly of carbon dioxide with a thick, global sulfuric acid cloud cover. At the surface it has a mean temperature of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's at sea level.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"

                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://media.wired.com/photos/5c4b602dbf8f101be175ceea/master/pass/02_SPoW_012619.jpg",
                    "https://cdn.britannica.com/06/21206-050-7C844247/Crescent-view-images-composite-Jupiter-Voyager-1-March-24-1979.jpg",
                    "https://static.scientificamerican.com/dam/m/246c6a974523b6b2/original/PIA24962-orig_WEB.jpg?m=1720721129.678&w=1200"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The Icy Enigma of the Asteroid Belt",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt between Mars and Jupiter and the only dwarf planet located in the inner solar system. Discovered in 1801, it was once classified as a planet and later an asteroid, before earning its current status as a dwarf planet in 2006. With its mysterious bright spots, water ice, and possible briny underground ocean, Ceres continues to intrigue scientists as a potential key to understanding planetary formation and the possibility of life beyond Earth",
                AccentColorStart = Color.FromArgb("#a9d1c1"),
                AccentColorEnd = Color.FromArgb("#1b7551"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg/640px-Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://cdn.mos.cms.futurecdn.net/qnft8kRfeGWWLgaygo4fb9.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/redirect/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdUZsIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--ca667488ed16597e35eaab71acd42034ca4f56c2/PIA20180-16-640x350.jpg"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The Spinning Mystery of the Outer Solar System",
                HeroImage = "haumea.png",
                Description = "Haumea is a fast-spinning, football-shaped dwarf planet located in the Kuiper Belt beyond Neptune. Named after the Hawaiian goddess of childbirth, Haumea stands out with its rapid 4-hour rotation, elongated shape, and unique ring system — the first discovered around a trans-Neptunian object. With two known moons and a surface covered in crystalline ice, Haumea challenges our understanding of how distant icy worlds form and evolve.",
                AccentColorStart = Color.FromArgb("#ad8f71"),
                AccentColorEnd = Color.FromArgb("#5e4022"),
                Images = new()
                {
                     "https://science.nasa.gov/wp-content/uploads/2023/07/haumea-480x320-1-jpg.webp?w=320",
                    "https://c02.purpledshub.com/uploads/sites/48/2024/01/dwarf-planet-haumea.jpg?w=1029&webp=1",
                    "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/haumea.png"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "The Silent Watcher of the Kuiper Belt",
                HeroImage = "makemake.png",
                Description = "Makemake is a distant dwarf planet nestled in the icy reaches of the Kuiper Belt. Discovered in 2005 and named after the Rapa Nui god of creation, Makemake is a cold, reddish world with a methane-rich surface and a mysterious, near-invisible atmosphere. Once thought to be moonless, it surprised astronomers with the discovery of a hidden satellite in 2016. As one of the brightest objects beyond Neptune, Makemake offers a glimpse into the frozen frontier of our solar system.\r\n\r\n",
                AccentColorStart = Color.FromArgb("#e87400"),
                AccentColorEnd = Color.FromArgb("#cfbeae"),
                Images = new()
                {
                    "https://cdn.eso.org/images/screen/eso1246a.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/04/makemakemoon100mile-jpg.webp?w=2000",
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The Beloved Outcast of the Solar System",
                HeroImage = "pluto.png",
                Description = "Once the ninth planet in our solar system, Pluto was reclassified as a dwarf planet in 2006 — but it remains a celestial icon. Located in the Kuiper Belt, Pluto is a complex world with towering ice mountains, vast nitrogen plains, and a thin, hazy atmosphere. The 2015 New Horizons flyby revealed a surprisingly active surface, hinting at a geologically dynamic history. With its heart-shaped glacier and five moons — including the massive Charon — Pluto continues to captivate hearts and challenge our cosmic definitions.\r\n\r\n",
                AccentColorStart = Color.FromArgb("#edb361"),
                AccentColorEnd = Color.FromArgb("#875610"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Pluto_in_True_Color_-_High-Res.jpg/1200px-Pluto_in_True_Color_-_High-Res.jpg",
                    "https://www.iau.org/static/archives/images/screen/iau0601a.jpg",
                    "https://i.natgeofe.com/n/b103fff5-6a84-4d19-b65e-5856998816c3/PIA19952_2x3.jpg"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The Ice Queen That Redefined Planets",
                HeroImage = "eris.png",
                Description = "Eris is one of the most massive known dwarf planets, orbiting far beyond Pluto in the scattered disc region of the solar system. Discovered in 2005, its size and weight rivaled Pluto’s — sparking the debate that led to the redefinition of what it means to be a planet. Icy, remote, and highly reflective, Eris has a frigid surface and a small moon named Dysnomia. With an orbit that takes over 500 years to complete, Eris remains a powerful reminder of how much we’re still learning about the farthest reaches of our solar system.\r\n\r\n",
                AccentColorStart = Color.FromArgb("#75ebdd"),
                AccentColorEnd = Color.FromArgb("#13544c"),
                Images = new()
                {

                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSG6gj2_jvLR_vafhxvRxJMZvvR3EEo1a6Ufg&s",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/redirect/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBaUFSIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1f24a5d7e143ef1d68416edb76a51ec065c1019c/eris_th.jpg?disposition=inline",
                    "https://theplanets.org/123/2021/10/Eris-Facts.png"
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
