using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Form.classes
{
    internal class course
    {

        [Key]
        public string Course1 { get; set; }

        public string Degree { get; set; }

        public ICollection<Student> Students { get; set; }


    }
}
