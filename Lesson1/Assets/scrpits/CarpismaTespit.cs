using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpismaTespit : MonoBehaviour
{
   
    public int puan;
    public List <GameObject> puanObjeleri = new List<GameObject> ();
    private void OnCollisionEnter(Collision collision)
    {
        puanObjeleri.Add(GameObject.Find("PositiveObject"));// 3+ 2- olacak
        puanObjeleri.Add(GameObject.Find("PositiveObject"));
        puanObjeleri.Add(GameObject.Find("PositiveObject"));
        puanObjeleri.Add(GameObject.Find("NegativeObject"));
        puanObjeleri.Add(GameObject.Find("NegativeObject"));
       
        int SecimDegiskeni = Random.Range(0, 5);
        float rastgeleXDegiskeni = Random.Range(-5.2f, 7.94f);
        float rastgeleZDegiskeni = Random.Range(-18.54f, 0f);
        GameObject yaratilanObje = (GameObject)Instantiate(puanObjeleri[SecimDegiskeni], new Vector3(rastgeleXDegiskeni, 4.55f, rastgeleZDegiskeni), Quaternion.Euler(0, 0, 0));
    }
    
   
        
    void Update()
    {
        transform.Rotate(1, 3, 4);
        
    }
}
