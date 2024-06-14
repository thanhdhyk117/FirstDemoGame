using System;
using UnityEngine;

public class UnixTimeStamp : MonoBehaviour
{
    private static int GetUnixTime()
    {
        return (int)(DateTime.UtcNow - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;
    }


    public static long GetUnixTimeMicro()
    {
        DateTimeOffset now = DateTimeOffset.Now;
        return ToUnixTimeMicroSeconds(now);
    }

    public static long ToUnixTimeMicroSeconds(DateTimeOffset timestamp)
    {
        TimeSpan duration = timestamp - DateTime.UnixEpoch;
        return duration.Ticks / 10;
    }

    public static float GetTimeDiffNow(long startTime)
    {
        long nowTime = UnixTimeStamp.GetUnixTimeMicro();
        return (float)(nowTime - startTime) / 1000000;
    }
}