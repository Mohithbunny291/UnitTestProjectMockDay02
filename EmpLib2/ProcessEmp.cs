using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib2
{
    public class ProcessEmp
    {
        public bool InsertEmp(CheckEmpSecondDev objCheck)
        {
            objCheck.CheckEmp();
            return true;
        }
    }
}
