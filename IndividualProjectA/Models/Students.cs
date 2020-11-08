using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Students
    {
        private string _firstname;
        private string _lastname;
        private DateTime _dateofbirth;
        private double _tuitionfees;

        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value.ToUpper(); }
        }

        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value.ToUpper(); }
        }
        public DateTime DateOfBirth
        {
            get { return (this._dateofbirth); }
            set { this._dateofbirth = value; }
        }

        public Double TuitionFees
        {
            get { return (this._tuitionfees); }
            set { this._tuitionfees = value; }
        }
        public override string ToString()
        {
            return ($"First Name: {_firstname}\t Last Name: {_lastname}\t Date Of Birth: {_dateofbirth}/t Tuition Fees: {_tuitionfees} ");
        }
    }
}
