using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    bool active = false;
    public GameObject MenuList;
    public void OpenMainMenu()
    {
        if (MenuList)
        {
            MenuList.SetActive(false);
        }
        SceneManager.LoadScene("MainScene");
    }

    public void OpenPrehistoricBuilder()
    {
        if (MenuList)
        {
            MenuList.SetActive(false);
        }
        SceneManager.LoadScene("PG");
    }

    public void OpenGallery()
    {
        if (MenuList)
        {
            MenuList.SetActive(false);
        }
        SceneManager.LoadScene("GG");
    }

    public void OpenMenuList()
    {
        active = !active;
        if (active)
        {
            MenuList.SetActive(active);
        }
        else
        {
            MenuList.SetActive(active);
        }
    }
}
