
public class Player : Basketball
{
   
    private int playerNumber;
  
    public int Number
    {
        get { return playerNumber; }
        set {
            if (playerNumber < 0 ||  playerNumber > 99)
            {
                throw new ArgumentException("Íîìåð èãðîêà íå ìîæåò áûòü îòðèöàòåëüíûì ÷èñëîì èëè áûòü áîëüøå 99");
            }
            playerNumber = value;
        }
    }

    //Êîíñòðóêòîð ñ ïàðàìåòðàìè
    public Player(int number, int pts, int reb, int ast) : base(pts, reb, ast)
    {
        this.playerNumber = number;
    }

  

    //Ìåòîä äëÿ îòîáðàæåíèÿ ñòàòèñòèêè
   public void DisplayInfo()
    {
        Console.WriteLine($"Íîìåð: {Number}, {base.ToString()}");
    }

    public int CountTSPerc(int fga, int fgm)
    {
        if (fga == 0) { 
            return 0;
        }

        return (int)((double)fgm / fga * 100);
    }

}
