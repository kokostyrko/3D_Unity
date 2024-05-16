using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;
    void Update()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(100);
        if (parentName == "section01(Clone)")
        {
            Destroy(gameObject);
        }
        if (parentName == "section02(Clone)")
        {
            Destroy(gameObject);
        }
        if (parentName == "section03(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
