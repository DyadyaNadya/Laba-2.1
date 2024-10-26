
public class Player : Basketball
{
   
    private int playerNumber;
  
    public int Number
    {
        get { return playerNumber; }
        set {
            if (playerNumber < 0 ||  playerNumber > 99)
            {
                throw new ArgumentException("����� ������ �� ����� ���� ������������� ������ ��� ���� ������ 99");
            }
            playerNumber = value;
        }
    }

    //����������� � �����������
    public Player(int number, int pts, int reb, int ast) : base(pts, reb, ast)
    {
        //this.playerName = name;
        this.playerNumber = number;
    }

  

    //����� ��� ����������� ����������
   public void DisplayInfo()
    {
        Console.WriteLine($"�����: {Number}, {base.ToString()}");
    }

    public int CountTSPerc(int fga, int fgm)
    {
        if (fga == 0) { 
            return 0;
        }

        return (int)((double)fgm / fga * 100);
    }

}
