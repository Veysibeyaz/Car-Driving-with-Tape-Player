using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    public GameObject yol;
    bool yol_oldumu = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Car" && yol_oldumu == false)
        {
            Vector3 konum = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(yol, konum, Quaternion.identity);
            yol_oldumu = true;
            Destroy(this.gameObject,7f);
        }
        
    }
}
