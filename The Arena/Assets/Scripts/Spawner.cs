using System;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Object enemy;
    
    public Game game;
    
    float fixedFramesPerSecond;
    float sCount = 0;
    
    private void FixedUpdate() {
        fixedFramesPerSecond = 1 / Time.fixedDeltaTime;
        
        sCount++;
        if (game.enemySpawnRate <= sCount) {
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
            
            sCount = 0;
        }
    }
}
