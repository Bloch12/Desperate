using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    public GameObject Enemigo;
    public GameObject Enemigo2;
    public Vector3 PosIn1,PosIn2;
    public bool a, b, c;
    public Animator anim;
    public bool check;
    private AudioSource audiosource;
    public AudioClip Musica;
    // Start is called before the first frame update
    void Start()
    {
     PosIn1 = Enemigo.transform.position;
     PosIn2= Enemigo2.transform.position;
     anim = GetComponent<Animator>();
     check = false;
     audiosource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
     anim.SetBool("check", check);
        if (check)
          if (!audiosource.isPlaying)
            audiosource.enabled = false;
    }
    public void Reset()
    {
      Enemigo.transform.position = PosIn1; 
      Enemigo.SetActive(a);
      Enemigo2.transform.position = PosIn2;
      Enemigo2.SetActive(b);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = true;
            audiosource.PlayOneShot(Musica);
            

        }
}


}
