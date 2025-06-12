using UnityEngine;

public class Body : MonoBehaviour
{
    public Vector3 velocity;
    public float mass;
    [HideInInspector] public Vector3 force;

    public void applyGravity(Body body)
    {
        Vector3 diff = body.transform.position - transform.position;
        float distUnity = Mathf.Max(diff.magnitude, 1f); // avoid divide-by-zero
        float distMeters = distUnity * StelarSystem.Instance.positionScale;

        Vector3 forceDir = diff.normalized;
        float G = 6.67430e-11f;
        float forceMag = G * this.mass * body.mass / (distMeters * distMeters);

        Vector3 force = forceDir * (forceMag / StelarSystem.Instance.positionScale);

        this.force += force;
        body.force -= force;
    }
}
