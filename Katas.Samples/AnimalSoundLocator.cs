namespace Katas.Samples {
	public class AnimalSoundsLocator {
		//This method has a cyclomatic complexity of 6 because we have five cases + the default. 
		//We can get this complexity down to 1 (lowest possible for any method), that is if we use no conditionals for this code.
		//How would you do it? You are not allowed to create any new classes or change the signature of the method.
		public string GetAnimalSound(AnimalType animal) {
			switch(animal) {
				case AnimalType.Cat:
					return "Meow";
				case AnimalType.Dog:
					return "Woff";
				case AnimalType.Gorilla:
					return "Oh ahah";
				case AnimalType.Fox:
					return "What does it say";
				case AnimalType.Crow:
					return "Krah, krah";
				default:
					return string.Empty;
			}
		}
	}

	public enum AnimalType {
		Cat,
		Dog,
		Gorilla,
		Fox,
		Crow,
		None
	}
}