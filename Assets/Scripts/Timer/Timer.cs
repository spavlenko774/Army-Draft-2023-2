using UnityEngine;

public class Timer
{
    public float TimeLeft { get; private set; }
    public float MaxTime { get; private set; }

    public Timer(float maxTime)
    {
        MaxTime = maxTime;
        TimeLeft = maxTime;
    }

    public void Tick()
    {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }
    }

    public void AddTime(float time)
    {
        TimeLeft += time;
        if (TimeLeft > MaxTime)
        {
            TimeLeft = MaxTime;
        }
    }
}
