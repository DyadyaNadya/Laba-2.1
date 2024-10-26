
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
                throw new ArgumentException("���������� ����� ������ ���� ��������������� ����� ������");
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
                throw new ArgumentException("���������� �������� ������ ���� ��������������� ����� ������");
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
                throw new ArgumentException("���������� ������� ������ ���� ��������������� ����� ������");
            }
            assists = value;
        }
    }

    //����������� �����������
    public Basketball(Basketball other)
    {
        Points = other.Points + 4;
        Rebounds = other.Rebounds - 6;
        Assists = other.Assists - 3;
    }

    //����������� � �����������
    public Basketball(int pts, int reb, int ast)
    {
        Points = pts;
        Rebounds = reb;
        Assists = ast;
    }

  
    //����� ��� ����������� ������������ ����
    public int Minstat()
    {
        return Math.Min(Points, Math.Min(Rebounds, Assists));
    }

    //���������� ������
    public override string ToString()
    {
        return $"����: {Points}, �������: {Rebounds}, ��������: {Assists}";
    }

}

