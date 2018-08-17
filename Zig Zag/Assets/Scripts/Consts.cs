using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;




   public  static class Consts
    {
        public static class Events
        {
        
            public enum events
            {
                myfirstEvent,
                flyToBoard,
                startGame,
                startLeftStick,
                startRightStick
        };

        }

        public static class Coordinates
        {

        public const float maxYPos = 9f;
        public static Vector3 ballStartPosition = new Vector3(0f, -9f, -601f);

        public static Vector3 leftStickStartPosition = new Vector3(-5.3f, -7.45f, -606);
        public static Vector3 leftStickEndPosition = new Vector3(-5.3f, 7.45f, -606f);

        public static Vector3 rightStickStartPosition = new Vector3(5.3f, -7.45f, -606f);
        public static Vector3 rightStickEndPosition = new Vector3(5.3f, 7.45f, -606f);

        public static float minXPosition = -5.26f;
        public static float maxXPosition = 5.26f;
        public static float zCoord = -606f;


    }


    public static class Values
    {
        public static float stickSpeed = 10f;



    }



}


