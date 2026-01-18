using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.ProBuilder.Shapes;

public class Customer : MonoBehaviour
{
    public MainRune myMainRune;
    public ActivationRune myActivationRune;

    public GameObject UITextParent;
    public TextMeshProUGUI UIText;

    public void CreateOrder(int _option)
    {
        switch (_option)
        {
            case 0:
                myMainRune = new MainRune(Element.water, Indicators.heat, Indicators.cold);
                myActivationRune = new ActivationRune(PowerShape.square, RuneDuration.sixty);
                SetUIText("I would like water that's hot and cold");
                break;
            case 1:
                myMainRune = new MainRune(Element.air, Indicators.heat, Indicators.lowDensity);
                myActivationRune = new ActivationRune(PowerShape.square, RuneDuration.sixty);
                SetUIText("I would like water that's hot and not very dense");
                break;
        }
    }

    public void SetUIText(string _text)
    {
        UIText.text = _text;
    }
}
