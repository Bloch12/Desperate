using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laaaaaaanza : MonoBehaviour
    

{
    public float velocidad = 4;
    private PlayerControl player;
    public int Detector;
    public GameObject centro;
    public Vector3 inicio;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerControl>();
        transform.localPosition = inicio;
    }

    // Update is called once per frame
    void Update()
    {




    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("HorizontalL");
        if (Detector == 1 && gameObject.transform.localPosition.x >= 0 && h <= 0)
        {
            h = 0;
        }
        if (Detector == -1 && gameObject.transform.localPosition.x <= 0 && h >= 0)
        {
            h = 0;
        }
        transform.RotateAround(centro.transform.position, Vector3.back, velocidad * h);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        player.engancharse = true;
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        player.engancharse = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        player.engancharse = false;
    }
}


