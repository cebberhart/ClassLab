using System;
using System.Collections.Generic;
using System.Text;

namespace StudentListLab10
{
    class Students
    {
        //1 properties
        //2 constructors
        //3 methods

        public string StudentNames { get; set; }
        public string HomeTowns { get; set; }
        public string FavoriteFood { get; set; }

        public Students( string StudentNames, string HomeTowns, string FavoriteFood)
        {
            this.FavoriteFood = FavoriteFood;
            this.HomeTowns = HomeTowns;
            this.StudentNames = StudentNames;
        }
    }
}
