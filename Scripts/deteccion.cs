using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccion : MonoBehaviour
{
    private Laaaaaaanza Lanza;
    public int IoD;
    // Start is called before the first frame update
    void Start()
    {
        Lanza = GetComponentInParent<Laaaaaaanza>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Lanza.Detector = IoD;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Lanza.Detector = 0;
    }
}
