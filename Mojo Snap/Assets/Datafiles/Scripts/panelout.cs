using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelout : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        
    }

    public void panelgo(Animator anim)
    {
        anim.SetBool("in", false);
    }
    public void panelin(Animator anim)
    {
        anim.SetBool("in", true);
    }
}
