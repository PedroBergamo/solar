using UnityEngine;

class StelarSystem: MonoBehaviour {
    public static StelarSystem Instance;
    public float positionScale = 10000000;

    void Awake(){
        Instance = this; 
    }
}