
// класс поляusing System.Drawing;
using System.Drawing;

internal class Field
{
    private static Field instance;
        // тут организовать синглтон и хранение ячеек в свойстве Cells
    public int[,] Cells { get; set; }

   
    public static Field GetInstance()
    {
        if (instance == null)
            instance = new Field(); return instance;
    }
   
    internal bool CheckRobotEndGame(Robot robot)
    {
        if (Cells[robot.Y, robot.X] == 4)
        {
            return false;
        }        
        return true;
        // сравнение координат робота с координатами     
        // финишной точки
    }

    
}

