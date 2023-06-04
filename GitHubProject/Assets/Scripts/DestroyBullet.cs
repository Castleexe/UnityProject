using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("destroyBullet");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
