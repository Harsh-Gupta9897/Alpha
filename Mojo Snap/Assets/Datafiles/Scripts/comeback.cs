using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comeback : MonoBehaviour
{
    public GameObject obj;

        public void setoff()
    {
        obj.SetActive(false);
        StartCoroutine(seton(0.1f, obj));
    }


    IEnumerator seton(float t1, GameObject obj)
    {
        yield return new WaitForSeconds(t1);
        obj.SetActive(true);
    }
}
