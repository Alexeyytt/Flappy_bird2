using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{

    [SerializeField] float velocity = 1;
    [SerializeField] Manager manger;
    Rigidbody2D rigidbody2D;
    bool alreadyTouched = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetMouseButtonDown(0) && alreadyTouched == false)
        {
            Debug.Log("First Toched");
            alreadyTouched = true;
            rigidbody2D.isKinematic = false;
            FindObjectOfType<PipeSpawner>().StartSpawning();
            manger.ShowScore();
            manger.DisableStartUI();
        }
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manger.GameOver();
    }
}
 