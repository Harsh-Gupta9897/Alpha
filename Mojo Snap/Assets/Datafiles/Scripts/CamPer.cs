using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class CamPer : MonoBehaviour
{
    void Awake()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
    }
}
