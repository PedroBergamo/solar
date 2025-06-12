using UnityEngine;

public class NBodySimulation : MonoBehaviour
{
    public float timeStep = 60f;
    public float positionScale = 1e7f;
    public float maxAllowedVelocity = 1e5f;
    public GameObject errands;
    private Body[] bodies;

    void Start()
    {
        bodies = new Body[errands.transform.childCount];
        for (int i = 0; i < errands.transform.childCount; i++)
        {
            bodies[i] = errands.transform.GetChild(i).GetComponent<Body>();
        }
    }

    void FixedUpdate()
    {
        foreach (var b in bodies) b.force = Vector3.zero;
        for (int i = 0; i < bodies.Length; i++)
        {
            for (int j = i + 1; j < bodies.Length; j++)
            {
                bodies[i].applyGravity(bodies[j]);
            }
        }

        foreach (var b in bodies)
        {
            if (!float.IsFinite(b.velocity.x) || !float.IsFinite(b.transform.position.x))
            {
                Debug.LogError($"{b.name} has invalid physics state. Skipping update.");
                b.velocity = Vector3.zero;
                continue;
            }

            b.velocity = Vector3.ClampMagnitude(b.velocity, maxAllowedVelocity);
            b.velocity += (b.force / b.mass) * timeStep;
            b.transform.position += b.velocity * timeStep;
        }
    }
}
