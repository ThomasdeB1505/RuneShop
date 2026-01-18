using UnityEngine;

public class RuneSpawner : MonoBehaviour
{
    public GameManager gameManager;

    public bool[] everythingClicked = new bool[5];
    public Element element;
    public Indicators indicatorsVertical;
    public Indicators indicatorsHorizontal;
    public PowerShape shape;
    public RuneDuration duration;

    public void setElement(int _element) {  element = (Element)_element; everythingClicked[0] = true; }
    public void setIndicatorsVertical(int _indicators) { indicatorsVertical = (Indicators)_indicators; everythingClicked[1] = true; }
    public void setIndicatorsHorizontal(int _indicators) { indicatorsHorizontal = (Indicators)_indicators; everythingClicked[2] = true; }
    public void setShape(int _shape) { shape = (PowerShape)_shape; everythingClicked[3] = true; }
    public void setDuration(int _duration) { duration = (RuneDuration)_duration; everythingClicked[4] = true; }

    public void ResetRunes()
    {
        for(int i = 0; i < everythingClicked.Length; i++)
        {
            everythingClicked[i] = false;
        }
    }

    public bool checkIfEverythingGotClicked()
    {
        for (int i = 0; i < everythingClicked.Length; i++)
        {
            if (!everythingClicked[i])
                return false;
        }

        return true;
    }

    public void SpawnMainRune()
    {
        gameManager.mainRune = new MainRune(element, indicatorsVertical, indicatorsHorizontal);
    }

    public void SpawnActivationRune()
    {
        gameManager.activationRune = new ActivationRune(shape, duration);
    }
}
