
using UnityEngine;
using UnityEngine.UI;
namespace RelativesLib.Utilities
{
    public class DescribeFacingAndPosition : MonoBehaviour
    {
        Text description;
        Relatives relatives_subject;
        public GameObject targetTransform;
        public GameObject subjectTransform;
        void Start()
        {
            description = GetComponentInChildren<Text>();
            relatives_subject = subjectTransform.GetComponent<Relatives>();
        }

        void Update()
        {
            description.text = $"{subjectTransform.name} is facing {PrettifyRelativePosition(relatives_subject.facing_relativeToWorld.direction)} world\n" +
                $"{subjectTransform.name} is facing {PrettifyRelativePosition(relatives_subject.facing_relativeToReference.direction)} {targetTransform.name}\n" +
                $"{subjectTransform.name} is {PrettifyRelativePosition(relatives_subject.positioning_relativeToObject.direction)} {targetTransform.name}";
        }
       
        string PrettifyRelativePosition(Directions dir)
        {
            switch (dir)
            {
                case Directions.Up:
                    return $"{PrettyDirectionsPositions.Above}";
                case Directions.Down:
                    return $"{PrettyDirectionsPositions.Beneath}";
                case Directions.Forward:
                    return $"{PrettyDirectionsPositions.Infront} of";
                case Directions.Right:
                    return $"to the {PrettyDirectionsPositions.Right} of";
                case Directions.Back:
                    return $"{PrettyDirectionsPositions.Behind}";
                case Directions.Left:
                    return $"to the {PrettyDirectionsPositions.Left} of";
                case Directions.ForwardRight:
                    return $"{PrettyDirectionsPositions.Infront} and to the {PrettyDirectionsPositions.Right} of";
                case Directions.BackRight:
                    return $"{PrettyDirectionsPositions.Behind} and to the {PrettyDirectionsPositions.Right} of";
                case Directions.BackLeft:
                    return $"{PrettyDirectionsPositions.Behind} and to the {PrettyDirectionsPositions.Left} of";
                case Directions.ForwardLeft:
                    return $"{PrettyDirectionsPositions.Infront} and to the {PrettyDirectionsPositions.Left} of";
                case Directions.UpForward:
                    return $"{PrettyDirectionsPositions.Above} and {PrettyDirectionsPositions.Infront} of";
                case Directions.UpForwardRight:
                    return $"{PrettyDirectionsPositions.Above} , {PrettyDirectionsPositions.Infront} and to the {PrettyDirectionsPositions.Right} of";
                case Directions.UpRight:
                    return $"{PrettyDirectionsPositions.Above} and to the {PrettyDirectionsPositions.Right} of";
                case Directions.UpBackRight:
                    return $"{PrettyDirectionsPositions.Above} , {PrettyDirectionsPositions.Behind} and to the {PrettyDirectionsPositions.Right} of";
                case Directions.UpBack:
                    return $"{PrettyDirectionsPositions.Above} and {PrettyDirectionsPositions.Behind}";
                case Directions.UpBackLeft:
                    return $"{PrettyDirectionsPositions.Above} , {PrettyDirectionsPositions.Behind} and to the {PrettyDirectionsPositions.Left} of";
                case Directions.UpLeft:
                    return $"{PrettyDirectionsPositions.Above} and to the {PrettyDirectionsPositions.Left} of";
                case Directions.UpForwardLeft:
                    return $"{PrettyDirectionsPositions.Above} , {PrettyDirectionsPositions.Infront} and to the {PrettyDirectionsPositions.Left} of";
                case Directions.DownForward:
                    return $"{PrettyDirectionsPositions.Beneath} and {PrettyDirectionsPositions.Infront} of";
                case Directions.DownForwardRight:
                    return $"{PrettyDirectionsPositions.Beneath} , {PrettyDirectionsPositions.Infront} and to the {PrettyDirectionsPositions.Right} of";
                case Directions.DownRight:
                    return $"{PrettyDirectionsPositions.Beneath} and to the {PrettyDirectionsPositions.Right} of";
                case Directions.DownBackRight:
                    return $"{PrettyDirectionsPositions.Beneath} , {PrettyDirectionsPositions.Behind} and to the {PrettyDirectionsPositions.Right} of";
                case Directions.DownBack:
                    return $"{PrettyDirectionsPositions.Beneath} and {PrettyDirectionsPositions.Behind}";
                case Directions.DownBackLeft:
                    return $"{PrettyDirectionsPositions.Beneath} , {PrettyDirectionsPositions.Behind} and to the {PrettyDirectionsPositions.Left} of";
                case Directions.DownLeft:
                    return $"{PrettyDirectionsPositions.Beneath} and to the {PrettyDirectionsPositions.Left} of";
                case Directions.DownForwardLeft:
                    return $"{PrettyDirectionsPositions.Beneath} , {PrettyDirectionsPositions.Infront} and to the {PrettyDirectionsPositions.Left} of";
            }
            return "in the middle of";
        }
     
        enum PrettyDirectionsPositions
        {
            Infront,
            Behind,
            Above,
            Beneath,
            Left,
            Right
        }
    }
}