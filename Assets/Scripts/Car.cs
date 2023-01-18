using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    
    public float hiz, varsayilanhiz, yatayhiz;

    [SerializeField]
    private float dikeyhareket, yatayhareket;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dikeyhareket = Input.GetAxis("Vertical");
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(yatayhareket * 100 * yatayhiz * Time.deltaTime, varsayilanhiz + hiz * dikeyhareket * 100 * Time.deltaTime);

        if(transform.position.x > 1.26f)
        {
            Vector3 sag = new Vector3(1.26f, transform.position.y);
            transform.position = sag;
        }
        if(transform.position.x < -4.15f)
        {
            Vector3 sol= new Vector3(-4.15f, transform.position.y);
            transform.position = sol;
        }

    }




}

