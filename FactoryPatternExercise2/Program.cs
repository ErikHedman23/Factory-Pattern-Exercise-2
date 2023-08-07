namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use: a Mongo, SQL, or List?");
            var userInput = Console.ReadLine();
            var dataBase = DataAccessFactory.GetDataAccessType(userInput);
            dataBase.LoadData();
            dataBase.SaveData();
            
        }
    }
}
