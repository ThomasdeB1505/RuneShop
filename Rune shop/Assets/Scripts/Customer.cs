using TMPro;
using UnityEditor.SpeedTree.Importer;
using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.ProBuilder.Shapes;

public class Customer : MonoBehaviour
{
    public MainRune myMainRune;
    public ActivationRune myActivationRune;

    public GameObject UITextParent;
    public TextMeshProUGUI UIText;
    public MeshRenderer meshRenderer;

    public void SetVisual(Material newMat)
    {
        meshRenderer.materials = new Material[] { newMat };
    }

    public void CreateOrder(int _option)
    {
        switch (_option)
        {
            case 0:
                myMainRune = new MainRune(Element.water, Indicators.heat, Indicators.heat);
                myActivationRune = new ActivationRune(PowerShape.square, RuneDuration.thirty);
                SetUIText("I would like boiling hot water that fills my pot in half a minute with 1 1/3p");
                break;
            case 1:
                myMainRune = new MainRune(Element.air, Indicators.cold, Indicators.inwardForce);
                myActivationRune = new ActivationRune(PowerShape.hexagon, RuneDuration.five);
                SetUIText("I need something that sucks out all the cold air with the most power you have in a few seconds");
                break;
            case 2:
                myMainRune = new MainRune(Element.fire, Indicators.cold, Indicators.highDensity);
                myActivationRune = new ActivationRune(PowerShape.triangle, RuneDuration.infinite);
                SetUIText("Can you give me a small dense flame of 1p that keeps burning and doesn't burn my fingers?");
                break;
        }
    }

    public void SetUIText(string _text)
    {
        UIText.text = _text;
    }
}
