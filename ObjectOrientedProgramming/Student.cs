public class Student
{
    private string _name;
    private int _age;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Name should not be empty");
            _name = value;
        }
    }

    public int Age => _age;

    public Student(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name), "Name should not be empty");

        if (age < 16)
            throw new ArgumentOutOfRangeException(nameof(age), "Age should be >= 16");

        _name = name;
        _age = age;
    }
}