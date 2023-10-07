namespace personsList
{ class Person
        {
            public  string Name { get; set; }
            public  string Surname { get; set; }
            public  int Age { get; set; }
            public string Gender { get; set; }
        public  DateTime Birthday { get; set; }
        public Person(string name, string surname, string gender, int age, DateTime birthday)
            {
             Name = name; Surname = surname;
                Gender = gender; Age = age; Birthday = birthday;
            }
        public override string ToString()
        {
            return $"{Name} {Surname}, {Age} years old({Birthday.Day}/{Birthday.Month}/{Birthday.Year}), {Gender}";
        }
    }
    internal static class Program
    {
       
        
        [STAThread]
        static void Main()
        { 
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}