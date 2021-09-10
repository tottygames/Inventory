using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAnimation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ButtonClick(int num)
    {
        switch (num)
        {
            case 1:
                anim.SetBool("Cold", true);
                break;
            case 2:
                anim.SetBool("Fire", true);
                break;
            case 3:
                anim.SetBool("Dark", true);
                break;
        }
    }
}
