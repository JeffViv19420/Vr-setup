using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthLabel : MonoBehaviour
{
    public GameObject player;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text= "Health: "+(player.GetComponent<Player>().health).ToString();
    }
}
