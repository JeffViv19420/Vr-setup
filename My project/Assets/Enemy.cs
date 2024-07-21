using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    void Start()
    {
        
    }
     void OnTriggerEnter(Collider other){
        if (other.tag=="sword"){
            health-=10;
        }
        if (health==0){
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
