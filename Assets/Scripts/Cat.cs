using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameObject fullCat; 
    public GameObject hungryCat;



    public RectTransform front;

    float full = 5.0f;
    float energy = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * 0.05f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Food"))
        {
            if (energy < full)
            {
                energy += 1.0f;
                front.localScale = new Vector3(energy / full, 1.0f, 1.0f);
                Destroy(collision.gameObject);
            }
            else {
                Debug.Log("배가불러요!");
                    }
           
        }
    }
}
