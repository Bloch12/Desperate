using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Abrir : MonoBehaviour
{
    public bool Cerrado;
    public GameObject jugador;
    public GameObject Lanza;
    SpriteRenderer A;
    public Vector3 posin;
    // Start is called before the first frame update
    void Start()
    {
        posin = Lanza.transform.localPosition;
        A = GetComponent<SpriteRenderer>(); 
        Cerrado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cerrado)
        {
            A.sprite = Resources.Load<Sprite>("PuertaCerrada");
        }
    }
    public void Cerrate()
    {
        Cerrado = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!Cerrado)
            {
                Lanza.transform.eulerAngles = new Vector3(0, 0, 0);
                Lanza.transform.localPosition = posin;

                jugador.transform.position = new Vector3(440.14f, -21.67f, 0);
            }
            else
                SceneManager.LoadScene("Final2");

           


        }

    }
}
