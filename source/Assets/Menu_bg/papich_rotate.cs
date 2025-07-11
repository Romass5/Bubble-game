using UnityEngine;

public class papich_rotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bossPrefab.transform.position = new Vector3(6f, bossPrefab.transform.position.y, bossPrefab.transform.position.z);
        GetComponent<Transform>().rotation.Set(GetComponent<Transform>().rotation.x, GetComponent<Transform>().rotation.y, 1f, GetComponent<Transform>().rotation.w);
    }
}
