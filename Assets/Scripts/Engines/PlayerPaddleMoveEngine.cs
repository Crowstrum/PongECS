using Assets.Scripts.Nodes;
using Svelto.ECS;
using Svelto.Tasks;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Scripts.Engines
{
    public class PlayerPaddleMoveEngine : SingleNodeEngine<PlayerPaddleNode>
    {
        private PlayerPaddleNode _playerNode;

        public PlayerPaddleMoveEngine()
        {
            TaskRunner.Instance.RunOnSchedule(StandardSchedulers.physicScheduler,
                new TimedLoopActionEnumerator(PhysicsTick));
        }

        private void PhysicsTick(float dt)
        {
            if (_playerNode == null)
            {
                Debug.Log("we are null");
                return;
            }

            Move();
        }

        private void Move()
        {
            var vertical = CrossPlatformInputManager.GetAxisRaw("Vertical");

            var movement = new Vector3();
            movement.Set(0, vertical, 0);

            movement = movement.normalized * _playerNode.SpeedComponent.speed * Time.deltaTime;

            _playerNode.Rigidbody2DComponent.rigidbody2D.MovePosition(
                _playerNode.PositionComponent.position + movement);
        }

        protected override void Add(PlayerPaddleNode node)
        {
            _playerNode = node;
        }

        protected override void Remove(PlayerPaddleNode node)
        {
            _playerNode = null;
        }
    }
}