using UnityEngine;

public class BoxRotation : MonoBehaviour
{
    [SerializeField] private float CubeRotationSpeed = 45.0f;

    // Update is called once per frame
    void Update()
    {
        // Cube rotation logic, multiplied cube rotation with Time.deltaTime to get same output across devices
        transform.Rotate(transform.up, CubeRotationSpeed * Time.deltaTime);
    }

    // Function callback for slider value change event
    public void ChangeRotationSpeed(float value)
    {
        CubeRotationSpeed = value;
    }
}
