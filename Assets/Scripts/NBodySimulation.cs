using UnityEngine;

public class NBodySimulation : MonoBehaviour
{
    public float timeStep = 60f; // 1 minute per step
    private Body[] bodies = new Body[2];
    public Body Moon;
    public Body Earth;
    public float positionScale = 1e7f; // 1 Unity unit = 1e7 meters

    void Start()
    {
        bodies[0] = Moon;
        bodies[1] = Earth;
    }

    void FixedUpdate()
    {
        foreach (var b in bodies) b.force = Vector3.zero;

        for (int i = 0; i < bodies.Length; i++)
        {
            for (int j = i + 1; j < bodies.Length; j++)
            {
                ApplyGravity(bodies[i], bodies[j]);
            }
        }

        foreach (var b in bodies)
        {
            b.velocity += (b.force / b.mass) * timeStep;
            b.transform.position += b.velocity * timeStep;
        }
    }

    void ApplyGravity(Body a, Body b)
    {
        Vector3 diff = b.transform.position - a.transform.position;

        float distUnity = diff.magnitude + 1e-5f;
        float distMeters = distUnity * positionScale; // convert to meters
        Vector3 forceDir = diff.normalized;

        float G = 6.67430e-11f;
        float forceMag = G * a.mass * b.mass / (distMeters * distMeters);

        Vector3 force = forceDir * (forceMag / positionScale); // scale back to Unity units

        a.force += force;
        b.force -= force; 
    }
}





