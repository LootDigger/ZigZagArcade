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
                startGame
        };

        }

        public static class Coordinates
        {

        public const float maxYPos = 9f;
        public static  Vector3 ballStartPosition = new Vector3(0f, -9f, -601f);
        public static float minXPosition = -5.26f;
        public static float maxXPosition = 5.26f;

    }



}


