using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pausa : MonoBehaviour
{
    bool activa;
    Canvas canvas;
    bool Menu;
    public Image Salir;
    public Image Quedarse;
    AudioListener PJ;
    AudioSource Musica;


    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        Salir = GameObject.Find("Salir Al Menu").GetComponent<Image>();
        Quedarse = GameObject.Find("Reanudar").GetComponent<Image>();
        PJ = GameObject.Find("PJ").GetComponent<AudioListener>();
        Musica = GameObject.Find("Main Camera").GetComponent<AudioSource>();

        canvas.enabled = false;
        Menu = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!activa)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                activa = true;
                canvas.enabled = true;
                Time.timeScale = 0;
                PJ.enabled = false;
                Musica.Pause();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return)) {
                if (Menu)
                {
                    activa = false;
                    canvas.enabled = false;
                    PJ.enabled = true;
                    Musica.Play();
                    Time.timeScale = 1;
                }
                else
                {
                    Time.timeScale = 1;
                    SceneManager.LoadScene("Menu principal");

                }
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                Menu = !Menu;
                Salir.sprite = (Menu) ? Resources.Load<Sprite>("SalirB") : Resources.Load<Sprite>("SalirA");
                Quedarse.sprite = (Menu) ? Resources.Load<Sprite>("ReanudarA") : Resources.Load<Sprite>("ReanudarB");
            }



        }
        

           


        
    }
}
