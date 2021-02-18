
using UnityEngine;

namespace RelativesLib
{
    public struct Positioning
    {
        private Directions dir;
        public Directions direction { get { return dir; } }
        /// <summary>
        /// Set relative position with relation to a reference point using World forward, right and up.
        /// </summary>
        /// <param name="thisTransform"></param>
        /// <param name="referencePosition"></param>
        public void SetRelatives(Transform thisTransform, Vector3 referencePosition)
        {
            SetRelatives(thisTransform.position - referencePosition, Vector3.forward, Vector3.right, Vector3.up);
        }
        /// <summary>
        /// Set relative position with relation to a reference transform's position. This will use the reference transform's forward, right and up.
        /// </summary>
        /// <param name="thisTransform"></param>
        /// <param name="reference"></param>
        public void SetRelatives(Transform thisTransform, Transform reference)
        {
            SetRelatives(thisTransform.position - reference.position, reference.forward, reference.right, reference.up);
        }
        void SetRelatives(in Vector3 directionFromTarget, in Vector3 other_forward, in Vector3 other_right, in Vector3 other_up)
        {
            dir = 0;
            var dot_forward = Vector3.Dot(directionFromTarget, other_forward);
            var dot_right = Vector3.Dot(directionFromTarget, other_right);
            var dot_up = Vector3.Dot(directionFromTarget, other_up);
            // dots = new DOTS(dot_forward, dot_right, dot_up); 

            if (dot_forward < 0) dir = Directions.Back;
            else if (dot_forward > 0) dir = Directions.Forward;

            if (dot_right < 0) dir.Add(Directions.Left);
            else if (dot_right > 0) dir.Add(Directions.Right);

            if (dot_up < 0) dir.Add(Directions.Down);
            else if (dot_up > 0) dir.Add(Directions.Up);
        }
    }
}
