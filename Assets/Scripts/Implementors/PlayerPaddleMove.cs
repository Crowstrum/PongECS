using UnityEngine;

namespace Assets.Scripts.Implementors
{
    public class PlayerPaddleMove : MonoBehaviour, IPositonComponent, ISpeedComponent, IRigidbody2DComponent
    {

        private Rigidbody2D _rigidbody2D;
        private Transform _transform;
        public float Speed = 6f;

        public Vector3 position { get { return _transform.position; }}
        public float speed { get { return Speed; }}
        Rigidbody2D IRigidbody2DComponent.rigidbody2D { get { return _rigidbody2D; } }

        void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _transform = this.transform;
        }
    }
}
