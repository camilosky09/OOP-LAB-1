namespace OOP_Lab_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();

            Person Ian = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
            Person Gina = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
            Person Mike = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
            Person Mary = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };

            peopleList.Add(Ian);
            peopleList.Add(Gina);
            peopleList.Add(Mike);
            peopleList.Add(Mary);

            Console.WriteLine($"{Gina.personId}: {Gina.firstName} {Gina.lastName}'s favorite colour is {Gina.favoriteColour}");

            Console.WriteLine(Mike.ToString());

            Ian.ChangeFavoriteColour();
            Console.WriteLine($"{Ian.personId}: {Ian.firstName} {Ian.lastName}'s favorite colour is: {Ian.favoriteColour}");

            Console.WriteLine($"{Mary.firstName} {Mary.lastName}'s Age in 10 years is: {Mary.GetAgeInTenYears()}");

            Relation relation1 = new Relation();
            relation1.ShowRelationship(Gina, Mary, Relation.RelationshipType.Sister);

            Relation relation2 = new Relation();
            relation2.ShowRelationship(Ian, Mike, Relation.RelationshipType.Brother);

            double averageAge = CalculateAverageAge(peopleList);
            Console.WriteLine($"Average age is: {averageAge}");

            Person youngestPerson = GetYoungestPerson(peopleList);
            Console.WriteLine($"The youngest person is: {youngestPerson.firstName}");

            Person oldestPerson = GetOldestPerson(peopleList);
            Console.WriteLine($"The oldest person is: {oldestPerson.firstName}");

            List<Person> peopleWithM = GetPeopleWithM(peopleList);
            foreach (Person person in peopleWithM)
            {
                Console.WriteLine(person.ToString());
            }
            
            List<Person> peopleWithBlue = GetPeopleWithFavoriteColour(peopleList, "Blue");
            foreach (Person person in peopleWithBlue)
            {
                Console.WriteLine(person.ToString());
            }
        }

        static double CalculateAverageAge(List<Person> peopleList)
        {
            int totalAge = 0;
            foreach (Person person in peopleList)
            {
                totalAge += person.age;
            }
            return (double)totalAge / peopleList.Count;
        }

        static Person GetYoungestPerson(List<Person> peopleList)
        {
            Person youngestPerson = peopleList[0];
            foreach (Person person in peopleList)
            {
                if (person.age < youngestPerson.age)
                {
                    youngestPerson = person;
                }
            }
            return youngestPerson;
        }

        static Person GetOldestPerson(List<Person> peopleList)
        {
            Person oldestPerson = peopleList[0];
            foreach (Person person in peopleList)
            {
                if (person.age > oldestPerson.age)
                {
                    oldestPerson = person;
                }
            }
            return oldestPerson;
        }

        static List<Person> GetPeopleWithM(List<Person> peopleList)
        {
            List<Person> peopleWithM = new List<Person>();
            foreach (Person person in peopleList)
            {
                if (person.firstName.StartsWith("M", StringComparison.OrdinalIgnoreCase))
                {
                    peopleWithM.Add(person);
                }
            }
            return peopleWithM;
        }
        static List<Person> GetPeopleWithFavoriteColour(List<Person> peopleList, string color)
        {
            List<Person> peopleWithColor = new List<Person>();
            foreach (Person person in peopleList)
            {
                if (person.favoriteColour.Equals(color, StringComparison.OrdinalIgnoreCase))
                {
                    peopleWithColor.Add(person);
                }
            }
            return peopleWithColor;
        }
    }
}
