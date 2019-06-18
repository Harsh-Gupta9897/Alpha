using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructPanel : MonoBehaviour
{
    public Animator anim;
    void Update()
    {    
    }

    public void setoff(Animator anim)
    {
        anim.SetBool("flag",false);
    }

    public void seton(Animator anim)
    {
        anim.SetBool("flag",true);
    }
}
