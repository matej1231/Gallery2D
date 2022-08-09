using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PG : MonoBehaviour
{
    public GameObject FullScreenPanel;

    void Start()
    {
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
}
