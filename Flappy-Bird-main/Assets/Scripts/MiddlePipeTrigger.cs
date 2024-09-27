using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeTrigger : MonoBehaviour
{
    public LogicManager Logic;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            Logic.AddScore(1);
        }
    }
}
