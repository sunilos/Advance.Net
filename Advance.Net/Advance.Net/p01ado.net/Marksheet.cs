namespace Advance.Net.p01ado.net
{
    public class Marksheet
    {
        private int id;
        private string rollno;
        private string fname;
        private string lname;
        private int physics;
        private int chemistry;
        private int maths;

        public int Id   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
        public string RollNo   // property
        {
            get { return rollno; }   // get method
            set { rollno = value; }  // set method
        }
        public string FName   // property
        {
            get { return fname; }   // get method
            set { fname = value; }  // set method
        }
        public string LName   // property
        {
            get { return lname; }   // get method
            set { lname = value; }  // set method
        }
        public int Physics   // property
        {
            get { return physics; }   // get method
            set { physics = value; }  // set method
        }
        public int Chemistry   // property
        {
            get { return chemistry; }   // get method
            set { chemistry = value; }  // set method
        }
        public int Maths   // property
        {
            get { return maths; }   // get method
            set { maths = value; }  // set method
        }
    }
}