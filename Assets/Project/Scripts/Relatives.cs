
using System.Collections; 
using UnityEngine;

namespace RelativesLib
{
    public class Relatives : MonoBehaviour
    {
        [SerializeField]public Facing facing;
        void Start()
        {
            facing = new Facing();
            StartCoroutine(facing.UpdateFacing(transform));
        } 
        public readonly struct RelativeBody
        {
            public RelativeBody(Vector3 forward, Vector3 right, Vector3 up)
            {
                this.forward = forward;
                this.right = right;
                this.up = up;
            }
            public readonly Vector3 forward;
            public readonly Vector3 right;
            public readonly Vector3 up;
        }
        public readonly struct DOTS
        {
            public DOTS(float forward, float right, float up)
            {
                this.forward = forward;
                this.right = right;
                this.up = up;
            }
            public readonly float forward;
            public readonly float right;
            public readonly float up;
        }
        [System.Serializable]
        public class Facing
        {
            public Facing()
            {
                relativeBody = new RelativeBody(Vector3.forward, Vector3.right, Vector3.up);
            }
            private Directions dir;
            public Directions facing { get { return dir; } }
            public DOTS dots { get; private set; }
            public RelativeBody relativeBody;
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

            public IEnumerator UpdateFacing(Transform transform)
            {
                while (true)
                {
                    dir = 0;
                    var dot_forward = Vector3.Dot(transform.forward, relativeBody.forward);
                    var dot_right = Vector3.Dot(transform.right, relativeBody.right);
                    var dot_up = Vector3.Dot(transform.up, relativeBody.up);
                    dots = new DOTS(dot_forward, dot_right, dot_up);

                    horizontally_inverted = dot_forward < 0 ? true : false;
                    laterally_inverted = dot_right < 0 ? true : false;
                    vertically_inverted = dot_up < 0 ? true : false;

                    if (dot_forward < 0) dir = Directions.Back;
                    if (dot_forward > 0) dir = Directions.Forward;

                    dot_forward = Vector3.Dot(transform.forward, relativeBody.up);
                    if (dot_forward < 0) dir.Add(Directions.Down);
                    if (dot_forward > 0) dir.Add(Directions.Up);

                    dot_forward = Vector3.Dot(transform.forward, relativeBody.right);
                    if (dot_forward < 0) dir.Add(Directions.Left);
                    if (dot_forward > 0) dir.Add(Directions.Right);

                    yield return null;
                }
            }
        }
    }
}
