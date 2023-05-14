using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jäätelöskripti hoitaa pääasiassa jäätelön ohjausta
public class Jäätelöskripti : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float puskuvoima;
    public LogicScript logiikka;
    public static bool tikkuElossa = true;

    // Start is called before the first frame update
    void Start()
    {
        //yhdistetään LogicScript käytettäväksi komponentiksi logiikkaslottiin
        logiikka = GameObject.FindGameObjectWithTag("Logiikkatägi").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jäätelötikun ohjausta:
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && tikkuElossa == true)
        {
            myRigidbody.velocity = Vector2.up * puskuvoima;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true && tikkuElossa == true)
        {
            myRigidbody.velocity = new Vector2(-1, 1) * puskuvoima;
            myRigidbody.angularVelocity += 40;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) == true && tikkuElossa == true)
        {
            myRigidbody.velocity = new Vector2(1, 1) * puskuvoima;
            myRigidbody.angularVelocity -= 40;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) == true && tikkuElossa == true)
        {
            myRigidbody.velocity = Vector2.down * puskuvoima;
        }

        //Pelin lopetus escistä:
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
            Debug.Log("Peli lopetettu.");
        }


    }

    //Jäätelötikun törmätessä näytä gameover-ruutu ja jäätelötikku elottomaksi
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logiikka.DisplayGameOver();
        tikkuElossa = false;
    }

}
