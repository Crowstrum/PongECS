using Svelto.ECS;

namespace Assets.Scripts.Nodes
{
    public class PlayerPaddleNode : NodeWithID {

        public ISpeedComponent SpeedComponent;
        public IPositonComponent PositionComponent;
        public IRigidbody2DComponent Rigidbody2DComponent;
    }
}
