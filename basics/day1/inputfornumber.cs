class In
{
    public int Inp1()
    {
        Console.WriteLine("Enter your Age: ");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Age is: {age}");
        return age;
    }
}