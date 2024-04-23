namespace GenericTypesTask
{
    internal class CustomCollection
    {
        private string name;
        private string surname;
        private byte age;
        private object salary;

        public CustomCollection()
        {
        }

        public CustomCollection(string name, string surname, byte age, object salary)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salary = salary;
        }
    }
}