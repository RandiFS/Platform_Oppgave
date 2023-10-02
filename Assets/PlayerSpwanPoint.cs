using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpwanPoint : MonoBehaviour
{
    public GameObject PrefabToSpawn;
    public Vector3 SpawnPosition;
    public Quaternion SpawnRotation;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(PrefabToSpawn, SpawnPosition, SpawnRotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            Instantiate(PrefabToSpawn, SpawnPosition, SpawnRotation);
        }
    }
}
