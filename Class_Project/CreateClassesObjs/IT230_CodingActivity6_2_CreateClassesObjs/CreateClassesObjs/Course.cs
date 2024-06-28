namespace CreateClassesObjs
{
    public class Course
    {
        private string name;

        // Method to set the name field
        public void setName(string courseName)
        {
            name = courseName;
        }

        // Method to get the name field
        public string getName()
        {
            return name;
        }

        // Override ToString method to return the name field
        public override string ToString()
        {
            return name;
        }
    }
}


