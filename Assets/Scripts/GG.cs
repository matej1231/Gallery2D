using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GG : MonoBehaviour
{
    public GameObject FullScreenImageHolder;
    public GameObject PanelFullScreenImageHolder;

    public void LoadImageFullScreen()
    {
        PanelFullScreenImageHolder.SetActive(true);
        for (int i = 0; i < GG3._instance.Paneli.Length; i++)
        {
            if (GG3._instance.Paneli[i].gameObject.activeSelf)
            {
                FullScreenImageHolder.GetComponent<Image>().sprite = GG3._instance.Paneli[i].transform.parent.GetChild(0).GetComponent<Image>().sprite;
            }
        }
    }

    public void ClosePanelFullScreenImageHolder()
    {
        PanelFullScreenImageHolder.SetActive(false);
    }
}