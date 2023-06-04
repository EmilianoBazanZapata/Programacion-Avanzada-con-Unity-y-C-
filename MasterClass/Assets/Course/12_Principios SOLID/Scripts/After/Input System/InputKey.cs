using UnityEngine;

namespace Course.SOLID.After
{
    public class InputKey : InputHandler
    {
        public KeyCode keyLefth = KeyCode.LeftArrow;
        public KeyCode keyRight = KeyCode.RightArrow;
        public override float GetAxistHorizontal()
        {
            if (Input.GetKey(keyLefth))
            {
                return -1;
            }

            if (Input.GetKey(keyRight))
            {
                return 1;
            }
            return 0;
        }
    }
}