using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectableBehaviour : MonoBehaviour {



    void Start () {
        GameManager.instance.AddMaxCollectables(1);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player")) {
            Collect();
        }
    }

    void Collect() {
        GameManager.instance.AddCollectables(1);
        gameObject.SetActive(false);
    }

}