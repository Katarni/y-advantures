using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letterOpen : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
