using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG2 : MonoBehaviour
{
    public void OpenViewPanel()
    {
        if (!GG3._instance.oneIsAlreadyOpened)
        {
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            GG3._instance.oneIsAlreadyOpened = true;
        }
    }

    public void CloseViewPanel()
    {
        GG3._instance.oneIsAlreadyOpened = false;
        this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
}
