using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthLabel : MonoBehaviour
{
    public GameObject enemy;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text= "Enemy Health: "+(enemy.GetComponent<Enemy>().health).ToString();
    }
}
