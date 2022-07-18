using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuerpo : MonoBehaviour
{
    public GameObject Lanza;
    public Vector3 posin;
    public PlayerControl player;
    public GameObject efecto;
    // Start is called before the first frame update
    void Start()
    {
   
        posin = Lanza.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dead" || collision.gameObject.tag == "Enemigo")
        {

            Lanza.transform.eulerAngles = new Vector3(0, 0, 0);
            Lanza.transform.localPosition = posin;
            Instantiate(efecto, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            player.dead = true;
        }
        if (collision.gameObject.tag == "Dead" || collision.gameObject.tag == "Enemigo")
        {
            player.dead = false;

        }
    }
 }
