
public class Player : Basketball
{
   
    private int playerNumber;
  
    public int Number
    {
        get { return playerNumber; }
        set {
            if (playerNumber < 0 ||  playerNumber > 99)
            {
                throw new ArgumentException("Номер игрока не может быть отрицательным числом или быть больше 99");
            }
            playerNumber = value;
        }
    }

    //Конструктор с параметрами
    public Player(int number, int pts, int reb, int ast) : base(pts, reb, ast)
    {
        this.playerNumber = number;
    }

  

    //Метод для отображения статистики
   public void DisplayInfo()
    {
        Console.WriteLine($"Номер: {Number}, {base.ToString()}");
    }

    public int CountTSPerc(int fga, int fgm)
    {
        if (fga == 0) { 
            return 0;
        }

        return (int)((double)fgm / fga * 100);
    }

}
