using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG3 : MonoBehaviour
{
    public static GG3 _instance;

    public GameObject[] Paneli;

    public bool oneIsAlreadyOpened = false;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }

        Paneli = GameObject.FindGameObjectsWithTag("Paneli");
    }

    void Start()
    {
        for (int i = 0; i < Paneli.Length; i++)
        {
            Paneli[i].gameObject.SetActive(false);
        }
    }
}
