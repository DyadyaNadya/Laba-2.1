
public class Basketball
{
    protected int points;
    protected int rebounds;
    protected int assists;

    public int Points
    {
        get { return points; }

        set { 
            if (value < 0)
            {
                throw new ArgumentException("Количество очков должно быть неотрицательным целым числом");
            }
            points = value; 
        }
    }

    public int Rebounds
    {
        get { return rebounds; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Количество подборов должно быть неотрицательным целым числом");
            }
            rebounds = value;
        }
    }

    public int Assists
    {
        get { return assists; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Количество передач должно быть неотрицательным целым числом");
            }
            assists = value;
        }
    }

    //Конструктор копирования
    public Basketball(Basketball other)
    {
        Points = other.Points + 4;
        Rebounds = other.Rebounds - 6;
        Assists = other.Assists - 3;
    }

    //Конструктор с параметрами
    public Basketball(int pts, int reb, int ast)
    {
        Points = pts;
        Rebounds = reb;
        Assists = ast;
    }

  
    //Метод для определения минимального поля
    public int Minstat()
    {
        return Math.Min(Points, Math.Min(Rebounds, Assists));
    }

    //Перегрузка метода
    public override string ToString()
    {
        return $"Очки: {Points}, Подборы: {Rebounds}, Передачи: {Assists}";
    }

}

