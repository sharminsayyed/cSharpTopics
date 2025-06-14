// importing namespace (using deirective)

// this helps us to access the members of namespace without writing the namespace name every time 
// using can import one namespace at a time

using HR.Mgr;
using HR;
using FrontOffice;


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

        // namespaces can span across the files also 
        FrontOfficeExecutive fr; // here namespace used by (using) directive 
        fr = new FrontOfficeExecutive();

        FrontOffice.CustomerEnquiry ce;
        ce = new FrontOffice.CustomerEnquiry();

        // accessing from the nested namespace 
        HR.Mgr.Manager mr;
        mr = new HR.Mgr.Manager();

    }
}