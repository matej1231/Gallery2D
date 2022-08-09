using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PG : MonoBehaviour
{
    public GameObject FullScreenPanel;

    public GameObject FirstTimePanel;

    void Start()
    {
        if (PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {
            FirstTimePanel.SetActive(true);

            PlayerPrefs.SetInt("FIRSTTIMEOPENING", 0);
        }
        FullScreenPanelDeactivate();
    }

    public void FullScreenImage()
    {
        FullScreenPanel.SetActive(true);
    }

    public void FullScreenPanelDeactivate()
    {
        FullScreenPanel.SetActive(false);
    }

    public void CloseFirstTimePanel()
    {
        FirstTimePanel.SetActive(false);
    }
}