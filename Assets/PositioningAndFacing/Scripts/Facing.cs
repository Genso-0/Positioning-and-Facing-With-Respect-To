 
using UnityEngine;

namespace PositioningAndFacing
{
    public struct Facing
    { 
        private Directions dir;
        public Directions direction { get { return dir; } }
        /// <summary>
        /// Object forward/back is reversed with respect to the referenced forward/back. AKA BackToFront.
        /// </summary>
        public bool horizontally_inverted { get; private set; }
        /// <summary>
        /// Object right/left is reversed with respect to the referenced right/left.
        /// </summary>
        public bool laterally_inverted { get; private set; }
        /// <summary>
        /// Object up/down is reversed with respect to the referenced up/down. AKA Upside down.
        /// </summary>
        public bool vertically_inverted { get; private set; }

        /// <summary>
        /// Sets relative facing to reference transform's forward right and up.
        /// </summary>
        /// <param name="thisTransform"></param>
        /// <param name="reference"></param>
        public void SetRelatives(Transform thisTransform, Transform reference)
        {
            SetRelatives(thisTransform.forward, thisTransform.right, thisTransform.up, reference.forward, reference.right, reference.up);
        } 
        void SetRelatives(in Vector3 this_forward, in Vector3 this_right, in Vector3 this_up, in Vector3 other_forward, in Vector3 other_right, in Vector3 other_up)
        {
            dir = 0;
            var dot_forward = Vector3.Dot(this_forward, other_forward);
            var dot_right = Vector3.Dot(this_right, other_right);
            var dot_up = Vector3.Dot(this_up, other_up);

            horizontally_inverted = dot_forward < 0 ? true : false;
            laterally_inverted = dot_right < 0 ? true : false;
            vertically_inverted = dot_up < 0 ? true : false;

            if (dot_forward < -Small.comparisonToDot) dir = Directions.Back;
            else if (dot_forward > Small.comparisonToDot) dir = Directions.Forward;

            dot_forward = Vector3.Dot(this_forward, Vector3.up);
            if (dot_forward < -Small.comparisonToDot) dir.Add(Directions.Down);
            else if (dot_forward > Small.comparisonToDot) dir.Add(Directions.Up);

            dot_forward = Vector3.Dot(this_forward, Vector3.right);
            if (dot_forward > Small.comparisonToDot) dir.Add(Directions.Left);
            else if (dot_forward < -Small.comparisonToDot) dir.Add(Directions.Right);
        }
    }
}
