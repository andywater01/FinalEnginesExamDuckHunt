using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolDuck : MonoBehaviour
{
    public float time = 20.0f;

    

    void OnEnable()
    {
        StartCoroutine(DestroyDuck());
    }

    IEnumerator DestroyDuck()
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
}
