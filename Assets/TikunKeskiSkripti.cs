using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TikunKeskiSkripti lis‰‰ pisteit‰ kun menee tikkujen keskelt‰
public class TikunKeskiSkripti : MonoBehaviour
{
    public LogicScript logiikka;

    // Start is called before the first frame update
    void Start()
    {
        //yhdistet‰‰n LogicScript k‰ytett‰v‰ksi komponentiksi logiikkaslottiin
        logiikka = GameObject.FindGameObjectWithTag("Logiikkat‰gi").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logiikka.AddScore(1);
        }
        
    }

}
