using MauiPlanets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlanets.Services
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
				Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. ",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
				{
					"https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQLvLfdgshY1HwVy-Js7V-0KD0QvWsSvrxLPg&s"
                }
			},

			new()
			{
				Name = "Venus",
				Subtitle = "The pressure cooker",
				HeroImage = "venus.png",
				Description = "Venus is the second planet from the Sun. It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. Venus is notable for having the densest atmosphere of the terrestrial planets, composed mostly of carbon dioxide with a thick, global sulfuric acid cloud cover. At the surface it has a mean temperature of 737 K (464 °C; 867 °F) and a pressure of 92 times that of Earth's at sea level.",
				AccentColorStart = Color.FromArgb("#a6393b"),
				AccentColorEnd = Color.FromArgb("#d17f21"),
				Images = new()
				{
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJloXbePMZrQQjOBhbZSqCPW3UFAoirL6_Rw&s",
                    "https://images.theconversation.com/files/404401/original/file-20210604-13-128m0ja.jpg?ixlib=rb-4.1.0&rect=194%2C26%2C3400%2C2365&q=20&auto=format&w=320&fit=clip&dpr=2&usm=12&cs=strip",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_dj0AC1EUzSzKfkz8gDKAxXD-bigw7tBLHA&s"
                }
			},

			new()
			{
				Name = "Earth",
				Subtitle = "The cradle of life",
				HeroImage = "earth.png",
				Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. This is enabled by Earth being an ocean world, the only one in the Solar System sustaining liquid surface water. Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within Earth's land hemisphere.",
				AccentColorStart = Color.FromArgb("#0e3d68"),
				AccentColorEnd = Color.FromArgb("#2e97c7"),
				Images = new()
				{
                    "https://cdn.britannica.com/31/160431-050-C38A5086/Image-Earth-Russian-Elektro-L-weather-satellite-2012.jpg",
					"https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
				}
			},

			new()
			{
				Name = "Mars",
				Subtitle = "The red beauty",
				HeroImage = "mars.png",
				Description = "Mars is the fourth planet from the Sun. The surface of Mars is orange-red because it is covered in iron(III) oxide dust, giving it the nickname \"the Red Planet\". Mars is among the brightest objects in Earth's sky, and its high-contrast albedo features have made it a common subject for telescope viewing.",
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
				Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than 2.5 times that of all the other planets in the Solar System combined, and slightly less than one-thousandth the mass of the Sun. Its diameter is eleven times that of Earth, and a tenth that of the Sun.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#cd8026"),
				Images = new()
				{
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/Jupiter.jpg/800px-Jupiter.jpg",
                    "https://i.natgeofe.com/k/7c7e4173-5ad3-4ef7-8252-354de21430db/jupiter_4x3.jpg"
                }
			},

			new()
			{
				Name = "Saturn",
				Subtitle = "The ring planet",
				HeroImage = "saturn.png",
				Description = "Saturn is the sixth planet from the Sun and the second largest in the Solar System, after Jupiter. It is a gas giant, with an average radius of about nine times that of Earth. It has an eighth the average density of Earth, but is over 95 times more massive. Even though Saturn is almost as big as Jupiter, Saturn has less than a third the mass of Jupiter.",
				AccentColorStart = Color.FromArgb("#996237"),
				AccentColorEnd = Color.FromArgb("#c6502f"),
				Images = new()
				{
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQk6gwdZ3XVssZg967vb3iJ60C8jBC0ksM4Ag&s",
                    "https://cf-img-a-in.tosshub.com/sites/visualstory/wp/2024/06/Saturn1.jpeg?size=*:900"
                }
			},

			new()
			{
				Name = "Uranus",
				Subtitle = "The Herschel planet",
				HeroImage = "uranus.png",
				Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which astronomy calls \"ice\" or volatiles. The planet's atmosphere has a complex layered cloud structure and has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar System's planets.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc2Rm9gNbKitob9-o3zI754jMyVL6VqLOCww&s",
                    "https://imageio.forbes.com/specials-images/imageserve/5f91806c76fcfa4a1e885d7c/Planet-Uranus-/960x0.jpg?format=jpg&width=960"
                }
			},

			new()
			{
				Name = "Neptune",
				Subtitle = "The god of the sea",
				HeroImage = "neptune.png",
				Description = "Neptune is the eighth and farthest known planet from the Sun. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth and slightly more massive, but denser and smaller, than fellow ice giant Uranus.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
                    "https://images.squarespace-cdn.com/content/v1/5fa5ec79661ee904d2973ca0/1678752888290-2A53B1ST09WTKNPYW35R/neptune.png",
                    "https://media.npr.org/assets/img/2024/01/04/neptune-voyager_wide-6f930726366a55df02388c795be87841fcbf2443.jpg?s=1400&c=100&f=jpeg"
                }
			},


            new()
            {
                 Name = "Pluto",
                 Subtitle = "The Dwarf Planet",
                 HeroImage = "pluto.png",
                 Description = "Pluto (minor-planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, a ring of bodies beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun. It is the largest known trans-Neptunian object by volume, by a small margin, but is less massive than Eris. Like other Kuiper belt objects, Pluto is made primarily of ice and rock and is much smaller than the inner planets.",
                 AccentColorStart = Color.FromArgb("##f7c95e"),
                 AccentColorEnd = Color.FromArgb("#a87703"),
                 Images = new()
                 {
                    "https://i.natgeofe.com/n/b103fff5-6a84-4d19-b65e-5856998816c3/PIA19952_2x3.jpg",
                    "https://c4.wallpaperflare.com/wallpaper/486/838/486/planet-pluto-space-universe-wallpaper-preview.jpg"
                 }
            },

            new()
            {
				Name = "Ceres",
				Subtitle = "The Harvest Keeper of the Asteroid Belt",
				HeroImage = "ceres.png",
				Description = "Ceres (minor-planet designation: 1 Ceres) is a dwarf planet in the middle main asteroid belt between the orbits of Mars and Jupiter. It was the first known asteroid, discovered on 1 January 1801 by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily, and announced as a new planet. Ceres was later classified as an asteroid and then a dwarf planet, the only one not beyond Neptune's orbit. ",
				AccentColorStart = Color.FromArgb("#020a78"),
				AccentColorEnd = Color.FromArgb("#ede8e6"),
				Images = new()
				{
                    "https://miro.medium.com/v2/resize:fit:1260/format:webp/1*rKn4CBlXIt7VW5hQuGLqfw.png",
                    "https://www.nation.com.pk/print_images/large/2016-12-16/dwarf-planet-ceres-is-flush-with-ice-nasa-1481905999-6325.jpg"
                }
            },

            new()
            {
				Name = "Haumea",
                Subtitle = "The Reshaper of Worlds",
                HeroImage = "haumea.png",
                Description = "Haumea (minor-planet designation: 136108 Haumea) is a dwarf planet located beyond Neptune's orbit.[25] It was discovered in 2004 by a team headed by Mike Brown of Caltech at the Palomar Observatory, and formally announced in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada Observatory in Spain, who had discovered it that year in precovery images taken by the team in 2003. From that announcement, it received the provisional designation 2003 EL61. On 17 September 2008, it was named after Haumea, the Hawaiian goddess of childbirth, under the expectation by the International Astronomical Union (IAU) that it would prove to be a dwarf planet.",
                AccentColorStart = Color.FromArgb("#615c5a"),
                AccentColorEnd = Color.FromArgb("#ded9d7"),
                Images = new()
                {
                    "https://i.redd.it/9fswe344cff51.jpg",
                    "https://cdn.sci.news/images/enlarge10/image_11303e-Haumea.jpg"
                }
            },

            new()
			{
				Name = "MakeMake",
				Subtitle = "The Creator of Easter Island",
				HeroImage = "makemake.png",
				Description = "Makemake (minor-planet designation: 136472 Makemake) is a dwarf planet and the largest of what is known as the classical population of Kuiper belt objects,[b] with a diameter approximately that of Saturn's moon Iapetus, or 60% that of Pluto.[24][25] It has one known satellite.[26] Its extremely low average temperature, about 40 K (−230 °C), means its surface is covered with methane, ethane, and possibly nitrogen ices.",
				AccentColorStart = Color.FromArgb("#8c4732"),
				AccentColorEnd = Color.FromArgb("#ccb0a7"),
				Images = new()
                {
                    "https://www.universetoday.com/wp-content/uploads/2008/07/Makemake.jpg",
                    "https://article-imgs.scribdassets.com/4i05y8h0ao9lf9r6/images/fileS27I6RTH.jpg"
                }
            },

            new()
			{
				Name = "Eris",
				Subtitle = "The Goddess of Discord in the Kuiper Belt",
				HeroImage = "eris.png",
				Description = "Eris (minor-planet designation: 136199 Eris) is the most massive and second-largest known dwarf planet in the Solar System.[22] It is a trans-Neptunian object (TNO) in the scattered disk and has a high-eccentricity orbit. Eris was discovered in January 2005 by a Palomar Observatory–based team led by Mike Brown and verified later that year. It was named in September 2006 after the Greco–Roman goddess of strife and discord. Eris is the ninth-most massive known object orbiting the Sun and the sixteenth-most massive overall in the Solar System (counting moons).",
				AccentColorStart = Color.FromArgb("#e0ccc5"),
				AccentColorEnd = Color.FromArgb("#a89d99"),
				Images = new()
				{
                    "https://cff2.earth.com/uploads/2024/02/20135637/Eris_icy-dwarf-planet_kuiper-belt_1m.jpg",
                    "https://starchild.gsfc.nasa.gov/Images/StarChild/solar_system_level2/eris_and_dysnomia_485.jpg"
                }
			},

        };
		public static List<Planet> GetFeaturedPlanets()
		{
			var random = new Random();
			var randomizePlantes = planets
				.OrderBy(ItemDelegateList => random.Next());

			return randomizePlantes
				.Take(2).
				ToList();
		}
		public static List<Planet> GetAllPlanets()
			=> planets;
	}
}
