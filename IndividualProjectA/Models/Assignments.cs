using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Assignments
    {
        private string _title;
        private string _description;
        private DateTime _subDateTime;
        private string _oralMark;
        private string _totalMark;

        public string Title
        {
            get { return (this._title); }
            set { this._title = value; }
        }

        public string Description
        {
            get { return (this._description); }
            set { this._description = value; }
        }
        public DateTime SubDateTimes
        {
            get { return (this._subDateTime); }
            set { this._subDateTime = value; }
        }

        public string OralMark
        {
            get { return (this._oralMark); }
            set { this._oralMark = value; }
        }

        public string TotalMark
        {
            get { return (this._totalMark); }
            set { this._totalMark = value; }
        }
        public override string ToString()
        {
            return ($"Title: {_title}\t Description: {_description}\t Submition Date: {SubDateTimes}/t Oral Mark: {_oralMark}/t Total Mark: {_totalMark} ");
        }
    }
}
