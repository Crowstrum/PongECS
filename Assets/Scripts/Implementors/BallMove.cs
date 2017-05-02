using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour, IPositonComponent,IRigidbody2DComponent,ISpeedComponent,IDirectionComponent
{
    private Rigidbody2D _rigidbody2D;
    private Transform _transform;
    public float Speed = 6f;
    private Vector3 _directoinVector3;

    public Vector3 position { get { return _transform.position; } }
    Rigidbody2D IRigidbody2DComponent.rigidbody2D { get { return _rigidbody2D; } }
    public float speed { get { return Speed; } }
    public Vector3 direction { get { return _directoinVector3; } }

    void Awake()
    {
        _transform = transform;
        _rigidbody2D = GetComponent<Rigidbody2D>();

    }
}
