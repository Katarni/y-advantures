using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathWinClose : MonoBehaviour
{
    public Animator death;

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            death.SetBool("death", false);
        }
    }
}
