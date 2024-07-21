using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    private bool forwards = true;
    private bool ready = false;
    private bool reset = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z<51 && forwards){
            //Debug.Log("1");
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+0.08f);
        }
        if (transform.position.z>48 && transform.localEulerAngles.y<90){
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y+2, transform.localEulerAngles.z);
        }
        if (transform.position.z>=50.9 && transform.position.x<23 && forwards){
            transform.position = new Vector3(transform.position.x+0.08f, transform.position.y, transform.position.z);
        }
        if (transform.position.x>21 && transform.localEulerAngles.y>-90){
            forwards = false;
           transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, -90, transform.localEulerAngles.z);
        }
        if (forwards==false && transform.position.x>0){
            transform.position = new Vector3(transform.position.x-0.08f, transform.position.y, transform.position.z);
        }
        if (forwards==false && transform.position.x<=0){
           transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 180, transform.localEulerAngles.z);
           ready = true;
        }
        if (ready && forwards==false && transform.position.z>30){
            //Debug.Log("1");
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-0.08f);
        }
        if (ready && forwards==false && transform.position.z<=30){
            reset=true;
        }
        if (reset){
           transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 0, transform.localEulerAngles.z);
            forwards = true;
            ready = false;
            reset = false;
        }
    }
}
