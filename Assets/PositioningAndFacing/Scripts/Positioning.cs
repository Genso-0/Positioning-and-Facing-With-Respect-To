
using UnityEngine;

namespace PositioningAndFacing
{
    public struct Positioning
    {
        private Directions dir;
        public Directions direction { get { return dir; } }
    
        /// <summary>
        /// Set relative position with relation to a reference transform's position. This will use the reference transform's forward, right and up.
        /// </summary>
        /// <param name="thisTransform"></param>
        /// <param name="other"></param>
        public void SetRelatives(Transform thisTransform, Transform other)
        {
            SetRelatives(other.position - thisTransform.position, thisTransform.forward, thisTransform.right, thisTransform.up);
        }
        public void SetRelatives(in Vector3 directionToTarget, in Vector3 this_forward, in Vector3 this_right, in Vector3 this_up)
        {
            dir = 0;
            var dot_forward = Vector3.Dot(directionToTarget, this_forward);
            var dot_right = Vector3.Dot(directionToTarget, this_right);
            var dot_up = Vector3.Dot(directionToTarget, this_up);

            if (dot_forward < 0) dir = Directions.Back;
            else if (dot_forward > 0) dir = Directions.Forward;

            if (dot_right < 0) dir.Add(Directions.Left);
            else if (dot_right > 0) dir.Add(Directions.Right);

            if (dot_up < 0) dir.Add(Directions.Down);
            else if (dot_up > 0) dir.Add(Directions.Up);
        }
    }
}
