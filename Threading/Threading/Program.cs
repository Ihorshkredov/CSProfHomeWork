namespace Threading
{
    internal class Program
    {
        static object syncObject = new object();
        static void Main(string[] args)
        {
            

            List<Candidate> candidatelist = new List<Candidate>()
            {
                new Candidate(35, "Arni Shwartsneger",2),
                new Candidate(40, "Mahamad Ali", 15),
                new Candidate(35, "Tony Stark", 20),
                new Candidate(35, "Roy Rojers", 8),
                new Candidate(50, "Ker Laeda",30)
            };

            var listOfHiredPersons = HRDepartment.GetListOfHiredPersons(3, candidatelist);
            for (int i = 0; i < listOfHiredPersons.Count; i++) 
            {
                lock (syncObject)
                {
                    Console.ForegroundColor = ConsoleColor.Blue; 
                }
                var thread = new Thread(MailSender.SendMail) { IsBackground = false};
                thread.Start();
                
                 Console.ResetColor();
            }

            List<EquitationTask> listOfEquitationTasks = new List<EquitationTask>();
            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();
                listOfEquitationTasks.Add(new EquitationTask(random.Next(1, 50),
                                                              random.Next(30, 80),
                                                              random.Next(10, 30)));
            }

            foreach (var task in listOfEquitationTasks) 
            {
                EquitationSolver.SolveEquitation(task);
            }
        }
    }
}