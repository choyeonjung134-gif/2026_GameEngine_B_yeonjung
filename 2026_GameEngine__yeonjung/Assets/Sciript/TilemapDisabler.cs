using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapDisabler : MonoBehaviour
{
    public class Tilemap : MonoBehaviour
    {
        private void Awake()
        {
            GetComponent <TilemapRenderer>().enabled = false;
        }
    }

    void Update()
    {
        
    }
}
