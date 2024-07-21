using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondaudio : MonoBehaviour
{
    public AudioSource a;
    public GameObject player;
    private bool played = false;
    public int val;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z>val && played==false){
            a.Play();
            played=true;
        }
    }
}
