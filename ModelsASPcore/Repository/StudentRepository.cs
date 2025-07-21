using ModelsASPcore.Models;

namespace ModelsASPcore.Repository
{
    public class StudentRepository : Istudent
    {
        public List<StudentModel> getAllStudent(int id)
        {
            return Datasoure();

        }

        public StudentModel getStudentById(int id)
        {
          
        }
        private List<StudentModel> Datasoure()

        {
           return  new List<StudentModel>
            {
                new StudentModel { RollNum =  1, Name="Babita"  ,Gender="Female",Stander=10},
                new StudentModel { RollNum =  2, Name="Sita", Gender = "Female" ,Stander =11},
                new StudentModel { RollNum =  3, Name="Sabita", Gender = "Female", Stander=12}

                };


        }
    }
}
