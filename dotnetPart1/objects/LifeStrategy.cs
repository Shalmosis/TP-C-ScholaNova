#region SadLifeStrategy ... 
public class SadLifeStrategy : ILifeStrategy
{
    public int pointsLostWhenEating()
    {
        return 10;
    }

    public int pointsWonWhenPlaying()
    {
        return 1;
    }
}
#endregion


#region HappyLifeStrategy ....
public class HappyLifeStrategy : ILifeStrategy
{
    public int pointsLostWhenEating()
    {
        return 5;
    }
    public int pointsWonWhenPlaying()
    {
        return 10;
    }
}
#endregion