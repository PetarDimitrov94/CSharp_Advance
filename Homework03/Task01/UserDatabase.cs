namespace Task01
{
    public static class UserDatabase
    {
        public static List<User> Users = new List<User>()
       {
        new User(1, "Petar", 30),
        new User(2, "Darko", 33),
        new User(3, "Angela", 28),
        new User(4, "Dejan", 40),
        new User(5, "Jovana", 23)
       };


        public static User SearchById(int id)
        {
            return Users.FirstOrDefault(user => user.Id == id);
        }

        public static List<User> SearchByName(string name)
        {
            return Users.Where(user => user.Name == name).ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return Users.Where(user => user.Age == age).ToList();
        }

    }
}
