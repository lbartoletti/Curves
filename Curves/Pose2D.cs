﻿using System;

namespace Curves
{
    /// <summary>
    /// A class representing a pose. Consists of position coordinates x, y and a direction in radians.
    /// </summary>
    [Serializable]
    public class Pose2D
    {
        private double _direction;
        private double _x;
        private double _y;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Direction { get => _direction; set => _direction = value; }

        public Pose2D(double x, double y, double direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        public override string ToString()
        {
            return "X: " + _x + " Y: " + _y + " Direction " + _direction;
        }
    }
}
