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
					"https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
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
				Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. This is enabled by Earth being an ocean world, the only one in the Solar System sustaining liquid surface water. Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within Earth's land hemisphere.",
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
					"https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
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
				Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which astronomy calls \"ice\" or volatiles. The planet's atmosphere has a complex layered cloud structure and has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar System's planets.",
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
				Description = "Neptune is the eighth and farthest known planet from the Sun. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth and slightly more massive, but denser and smaller, than fellow ice giant Uranus.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
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
