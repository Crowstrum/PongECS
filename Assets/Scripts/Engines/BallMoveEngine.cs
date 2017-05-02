using Svelto.ECS;
using Svelto.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Engines
{
    public class BallMoveEngine : SingleNodeEngine<BallNode>
    {
        private BallNode _ballNode;
        private bool _isStarted;
        public BallMoveEngine()
        {
            TaskRunner.Instance.RunOnSchedule(StandardSchedulers.physicScheduler,
                new TimedLoopActionEnumerator(PhysicsTick));
            
        }

        private void PhysicsTick(float obj)
        {
            if (_ballNode == null)
            {
                return;
                
            }
            if(!_isStarted)
            Move();
        }

        private void Move()
        {
            _isStarted = true;
            
            _ballNode.Rigidbody2DComponent.rigidbody2D.velocity = Vector3.right + Vector3.up *  _ballNode.SpeedComponent.speed;
        }

        protected override void Add(BallNode node)
        {
            _ballNode = node;
        }

        protected override void Remove(BallNode node)
        {
            _ballNode = null;
        }
    }
}
