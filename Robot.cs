// класс робота
public class Robot
{
    // организовать синглтон и хранение текущих координат

    private static Robot instance;

    public int X { get;set; }
    public int Y { get;set; }
    public static Robot GetInstanse()
    {
        if (instance == null) 
        { 
        instance = new Robot();
        }
        return instance;
    }

    internal static Robot GetInstance()
    {
       return instance;
    }
}