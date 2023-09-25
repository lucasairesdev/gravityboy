using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public int collectableAmount = 0;
    public int maxCollectableAmount = 0;

    void Awake() {
        if(instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void AddCollectables(int amount) {
        collectableAmount += amount;

    }
    public void AddMaxCollectables(int amount) {
        maxCollectableAmount += amount;
    }


    public bool VerifySpacecraftFuel() {
        if(collectableAmount == maxCollectableAmount) {
            sceneEndGame();
            return true;
        } else {
            return false;
        }
    }


    void sceneEndGame() {
        print("Parabéns seu arrombADO você finalizou essa bosta de jogo que o merda do israel fez");
    }

}
