using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patitas : MonoBehaviour
{
    private PlayerControl player;
    public GameObject[] Enemigo;
    public GameObject efecto;
    public GameObject Lanza;
    public Vector3 posin;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerControl>();
        posin = Lanza.transform.localPosition;
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        player.piso = true;

        
     
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        player.piso = false;
       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dead" || collision.gameObject.tag == "Enemigo" || Input.GetKeyDown(KeyCode.R))
        {

            player.dead = true;
            Lanza.transform.eulerAngles = new Vector3(0, 0, 0);
            Lanza.transform.localPosition = posin;
            Instantiate(efecto, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            
        }
        if (collision.gameObject.tag == "Check Point")
        {
            if (player.check != collision.gameObject)
            {
                
                if (player.check != null)
                {
                    player.check.SetActive(false);
                }
                player.check = collision.gameObject;
                player.check.SendMessage("Reset");

            }
            player.CheckPoint = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + 2f, 0);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dead" || collision.gameObject.tag == "Enemigo")
        {
            player.dead = false;

        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
