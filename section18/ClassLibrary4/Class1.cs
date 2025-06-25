namespace ClassLibrary4
{
    public class Student
    {
        public double marks;
        public double maxMarks;
        public double percentage;   

    }

    // outer class 
    public class MarksCalculation
    {
        public void CalcualtePer(Student s)
        {
            // outer class cannot access the members of inner class directly, without creating an object 
            // create an object of inner class inside the outer class 
            //calling the inner class method in outer class
            CalculationHelper ch = new CalculationHelper();
            s.percentage = ch.Multiply(s.marks / s.maxMarks, 100);
        }
        // private inner class is accessible only in the outer class
        //so we make it public to be accessible 
        // inner class

        //By default, inner class is "private"; so it is accessible within the same outer class. To make it available to outside of the outer class, you can use other access modifiers such as "protected", "private protected", "internal", "protected internal" or "public".
        
        public class CalculationHelper
        {
            public double Multiply(double n1, double n2)
            {
                return n1 * n2;
            }
        }

        //Inner class can't access the members of outer class directly, without object.

//You are allowed to create objects of inner class in outer class; and vice versa; but you can't do both; if you create objects vice-versa, it causes StackOverflowException.

//You can create a child class for the inner class, outside the outer class.
    }
}
