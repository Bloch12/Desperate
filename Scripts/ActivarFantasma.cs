using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarFantasma : MonoBehaviour
{
    public GameObject Fantasma;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Fantasma.SetActive(true);
            gameObject.SetActive(false);
            
        }
    }
}
