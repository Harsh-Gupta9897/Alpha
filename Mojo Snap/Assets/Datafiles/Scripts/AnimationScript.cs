using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator a1;
    void Update()
    {
    }
    public void animchange1(Animator a1)
    { 
        a1.SetInteger("flag", 1);
    }
    public void animchange2(Animator a1)
    {
        a1.SetInteger("flag", 2);
    }
    public void animchange3(Animator a1)
    {
        a1.SetInteger("flag", 3);
    }
    public void animchange4(Animator a1)
    {
        a1.SetInteger("flag", 4);
    }
}
