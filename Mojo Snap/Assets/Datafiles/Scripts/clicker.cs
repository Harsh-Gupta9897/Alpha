using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicker : MonoBehaviour
{
    private float time = 2f;
    public GameObject g1, g2;      //g1=canvas g2
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            g1.SetActive(true);
            g2.SetActive(false);
        }
        

    }
}
