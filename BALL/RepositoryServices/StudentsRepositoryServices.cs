using DALL.Models;
using DALL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.RepositoryServices
{
    public  class StudentsRepositoryServices
    {
        StudentsRepository objdall = new StudentsRepository();

        public int InsertStudentRecord(Students obj)
        {
            int i = objdall.INSERT(obj);
            return i;
        }

        public List<GetAll> AllStudents()
        {
            return objdall.GetAll().ToList();
        }

        public List<Students> SingleStudents(int ID)
        {
            return objdall.SINGLE(ID).ToList();
        }

        public int DeleteStudent(int ID)
        {
            return objdall.DELETE(ID);
        }

        public int UpdateStudent(int ID, Students obj)
        {
            return objdall.UPDATE(ID, obj);
        }

    }
}
