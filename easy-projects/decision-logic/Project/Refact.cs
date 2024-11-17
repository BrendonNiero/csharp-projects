string permission = "Admin";
int level = 100;

switch(permission)
{
    case "Admin":
        if(level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        } else if(level <= 55)
        {
            Console.WriteLine("Welcome, Admin user.");
        }
    break;
    case "Manager":
        if(level >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        } else if(level < 20)
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    break;
    default:
        Console.WriteLine("You do not have sufficient privileges.");
    break;
}