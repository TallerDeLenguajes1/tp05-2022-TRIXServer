Console.Clear();
Console.WriteLine("Hola Mundo");

public class pixel
{
    private int x;
    private int y;

    public int X
    {
        get;
        set;
    }

    public int Y
    {
        get;
        set;
    }

    public void moverPunto (int nX, int nY)
    {
        x = nX;
        y = nY;
    }

    public pixel()
    {
        x = 0;
        y = 0;
    }
    
}