namespace builderpatterndemo
{
    public class BuilderFacadeDemo
    {
        public string BuildPerson()
        {
            var pb = new PersonBuilder();
            Person person = pb.Info.WithName("John")
                                   .OfAge(25)
                            .Lives.In("Banaglore")
                                  .Pincode("SW12I0")
                            .Works.At("Some Company")
                                  .As("Software Engineer");

            return person.ToString();
        }
    }

    public class Person
    {
        //Personal Info
        public string Name { get; set; }
        public int Age { get; set; }

        //Work Info
        public string Company { get; set; }
        public string Designation { get; set; }

        //Address Info
        public string City { get; set; }
        public string Pincode { get; set; }

        public override string ToString()
        {
            return $"{Name} of age {Age} living at {City} {Pincode}, works at {Company} as a {Designation}.";
        }
    }

    public class PersonBuilder
    {
        protected Person person;

        public PersonBuilder()
        {
            this.person = new Person();
        }

        public PersonInfoBuilder Info => new PersonInfoBuilder(person);

        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }

    public class PersonInfoBuilder : PersonBuilder
    {
        public PersonInfoBuilder(Person person)
        {
            this.person = person;
        }

        public PersonInfoBuilder WithName(string name)
        {
            this.person.Name = name;
            return this;
        }

        public PersonInfoBuilder OfAge(int age)
        {
            this.person.Age = age;
            return this;
        }
    }

    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string company)
        {
            this.person.Company = company;
            return this;
        }

        public PersonJobBuilder As(string designation)
        {
            this.person.Designation = designation;
            return this;
        }
    }

    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder In(string city)
        {
            this.person.City = city;
            return this;
        }

        public PersonAddressBuilder Pincode(string pincode)
        {
            this.person.Pincode = pincode;
            return this;
        }
    }
}
