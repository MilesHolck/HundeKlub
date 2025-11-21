using HundeKlub;

Dog dog1 = new Dog(1, "Bobby");

Member member1 = new Member("ida", new DateTime(1992, 07, 09), new List<Dog> { dog1 });

Console.WriteLine(member1.ToString());

Dog dog2 = new Dog(2, "Jonatan");

member1.RegisterDog(dog2);

Console.WriteLine("After adding dog2:"); 

member1.PrintDogs();

Console.WriteLine("After removing dog2:");

member1.RemoveDog(dog2);

member1.PrintDogs(); 