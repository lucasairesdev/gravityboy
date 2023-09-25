using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpacecraftBehaviour : MonoBehaviour {
    public GameObject mensageObject;



    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player")) {
            if(GameManager.instance.VerifySpacecraftFuel() == false) {
                MessageCollectable(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            MessageCollectable(false);
        }
    }

    public void MessageCollectable(bool value) {
        mensageObject.SetActive(value);
    }
}
