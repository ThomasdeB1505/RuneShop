using UnityEngine;

public class MainRune
{
    public Element element;
    public Indicators indicatorsVertical;
    public Indicators indicatorsHorizontal;

    public MainRune(Element _element, Indicators _indicatorsVert, Indicators _indicatorsHor)
    {
        element = _element;
        indicatorsHorizontal = _indicatorsHor;
        indicatorsVertical = _indicatorsVert;
    }   

    public bool Compare(MainRune rune)
    {
        if (rune.element != element)
            return false;
        if((rune.indicatorsVertical == indicatorsVertical && rune.indicatorsHorizontal == indicatorsHorizontal) ||
            (rune.indicatorsVertical == indicatorsHorizontal && rune.indicatorsHorizontal == indicatorsVertical))
            return true;
        return true;
    }
}
