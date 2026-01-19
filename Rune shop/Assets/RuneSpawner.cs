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

    public Drawing mainRuneDrawing;
    public Drawing activationRuneDrawing;

    public void DrawCircle(int _index)
    {
        if (_index == 0 && !mainRuneDrawing.circleDrawn)
            mainRuneDrawing.TriggerAnimation(0);
        else if(_index == 1 && !activationRuneDrawing.circleDrawn)
            activationRuneDrawing.TriggerAnimation(0);

        if(mainRuneDrawing.circleDrawn && activationRuneDrawing.circleDrawn)
            gameManager.cameraSwitch.SwitchCamera(1);
    }
    public void setElement(int _element) 
    { 
        element = (Element)_element; 
        everythingClicked[0] = true; 

        switch(_element)
        {
            case 0:
                mainRuneDrawing.TriggerAnimation(1);
                break;
            case 1:
                mainRuneDrawing.TriggerAnimation(2);
                break;
            case 2:
                mainRuneDrawing.TriggerAnimation(3);
                break;
        }
    }
    public void setIndicatorsVertical(int _indicators) 
    {
        indicatorsVertical = (Indicators)_indicators; 
        everythingClicked[1] = true;
        
        switch (_indicators)
        {
            case 0:
                mainRuneDrawing.TriggerAnimation(4);
                break;
            case 1:
                mainRuneDrawing.TriggerAnimation(5);
                break;
            case 2:
                mainRuneDrawing.TriggerAnimation(6);
                break;
            case 3:
                mainRuneDrawing.TriggerAnimation(7);
                break;
            case 4:
                mainRuneDrawing.TriggerAnimation(8);
                break;
            case 5:
                mainRuneDrawing.TriggerAnimation(9);
                break;
        }
    }
    public void setIndicatorsHorizontal(int _indicators) 
    {
        indicatorsHorizontal = (Indicators)_indicators; 
        everythingClicked[2] = true;

        switch (_indicators)
        {
            case 0:
                mainRuneDrawing.TriggerAnimation(10);
                break;
            case 1:
                mainRuneDrawing.TriggerAnimation(11);
                break;
            case 2:
                mainRuneDrawing.TriggerAnimation(12);
                break;
            case 3:
                mainRuneDrawing.TriggerAnimation(13);
                break;
            case 4:
                mainRuneDrawing.TriggerAnimation(14);
                break;
            case 5:
                mainRuneDrawing.TriggerAnimation(15);
                break;
        }
    }
    public void setShape(int _shape) 
    {
        shape = (PowerShape)_shape; 
        everythingClicked[3] = true;

        switch (_shape)
        {
            case 0:
                activationRuneDrawing.TriggerAnimation(16);
                break;
            case 1:
                activationRuneDrawing.TriggerAnimation(17);
                break;
            case 2:
                activationRuneDrawing.TriggerAnimation(18);
                break;
            case 3:
                activationRuneDrawing.TriggerAnimation(19);
                break;
        }

    }
    public void setDuration(int _duration) 
    {
        duration = (RuneDuration)_duration; 
        everythingClicked[4] = true;

        switch (_duration)
        {
            case 0:
                activationRuneDrawing.TriggerAnimation(20);
                break;
            case 1:
                activationRuneDrawing.TriggerAnimation(21);
                break;
            case 2:
                activationRuneDrawing.TriggerAnimation(22);
                break;
            case 3:
                activationRuneDrawing.TriggerAnimation(23);
                break;
        }
    }

    public void ResetRunes()
    {
        for(int i = 0; i < everythingClicked.Length; i++)
        {
            everythingClicked[i] = false;
        }
        mainRuneDrawing.ResetRune();
        activationRuneDrawing.ResetRune();
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
