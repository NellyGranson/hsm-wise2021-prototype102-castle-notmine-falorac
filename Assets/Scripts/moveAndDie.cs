using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAndDie : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move continuously to the left
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        
        
        // destroy when reaching point of death (out of vision)
        if (transform.position.x <= GameObject.Find("DeathZone").transform.position.x) {
            gameObject.SetActive(false);
            Destroy(gameObject, 0.5f);
        }
    }
}
