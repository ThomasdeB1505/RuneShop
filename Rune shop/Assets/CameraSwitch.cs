using UnityEngine;

public enum cameraState
{
    customer,
    table,
    drawCircle
}
public class CameraSwitch : MonoBehaviour
{

    public RuneSpawner runeSpawner;
    Animator animator;
    cameraState state;
    public GameObject customerUI;
    public GameObject tableUI;
    public GameObject drawCircleUI;

    public bool lockCam;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        SwitchCamera(0);
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchCamera(int _state)
    {
        if (lockCam)
            return;
        animator.SetInteger("CameraState", _state);

        if (_state == 1 && !runeSpawner.mainRuneDrawing.circleDrawn && !runeSpawner.activationRuneDrawing.circleDrawn)
            _state = 2;
        
        state = (cameraState)_state;

        if (state == cameraState.customer)
        {
            drawCircleUI.SetActive(false);
            tableUI.SetActive(false);
            customerUI.SetActive(true);
        }
        if (state == cameraState.table)
        {
            drawCircleUI.SetActive(false);
            tableUI.SetActive(true);
            customerUI.SetActive(false);
        }
        if (state == cameraState.drawCircle)
        {
            drawCircleUI.SetActive(true);
            tableUI.SetActive(false);
            customerUI.SetActive(false);
        }
    }
}
