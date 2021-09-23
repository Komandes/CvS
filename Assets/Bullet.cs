using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject target;
    Square targetScript;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 v = new Vector2(200, 0);
        transform.GetComponent<Rigidbody2D>().AddForce(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D targetColider)
    {
        target = targetColider.gameObject;
        targetScript = target.GetComponent<Square>();
        targetScript.GetHit();
        Destroy(transform.gameObject);
    }
}
