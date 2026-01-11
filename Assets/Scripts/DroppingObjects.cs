using UnityEngine;

public class DroppingObjects : MonoBehaviour
{
    [SerializeField] float waitTime = 3f;
    MeshRenderer dropMeshRenderer;
    Rigidbody dropRigidBody;

    void Start()
    {
        dropMeshRenderer = GetComponent<MeshRenderer>();
        dropRigidBody = GetComponent<Rigidbody>();

        dropMeshRenderer.enabled = false;
        dropRigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > waitTime)
        {
            dropMeshRenderer.enabled = true;
            dropRigidBody.useGravity = true;
        }
    }
}
