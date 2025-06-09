using UnityEngine;

public class Body : MonoBehaviour
{
    public Vector3 velocity;
    public float mass;

    [HideInInspector] public Vector3 force;

}
