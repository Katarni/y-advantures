using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleAnimator : MonoBehaviour
{
    public Animator titleAnim;
    public Animator textAnim;

    void Start()
    {
        titleAnim.SetBool("open", true);
        textAnim.SetBool("continue", true);
    }
}
