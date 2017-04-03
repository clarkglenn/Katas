using Shouldly;

using Xunit;

namespace Katas.Test {
	public class AnimalSoundLocatorTests {
		private readonly AnimalSoundsLocator sut = new AnimalSoundsLocator();

		[Theory]
		[InlineData(AnimalType.Cat, "Meow")]
		[InlineData(AnimalType.Dog, "Woff")]
		[InlineData(AnimalType.Gorilla, "Oh ahah")]
		[InlineData(AnimalType.Fox, "What does it say")]
		[InlineData(AnimalType.Crow, "Krah, krah")]
		[InlineData(AnimalType.None, "")]
		public void GettingAndAnimalSounds_WhenAnimalIsCatDogGorillaFoxVixen_ShouldReturnTheCorrectSound(AnimalType animal, string expectedSound) {
			this.sut.GetAnimalSound(animal).ShouldBe(expectedSound);
		}
	}
}