using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Shooting : MonoBehaviour
{
    
    public AudioSource gunShot;
    private int Score = 0;
    private Vector3 Big = new Vector3(20, 20, 20);
    private Vector3 Medium = new Vector3(15, 15, 15);
    private Vector3 Small = new Vector3(10, 10, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //gunShot.Play();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit)
            {
                if (hit.collider.transform.localScale == Big)
                {
                    Score += 50;
                }
                else if (hit.collider.transform.localScale == Medium)
                {
                    Score += 100;
                }
                else 
                {
                    Score += 150;
                }



                hit.collider.gameObject.SetActive(false);
                
            }

        }

        if (Score >= 1000)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
