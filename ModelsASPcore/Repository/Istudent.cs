using ModelsASPcore.Models;

namespace ModelsASPcore.Repository
{
    public interface Istudent

    {

        List<StudentModel> getAllStudent();

        StudentModel getStudentById(int id);

    }
}
