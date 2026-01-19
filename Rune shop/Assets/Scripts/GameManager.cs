using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //My plan is to spawn a prefab, which runs an animation on startup
    public CameraSwitch cameraSwitch;
    public RuneSpawner runeSpawner;

    public GameObject customerPrefab;
    public Transform spawnLocation;
    public GameObject currentCustomer;

    public Material[] customerMats;


    public MainRune mainRune;
    public ActivationRune activationRune;

    int customerID;

    private void Start()
    {
        SpawnCustomer();
    }

    public void SpawnCustomer()
    {
        //end the demo
        if (customerID == 3)
            SceneManager.LoadScene(1);
        if (currentCustomer != null)
            Destroy(currentCustomer);
        currentCustomer = Instantiate(customerPrefab, spawnLocation.position, Quaternion.Euler(90, 0 , 180));
        Customer cus = currentCustomer.GetComponent<Customer>();
        cus.SetVisual(customerMats[customerID]);

        cus.CreateOrder(customerID);
        customerID++;

        runeSpawner.ResetRunes();
    }

    public bool CheckCustomerRunes()
    {
        if (!runeSpawner.checkIfEverythingGotClicked())
            return false;
        Customer cus = currentCustomer.GetComponent<Customer>();

        Debug.Log(mainRune.Compare(cus.myMainRune));
        Debug.Log(activationRune.Compare(cus.myActivationRune));
        if (!mainRune.Compare(cus.myMainRune) ||
            !activationRune.Compare(cus.myActivationRune))
            return false;

        return true;
    }

    public void HandInRune()
    {
        cameraSwitch.SwitchCamera(0);
        StartCoroutine(handInRuneCoroutine());
    }

    IEnumerator handInRuneCoroutine()
    {
        cameraSwitch.lockCam = true;
        Customer cus = currentCustomer.GetComponent<Customer>();
        if (CheckCustomerRunes())
            cus.SetUIText("Thanks! That was exactly what I was looking for");
        else
            cus.SetUIText("Uhhm, not quite what I had in mind...");

        yield return new WaitForSeconds(3);

        cameraSwitch.lockCam = false;
        SpawnCustomer();
    }

}
