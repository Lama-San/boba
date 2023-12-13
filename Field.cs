// класс поля
public class Field
{
    // тут организовать синглтон и хранение ячеек в свойстве Cells
    private static Field instanse;
    public int[,]cells {  get; set; }
         
    private Field() 
    { 
        instanse = new Field();
        if (instanse == null)
        {
            instanse = new Field();
        }
       
    }
    //public static Field GetInstance()
    //{
    //    if (instance == null)
    //    {
    //        instance = new Field();
    //    }
    //    return instance;
    //}



    internal bool CheckRobotEndGame(Robot robot)
    {
        int robotX = robot.X;
        int robotY = robot.Y;

        int finishX = GetFinishX();
        int finishY = GetFinishY();

        if (robotX == finishX && robotY == finishY)
        {
            return true;
        }
        return false;
        // сравнение координат робота с координатами
        // финишной точки
    }
    internal int GetFinishX()
    {
        return 10;
    }
    internal int GetFinishY()
    {
        return 5;
    }

    internal static Field GetInstance()
    {
        throw new NotImplementedException();
    }
}

