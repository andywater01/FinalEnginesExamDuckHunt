using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectFromPool : MonoBehaviour
{

    GameObject spawnedObject;
    public float spawnTime = 0.5f;
    private float lastTime;



    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTime > spawnTime)
        {
            lastTime = Time.time;
            spawnedObject = ObjectPool.SharedInstance.GetPooledObject();

            if (spawnedObject != null)
            {
                Vector3 position = RandomPointInBox(this.transform.position);
                spawnedObject.transform.position = position;
                spawnedObject.transform.rotation = Quaternion.Euler(this.transform.forward);
                spawnedObject.SetActive(true);

               
            }
        }
    }



    public Vector3 RandomPointInBox(Vector3 center)
    {
        return center + new Vector3(
            
            Random.Range(-500.0f, 500.0f),
            Random.Range(-600.0f, -550.0f),
            0.0f
        );
    }
}
