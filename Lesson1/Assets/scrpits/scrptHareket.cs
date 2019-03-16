using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrptHareket : MonoBehaviour
{
    public int speed = 0;
    Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(string.Format("x : {0}", gameObject.transform.position.x.ToString()));
        Debug.Log(string.Format("y : {0}", gameObject.transform.position.y.ToString()));
        Debug.Log(string.Format("z : {0}", gameObject.transform.position.z.ToString()));
        rBody = gameObject.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rBody.AddForce(0, 0, speed);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            rBody.AddForce(0, 0, -speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rBody.AddForce(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rBody.AddForce(-speed, 0, 0);
        }

        /*
         if(Input.GetAxis("Horizontal") < 0.0) //left
         {
             gameObject.transform.position = new Vector3((gameObject.transform.position.x - speed) * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);

         } else //rigth
         {
             gameObject.transform.position = new Vector3((gameObject.transform.position.x + speed) * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
         }
         if (Input.GetAxis("Vertical") < 0.0) // down
         {
             gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, (gameObject.transform.position.z - speed) * Time.deltaTime);
         } else //up
         {
             gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, (gameObject.transform.position.z + speed) * Time.deltaTime);
         }
         */
    }
}
