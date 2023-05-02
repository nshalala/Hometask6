namespace HomeTask6.Models;

internal class Student
{
    public int Id { get; }
    static int Count { get; set; } = 0;

    public Student() 
    {
        Count++;
        Id = Count;
    }

}
