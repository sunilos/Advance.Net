namespace Advance.Net.p01ado.net
{
    public class MarksheetBean
    {
        private int id;
        private string rollno;
        private string fname;
        private string lname;
        private int physics;
        private int chemistry;
        private int maths;

        public void setId(int Id)
        {
            this.id = Id;
        }
        public int getId()
        {
            return id;
        }

        public void setRollNo(string RollNo)
        {
            this.rollno = RollNo;
        }
        public string getRollNo()
        {
            return rollno;
        }

        public void setFName(string Fname)
        {
            this.fname = Fname;
        }
        public string getFName()
        {
            return fname;
        }

        public void setLName(string Lname)
        {
            this.lname = Lname;
        }
        public string getLName()
        {
            return lname;
        }

        public void setPhysics(int Physics)
        {
            this.physics = Physics;
        }
        public int getPhysics()
        {
            return physics;
        }

        public void setChemistry(int Chemistry)
        {
            this.chemistry = Chemistry;
        }
        public int getChemistry()
        {
            return chemistry;
        }

        public void setMaths(int Maths)
        {
            this.maths = Maths;
        }
        public int getMaths()
        {
            return maths;
        }
    }
}