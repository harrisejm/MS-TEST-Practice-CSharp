namespace PingPong
{
  public class Ping
  {
    public bool IsPingPong(int numb)
    {
    if (numb % 3 == 0 && numb % 5 == 0)
    {
      return true;
    }
    else
    {
      return false;
    }

    }
  }
}
