
namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill", StudentEmail = "bill@gmail.com", Section = "Freshman"};
                
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}