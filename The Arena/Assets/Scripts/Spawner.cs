using System;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public object enemy;
    
    public Game game;
    
    int fixedFramesPerSecond;
    int sCount = 0;
    
    private void FixedUpdate() {
        fixedFramesPerSecond = 1 / Time.fixedDeltaTime;
        
        sCount++;
        if (game.enemySpawnRate <= sCount) {
            Instantiate(enemy, gameObject.position, gameObject.rotation);
            
            sCount = 0;
        }
    }
}
