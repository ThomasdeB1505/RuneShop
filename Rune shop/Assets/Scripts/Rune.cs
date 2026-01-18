using System;
using UnityEngine;

[Serializable]
public enum RuneType
{
    main,
    activation
}
[Serializable]
public enum Element
{
    air,
    water
}

[Serializable]
public enum Indicators
{
    heat,
    cold,
    outwardForce,
    inwardForce,
    lowDensity,
    highDensity
}

[Serializable]
public enum PowerShape
{
    triangle,
    square,
    pentagon,
    hexagon
}

[Serializable]
public enum RuneDuration
{
    infinite,
    sixty,
    thirty,
    five
}
