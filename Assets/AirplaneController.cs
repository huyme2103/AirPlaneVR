using UnityEngine;
using UnityEngine.XR;

public class AirplaneController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 50f;
    public XRNode inputSource = XRNode.RightHand;
    public float climbSpeed = 5f;

    private Vector2 inputAxis;
    private Rigidbody rb;

    void Start()
    {
       
    }

    void Update()
    {
        
    }
}
