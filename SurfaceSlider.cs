using UnityEngine;

public class SurfaceSlider : MonoBehaviour
{
    private Vector2 _normal;

    public Vector2 Project(Vector2 forward)
    {
        return forward - Vector2.Dot(forward, _normal) * _normal; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _normal = collision.contacts[0].normal;
    }
}
