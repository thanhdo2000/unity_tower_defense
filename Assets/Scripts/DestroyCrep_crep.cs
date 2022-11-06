using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCrep_crep : MonoBehaviour
{
    [SerializeField]
    GameObject prefabexplosion;

    //public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("dan"))
        {
            // audio.Play();
            Instantiate<GameObject>(prefabexplosion, transform.position, Quaternion.identity);
            GameManager.Instance.gameEffectPool.Despawn(transform);
            Count_Value.count += 1;
        }
    }
}

