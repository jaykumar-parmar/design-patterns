namespace factorypatterndemo
{
    public class Person
    {
        private string name;
        private string lastName;
        private int age;

        private Person(string name, string lastname, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {this.name} {nameof(lastName)} is of age {age}";
        }

        public static class PersonFactory
        {
            //Factories
            public static Person PersonWithFullnameFactory(string fullname, int age)
            {
                return new Person(fullname, "", age);
            }

            public static Person PersonFactoryWithFirstAndLastName(string firstname, string lastname, int age)
            {
                return new Person(firstname, lastname, age);
            }
        }
    }
    

}
