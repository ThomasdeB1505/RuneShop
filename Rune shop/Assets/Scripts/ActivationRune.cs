using System;
using UnityEngine;

[Serializable]
public class ActivationRune
{
    public PowerShape shape;
    public RuneDuration duration;

    public ActivationRune(PowerShape _shape, RuneDuration _duration)
    {
        shape = _shape;
        duration = _duration;
    }

    public bool Compare(ActivationRune rune)
    {
        Debug.Log(shape + ", " + rune.shape);
        Debug.Log(duration + ", " + rune.duration);
        if (rune.shape != shape)
            return false;
        if (rune.duration != duration)
            return false;
        return true;
    }
}
