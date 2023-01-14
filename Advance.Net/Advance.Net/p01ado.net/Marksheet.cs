namespace Advance.Net.p01ado.net
{
    public class Marksheet
    {
        private int id;
        private string rollno;
        private string fname;
        private string lname;
        private int phy;
        private int chem;
        private int math;

        public int iD   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
        public string rollNo   // property
        {
            get { return rollno; }   // get method
            set { rollno = value; }  // set method
        }
        public string fName   // property
        {
            get { return fname; }   // get method
            set { fname = value; }  // set method
        }
        public string lName   // property
        {
            get { return lname; }   // get method
            set { lname = value; }  // set method
        }
        public int physics   // property
        {
            get { return phy; }   // get method
            set { phy = value; }  // set method
        }
        public int chemistry   // property
        {
            get { return chem; }   // get method
            set { chem = value; }  // set method
        }
        public int maths   // property
        {
            get { return math; }   // get method
            set { math = value; }  // set method
        }
    }
}