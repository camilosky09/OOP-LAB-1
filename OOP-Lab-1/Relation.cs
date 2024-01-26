using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_1
{
    class Relation
    {
        public enum RelationshipType
        {
            Sister,
            Brother,
            Mother,
            Father
        }

        public void ShowRelationship(Person person1, Person person2, RelationshipType relationshipType)
        {
            Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {relationshipType}hood");
        }
    }

}
