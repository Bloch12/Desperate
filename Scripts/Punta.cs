using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punta : MonoBehaviour
{
    public GameObject efecto;
    private AudioSource audiosource;
    public AudioClip golpe;
    
    private PlayerControl player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerControl>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        player.engancharse = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        player.engancharse = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Enemigo")
        {
            Instantiate(efecto, new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            
            collision.gameObject.SetActive(false);
            audiosource.PlayDelayed(0);

        }
    }
}
   


