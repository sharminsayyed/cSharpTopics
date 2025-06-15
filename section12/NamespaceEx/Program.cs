// importing namespace (using deirective)

// this helps us to access the members of namespace without writing the namespace name every time 
// using can import one namespace at a time

using m = HR.Mgr; // using alias names 
// alias name also helps us from namespace name ambiguity (2 classes with same name in 2 different namespace and both namespaces are imported in same file 
using HR;
using FrontOffice;

// usage of static directive 
// console is a static class from system namespace 
using static System.Console;


class Program
{
    static void Main()
    {
        // to access the classes and members of namespace 
        // namespacename . typename
        HR.Executive er;
        er = new HR.Executive();

        Executive er1; // here namespace used by (using) directive 
        er1 = new Executive();

        // usage if alias name 
        m.AsstManager am;
        am = new m.AsstManager();

        // namespaces can span across the files also 
        FrontOfficeExecutive fr; // here namespace used by (using) directive 
        fr = new FrontOfficeExecutive();

        FrontOffice.CustomerEnquiry ce;
        ce = new FrontOffice.CustomerEnquiry();

        // accessing from the nested namespace 
        HR.Mgr.Manager mr;
        mr = new HR.Mgr.Manager();

        // usage of console class which is a  staic class in system namespace 
        WriteLine("helloo from console static class");

        ReadKey();


    }
}