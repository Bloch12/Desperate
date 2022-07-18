using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float speed = 2f;
    public float speedr;
    private Rigidbody2D rb2d;
    public bool fuerzaG;
    public bool piso;
    public int velocidad = 4;
    public bool engancharse;
    private Animator anim;
    public bool dead;
    public Vector3 CheckPoint;
    public GameObject lanza;
    public GameObject check;
    public Vector3 posin;
    public GameObject efecto;




    // Start is called before the first frame update
    void Start()
    {
        engancharse = true;
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        posin = lanza.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", rb2d.velocity.x);
        anim.SetBool("Suelo", piso);
        if (dead)
        {
            transform.position = CheckPoint;
            check.SendMessage("Reset");
            dead = false;
        }
        CheckPoint = new Vector3(check.gameObject.transform.position.x, check.gameObject.transform.position.y, 0);
        if (Input.GetKeyDown(KeyCode.R))
        {

            lanza.transform.eulerAngles = new Vector3(0, 0, 0);
            lanza.transform.localPosition = posin;
            Instantiate(efecto, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            dead = true;
        }





    }


    void FixedUpdate()
    {
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        float c;
        if (engancharse)
        {
            c = 0;
        }
        else
        {
            c = 1;
        }
        float h = Input.GetAxis("Horizontal");
        
        rb2d.AddForce(Vector2.right * h * speed * c);
        if (h == 0)
        {
            fuerzaG = true;
        }

        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

        if (fuerzaG)
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
       
       
    }
    
    
}

