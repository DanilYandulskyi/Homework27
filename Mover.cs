using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SurfaceSlider))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
        
    private SurfaceSlider _surfaceSlider;

    private void Awake()
    {
        _surfaceSlider = GetComponent<SurfaceSlider>();
    }

    public void Move(Vector2 direction)
    {
        Vector2 offset = direction.normalized * (_speed * Time.deltaTime);

        transform.Translate(_surfaceSlider.Project(offset));
    }

    public Vector2 DeployVector(Vector2 direction)
    {
        return -direction;
    }
}