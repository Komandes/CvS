using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public int hp = 3;
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHit()
    {
        hp--;
        if (hp <= 0)
            Destroy(transform.gameObject);
    }
}
