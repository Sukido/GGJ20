using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
    public AudioSource sound;
    private int option = 1;
    private bool mMenu = true;
    private GameObject Hammer;
    private GameObject Menu;
    private GameObject infoMenu;

    // Start is called before the first frame update
    void Start()
    {
        Hammer = GameObject.Find("Hammer_Icon");
        Menu = GameObject.Find("MainMenu");
        infoMenu = GameObject.Find("InfoMenu");
        infoMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        var d = Input.GetAxis("Mouse ScrollWheel");
        if (d < 0f)
        {
            option += 1;
            if (mMenu)
            {
                if (option >= 3)
                    option = 1;
            }
            UpdateUI();
        }
        else if (d > 0f)
        {
            SelectOption();
        }
    }

    void UpdateUI()
    {
        if (mMenu)
        {
            if (option == 1)
            {
                Hammer.transform.localPosition = new Vector3(Hammer.transform.localPosition.x, -71, Hammer.transform.localPosition.z);
            }
            else if (option == 2)
            {
                Hammer.transform.localPosition = new Vector3(Hammer.transform.localPosition.x, -196, Hammer.transform.localPosition.z);
            }
        }
        else
            Hammer.transform.localPosition = new Vector3(Hammer.transform.localPosition.x, -361, Hammer.transform.localPosition.z);

    }

    void SelectOption()
    {
        if(option == 1)
        {
            sound.Play();
            SceneManager.LoadScene("Conversation");
        }
        if(option == 2)
        {
            sound.Play();
            mMenu = false;
            Menu.SetActive(false);
            infoMenu.SetActive(true);
            option = 3;
            UpdateUI();
        }
        else if(option == 3)
        {
            sound.Play();
            mMenu = true;
            Menu.SetActive(true);
            infoMenu.SetActive(false);
            option = 1;
            UpdateUI();
        }
        
    }
}
