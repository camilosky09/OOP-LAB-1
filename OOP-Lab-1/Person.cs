using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_1
{
    class Person
        {
            public int personId;
            public string firstName;
            public string lastName;
            public string favoriteColour;
            public int age;
            public bool isWorking;

            public void DisplayPersonInfo()
            {
                Console.WriteLine($"PersonId: {personId}\nName: {firstName} {lastName}'s favorite colour is {favoriteColour}");
            }

            public void ChangeFavoriteColour()
            {
                favoriteColour = "White";
            }

            public int GetAgeInTenYears()
            {
                return age + 10;
            }

            public override string ToString()
            {
                return $"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavoriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}";
            }
        }
    }

