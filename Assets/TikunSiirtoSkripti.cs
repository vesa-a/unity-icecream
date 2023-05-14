using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TikunSiirtoSkripti siirt‰‰ tikkuja oikealta vasemmalle ja poistaa ne kun ne ylitt‰v‰t deadZonen
public class TikunSiirtoSkripti : MonoBehaviour
{

    public float moveSpeed = 30;
    public float deadZone = -80;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Tikku poistettu.");
            Destroy(gameObject);
        }
    }
}
