// класс для ввода данных
using System.ComponentModel.Design;

public class Controller
{
    private MainCommander mainCommander;

    //public void StartGame()
    //{  
    //    mainCommander = new MainCommander(); 
    ////Получение первыого ввода от ползователя и создание поля 


    //    //Создание экземпляров поле и робота
    //    Field field = Field.GetInstance();
    //    Robot robot = Robot.GetInstanse();

    //    //Создание испольтнителя команд
    //    FieldCommander fieldcommander = new FieldCommander();
    //    RobotCommander robotCommander = new RobotCommander();

    //    //создание главного исполнителя команд
    //    mainCommander.SetInterpretator(fieldcommander);
    //}

    public Controller(MainCommander mainCommander)
    {
        this.mainCommander = mainCommander;
        mainCommander.SetInterpretator(new FieldCommander());
    }

    // цикл по запросу команды
    internal void StartListner()
    {
        int[] Command = new int[25];
        string a = Console.ReadLine();
        for (int i = 0;i < 25; i++)
        {
            Command[i]= int.Parse(a[i].ToString());
        }
        mainCommander.SetInterpretator(new RobotCommander());
        do
        {
            int c = int.Parse(Console.ReadLine());
        }
        while (true);
        // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute
        // смена интерпретатора у mainCommander на RobotCommander
        // остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)

    }
    static Controller instance;
    public static Controller GetInstance()
    {
        if (instance == null)
            instance = new Controller(default);
        return instance;
    }

}

