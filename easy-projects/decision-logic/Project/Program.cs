string permission = "Admin";
int level = 100;

if(permission.Contains("Admin") || permission.Contains("Manager"))
{
    if(permission.Contains("Admin"))
    {
        if(level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        if(level <= 55)
        {
            Console.WriteLine("Welcome, Admin user.");
        }
    }

    if(permission.Contains("Manager"))
    {
        if(level >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        if(level < 20)
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
} else 
{
    Console.WriteLine("You do not have sufficient privileges.");
}