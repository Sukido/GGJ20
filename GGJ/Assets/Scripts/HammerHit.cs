using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerHit : MonoBehaviour
{

    private int option = 2;
    private GameObject Hammer;

    // Start is called before the first frame update
    void Start()
    {
        Hammer = GameObject.Find("Hammer_Icon");
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        var d = Input.GetAxis("Mouse ScrollWheel");
        if (d > 0f)
        {
            if (option > 1)
            {
                option--;
                UpdateUI();
            }
        }
        else if (d < 0f)
        {
            if (option < 3)
            {
                option++;
                UpdateUI();
            }
        }
    }

    void UpdateUI()
    {
        if (option == 1)
        {
            Hammer.transform.localPosition = new Vector3(Hammer.transform.localPosition.x, 395, Hammer.transform.localPosition.z);
        }
        else if (option == 2)
        {
            Hammer.transform.localPosition = new Vector3(Hammer.transform.localPosition.x, 295, Hammer.transform.localPosition.z);
        }
        else if (option == 3)
        {
            Hammer.transform.localPosition = new Vector3(Hammer.transform.localPosition.x, 195, Hammer.transform.localPosition.z);
        }
    }

    

    /*void SelectOption()
    {
        if (option == 1)
        {
            // Change Scene to game scene

        }
        if (option == 2)
        {
            mMenu = false;
            Menu.SetActive(false);
            infoMenu.SetActive(true);
            option = 3;
            UpdateUI();
        }
        else if (option == 3)
        {
            mMenu = true;
            Menu.SetActive(true);
            infoMenu.SetActive(false);
            option = 1;
            UpdateUI();
        }
    }*/
}
