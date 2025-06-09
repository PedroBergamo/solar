using UnityEngine;

public class SolarSystemInitializer : MonoBehaviour
{
    public GameObject planetPrefab;

    void Start()
    {
        
        }

    void CreateBody(string name, float px, float py, float pz, float vx, float vy, float vz, float mass, Color color, float scale)
    {
        GameObject body = Instantiate(planetPrefab, new Vector3(px, py, pz), Quaternion.identity);
        body.name = name;
        body.GetComponent<Renderer>().material.color = color;
        body.transform.localScale = Vector3.one * scale;

        Body b = body.GetComponent<Body>();
        b.mass = mass;
        b.velocity = new Vector3(vx, vy, vz);
    }
}
