using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : MonoBehaviour
{
    public GameObject False;
    public GameObject True;

    public void Start()
    {
        StartCoroutine(ToWait());    
    }

    public IEnumerator ToWait()
    {
        yield return new WaitForSeconds(5f);
        True.SetActive(true);
        False.SetActive(false);
    }
}
