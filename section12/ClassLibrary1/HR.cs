// namespace is a collection of classes , interfaces , structures , delegates ,events , enumerations 

namespace HR
{ // here the hr namespace says that all the below collections are used for hr operations only 

    // nested namespace or inner namespace 
    namespace Mgr
    {
        //interface that represents a manager, which inherits from IEmployee
        public interface IManager : IEmployee
        {

        }

        //class that represents a manager which inherits from IManager
        public class Manager : IManager
        {

        }

        // class that represents  an assistant manager , which inherits from IManager
        public class AsstManager : IManager
        {

        }

    }
    //interface that represents an employee in an organization
    public interface IEmployee
    {

    }

    

    //interface that represents an executive which inherits from IEmployee
    public interface IExecutive : IEmployee
    {

    }

    
    

    // class that represents an executive which inherits from IExecutive 
    public class Executive : IExecutive
    {

    }
}
