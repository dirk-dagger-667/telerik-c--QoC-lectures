namespace _03.NamingIdentifiers._02.ManAndWomanCreatorTest
{
    using System;

    class Human
    {
        enum Gender
        {
            Male,
            Female
        };

        public Human(int age)
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = "Батката";
                this.Sex = Gender.Male;
            }
            else
            {
                this.Name = "Мацето";
                this.Sex = Gender.Female;
            }
        }

        public Gender Sex { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
   
