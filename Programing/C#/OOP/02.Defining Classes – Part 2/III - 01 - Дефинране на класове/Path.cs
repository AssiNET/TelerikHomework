﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове
{
    class Path
    {
        //<fields>
        private List<Point3D> path = new List<Point3D>();
        //</fields>

        //<constructors>
        public Path(params Point3D[] points)
        {

        }
        public List<Point3D> PathList
        {
            get
            {
                return this.path;
            }
        }
        //</constructors>

        //<methods>
        public void AddPoint(params Point3D[] point)
        {
            foreach (var item in point)
            {
                path.Add(item);
                
            }

        }
        //</methods>

    }
}
