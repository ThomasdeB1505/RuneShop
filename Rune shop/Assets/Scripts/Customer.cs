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
                myMainRune = new MainRune(Element.water, Indicators.heat, Indicators.cold);
                myActivationRune = new ActivationRune(PowerShape.square, RuneDuration.sixty);
                SetUIText("Ik wil een frikandelbroodje");
                break;
            case 1:
                myMainRune = new MainRune(Element.air, Indicators.heat, Indicators.lowDensity);
                myActivationRune = new ActivationRune(PowerShape.square, RuneDuration.sixty);
                SetUIText("I would like water that's hot and not very dense");
                break;
            case 2:
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
